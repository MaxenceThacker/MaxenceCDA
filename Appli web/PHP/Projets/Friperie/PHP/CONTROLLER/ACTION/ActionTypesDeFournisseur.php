<?php
$elm = new TypesDeFournisseur($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TypesDeFournisseurManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TypesDeFournisseurManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TypesDeFournisseurManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTypesDeFournisseur");