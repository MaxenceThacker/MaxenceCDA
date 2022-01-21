<?php
$elm = new Vetements($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = VetementsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = VetementsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = VetementsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeVetements");