
export interface CategoryPageData {
  path: string;
  heading: string;
  heroImage: string;
  subHeading: string;
}

export interface CategoryModel {
  categoryID: number;
  path: string;
  title: string;
  description: string;

  imageID: number;
  image?: ImageModel;
}

export interface PlaceModel {
  placeID: number;
  name: string;
  location: string;
  rating: number;

  imageID: number;
  image?: ImageModel;

  categoryID: number;
  category: CategoryModel;

  placeTags?: PlaceTagModel[];
}

export interface ImageModel {
  imageID: number;
  imageURL: string;
  name: string;
}

export interface TagModel {
  tagID: number;
  tagName: string;
}

export interface PlaceTagModel {
  placeID: number;
  tagID: number;

  tag: TagModel;
}

/* DTOs */

