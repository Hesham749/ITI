import {Shape} from "./ShapeModule.js";
class Circle extends Shape {
    radius;
    x;
    y;
    constructor(color, radius, x, y) {
        super(color);
        this.radius = radius;
        this.x = x;
        this.y = y;
    }
    GetArea() {
        super.DrawShape();
        console.log(Math.PI * Math.pow(this.radius, 2));
    }
}

export  {Circle};
