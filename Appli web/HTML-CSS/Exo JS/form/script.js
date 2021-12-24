//Variable
var form = document.querySelector("#logform");
var nom = form.nom.value;
var prenom = form.prenom.value;
var ddn = form.ddn.value;
var adresse = form.adresse.value;
var CP = form.cp.value;
var ville = form.ville.value;
var Email = form.email.value;


//Variable message manque

var noNom = document.getElementById("noNom");
var noPrenom = document.getElementById("noPrenom");
var ddn = document.getElementById("ddn");
var adresse = document.getElementById("adresse");
var noCP = document.getElementById("noCP");
var ville = document.getElementById("ville");
var email = document.getElementById("email");

//Regex
const nomRegex = /^[A-Z][A-Za-z\é\è\ê\-]+$/;
const prenomRegex = /^[A-Z][A-Za-z\é\è\ê\-]+$/;
const emailRegex = /(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])/;

//Récupération du clic
var submit = form.submit;
submit.addEventListener('click', valid);
var cancel = form.cancel;
cancel.addEventListener('click', reset);

//Tableau de span
var validation = {} // Contient des elements si l'utilisateur remplie mal le formulaire
var inputs = document.getElementsByTagName("input"); 
for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("input", validation)
    validation[inputs[i].name] = false;
}


//Fonction d'annulation
function reset() {
    noNom.textContent = "";
    noPrenom.textContent = "";
    noDate.textContent = "";
    noAdresse.textContent = "";
    noCP.textContent = "";
    noVille.textContent = "";
    noEmail.textContent = "";
}

//Fonction de validation du formulaire
function valid() {
    validNom();
    validPrenom();
    validDate();
    validAdresse();
    validCP();
    validVille();
    validEmail();
    validation();
     
} 



//Les fonctions
function validNom() {
    nom = document.querySelector('#nom').value
    if (nom == "") {
        noNom.textContent = "Nom manquant";
        noNom.classList.add("red");
        
    }else {
        noNom.textContent = "";
    }
    if (nomRegex.test(nom) == false) {
        noNom.textContent = "Nom incorrect";
        noNom.classList.add("orange");
        
    }else {
        noNom.textContent = "";
    }
}

function validPrenom() {
    prenom = document.querySelector('#prenom').value
    if (prenom == "") {
        noPrenom.textContent = "prenom manquant";
        noPrenom.classList.add("red");
        
    }else {
        noPrenom.textContent = "";
    }
    if (prenomRegex.test(prenom) == false) {
        noPrenom.textContent = "Prénom incorrect";
        noPrenom.classList.add("orange");
        
    }else {
        noPrenom.textContent = "";

    }
}




