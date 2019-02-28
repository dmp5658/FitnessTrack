import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = 'http://localhost:54476/auth/';

  constructor(private http: HttpClient) { }

  register(user) {
    return this.http.post(this.baseUrl + 'register', user);
  }

  login(user) {
    return this.http.post(this.baseUrl + 'login', user);
  }

  logout() {
    localStorage.removeItem('userName');
    localStorage.removeItem('token_value');
    localStorage.removeItem('userID');
  }

  get getUserName() {
    return localStorage.getItem('userName');
  }

  get getUserId() {
    return localStorage.getItem('UserID');
  }

  get isAuthenticated() {
    return !!localStorage.getItem('token_value');
  }
}
