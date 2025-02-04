import {Shape} from "./ShapeModule.js";
class Rectangle extends Shape {
    #width;
    #height;
    get Width() {
        return this.#width;
    }
    constructor(color, width, height) {
        super(color);
        this.Width = width;
        this.Height = height;
    }
    set Width(value) {
        value > 0 ? (this.#width = value) : (this.#width = 0);
    }

    get Height() {
        return this.#height;
    }
    set Height(value) {
        value > 0 ? (this.#height = value) : (this.#height = 0);
    }
    GetArea() {
        super.DrawShape();
        console.log(this.Width * this.Height);
    }
}

class Square extends Rectangle {
    constructor(color, width, height) {
        super(color, width, height);
    }
}

export {Square, Rectangle};
