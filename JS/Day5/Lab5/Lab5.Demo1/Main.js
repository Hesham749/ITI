var addBtn = document.querySelector("#Add");
var TodoList = document.querySelector("#ToDoList");
var newToDo = document.querySelector("#NewToDo");
var lists = document.querySelectorAll("li");





addBtn.addEventListener("click", function (e) {
    e.preventDefault();
    if (newToDo.value != "") {
        let nTodo = document.createElement("li");
        nTodo.innerText = "  " + newToDo.value;
        TodoList.appendChild(nTodo);
        newToDo.value = "";
        nTodo.addEventListener("click", function (e) {
            let checked = "✓ ";
            !this.classList.contains("Checked") ? this.classList.add("Checked") : this.classList.remove("Checked");
            this.innerText = this.classList.contains("Checked") ? checked + this.innerText : this.innerText.slice(1);
            //!this.classList.contains("Checked") ? localStorage.setItem(this.innerText, this.innerText) : localStorage.removeItem(this.innerText);
        });
        //localStorage.setItem(newToDo.value, newToDo.value);
    }
});


