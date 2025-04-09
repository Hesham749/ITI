import { Routes } from '@angular/router';
import { DepartmentListComponent } from './department/department-list/department-list.component';
import { HomeComponent } from './home/home.component';
import { DepartmentDetailsComponent } from './department/department-details/department-details.component';
import { DepartmentAddComponent } from './department/department-add/department-add.component';

export const routes: Routes = [
  {
    path: 'departments',
    component: DepartmentListComponent,
    children: [
      { path: 'details/:id', component: DepartmentDetailsComponent },
      { path: 'add', component: DepartmentAddComponent },
    ],
  },
  { path: 'home', component: HomeComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
];
