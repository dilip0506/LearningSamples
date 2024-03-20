import { Component } from "@angular/core";
import {AuthService} from "./auth.service";

@Component({
    selector: 'login',
    template: `
    <mat-card>
    <mat-form-field class="login">
        <input [(ngModel)] = "loginData.Email" matInput placeholder="Eamil" required>
    </mat-form-field>
    <br>
    <mat-form-field class="login">
        <input [(ngModel)] = "loginData.Password" matInput type = "password" placeholder="Password" required>
    </mat-form-field>
    <mat-card-actions><button (click)="login()" mat-raised-button color="primary">Submit</button></mat-card-actions>
    </mat-card>
    `
})
export class LoginComponent{
    loginData={
        Email:'',
        Password:''  
    }
    constructor(private auth: AuthService){}
    login(){
        this.auth.login(this.loginData);
    }
}