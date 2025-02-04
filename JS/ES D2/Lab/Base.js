import {Rectangle, Square} from "./SquareModule.js";
import {Circle} from "./CircleModule.js";

var rectangle1 = new Rectangle("red", 20, 10);
rectangle1.GetArea();

var square1 = new Square("Blue", 10, 10);
square1.GetArea();

var circle1 = new Circle("green", 8, 1, 3);
circle1.GetArea();
