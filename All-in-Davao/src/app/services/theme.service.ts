import { Injectable } from '@angular/core';
import {BehaviorSubject} from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ThemeService {

  private darkNav = new BehaviorSubject<boolean>(false);
  isDarkNav$ = this.darkNav.asObservable();

  setDarkNav(isDark: boolean) {
    this.darkNav.next(isDark);
  }
}
