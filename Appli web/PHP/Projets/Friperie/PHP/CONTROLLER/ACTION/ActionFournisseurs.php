<?php
$elm = new Fournisseurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = FournisseursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = FournisseursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = FournisseursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeFournisseurs");