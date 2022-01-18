<?php
$erreur = false;
$e = new Paiements($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
            PaiementsManager::add($e);
            break;
        }
    case "Modifier": {
            PaiementsManager::update($e);
            break;
        }
        case "Supprimer": {

            PaiementsManager::delete($p);
            break;
        }
}

if (!$erreur) {  // si pas d'erreur
    header("location:index.php?page=listePaiement");   //redirection directe
} else {
    header("refresh:3;url=index.php?page=listePaiement");    // on attend 3 secondes avant la redirection
}
