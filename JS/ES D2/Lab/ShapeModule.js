class Shape {
    #color;
    constructor(color) {
        this.Color = value;
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

export default Shape;
