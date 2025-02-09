document.addEventListener('DOMContentLoaded', async () => {
    const newPost = {
        title: 'foo',
        body: 'bar',
        userId: 1
    };

    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/posts', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(newPost)
        });

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const post = await response.json();
        console.log('Post added successfully:', post);
    } catch (error) {
        console.error('Error adding post:', error);
    }
});