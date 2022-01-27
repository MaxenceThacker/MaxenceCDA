<?php
$elm = new Films($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = FilmsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = FilmsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = FilmsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeFilms");