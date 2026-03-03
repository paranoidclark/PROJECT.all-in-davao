import {inject, Injectable, signal} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {tap} from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private http = inject(HttpClient);

  private apiUrl = 'https://localhost:7123/api/auth';

  isLoggedIn = signal<boolean>(this.hasToken());

  constructor() { }

  register(userData: any) {
    return this.http.post(`${this.apiUrl}/register`, userData, { responseType: 'text'});
  }

  login(credentials: any) {
    return this.http.post(`${this.apiUrl}/login`, credentials, { responseType: 'text'})
      .pipe(
        tap((token: string) => {
            localStorage.setItem('jwt_token', token);
            this.isLoggedIn.set(true);
        })
      );
  }

  private hasToken(): boolean {
    return !!localStorage.getItem('jwt_token');
  }

  logout() {
    localStorage.removeItem('jwt_token');
    this.isLoggedIn.set(false);
  }

  getDecodedToken(): any {
    const token = this.getToken();

    if (token) {
      const payload = token.split('.')[1];

      const decodedJson = window.atob(payload);

      return JSON.parse(decodedJson);
    }
    return null;
  }

  getToken(): string | null {
    return localStorage.getItem('jwt_token');
  }

  /* Auth Endpoints */

  getUserProfile() {
    return this.http.get(`${this.apiUrl}/me`);
  }
}
