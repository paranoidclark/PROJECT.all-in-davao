import { Component } from '@angular/core';

@Component({
  selector: 'app-landing-page',
  imports: [],
  templateUrl: './landing-page.html',
  styleUrl: './landing-page.css',
})
export class LandingPage {
  muted = true;

  onMute() {
    this.muted = !this.muted;
    console.log(this.muted);
  }
}
