import { Component } from "@angular/core";
import {Webservice} from "./web.service";

@Component({
    selector: 'user',
    template: `<mat-card>
    <mat-form-field class="login">
        <input [(ngModel)] = "user.firstName" matInput placeholder="First Name">
    </mat-form-field>
    <br>
    <mat-form-field class="login">
        <input [(ngModel)] = "user.lastName" matInput placeholder="Last Name">
    </mat-form-field>
    <mat-card-actions><button (click)="saveuser(user)" mat-raised-button color="primary">Submit</button></mat-card-actions>
    </mat-card>`
})
export class UserComponent{
    user={
        firstName:"",
        lastName:""
    }
    constructor(private web:Webservice){}
    ngOnInit() {
        this.web.getUser().subscribe(res=>{
           this.user.firstName = res.json().firstName;
           this.user.lastName = res.json().lastName
        });
        }
    saveuser(userData){
        this.web.saveUser(userData).subscribe();
    }
    }