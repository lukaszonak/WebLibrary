import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http'
import 'rxjs/add/operator/map';

@Injectable()
export class AuthService {
    constructor(private http: Http) { }

    baseUrl = 'http://localhost:65428/api/auth/'
    userToken: any;

    login(model: any) {
        //const headers = new Headers({ 'Content-type': 'application/json' });
        //const options = new RequestOptions({ headers: headers });
        return this.http.post(this.baseUrl + 'login', model, this.requestOptions()).map((response: Response) => {
            const user = response.json();
            if (user) {
                localStorage.setItem('token', user.tokenString);
                this.userToken = user.tokenString;
            }
        });
    }

    register(model: any) {
        return this.http.post(this.baseUrl + 'register', model, this.requestOptions());
    }

    private requestOptions() {
        const headers = new Headers({ 'Content-type': 'application/json' });
        return new RequestOptions({ headers: headers });
    }
}