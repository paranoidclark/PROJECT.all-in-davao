import { Component } from '@angular/core';
import {LandingPage} from './landing-page/landing-page';
import {CategoryPage} from './category-page/category-page';
import {EventsPage} from './events-page/events-page';

@Component({
  selector: 'app-homepage',
  imports: [
    LandingPage,
    CategoryPage,
    EventsPage,
  ],
  templateUrl: './homepage.html',
  styleUrl: './homepage.css',
})
export class Homepage {

}
