import { Component, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../../_services/auth.service';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
/** register component*/
export class RegisterComponent {

    @Output() cancelRegistration = new EventEmitter();

    model: any = {};

    constructor(private authService: AuthService) {
    }
    ngOnInit(): void {
    }

    register() {
        this.authService.register(this.model).subscribe(() => {
            console.log("Rejestracja poszła pomyślnie");
        }, error => { console.log(error) });
    }

    cancel() {
        this.cancelRegistration.emit(false);
        console.log('cancelled !!!');
    }
}