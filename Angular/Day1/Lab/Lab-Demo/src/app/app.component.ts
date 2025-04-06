import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavComponent } from "../Nav/Nav.component";
import { StudentComponent } from "../Student/Student.component";
import { FooterComponent } from "../Footer/Footer.component";
import { CourseComponent } from "./Course/Course.component";
import { DepartmentComponent } from "./Department/Department.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavComponent, StudentComponent, FooterComponent, CourseComponent, DepartmentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Lab-Demo';
}
