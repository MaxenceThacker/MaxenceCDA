<?php
$elm = new Usures($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = UsuresManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = UsuresManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = UsuresManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUsures");