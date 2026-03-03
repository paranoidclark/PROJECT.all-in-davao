import {Component, inject, OnDestroy, OnInit} from '@angular/core';
import {ThemeService} from '../services/theme.service';
import {FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import {Router, RouterLink} from '@angular/router';
import {AuthService} from '../services/auth.service';

@Component({
  selector: 'app-signup',
  imports: [ReactiveFormsModule, RouterLink],
  templateUrl: './signup.html',
  styleUrl: './signup.css',
})
export class Signup implements OnInit, OnDestroy {

  themeService = inject(ThemeService);
  authService = inject(AuthService);

  form = new FormGroup({
    firstName: new FormControl("", Validators.required),
    lastName: new FormControl("", Validators.required),
    email: new FormControl("", [Validators.required, Validators.email]),
    password: new FormControl("", [Validators.required, Validators.minLength(6)]),
  })
  private router = inject(Router);

  onSubmit() {
    if (this.form.valid) {

      const signupData = this.form.value;

      this.authService.register(signupData).subscribe({
        next: () => {
          alert("Registration Successful!");
          this.router.navigate(['/login']);
        },
        error: (error) => {
          console.log(error);
          alert("Registration Failed. Please try again.");
        }
      });
    } else {
      this.form.markAllAsTouched();
    }
  }

  ngOnInit(): void {
    this.themeService.setDarkNav(true);
  }

  ngOnDestroy(): void {
    this.themeService.setDarkNav(false);
  }
}
