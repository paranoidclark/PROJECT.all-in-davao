import {ChangeDetectorRef, Component, effect, inject, input, OnDestroy, OnInit} from '@angular/core';
import {CategoryService} from '../../../../services/category.service';
import {PlaceModel} from '../../../../models';
import {RouterLink, RouterOutlet} from '@angular/router';
import {ThemeService} from '../../../../services/theme.service';

@Component({
  selector: 'app-detail',
  imports: [
    RouterOutlet,
    RouterLink
  ],
  templateUrl: './detail.html',
  styleUrl: './detail.css',
})
export class Detail implements OnInit, OnDestroy {

  category = input.required<string>();
  place = input.required<string>();
  categoryService = inject(CategoryService);
  themeService = inject(ThemeService);
  cd = inject(ChangeDetectorRef);

  placeData: PlaceModel | undefined;


  constructor() {
    effect(() => {
      const currentPlace = this.place();

      console.log(currentPlace);

      this.loadData(currentPlace);
    });
  }

  loadData(id: string) {

    this.categoryService.getPlaceDetail(id).subscribe(place => {
      this.placeData = place;
      console.log(this.placeData);
      this.cd.detectChanges();
    })
  }

  ngOnInit() {
    this.themeService.setDarkNav(true);
  }

  ngOnDestroy() {
    this.themeService.setDarkNav(false);
  }
}
