import { Component } from "@angular/core";
import {AuthService} from "./auth.service";

@Component({
    selector: 'Nav',
    template: `<mat-toolbar color="primary">
     <button mat-button routerLink="/">Message Board</button>
     <button mat-button routerLink="/messages">Messages</button>
     <span style="flex: 1 1 auto"></span>
     <button *ngIf = "!auth.isAuthentic" mat-button routerLink="/register">Register</button>
     <button *ngIf = "!auth.isAuthentic" mat-button routerLink="/login">Log In</button>
     <button *ngIf = "auth.isAuthentic" mat-button routerLink="/">Welcome {{auth.name}}</button>
     <button *ngIf = "auth.isAuthentic" mat-button (click)="auth.logout()">Log Out</button>
     </mat-toolbar>  `
})
export class NavComponent{
    constructor(private auth: AuthService){}
}