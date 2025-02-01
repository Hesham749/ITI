addEventListener('load', function () {
    //function fun() {
    //    alert("cliiiiiked")
    //}

    //btn2 = document.getElementById("btn2")
    //btn2.onclick = fun2;
    //function fun2() {
    //    document.body.style.backgroundColor = "cyan"
    //}

    ////btn2.onclick = function () {
    ////    document.body.style.backgroundColor = "cyan"
    ////}

    //btn2.onclick = function () {
    //    document.title="Updated"
    //}

    ///* btn2.addEventListener("click", fun2 )*/
    btn2.addEventListener("click", function (e) {
        //document.body.style.backgroundColor = "cyan"
        console.log(e)

    })

    mydiv = document.querySelector("div")

    mydiv.addEventListener('mouseover', function (e) {
      /*  console.log("mouse Overrr")*/
        // console.log(this);
       console.log(e)

    })//mouseover

    mydiv.addEventListener('mouseout', function () {
       /* console.log("mouse Ouuut")*/


    })//mouseout


    mydiv.addEventListener('mousemove', function (e) {
      /*  console.log("mouse Movee")*/

      this.innerHTML="<h1 align='center'><font color='darkcyan'>"+e.x+" : "+e.y+"</font></h1>"

    })//mouseout


    myselect = document.querySelector("select")
    myspan = document.querySelector("span")

    myselect.addEventListener('change', function () {

        myspan.innerText = this.value;
        myspan.style.font = "bold 20px tahoma";
        myspan.style.color="red"


    })

    txt = document.querySelector("#txt")

    // key up
    //txt.addEventListener('keyup', function () {
    //    myspan.innerText = this.value;
    //    myspan.style.font = "bold 20px tahoma";
    //    myspan.style.color = "red"
    //})

    //keydown
    //txt.addEventListener('keydown', function () {
    //    myspan.innerText = this.value;
    //    myspan.style.font = "bold 20px tahoma";
    //    myspan.style.color = "red"
    //})

    //keypress
    txt.addEventListener('keypress', function (e) {
        //myspan.innerText = this.value;
        //myspan.style.font = "bold 20px tahoma";
        //myspan.style.color = "red"
        //if (e.key==='Enter') {
        //    /* alert('Enter Pressed')*/

        //}
        console.log(e)
    })



})

