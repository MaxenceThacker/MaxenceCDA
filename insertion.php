<?php

//Connexion à la BDD
$startPdo = new PDO ('mysql:host=localhost;dbname=cda', 'root','');

//Prépa Requète d'insertion (SQL)
$pdoInsert = $startPdo->prepare('INSERT INTO ville VALUES (:id, :name, :dn, :pc, :updd)');

//Lier les marqueurs à une valeur
$pdoInsert->bindValue(':id', $_POST['villeID'], PDO::PARAM_INT);
$pdoInsert->bindValue(':id', $_POST['villeName'], PDO::PARAM_STR);
$pdoInsert->bindValue(':id', $_POST['villeDepartementNumber'], PDO::PARAM_INT);
$pdoInsert->bindValue(':id', $_POST['villePostalCode'], PDO::PARAM_INT);
$pdoInsert->bindValue(':id', $_POST['villeUpdateDate'], PDO::PARAM_INT);

//Execution Requète préparée
$insertExe = $pdoInsert->execute();

if($insertExe){
    $message = 'La ville a été ajouté dans la bdd';
}else{
    $message = 'Echec de L\insertion';
}
?>