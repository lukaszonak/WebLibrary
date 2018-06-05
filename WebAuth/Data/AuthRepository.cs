using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDataLibrary;
using WebDataLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using WebServer.WebDataLibrary;

namespace WebAuth.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DatabaseModel _context;
        public AuthRepository(DatabaseModel context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
            {
                return null;
            }

            if (!VerfyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }
            //auth successful
            return user;
        }

        private bool VerfyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {

                var computetHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computetHash.Length; i++)
                {
                    if (computetHash[i] != passwordHash[i]) return false;

                }
                return true;
            }
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username == username))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
