<?php
$elm = new Menus($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = MenusManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = MenusManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = MenusManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeMenus");