<?php
$elm = new Oeuvres($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = OeuvresManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = OeuvresManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = OeuvresManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeOeuvres");