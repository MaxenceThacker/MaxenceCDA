<?php

//Connexion à la BDD
$startPdo = new PDO ('mysql:host=localhost;dbname=cda', 'root','');

//Prépa Requète d'affichage (SQL)
$pdoAffich = $startPdo->prepare('SELECT * FROM ville');

//Exécution Requète 
$AffichExe = $pdoAffich->execute();

//Récupération des résultat en une fois 
$ville = $pdoAffich->fetchAll();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Liste des villes</title>
</head>
<body>
    <h1>Liste des villes</h1>
    <ul>
        <?php foreach ($villes as $ville): ?>

            <li>
                <?= $ville['villeID'] ?> - <?= $ville['villeName'] ?> - <?= $ville['villeDepartementNumber'] ?> - <?= $ville['villePostalCode'] ?> - <?= $ville['villeUpdateDate'] ?>
            </li>

        <?php endforeach; ?>
    </ul>   
</body>
</html>


