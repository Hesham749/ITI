// 1- selection using ID
myul = document.getElementById("list1")
// 2- selectipn using tag Name
document.getElementsByTagName("p")// return collection

sendpara = document.getElementsByTagName("p")[1]
// selection using class


document.getElementsByClassName("bGrey")

tbl = document.getElementsByClassName("bGrey")[1]

// selection using name 
chck=document.getElementsByName("hoppy")

//queryselector
document.querySelector("p") // return first element with tag Name <p>
document.querySelector(".bGrey")// select using css selector

document.querySelectorAll(".bGrey")// return all elements with class bGrey


tbl2 = document.getElementsByTagName("table")[1]

tr1 = tbl.getElementsByTagName("tr")[0]
td1 = tr1.getElementsByTagName("td")[0]


//tbl.children[0].children[0].children[0]
td1.innerText// get

//td1.innerText="Zag" // set
//td1.innerHTML="<h1 align='center'><font color='red'>ITI</font></h1>"


//tbl.setAttribute("align", "center")

//tbl.setAttribute("class","bPink")

//tbl.getAttribute("class")

//tbl.classList.add("zag")
///// create Element

liobj = document.createElement("li")
liobj.innerText = "dotNet Zagazig"
liobj.style.color = "red"
liobj.style.backgroundColor = "cyan"

myul.appendChild(liobj)


//////////////
imgs = document.querySelectorAll("img")
for (var i = 0; i < imgs.length; i++) {
    imgs[i].style.border="3px dashed red"
}



//////////////
//chck[0].checked // true
//chck[0].checked = false

/////////////
txt.value


