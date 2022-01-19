<?php
$liste = ElevesManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn" href='index.php?page=formEleve&mode=Ajouter'><?php echo 'Ajouter' ?></a>
    </div>
    <div id="crudTableau1">

    <div class="crudColonne"><?php echo 'Nom' ?></div>
    <div class="crudColonne"><?php echo 'Prenom' ?></div>
    <div class="crudColonne"><?php echo 'DateDeNaissance' ?></div>
    <div class="crudColonne"><?php echo 'Solde' ?></div>
    <div></div>
    <div></div>
    <div></div>

        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getNomEleve() . '</div>
            <div class="crudColonne">' . $elt->getPrenomEleve() . '</div>
            <div class="crudColonne">' . $elt->getDDNEleve() . '</div>
            <div class="crudColonne">' . $elt->getSoldeEleve() . '</div>   
            <a class=" crudBtn" href="index.php?page=formEleve&mode=Editer&id='. $elt->getIdEleve().'">'.'Editer' .'</a>
            <a class=" crudBtn" href="index.php?page=formEleve&mode=Modifier&id='.$elt->getIdEleve().'">'. 'Modifier' .'</a>
            <a class=" crudBtn" href="index.php?page=formEleve&mode=Supprimer&id='. $elt->getIdEleve().'">'. 'Supprimer' .'</a>
            ';
        } ?>

    </div>
</div>