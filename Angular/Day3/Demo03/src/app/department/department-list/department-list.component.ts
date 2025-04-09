import { Component, OnInit } from '@angular/core';
import { DepartmentsService } from '../../_services/departments.service';
import { Department } from '../../_models/department';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-department-list',
  imports: [RouterLink , RouterLinkActive , RouterOutlet],
  templateUrl: './department-list.component.html',
  styleUrl: './department-list.component.css',
})
export class DepartmentListComponent implements OnInit {
  departments: Department[] = [];
  constructor(public ds: DepartmentsService) {}
  ngOnInit(): void {
    this.departments = this.ds.getAll();
  }
}
