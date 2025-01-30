
var st = "Welcome to js";
    var i =0 ;
    var typing = setInterval(function(){document.write(st[i]); i++;},500);
setTimeout( ()=>{clearInterval(typing);close();},st.length *500)