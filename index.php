<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Ajouter une ville</h1>
    <form action="inserction.php" method='post'>
        <p>
            <label for="id">Id</label>
            <input id="id" type="text" name="villeID">
        </p>

        <p>
            <label for="name">Nom</label>
            <input id="name" type="text" name="villeName">
        </p>

        <p>
            <label for="dn">Numéro de Département</label>
            <input id="dn" type="text" name="villeDepartementNumber">
        </p>

        <p>
            <label for="pc">Code Postal</label>
            <input id="pc" type="text" name="villePostalCode">
        </p>

        <p>
            <label for="updd">Date de mise à jour</label>
            <input id="updd" type="text" name="villeUpdateDate">
        </p>
    </form>

</body>
</html>