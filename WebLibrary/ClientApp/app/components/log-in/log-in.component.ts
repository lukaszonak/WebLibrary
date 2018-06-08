import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../_services/auth.service';

@Component({
    selector: 'app-log-in',
    templateUrl: './log-in.component.html',
    styleUrls: ['./log-in.component.css']
})
/** logIn component*/
export class LogInComponent {

    model: any = {};
    logged: boolean = false;

    constructor(private authService: AuthService) { }

    ngOnInit() {
        const token = localStorage.getItem('token');
        if (token == null || token == "") {
            console.log("## token pusty ")
            this.logged = false;
        }
        else {
            console.log("## token ma zawartość")
            this.logged = true;
        }

    }

    login() {
        this.authService.login(this.model).subscribe(data => {
            console.log('logged in successfully');
            this.logged = true;
        }, error => {
            console.log('faild to login ');
        });
    }

    logout() {
        this.authService.userToken = null;
        localStorage.removeItem('token');
        this.logged = false;
        console.log('logged out');
    }


    // Obecnie moetoda nie używana 
    loggedIn() {
        const token = localStorage.getItem('token');

        //return !!token;

        if (token == null || token == "") {
            console.log("## token pusty ")
            return false;
        }
        else {
            console.log("## token ma zawartość")
            return true;
        }

    }
}