document.addEventListener('DOMContentLoaded', async () => {
    const userList = document.getElementById('userList');
    const showUserBtn = document.getElementById('showUserBtn');
    showUserBtn.disabled = true;
    document.body.appendChild(showUserBtn);

    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/users');
        const users = await response.json();
        users.forEach(user => {
            const option = document.createElement('option');
            option.value = user.id;
            option.textContent = user.name;
            userList.appendChild(option);
        });
        showUserBtn.disabled = false;
    } catch (error) {
        console.error("Error fetching users:", error);
    }

    showUserBtn.addEventListener('click', async () => {
        const selectedUserId = userList.value;
        if (selectedUserId) {
            try {
                const response = await fetch(`https://jsonplaceholder.typicode.com/users/${selectedUserId}`);
                const user = await response.json();
                alert(`User Details:\nName: ${user.name}\nEmail: ${user.email}\nPhone: ${user.phone}`);
            } catch (error) {
                console.error("Error fetching user details:", error);
            }
        }
    });
});