import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Student',
  templateUrl: './Student.component.html',
  styleUrls: ['./Student.component.css']
})
export class StudentComponent implements OnInit {
 name :string = "Hesham"
 age : number = 30
  constructor() { }

  ngOnInit() {
  }

}
