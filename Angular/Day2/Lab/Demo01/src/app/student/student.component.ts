import { Component } from '@angular/core';
import { Student } from '../_models/student';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-student',
  imports: [FormsModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css',
})
export class StudentComponent {
  delete(index: number) {
    this.students.splice(index, 1);
  }
  add() {
    this.students.push(this.std);

    this.std = new Student();

    this.index = -1;
  }
  updateStudent() {
    let x = this.students[this.index];

    x.id = this.std.id;
    x.name = this.std.name;
    x.age = this.std.age;

    this.std = new Student();
    this.index = -1;
  }
  showDetails(index: number) {
    var selected = this.students[index];

    this.std.id = selected.id;
    this.std.name = selected.name;
    this.std.age = selected.age;

    this.index = index;
  }



  students: Student[] = [
    new Student(1, 'Hesham', 30),
    new Student(2, 'Eslam', 22),
    new Student(3, 'Ezzat', 30),
  ];

  std: Student = new Student();
  private index = -1;
}
