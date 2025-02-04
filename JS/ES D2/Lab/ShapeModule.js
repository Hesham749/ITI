class Shape {
    #color;
    constructor(color) {
        this.Color = color;
    }
    set Color(value) {
        this.#color = value;
    }
    get Color() {
        return this.#color;
    }
    DrawShape() {
        console.log(this.#color);
    }
}

export {Shape};
