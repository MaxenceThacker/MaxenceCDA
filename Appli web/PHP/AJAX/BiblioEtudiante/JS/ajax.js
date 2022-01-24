var contenu = document.getElementById("contenu");
var enregs;

var req = new XMLHttpRequest();

req.open("GET", "https://opendata.paris.fr/api/records/1.0/search/?dataset=tous-les-documents-des-bibliotheques-de-pret&q=&facet=langue&facet=editeur&facet=auteur_nom&facet=auteur_secondaire_nom&facet=categorie_statistique_1&facet=categorie_statistique_2&facet=auteur&facet=collectivite_auteur", true);   
req.send(null);



req.onreadystatechange = function (event) {
    if (this.readyState == XMLHttpRequest.DONE) {
        if (this.status == 200) /*Code de validité */ {
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            enregs = trie(reponse.records);
            for (let i = 0; i < enregs.length; i++) {
                // on crée la ligne et les div internes
                ligne = document.createElement("div");
                ligne.setAttribute("class", "ligne");
                ligne.id = i;
                nombre_d_exemplaires = document.createElement("div");
                nombre_d_exemplaires.setAttribute("class", "nombre_d_exemplaires");
                ligne.appendChild(nombre_d_exemplaires);
                titre = document.createElement("div");
                titre.setAttribute("class", "titre");
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
            }
            console.log("Réponse reçue: %s", this.responseText)
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
        
    }
};

function trie(tab){

    do{
        //on part du principe que le tableau est bien trié, et dès que l'on fait une permutation il ne l'est plus. Si on ne fait plus de permutation alors il est trié et on sort de la boucle
        flag=true;
        //on compare tout les éléments du tableau avec son voisin (sauf le dernier)
        for(let i=0;i<tab.length-1;i++){
            //si la valeur suivante est plus petite alors on permute les 2 valeurs dans le tableau
            if(tab[i+1].fields.commune<tab[i].fields.commune){
                temp=tab[i];
                tab[i]=tab[i+1];
                tab[i+1]=temp;
                flag=false;    
            }
        }
    }while(!flag);
    return tab;
}
