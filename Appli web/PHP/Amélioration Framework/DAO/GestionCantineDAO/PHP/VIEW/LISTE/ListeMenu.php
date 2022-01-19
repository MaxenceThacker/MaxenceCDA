<?php
$liste = MenusManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn" href='index.php?page=formMenu&mode=Ajouter'><?php echo 'Ajouter' ?></a>
    </div>
    <div id="crudTableau">

    <div class="crudColonne"><?php echo 'Date' ?></div>
    <div class="crudColonne"><?php echo 'Libelle' ?></div>
    <div class="crudColonne"><?php echo 'Prix' ?></div>
    <div></div>
    <div></div>
    <div></div>

        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getDateMenu() . '</div>
            <div class="crudColonne">' . $elt->getLibelleMenu() . '</div>
            <div class="crudColonne">' . $elt->getPrixMenu() . '</div>
            <a class=" crudBtn" href="index.php?page=formMenu&mode=Editer&id='. $elt->getIdMenu().'">'.'Editer' .'</a>
            <a class=" crudBtn" href="index.php?page=formMenu&mode=Modifier&id='.$elt->getIdMenu().'">'. 'Modifier' .'</a>
            <a class=" crudBtn" href="index.php?page=formMenu&mode=Supprimer&id='. $elt->getIdMenu().'">'. 'Supprimer' .'</a>
            ';
        } ?>

    </div>
</div>