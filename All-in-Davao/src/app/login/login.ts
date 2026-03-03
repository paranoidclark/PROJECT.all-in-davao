import {Component, Inject, inject, OnDestroy, OnInit} from '@angular/core';
import {ThemeService} from '../services/theme.service';
import {Router, RouterLink} from '@angular/router';
import {FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import {AuthService} from '../services/auth.service';

@Component({
  selector: 'app-login',
  imports: [
    RouterLink,
    ReactiveFormsModule
  ],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login implements OnInit, OnDestroy {

  themeService = inject(ThemeService);
  authService = inject(AuthService);

  form = new FormGroup({
    email: new FormControl("", Validators.required),
    password: new FormControl("", [Validators.required, Validators.minLength(6)]),
  });
  private router = inject(Router);

  onSubmit() {
    if (this.form.valid) {

      const userData = this.form.value;

      this.authService.login(userData).subscribe({
        next: () => {
          alert("Login successfully.");
          this.router.navigate(['/user']);
        },
        error: error => {
          alert("Login failed. Please try again.");
        }
      });
    }
  }

  ngOnInit(): void {
    this.themeService.setDarkNav(true);
  }

  ngOnDestroy(): void {
    this.themeService.setDarkNav(false);
  }

}
