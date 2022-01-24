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
        }
    }
}