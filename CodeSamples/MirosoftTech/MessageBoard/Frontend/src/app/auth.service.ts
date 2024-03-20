import {Injectable} from '@angular/core';
import {Http,Headers, RequestOptions} from '@angular/http';
import {Router} from '@angular/router'

@Injectable()
export class AuthService{
BASE_URL = 'http://localhost:62198/auth';
NAME_KEY = "name";
TOKEN_KEY = "token";
constructor(private http:Http, private route:Router){}

    get name(){
        return localStorage.getItem(this.NAME_KEY);
    }

    get isAuthentic(){
        return !!localStorage.getItem(this.TOKEN_KEY);//return false if the token does not exits
    }

    get TokenHeader(){
        var Header = new Headers({'Authorization':'Bearer '+localStorage.getItem(this.TOKEN_KEY)});
        return new RequestOptions({headers:Header})
    }
    login(loginData){
        this.http.post(this.BASE_URL+'/login',loginData).subscribe(res=>{
            this.Authenticate(res);
        });
    }

    register(user){
        delete user.confirmPassword//we are sending confirm password to backend but for now we need only to frontend
        this.http.post(this.BASE_URL+'/register',user).subscribe(res=>{
           this.Authenticate(res);
        });
    }
    logout(){
        localStorage.removeItem(this.TOKEN_KEY);
        localStorage.removeItem(this.NAME_KEY);
    }
    Authenticate(res){
        var respone = res.json();
        if(!respone.token)
            return;

        localStorage.setItem(this.TOKEN_KEY,respone.token);
        localStorage.setItem(this.NAME_KEY,respone.name);
        this.route.navigate(['/']);
    }
}