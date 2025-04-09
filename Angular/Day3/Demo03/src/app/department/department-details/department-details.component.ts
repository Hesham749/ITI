import { Component, OnDestroy, OnInit } from '@angular/core';
import { DepartmentsService } from '../../_services/departments.service';
import { Department } from '../../_models/department';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-department-details',
  imports: [JsonPipe],
  templateUrl: './department-details.component.html',
  styleUrl: './department-details.component.css',
})
export class DepartmentDetailsComponent implements OnInit, OnDestroy {
  dept?: Department;
  constructor(
    protected ds: DepartmentsService,
    protected route: ActivatedRoute
  ) {}
  ngOnDestroy(): void {
    this.subscriber?.unsubscribe();
  }
  subscriber?: Subscription;
  ngOnInit(): void {
    this.subscriber = this.route.params.subscribe(
      (s) => (this.dept = this.ds.getById(s['id']))
    );
  }
}
