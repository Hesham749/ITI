next.onclick = function () {
    index++;
    if (index >= images.length) {
        index = 0;
    }
    image.src = "Assets/" + images[index];
};

previous.onclick = function () {
    index--;
    if (index < 0) {
        index = images.length - 1;
    }
    image.src ="Assets/" + images[index];
};
slideShow.onclick = function () {
    slideShow = setInterval(function () {
        index++;
        if (index >= images.length) {
            index = 0;
        }
        image.src = "Assets/" + images[index];
    }, 1000);
};
stop.onclick = function () {
    clearInterval(slideShow);
};