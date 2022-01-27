<?php
$elm = new Salles($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = SallesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = SallesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = SallesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeSalles");