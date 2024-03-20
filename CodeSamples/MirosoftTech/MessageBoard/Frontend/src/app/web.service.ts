import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/toPromise'//rxjs is a library
import { Console } from '@angular/core/src/console';
import { MatSnackBar } from '@angular/material';
import {Subject} from 'rxjs/Rx';
import {AuthService} from './auth.service';

@Injectable()
export class Webservice{
    BASE_URL = 'http://localhost:62198/api';
    private messagestore = [];// we are sending data throug messagesubject observable make it private
    private messagesubject = new Subject();
    
    messages = this.messagesubject.asObservable();
  
    constructor (private http: Http, private sb : MatSnackBar, private auth: AuthService){
        //this.getMessages();
    }
    // async getMessages(owner){//using promise
    //     try {
    //     owner = (owner) ? '/' + owner : ''; 
    //     var reponse = await this.http.get(this.BASE_URL + '/Messages'+owner).toPromise();
    //     this.messagestore = reponse.json();
    //     } catch (error) {
    //         this.ErrorMessage('unable to get message');
    //     }
        
    // }
    getMessages(owner){//using obsrvables
        owner = (owner) ? '/' + owner : ''; 
        this.http.get(this.BASE_URL + '/Messages'+owner).subscribe((reponse)=>{
        this.messagestore = reponse.json();
        this.messagesubject.next(this.messagestore);
        },(error)=>{
            this.ErrorMessage('unable to get message');
        })  
    }
    async PostMessage(messagestore){
        try {
            var reponse = await this.http.post(this.BASE_URL + '/Messages',messagestore).toPromise();
            this.messagestore.push(reponse.json());
            this.messagesubject.next(this.messagestore)//no need of doing this in this situation because we are point to same messagestore array useful it the second abservale subscribes after the first value is broadcasted
        } catch (error) {
            this.ErrorMessage('unable to post message');
        }  
    }

    getUser(){//request the secure resorce
        return this.http.get(this.BASE_URL+'/users/me',this.auth.TokenHeader);//.map(res=>res.json())
    }
    saveUser(userData){//request the secure resorce
        return this.http.post(this.BASE_URL+'/users/me',userData,this.auth.TokenHeader)//.map(res=>res.json())
    }
    private ErrorMessage(error){
        this.sb.open(error,'close',{duration: 2000})      
    }
}