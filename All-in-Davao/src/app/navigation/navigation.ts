import { Component } from '@angular/core';
import {RouterLink} from '@angular/router';
import {ThemeService} from '../services/theme.service';
import {AsyncPipe} from '@angular/common';

@Component({
  selector: 'app-navigation',
  imports: [
    RouterLink,
    AsyncPipe
  ],
  templateUrl: './navigation.html',
  styleUrl: './navigation.css',
})
export class Navigation {

  constructor(public themeService: ThemeService) {}
}
