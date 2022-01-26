const req = XMLHttpRequest();
const req2 = XMLHttpRequest();
var listeOeuvres = document.querySelector('.countOeuvre');
var select = document.querySelector('select');

select.addEventListener("change", changeAuteur);

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText);
            listeOeuvre.innerHTML="";
            for (let i = 0; i < reponse.length; i++) {
                countOeuvres(reponse[i].typeOeuvre, reponse[i].titreOeuvre, reponse[i].idOeuvre);   
            }
            console.log(reponse);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText);
            listeOeuvre.innerHTML="";
            for (let i = 0; i < reponse.length; i++) {
                countOeuvres(reponse[i]);   
            }
            console.log(reponse);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

function countOeuvres(typeOeuvre,titreOeuvre,idOeuvre) {

    let OeuvreCompte = document.createElement("div");
    OeuvreCompte.setAttribute("class", "uneOeuvreCompte");
    OeuvreCompte.setAttribute("id", idOeuvre);
    OeuvreCompte.innerHTML = count (titreOeuvre);
    countOeuvre.appendChild(OeuvreCompte);

}

function changeAuteur(){
    if (select.value != "defaut"){
        // pour récupérer les oeuvres de l'auteur, on doit passer par la table associative => donc par la vue
        req.open('POST', 'index.php?page=ListeAuteursOeuvresAPI', true);
        req.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        var id = select.value;
        var args = "idAuteur=" + id;
        requ.send(args);
    }
}

function changeOeuvres(){
    req2.open('POST','index.php?page=ListeOeuvresAPI',true);
    req2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    var oeuvre = document.getElementById("IdOeuvre").value
    req2.send("idAuteur=" + oeuvre);
}






