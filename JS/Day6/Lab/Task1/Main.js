//1
var Arr = [20, 7, 8, 10, 89, 100, 45, 17];

// a
console.log(Arr.filter(e => e % 2 != 0));

//b
Arr.forEach(e => {
    if (e % 2 === 0) console.log(e);
});

//c
console.log(Arr.sort((a, b) => a - b));

//2
console.log("\n");
console.log("\nForeach");
Arr.forEach(e => console.log(e));

console.log("\nfor in ");

for (const item in Arr) {
    console.log(Arr[item]);
}
console.log("\nfor of ");
for (const element of Arr) {
    console.log(element);
}

//3
console.log("\n");
function DoMath(op, ...numbers) {
    console.log(eval(numbers.join(op)));
}

DoMath("+", 1, 2, 5);
DoMath("*", 1, 2, 5);

//4
console.log("\n");
const createRectangle = (width, height) => ({
    width,
    height,
    calculateArea() {
        return this.width * this.height;
    },
});
const rectangle = createRectangle(10, 5);
console.log(rectangle.calculateArea());

//5
console.log("\n");
const students = [
    {name: "John", grade: 45},
    {name: "Jane", grade: 85},
    {name: "Dave", grade: 52},
    {name: "Sara", grade: 60},
];

students.find(s => {
    if (s.grade >= 50) console.log(s);
});

//6
console.log("\n");
var x = {name: "hesham", age: 30, salary: 10000};
var {name = "Ahmed", salary = salary} = x;

console.log(salary);

//7
function CreateCar(make, model, year) {
    this.Make = make;
    this.Model = model;
    this.Year = year;
}

cars = [new CreateCar("BMW", "E6", 1994), new CreateCar("sian", "E10", 2000)];

var car1 = new CreateCar("BMW", "E6", 1994);
console.log(car1);

//8

function CreateShape(type, width, height, radius) {
    this.Type = type;
    this.width = width;
    this.height = height;
    this.radius = radius;
}
