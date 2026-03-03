import {ChangeDetectorRef, Component, DestroyRef, effect, inject, input } from '@angular/core';
import {PlaceModel, CategoryModel} from '../../../models';
import {CategoryService} from '../../../services/category.service';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';
import {RouterLink} from '@angular/router';

@Component({
  selector: 'app-listing',
  imports: [
    RouterLink
  ],
  templateUrl: './listing.html',
  styleUrl: './listing.css',
})
export class Listing {

  category = input.required<string>();
  private categoryService = inject(CategoryService);
  private destroyRef = inject(DestroyRef);

  categoryData: CategoryModel | undefined;
  placeData: PlaceModel[] = [];
  constructor(private cd: ChangeDetectorRef) {
    effect(() => {
      const currentCategory = this.category();

      console.log("This was in constructor: /" + currentCategory);

      this.loadData("/" + currentCategory);
    })
  }

  loadData(path: string) {

    this.categoryService.getCategories(path)
      .pipe(takeUntilDestroyed(this.destroyRef))
      .subscribe(category =>
        {
          this.categoryData = category[0];
          this.cd.detectChanges();
        });

    this.categoryService.getPlaces(path)
      .pipe(takeUntilDestroyed(this.destroyRef))
      .subscribe(places =>
        {
          this.placeData = places;
          console.log("This was in getPlaceData: ", this.placeData);
          this.cd.detectChanges();
        })
  }
}
