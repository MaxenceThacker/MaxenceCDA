<?php
$elm = new Auteurs_Oeuvres($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Auteurs_OeuvresManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Auteurs_OeuvresManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Auteurs_OeuvresManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAuteurs_Oeuvres");