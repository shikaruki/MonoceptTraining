var images = document.querySelectorAll(".theImage");
for (var i = 0; i < images.length; i++) {
 var image = images[i];
 alert(image.getAttribute("src"));
}