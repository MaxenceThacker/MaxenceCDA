<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TextesManager::checkIfLangExist($_GET['lang'])) {
	 // tester si la langue est gérée
	$_SESSION['lang'] = $_GET['lang'];
}else if (isset($_COOKIE['lang'])) {
	$_SESSION['lang'] = $_COOKIE['lang'];
}else{
	$_SESSION['lang'] = 'FR';
}
//Crée un cookie lang sur la machine de l'utilisateur d'une durée de 10h.
setcookie("lang", $_SESSION['lang'], time()+36000, '/');
/******Fin des langues******/

$routes=[
	"Default"=>["PHP/VIEW/FORM/","FormInscriptionConnexion","Connexion & Inscription",0,false],
	"Accueil"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],

	"ActionConnexion"=>["PHP/CONTROLLER/ACTION/","ActionConnexion","Action de la connexion",0,false],
	"ActionInscription"=>["PHP/CONTROLLER/ACTION/","ActionInscription","Action de l'inscription",0,false],
	"ActionDeconnexion"=>["PHP/CONTROLLER/ACTION/","ActionDeconnexion","Action de deconnexion",0,false],

	"ListeMailAPI"=>["PHP/MODEL/API/","ListeMailAPI", "ListeMailAPI",0,true],

	"ListeCategories"=>["PHP/VIEW/LISTE/","ListeCategories","Liste Categories",0,false],
	"FormCategories"=>["PHP/VIEW/FORM/","FormCategories","Formulaire Categories",0,false],
	"ActionCategories"=>["PHP/CONTROLLER/ACTION/","ActionCategories","Action Categories",0,false],

	"ListeFournisseurs"=>["PHP/VIEW/LISTE/","ListeFournisseurs","Liste Fournisseurs",0,false],
	"FormFournisseurs"=>["PHP/VIEW/FORM/","FormFournisseurs","Formulaire Fournisseurs",0,false],
	"ActionFournisseurs"=>["PHP/CONTROLLER/ACTION/","ActionFournisseurs","Action Fournisseurs",0,false],

	"ListeTypesDeFournisseur"=>["PHP/VIEW/LISTE/","ListeTypesDeFournisseur","Liste TypesDeFournisseur",0,false],
	"FormTypesDeFournisseur"=>["PHP/VIEW/FORM/","FormTypesDeFournisseur","Formulaire TypesDeFournisseur",0,false],
	"ActionTypesDeFournisseur"=>["PHP/CONTROLLER/ACTION/","ActionTypesDeFournisseur","Action TypesDeFournisseur",0,false],

	"ListeUsures"=>["PHP/VIEW/LISTE/","ListeUsures","Liste Usures",0,false],
	"FormUsures"=>["PHP/VIEW/FORM/","FormUsures","Formulaire Usures",0,false],
	"ActionUsures"=>["PHP/CONTROLLER/ACTION/","ActionUsures","Action Usures",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

	"ListeVentes"=>["PHP/VIEW/LISTE/","ListeVentes","Liste Ventes",0,false],
	"FormVentes"=>["PHP/VIEW/FORM/","FormVentes","Formulaire Ventes",0,false],
	"ActionVentes"=>["PHP/CONTROLLER/ACTION/","ActionVentes","Action Ventes",0,false],

	"ListeVetements"=>["PHP/VIEW/LISTE/","ListeVetements","Liste Vetements",0,false],
	"FormVetements"=>["PHP/VIEW/FORM/","FormVetements","Formulaire Vetements",0,false],
	"ActionVetements"=>["PHP/CONTROLLER/ACTION/","ActionVetements","Action Vetements",0,false],

];

if(isset($_GET["page"]))
{

	$page=$_GET["page"];

	if(isset($routes[$page]))
	{
		AfficherPage($routes[$page]);
	}
	else
	{
		AfficherPage($routes["Default"]);
	}
}
else
{
	AfficherPage($routes["Default"]);
}