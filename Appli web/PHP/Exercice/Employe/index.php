<?php

require "employe.class.php";

$e[] = new Employe(["Nom" => "Hiesse", "Prenom" => "Colline", "dateEmbauche" => new DateTime("25-02-2002"), "poste" => "Jardinière", "Salaire" => "35000", "Service" => "Entretien Exterieur"]);
$e[] = new Employe(["Nom" => "Cadart", "Prenom" => "Aurélien", "dateEmbauche" => new DateTime("13-08-1999"), "poste" => "Avocat", "Salaire" => "40000", "Service" => "Juridique"]);
$e[] = new Employe(["Nom" => "Lapin", "Prenom" => "Riven", "dateEmbauche" => new DateTime("23-03-2000"), "poste" => "Architecte d'intérieur", "Salaire" => "30000", "Service" => "Décoration"]);
$e[] = new Employe(["Nom" => "Marquis", "Prenom" => "Vladimir", "dateEmbauche" => new DateTime("25-03-1999"), "poste" => "Comptable", "Salaire" => "30000", "Service" => "Comptabilité"]);
$e[] = new Employe(["Nom" => "Demon", "Prenom" => "Teemo", "dateEmbauche" => new DateTime("27-10-1948"), "poste" => "Psychologue", "Salaire" => "50000", "Service" => "Social"]);

echo 'Il y a '.count($e).' employés dans l\'entreprise';

foreach ($e as $key => $value) 
{
    echo 'Employe'. $key . ': ' . $value->toString(); 
    echo 'prime :' . $value->calculePrimeTotal();
}

?>