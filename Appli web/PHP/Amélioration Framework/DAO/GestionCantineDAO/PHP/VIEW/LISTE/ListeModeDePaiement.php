<?php
$liste = ModesDePaiementManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn" href='index.php?page=formModeDePaiement&mode=Ajouter'><?php echo 'Ajouter' ?></a>
    </div>
    <div id="crudTableau">

    <div class="crudColonne"><?php echo 'Libelle' ?></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>

        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getLibelleModeDePaiement() . '</div>
            <a class=" crudBtn" href="index.php?page=formModeDePaiement&mode=Editer&id='. $elt->getIdModeDePaiement().'">'.'Editer' .'</a>
            <a class=" crudBtn" href="index.php?page=formModeDePaiement&mode=Modifier&id='.$elt->getIdModeDePaiement().'">'. 'Modifier' .'</a>
            <a class=" crudBtn" href="index.php?page=formModeDePaiement&mode=Supprimer&id='. $elt->getIdModeDePaiement().'">'. 'Supprimer' .'</a>
            <div></div>
            <div></div>
            ';
        } ?>

    </div>
</div>