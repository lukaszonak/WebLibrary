import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    registerMode = true;

    registerToggle() {
        this.registerMode = !this.registerMode;
    }

    cancelRegistrationMode(registerMode: boolean) {
        this.registerMode = registerMode;
    }
}
