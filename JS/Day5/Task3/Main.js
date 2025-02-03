var xhr = new XMLHttpRequest();
xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
xhr.send();
xhr.onreadystatechange = function() {
    if (xhr.readyState == 4 && xhr.status == 200) {
        localStorage.setItem('users', xhr.responseText);
        var users = JSON.parse(localStorage.getItem('users'));
        var tableBody = document.querySelector("#dataTable tbody");
        for (var i = 0; i < users.length; i++) {
            var tr = document.createElement("tr");
            var td1 = document.createElement("td");
            var td2 = document.createElement("td");
            var td3 = document.createElement("td");
            var td4 = document.createElement("td");
            td1.innerHTML = users[i].id;
            td2.innerHTML = users[i].name;
            td3.innerHTML = users[i].email;
            td4.innerHTML = users[i].phone;
      
            tr.appendChild(td1);
            tr.appendChild(td2);
            tr.appendChild(td3);
            tr.appendChild(td4);
        
            tableBody.appendChild(tr);
        }  
    }
};
