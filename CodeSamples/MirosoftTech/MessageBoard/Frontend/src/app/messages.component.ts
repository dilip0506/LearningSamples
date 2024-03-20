import { Component } from "@angular/core";
import { Webservice} from "./web.service";
import { ActivatedRoute } from "@angular/router"


@Component({
    selector: 'messages',
    //In below line instead of calling messages from same component we are calling from webService(commeted code is local)
    template: `
    <div *ngFor = "let user of webService.messages | async">
    <mat-card class="card">
    <mat-card-title [routerLink] = "['/messages',user.owner]" style="cursor: pointer">{{user.owner}}</mat-card-title>
    <mat-card-content>{{user.text}}</mat-card-content>
    </mat-card>
    </div>
    `
})
export class MessageComponent{
    //messages;
    constructor(private webService: Webservice, private Activate: ActivatedRoute){}
    ngOnInit(){
        this.webService.getMessages(this.Activate.snapshot.params.name)
        //this.webService.getUser().subscribe();
        // this.webService.messages.subscribe((submessages)=>{//instead of write subcribe call back we can use async pipe diretly
        // this.messages = submessages;
        // })
    }
    //implemted same code or funtionality in webservice for bettor poformance and feature
    // async ngOnInit(){
    //    var response = await this.webService.getMessages();
    //     this.messages = response.json();
    // }
// messages = [];
}