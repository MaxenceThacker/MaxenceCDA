function myFunction() {
  document.getElementById("menuDown").classList.toggle("show");
}

window.onclick = function (event) {
    if (!event.target.matches('.button')) {
      var menuDowns = document.getElementsByClassName("menuDown-content");
      var i;
      for (i = 0; i < menuDowns.length; i++) {
        var openMenuDown = menuDowns[i];
        if (openMenuDown.classList.contains('show')) {
          openMenudown.classList.remove('show');
        }
      }
    }
}