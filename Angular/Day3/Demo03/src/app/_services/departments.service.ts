import { Injectable } from '@angular/core';
import { Department } from './../_models/department';

@Injectable({
  providedIn: 'root',
})
export class DepartmentsService {
  private _departments: Department[] = [
    { id: 1, name: 'HR', location: 'Zag' },
    { id: 2, name: 'It', location: 'Cairo' },
    { id: 3, name: 'Finance', location: 'Alex' },
  ];
  constructor() {}

  getAll(): Department[] {
    return this._departments;
  }

  add(ndp: Department): void {
    this._departments.push(ndp);
  }

  getById(id: number) {
    return this._departments.find((s) => s.id == id);
  }

  update(dp: Department): void {
    let dept = this.getById(dp.id!);
    dept = dp;
  }
}
