<?php
$erreur = false;
$e = new ModesDePaiement($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
        ModesDePaiementManager::add($e);
        break;
    }
    case "Modifier": {
        ModesDePaiementManager::update($e);
        break;
    }
    case "Supprimer": {
        ModesDePaiementManager::delete($e);
        break;
    }
}

if($erreur) {
    header("location:index.php?page=listeModeDePaiement");
}else{
    header("refresh:3;url=index.php?page=listeModeDePaiement");
}