const req = new XMLHttpRequest();
var listeOeuvres = document.querySelector('countOeuvres');
var select = document.querySelector('select');

select.addEventListener("change", changeOeuvre);

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status == 200) {
            reponse = JSON.parse(this.responseText);
            countOeuvres.innerHTML = "";
            for (let i = 0; i < reponse.length; i++) {
                ligne = document.createElement("div");
                ligne.setAttribute("class", "ligne");
                ligne.id = i;
                oeuvre = document.createElement("div");
                oeuvre.setAttribute("class", "uneOeuvre");
                oeuvre.setAttribute("id", idOeuvre);
                listeOeuvre.appendChild(oeuvre);
                oeuvre.innerHTML = count(reponse[i].typeOeuvre + ' : ' + reponse[i].titreOeuvre);
                
            }
        }
    }
};



function changeOeuvre(){
    req.open('GET', 'index.php?page=ListeAuteursOeuvresAPI', true);
    req.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    var id = select.value;
    var args = "titreOeuvre";
    req.send(args);
}