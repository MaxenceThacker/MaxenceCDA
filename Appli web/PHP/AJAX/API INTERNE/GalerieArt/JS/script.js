const req = new XMLHttpRequest();
var listeOeuvres = document.querySelector('countOeuvres');
var select = document.querySelector('select');

select.addEventListener("change", changeOeuvre);

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status == 200) {
            reponse = JSON.parse(this.responseText);
            countOeuvres.innerHTML = "";
            oeuvre.innerHTML = count(reponse.typeOeuvre + ' : ' + reponse.titreOeuvre);
            select.addEventListener("change", changeOeuvre);
        }
    }
};



function changeOeuvre(){
    req.open('GET', 'index.php?page=ListeAuteursOeuvresAPI', true);
    req.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    var id = select.value;
    var args = "titreOeuvre" + id;
    req.send(args);
}