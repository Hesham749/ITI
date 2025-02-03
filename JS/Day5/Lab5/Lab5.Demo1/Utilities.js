function CheckToDo(e) {
    let checked = "✓ ";
    !this.classList.contains("Checked") ? this.classList.add("Checked") : this.classList.remove("Checked");
    this.innerText = this.classList.contains("Checked") ? checked + this.innerText : this.innerText.slice(1);
    if (!this.classList.contains("Checked")) SavedList.push(this.innerText);
    else SavedList.splice(SavedList.indexOf(" " + this.innerText, 1));
    localStorage.setItem("TodoList", JSON.stringify(SavedList));
}




function ADDToDo(e) {
    e.preventDefault();
    if (newToDo.value != "") {
        let nTodo = document.createElement("li");
        nTodo.innerText = "  " + newToDo.value;
        SavedList.push(nTodo.innerText);
        localStorage.setItem("TodoList", JSON.stringify(SavedList));
        TodoList.appendChild(nTodo);
        newToDo.value = "";
        nTodo.addEventListener("click", CheckToDo);
    }
}
