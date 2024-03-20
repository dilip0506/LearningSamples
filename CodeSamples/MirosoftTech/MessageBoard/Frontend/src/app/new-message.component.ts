import { Component } from "@angular/core";
import { Webservice } from "./web.service";
import { AuthService } from './auth.service'
//import { Output, EventEmitter } from '@angular/core'//option 1

@Component({
    selector: 'new-message',
    template: `
    <mat-card class="card">
    <mat-card-content>
    <!--
    <mat-form-field class="">
    <input [(ngModel)] = "messages.owner" matInput  placeholder="Name">
    </mat-form-field>
    -->

    <mat-form-field class="">
    <textarea [(ngModel)] = "messages.text" matInput placeholder="Message"></textarea>
    </mat-form-field>
    </mat-card-content>
    <mat-card-actions>
    <button (click) = "Post()" mat-button>Submit</button>
    </mat-card-actions>
    </mat-card>
    `
})
export class NewMessageComponent{
  //  @Output() onPosted = new EventEmitter();//option 1
    constructor(private webService: Webservice,private auth:AuthService){}
    messages={
    owner:this.auth.name,
    text:""
    }
    Post(messages){
        this.webService.PostMessage(this.messages)
        //this.onPosted.emit(this.messages);// option 1
    }
}