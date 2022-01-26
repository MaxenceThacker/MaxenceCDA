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
	"Default"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],
	"Accueil"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],

	"ActionConnexion"=>["PHP/CONTROLLER/ACTION/","ActionConnexion","Action de la connexion",0,false],
	"ActionInscription"=>["PHP/CONTROLLER/ACTION/","ActionInscription","Action de l'inscription",0,false],
	"ActionDeconnexion"=>["PHP/CONTROLLER/ACTION/","ActionDeconnexion","Action de deconnexion",0,false],

	"ListeMailAPI"=>["PHP/MODEL/API/","ListeMailAPI", "ListeMailAPI",0,true],

	"ListeAuteurs"=>["PHP/VIEW/LISTE/","ListeAuteurs","Liste Auteurs",0,false],
	"FormAuteurs"=>["PHP/VIEW/FORM/","FormAuteurs","Formulaire Auteurs",0,false],
	"ActionAuteurs"=>["PHP/CONTROLLER/ACTION/","ActionAuteurs","Action Auteurs",0,false],

	"ListeAuteurs_Oeuvres"=>["PHP/VIEW/LISTE/","ListeAuteurs_Oeuvres","Liste Auteurs_Oeuvres",0,false],
	"FormAuteurs_Oeuvres"=>["PHP/VIEW/FORM/","FormAuteurs_Oeuvres","Formulaire Auteurs_Oeuvres",0,false],
	"ActionAuteurs_Oeuvres"=>["PHP/CONTROLLER/ACTION/","ActionAuteurs_Oeuvres","Action Auteurs_Oeuvres",0,false],

	"ListeCreations"=>["PHP/VIEW/LISTE/","ListeCreations","Liste Creations",0,false],
	"FormCreations"=>["PHP/VIEW/FORM/","FormCreations","Formulaire Creations",0,false],
	"ActionCreations"=>["PHP/CONTROLLER/ACTION/","ActionCreations","Action Creations",0,false],

	"ListeOeuvres"=>["PHP/VIEW/LISTE/","ListeOeuvres","Liste Oeuvres",0,false],
	"FormOeuvres"=>["PHP/VIEW/FORM/","FormOeuvres","Formulaire Oeuvres",0,false],
	"ActionOeuvres"=>["PHP/CONTROLLER/ACTION/","ActionOeuvres","Action Oeuvres",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

	"ListeAuteursAPI"=>["PHP/MODEL/API/","ListeAuteursAPI", "ListeAuteursAPI",0,true],
    "ListeCreationsAPI"=>["PHP/MODEL/API/","ListeCreationsAPI", "ListeCreationsAPI",0,true],
    "ListeOeuvresAPI"=>["PHP/MODEL/API/","ListeOeuvresAPI", "ListeOeuvresAPI",0,true],
    "ListeAuteursOeuvresAPI"=>["PHP/MODEL/API/","ListeAuteursOeuvresAPI", "ListeAuteursOeuvresAPI",0,true]
	
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