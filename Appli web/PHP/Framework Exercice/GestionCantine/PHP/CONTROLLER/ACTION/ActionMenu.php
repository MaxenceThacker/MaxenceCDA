<?php
$erreur = false;
$e = new Menus($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
            MenusManager::add($e);
            break;
        }
    case "Modifier": {
            MenusManager::update($e);
            break;
        }
        case "Supprimer": {

            MenusManager::delete($p);
            break;
        }
}

if (!$erreur) {  // si pas d'erreur
    header("location:index.php?page=listeMenu");   //redirection directe
} else {
    header("refresh:3;url=index.php?page=listeMenu");    // on attend 3 secondes avant la redirection
}