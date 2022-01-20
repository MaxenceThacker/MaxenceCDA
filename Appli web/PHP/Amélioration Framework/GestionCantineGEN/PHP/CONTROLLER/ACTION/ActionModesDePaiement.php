<?php
$elm = new ModesDePaiement($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ModesDePaiementManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ModesDePaiementManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ModesDePaiementManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeModesDePaiement");