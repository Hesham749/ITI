import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Department',
  templateUrl: './Department.component.html',
  styleUrls: ['./Department.component.css']
})
export class DepartmentComponent implements OnInit {

  name = ".Net"
  capaticy = 30
  constructor() { }

  ngOnInit() {
  }

}
