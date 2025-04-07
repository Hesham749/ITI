import { Component } from '@angular/core';
import { Product } from '../_models/product';

@Component({
  selector: 'app-product',
  imports: [],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
})
export class ProductComponent {
  products: Product[] = [
    new Product(
      1,
      'product 1',
      100,
      'product 1 description',
      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3b88B0IhOB4xX6eC7S9sd_iM4q0ZF-YvIeA&s'
    ),
    new Product(
      2,
      'product 2',
      200,
      'product 2 description',
      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3b88B0IhOB4xX6eC7S9sd_iM4q0ZF-YvIeA&s'
    ),
    new Product(
      3,
      'product 3',
      300,
      'product 3 description',
      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3b88B0IhOB4xX6eC7S9sd_iM4q0ZF-YvIeA&s'
    ),
    new Product(
      4,
      'product 4',
      400,
      'product 4 description',
      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3b88B0IhOB4xX6eC7S9sd_iM4q0ZF-YvIeA&s'
    ),
    new Product(
      5,
      'product 5',
      500,
      'product 5 description',
      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3b88B0IhOB4xX6eC7S9sd_iM4q0ZF-YvIeA&s'
    )
  ];
}
