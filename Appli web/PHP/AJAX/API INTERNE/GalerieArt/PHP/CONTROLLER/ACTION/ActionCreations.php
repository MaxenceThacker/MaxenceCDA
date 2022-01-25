<?php
$elm = new Creations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = CreationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = CreationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = CreationsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeCreations");