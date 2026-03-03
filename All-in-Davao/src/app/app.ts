import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {Footerpage} from './footerpage/footerpage';
import {Navigation} from './navigation/navigation';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Footerpage, Navigation],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('All-in-Davao');
}
