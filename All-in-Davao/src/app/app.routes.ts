import { Routes } from '@angular/router';
import {Listing} from './homepage/category-page/listing/listing';
import {Homepage} from './homepage/homepage';
import {Detail} from './homepage/category-page/listing/detail/detail';
import {Login} from './login/login';
import {Signup} from './signup/signup';
import {Userpage} from './userpage/userpage';
import {authGuard} from './guards/auth-guard';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Homepage, data: { breadcrumb: 'Home' } },
  { path: 'explore/:category', component: Listing },
  { path: 'explore/:category/:place', component: Detail },
  { path: 'login', component: Login },
  { path: 'signup', component: Signup },

  /* Auth Pages */
  { path: 'user', component: Userpage, canActivate: [authGuard] },

];
