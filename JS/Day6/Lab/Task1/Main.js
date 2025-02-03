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

//3

function DoMath(op, ...numbers) {
    console.log(eval(numbers.join(op)));
}

DoMath("+", 1, 2, 5);
DoMath("*", 1, 2, 5);


//4

function GetREctangle()=>{};