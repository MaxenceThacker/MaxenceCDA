<?php
$elm = new Paiements($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = PaiementsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = PaiementsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PaiementsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePaiements");