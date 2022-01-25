const req = new XMLHttpRequest();
var listeOeuvres = document.querySelector('countOeuvres');
var select = document.querySelector('select');

select.addEventListener("change", changeAuteur);

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status == 200) {
            reponse = JSON.parse(this.responseText);
            countOeuvres.innerHTML = "";
            for (let i = 0; i < reponse.length; i++) {
                reponse[i].count++;
                console.log(reponse);
            }
        }
    }
};

