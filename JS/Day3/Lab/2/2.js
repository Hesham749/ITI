function Student(name , age , grade) {
    this.Name =name;
    this.Age = age ;
    this.Grade = grade;
    this.Print = function(){return`<h4>${this.Name} : ${this.Age} : ${this.Grade}<h4>`;}
}


var arr=[new Student ("hesham",30,90),  new Student ("karim",20,70), new Student ("Omar",220,60),] ;

  

PrintAllStudents(arr);


PrintStudentWithGradeMoreThan80(arr);

StudensSortedByNameAscending(arr);

















function PrintAllStudents(students , message = "All Students") {
    document.write(`<h2>${message}</h2>`)
   for (let i = 0; i < students.length; i++) {
    document.write(`${students[i].Print()}`);
   }
}



function PrintStudentWithGradeMoreThan80(students) {
    PrintAllStudents(students.filter(std => {
      return  std.Grade>80;
    }),"<font color = red >Students have grade more than 80</font>")
}



function StudensSortedByNameAscending(students) {
        x = students ;

        PrintAllStudents(x.sort((a,b)=>{return a.Name.toLowerCase() - b.Name.toLowerCase()}),"<font color = red >Students order by name ascending</font>")
}
