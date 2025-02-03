document.getElementById("loginForm").addEventListener("submit", function(e) {
    e.preventDefault();

    let username = document.getElementById("username").value.trim();
    let password = document.getElementById("password").value.trim();

    let usernameError = document.getElementById("usernameError");
    let passwordError = document.getElementById("passwordError");

    let usernameRegex = /^[a-zA-Z]+\S{5,}$/;
    let passwordRegex = /[a-zA-Z]+.{5,}$/;

    let isValid = true;


    if (!usernameRegex.test(username)) {
        usernameError.style.display = "block";
        isValid = false;
    } else {
        usernameError.style.display = "none";
    }


    if (!passwordRegex.test(password)) {
        passwordError.style.display = "block";
        isValid = false;
    } else {
        passwordError.style.display = "none";
    }

    if (isValid) {

        alert("Login Successful! ✅");
        usernameError.style.display = "none";
        passwordError.style.display = "none";

        document.getElementById("loginForm").reset();

    }
});
