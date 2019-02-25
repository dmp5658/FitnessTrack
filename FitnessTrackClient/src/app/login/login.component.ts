import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import {AuthService} from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  loginData = {
    userName: '',
    password: ''
  };

  constructor(private router: Router,
              private service: AuthService
              ) { }

  login() {
    this.service.login(this.loginData).subscribe((data: any) => {
        console.log(data);
        localStorage.setItem('userName', data.UserName);
        localStorage.setItem('token_value', data.Token);
        this.router.navigate(['/']);
      },
      (error) => alert(error.error.Message)
    );
  }

}
