var addBtn = document.querySelector("#Add");
var TodoList = document.querySelector("#ToDoList");
var newToDo = document.querySelector("#NewToDo");
var Todos = document.querySelectorAll("li");
// create or load local saved list
if (localStorage.getItem("TodoList") === null) localStorage.setItem("TodoList", JSON.stringify([]));
var SavedList = JSON.parse(localStorage.getItem("TodoList"));

// add todo to the dom

for (let i = 0; i < SavedList.length; i++) {
    let nTodo = document.createElement("li");
    nTodo.innerText = "  " + SavedList[i];
    TodoList.appendChild(nTodo);
    nTodo.addEventListener("click", CheckToDo);
}

addBtn.addEventListener("click", ADDToDo);
