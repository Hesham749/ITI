import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Course',
  templateUrl: './Course.component.html',
  styleUrls: ['./Course.component.css']
})
export class CourseComponent implements OnInit {


  name = "Angular"
  totalHours = 14
  constructor() { }

  ngOnInit() {
  }

}
