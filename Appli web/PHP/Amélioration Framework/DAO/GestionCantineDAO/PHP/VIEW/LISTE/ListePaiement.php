<?php
$liste = PaiementsManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn" href='index.php?page=formPaiement&mode=Ajouter'><?php echo 'Ajouter' ?></a>
    </div>
    <div id="crudTableau">

    <div class="crudColonne"><?php echo 'Date' ?></div>
    <div class="crudColonne"><?php echo 'Montant' ?></div>
    <div class="crudColonne"><?php echo 'ModeDePaiement' ?></div>
    <div></div>
    <div></div>
    <div></div>

        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getDatePaiement() . '</div>
            <div class="crudColonne">' . $elt->getMontantPaiement() . '</div>
            <div class="crudColonne">' . $elt->getIdModeDePaiement() . '</div>   
            <a class=" crudBtn" href="index.php?page=formPaiement&mode=Editer&id='. $elt->getIdPaiement().'">'.'Editer' .'</a>
            <a class=" crudBtn" href="index.php?page=formPaiement&mode=Modifier&id='.$elt->getIdPaiement().'">'. 'Modifier' .'</a>
            <a class=" crudBtn" href="index.php?page=formPaiement&mode=Supprimer&id='. $elt->getIdPaiement().'">'. 'Supprimer' .'</a>
            ';
        } ?>

    </div>
</div>