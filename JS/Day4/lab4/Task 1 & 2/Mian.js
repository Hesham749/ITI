//! 1

//a
var images1 = document.images;
console.log(images1);

var images2 = document.getElementsByTagName("img");
console.log(images2);

//b
var options = document.getElementsByTagName("option");
console.log(options);

//c
//Find all rows for second table in page
var rows = table.getElementsByTagName("tr");
console.log(rows);

//d
// Find all elements that contain class name fontBlue
var fontblue = document.getElementsByClassName("fontBlue");
console.log(fontblue);

//! 2
//a
var table = document.getElementsByTagName("table")[1];
var link = table.getElementsByTagName("a")[0];

link.href = "http://training.com";
link.innerText = "Training";

//b
var img = document.getElementsByTagName("img")[1];
img.style.border = "5px solid red";

// c
var form = document.getElementsByTagName("form")[1];

function ShowChecked() {
    for (var i = 0; i < form.children.length; i++) {
        if (form.children[i].checked) {
            alert(`You have selected the ${i + 1} option`);
        }
    }
}

//d
document.getElementById("example").style.backgroundColor = "pink";
