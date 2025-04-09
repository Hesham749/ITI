import { Component, OnInit } from '@angular/core';
import { DepartmentsService } from '../../_services/departments.service';
import { Department } from '../../_models/department';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-department-add',
  imports: [FormsModule],
  templateUrl: './department-add.component.html',
  styleUrl: './department-add.component.css',
})
export class DepartmentAddComponent {
  save() {
    this.ds.add(this.dept);
    this.route.navigate(['/departments']);
  }
  dept: Department = {};
  constructor(protected ds: DepartmentsService, protected route: Router) {}
}
