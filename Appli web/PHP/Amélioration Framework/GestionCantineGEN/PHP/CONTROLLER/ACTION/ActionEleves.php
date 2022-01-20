<?php
$elm = new Eleves($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ElevesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ElevesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ElevesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeEleves");