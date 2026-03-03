import {effect, Injectable, input} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map, Observable} from 'rxjs';
import { CategoryModel, PlaceModel } from '../models';

@Injectable({
  providedIn: 'root',
})
export class CategoryService {

  private apiCategories = "https://localhost:7123/api/categories";
  private apiPlaces = "https://localhost:7123/api/places";

  constructor(private http: HttpClient) { }

  getCategories(path: string): Observable<CategoryModel[]> {
    return this.http.get<CategoryModel[]>(this.apiCategories).pipe(
      map(categories => categories.filter(c => c.path === path))
    );
  }

  getPlaces(path: string): Observable<PlaceModel[]> {
    return this.http.get<PlaceModel[]>(this.apiPlaces).pipe(
      map(places => places.filter(p => p.category.path === path))
    );
  }

  getPlaceDetail(id: string): Observable<PlaceModel> {
    const url = `${this.apiPlaces}/${id}`;

    return this.http.get<PlaceModel>(url);
  }
}
