using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebDataLibrary.Migrations
{
    public partial class uproszczenie_mdelu_Usera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoginStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Users",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoginStatus",
                table: "Users",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
