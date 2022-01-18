<?php
$erreur = false;
$e = new Eleves($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
            ElevesManager::add($e);
            break;
        }
    case "Modifier": {
            ElevesManager::update($e);
            break;
        }
        case "Supprimer": {

            ElevesManager::delete($p);
            break;
        }
}

if (!$erreur) {  // si pas d'erreur
    header("location:index.php?page=listeEleve");   //redirection directe
} else {
    header("refresh:3;url=index.php?page=listeEleve");    // on attend 3 secondes avant la redirection
}
