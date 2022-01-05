<?php

require "employe.class.php";
require "agence.class.php";
require "enfant.class.php";

$a1 = new Agence(["Nom" => "Neuralink", "adresse" => "15 rue du Pompier","restauration" => "ticket restaurant" ,"codePostal" => "62120" , "ville" => "Wardrecques"]);
$a2 = new Agence(["Nom" => "SpaceX", "adresse" => "45 rue des Tanneurs","restauration" =>"restaurant d'entreprise" ,"codePostal" => "69000", "ville" => "Lyon"]);
$a3 = new Agence(["Nom" => "DeepMind", "adresse" => "23 rue du Colibri","restauration" =>"restaurant d'entreprise" ,"codePostal" => "62500", "ville" => "Saint-Omer"]);
$enfant[] = new Enfant(["Nom" => "Cadart", "Prenom" => "Albert", "Age" => 2]);
$enfant[] = new Enfant(["Nom" => "Cadart", "Prenom" => "George", "Age" => 3]);
$enfant[] = new Enfant(["Nom" => "Marquis", "Prenom" => "Jean", "Age" => 5]);
$enfant[] = new Enfant(["Nom" => "Lapin", "Prenom" => "Mathieu", "Age" => 7]);
$enfant[] = new Enfant(["Nom" => "Demon", "Prenom" => "Nutella", "Age" => 11]);
$e[] = new Employe(["Nom" => "Hiesse", "Prenom" => "Colline", "dateEmbauche" => new DateTime("25-02-2002"), "poste" => "Jardinière", "Salaire" => "35000", "Service" => "Entretien Exterieur","agence"=>$a3]);
$e[] = new Employe(["Nom" => "Cadart", "Prenom" => "Aurélien", "dateEmbauche" => new DateTime("13-08-1999"), "poste" => "Avocat", "Salaire" => "40000", "Service" => "Juridique","agence"=>$a1,"enfants"=>[$enfant[0],$enfant[1]]]);
$e[] = new Employe(["Nom" => "Lapin", "Prenom" => "Riven", "dateEmbauche" => new DateTime("23-03-2000"), "poste" => "Architecte d'intérieur", "Salaire" => "30000", "Service" => "Décoration","agence"=>$a2,"enfants"=>[$enfant[3]]]);
$e[] = new Employe(["Nom" => "Marquis", "Prenom" => "Vladimir", "dateEmbauche" => new DateTime("25-03-1999"), "poste" => "Comptable", "Salaire" => "30000", "Service" => "Comptabilité","agence"=>$a1,"enfants"=>[$enfant[2]]]);
$e[] = new Employe(["Nom" => "Demon", "Prenom" => "Teemo", "dateEmbauche" => new DateTime("27-10-1948"), "poste" => "Psychologue", "Salaire" => "50000", "Service" => "Social","agence"=>$a3,"enfants"=>[$enfant[4]]]);

echo 'Il y a '.count($e).' employés dans l\'entreprise';
usort($e, array("Employes", "compareToServiceNomPrenom"));
$masseSalarialeTotale = 0;
foreach ($e as $key => $value) 
{
    echo 'Employe'. $key . ': ' . $value->toString(); 
    echo 'prime :' . $value->calculePrimeTotal();
    $masseSalarialeTotale += $value->masseSalariale();
    echo 'cheque vacances :' . 
    recoitChequeNoel()
}
echo '<div>La masse salariale est de ' . $masseSalarialeTotale . '€ </div>';






?>