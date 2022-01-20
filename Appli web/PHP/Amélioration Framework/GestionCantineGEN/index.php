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

	"ListeEleves"=>["PHP/VIEW/LISTE/","ListeEleves","Liste Eleves",0,false],
	"FormEleves"=>["PHP/VIEW/FORM/","FormEleves","Formulaire Eleves",0,false],
	"ActionEleves"=>["PHP/CONTROLLER/ACTION/","ActionEleves","Action Eleves",0,false],

	"ListeMenus"=>["PHP/VIEW/LISTE/","ListeMenus","Liste Menus",0,false],
	"FormMenus"=>["PHP/VIEW/FORM/","FormMenus","Formulaire Menus",0,false],
	"ActionMenus"=>["PHP/CONTROLLER/ACTION/","ActionMenus","Action Menus",0,false],

	"ListeModesDePaiement"=>["PHP/VIEW/LISTE/","ListeModesDePaiement","Liste ModesDePaiement",0,false],
	"FormModesDePaiement"=>["PHP/VIEW/FORM/","FormModesDePaiement","Formulaire ModesDePaiement",0,false],
	"ActionModesDePaiement"=>["PHP/CONTROLLER/ACTION/","ActionModesDePaiement","Action ModesDePaiement",0,false],

	"ListePaiements"=>["PHP/VIEW/LISTE/","ListePaiements","Liste Paiements",0,false],
	"FormPaiements"=>["PHP/VIEW/FORM/","FormPaiements","Formulaire Paiements",0,false],
	"ActionPaiements"=>["PHP/CONTROLLER/ACTION/","ActionPaiements","Action Paiements",0,false],

	"ListeReservations"=>["PHP/VIEW/LISTE/","ListeReservations","Liste Reservations",0,false],
	"FormReservations"=>["PHP/VIEW/FORM/","FormReservations","Formulaire Reservations",0,false],
	"ActionReservations"=>["PHP/CONTROLLER/ACTION/","ActionReservations","Action Reservations",0,false],

	"ListeRoles"=>["PHP/VIEW/LISTE/","ListeRoles","Liste Roles",0,false],
	"FormRoles"=>["PHP/VIEW/FORM/","FormRoles","Formulaire Roles",0,false],
	"ActionRoles"=>["PHP/CONTROLLER/ACTION/","ActionRoles","Action Roles",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

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