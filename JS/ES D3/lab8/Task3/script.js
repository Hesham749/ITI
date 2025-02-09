document.addEventListener('DOMContentLoaded', () => {
    const welcomeMessage = () => {
        return new Promise((resolve) => {
            setTimeout(() => {
                document.body.innerHTML = '<h1>Welcome to the page!</h1>';
                resolve();
            }, 3000);
        });
    };

    const displayUserImage = () => {
        return new Promise((resolve) => {
            const img = document.createElement('img');
            img.src = 'https://example.com/flower.jpg';
            img.alt = 'User Image';
            document.body.appendChild(img);
            resolve();
        });
    };

    const displayThanksMessage = () => {
        return new Promise((resolve) => {
            setTimeout(() => {
                document.body.innerHTML += '<h2>Thanks for visiting!</h2>';
                resolve();
            }, 3000);
        });
    };

    const redirectToAnotherPage = () => {
        window.location.href = 'https://www.example.com';
    };

    welcomeMessage()
        .then(displayUserImage)
        .then(displayThanksMessage)
        .then(redirectToAnotherPage)
        .catch((error) => console.error('Error:', error));
});