import {ChangeDetectorRef, Component, inject, OnDestroy, OnInit} from '@angular/core';
import {ThemeService} from '../services/theme.service';
import {AuthService} from '../services/auth.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-userpage',
  imports: [],
  templateUrl: './userpage.html',
  styleUrl: './userpage.css',
})
export class Userpage implements OnInit, OnDestroy {
  private authService = inject(AuthService);
  private themeService = inject(ThemeService);
  private cd = inject(ChangeDetectorRef);
  private router = inject(Router);

  userName: string = "";
  userRole: string = "";
  serverData: any = null;

  onLogout() {
    this.authService.logout();
    void this.router.navigate(['/']);
  }

  ngOnInit() {
    this.themeService.setDarkNav(true);

    const tokenData = this.authService.getDecodedToken();

    console.log(tokenData);

    if (tokenData) {
/*      this.userName = tokenData['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'] || tokenData.email || 'User';
      this.userRole = tokenData['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] || tokenData.role || 'Unknown';*/
      this.userName = tokenData.given_name + " " + tokenData.family_name;
      this.userRole = tokenData.role;
    }

    this.authService.getUserProfile().subscribe({
      next: data => {
        console.log("Successful! We retrieved the user profile.", data);
        this.serverData = data;
        this.cd.detectChanges()
      },
      error: err => {
        console.log(err);
      }
    })
  }

  ngOnDestroy() {
    this.themeService.setDarkNav(false);
  }
}
