var contenu = document.getElementById("contenu");
var enregs;

var req = new XMLHttpRequest();

req.open("GET", "https://www.data.gouv.fr/fr/datasets/liste-publique-des-organismes-de-formation-l-6351-7-1-du-code-du-travail/", true);   
req.send(null);

req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status == 200) /*Code de validité */ {
            reponse = JSON.parse(req.responseText);
            console.log(this.responseText);
            console.log(reponse);
            enregs = trie(reponse.records);
            for (let i = 0; i < enregs.length; i++) {
                // on crée la ligne et les div internes
                ligne = document.createElement("div");
                ligne.setAttribute("class", "ligne");
                ligne.id = i;
                nombre_d_exemplaires = document.createElement("div");
                nombre_d_exemplaires.setAttribute("class", "commune");
                ligne.appendChild(nombre_d_exemplaires);
                titre = document.createElement("div");
                titre.setAttribute("class", "nom");
                ligne.appendChild(titre);
                date = document.createElement("div");
                date.setAttribute("class", "date");
                ligne.appendChild(date);
                contenu.appendChild(ligne);
                espace = document.createElement("div");
                espace.setAttribute("class","espaceHorizon");
                contenu.appendChild(espace);
                //on met à jour le contenu
                nombre_d_exemplaires.innerHTML = enregs[i].fields.nombre_d_exemplaires;
                titre.innerHTML = enregs[i].fields.titre;
                date.innerHTML = enregs[i].fields.date;

                // on ajoute un evenement sur ligne pour afficher le detail
                ligne.addEventListener("click", afficheDetail);
            }
        }
    }
}