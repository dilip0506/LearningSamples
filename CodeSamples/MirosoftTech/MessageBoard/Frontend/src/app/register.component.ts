import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthService } from './auth.service';

@Component({
  moduleId: module.id,//load correct html from its location
  selector: 'register',
  templateUrl: 'register.component.html',
  styles:[`.error{
      background-color:#fff0f0
  }`]
})
export class RegisterComponent {
    form;
    constructor(private fb: FormBuilder, private auth:AuthService){
        this.form = fb.group({// the first parameter is model
            firstName: ['', Validators.required],
            lastName:['', Validators.required],
            email:['', [Validators.required, emailValid()]],
            password:['', Validators.required],//we can pass a list of validations
            confirmPassword:['', Validators.required]
        },{validator:MatchingFields('password','confirmPassword')})
    }
    onSubmit(){
        //console.log(this.form.value);
       // console.log(this.form.errors);
       this.auth.register(this.form.value);
    }

    isValid(control){ // in html for validating empty feilds
       return this.form.controls[control].invalid && this.form.controls[control].touched
    }
}

function MatchingFields(field1,field2){
    return form =>{
        if(form.controls[field1].value != form.controls[field2].value){
        return {mismatchedFields: true};
        }
    }
}

function emailValid(){
    return  control => {
        var regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
        return regex.test(control.value)?null:{invalidEmail:true}
    }
}

