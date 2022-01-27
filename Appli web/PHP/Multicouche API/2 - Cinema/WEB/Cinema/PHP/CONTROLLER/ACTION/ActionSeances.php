<?php
$elm = new Seances($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = SeancesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = SeancesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = SeancesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeSeances");