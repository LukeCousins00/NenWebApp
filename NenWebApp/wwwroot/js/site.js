var mainNavbar = document.getElementById("main-navbar");
var activePageId = sessionStorage.getItem('activePageId');

document.addEventListener('DOMContentLoaded', function () {
    // persist nav icon color
    if (activePageId != null) {
        var icon = document.getElementById(activePageId);
        icon.style.border  = "2px solid black";
        icon.style.borderRadius = "9px";
    }
});

mainNavbar.addEventListener("click", function (event) {
    sessionStorage.setItem('activePageId', event.target.id);
});