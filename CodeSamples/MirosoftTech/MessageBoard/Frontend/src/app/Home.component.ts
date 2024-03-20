import { Component } from '@angular/core';
//import {ViewChild} from '@angular/core';//option 1
import {MessageComponent} from './messages.component';
import {NewMessageComponent} from './new-message.component';

@Component({
  selector: 'Home',
  template: ` <new-message></new-message>
              <messages></messages>
            `,
  styleUrls: ['./app.component.css']
})
export class HomeComponent {
  // @ViewChild(MessageComponent) messages: MessageComponent;//option 1
  //<new-message (onPosted) = "onPosted($event)"></new-message>//html template for calling below method
  // onPosted(message){//option 1
  // this.messages.messages.push(message);// option 1
  //}
}
