  export let fname = "mohamed"
export let arr = [10, 30, 50, 5, 200, 45]

  export function editname(_val) {
    fname=_val
}
function myfun() {
    console.log(`from module one`)
}
    export function calc(op, ...newarr) {
    console.log(eval(newarr.join(op)))
}

  export default class Animals {
    constructor(_name,_field) {
        // export  this.name = _name;// error because export per block
        this.name = _name;
        this.field = _field;


    }

    print() {
        return ` name=${this.name}  field = ${this.field}`
    }
}

/*export {arr ,calc,fname,Animal }*/// name Export 



