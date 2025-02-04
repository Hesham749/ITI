
/*import zagazig, { fname as stdname, arr, calc, editname } from "./Module1.js"*/
import * as zag from "./Module1.js";
 let fname = "mounir"

function dosomething() {
    alert("something Done ")
}

//arr.map((elm) => console.log(elm))
//stdname="Aliaaa"  error to edit expoted value 
//console.log(stdname)
//console.log(new zagazig("Lion", "anything"))

console.log(zag.calc("+",2,3))