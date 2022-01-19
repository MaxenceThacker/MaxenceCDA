<main>
    <div class="demi"></div>
    <div class="colonne">
        <?php
        $defaultMode =  $_GET['mode'];

        $disabled = " ";
        switch ($defaultMode) {
            case "Editer":
            case "Supprimer":
                $disabled = " disabled ";
                break;
        }

        echo '<h2>' . 'Eleve' .'</h2>
        <form id="formulaire" method="post" action="index.php?page=actionEleve&mode=' . $defaultMode . '">';
        if (isset($_GET['id'])) {
            $pai = ElevesManager::findById($_GET['id']);
            $idPai = $pai->getIdEleve();
        } else {
            $pai = new Eleves();
            $idPai = null;
        }

        

        echo '<div class="gridFormEleve">';
        //id
        echo '  <input type="hidden" name="idEleve" value="' . $pai->getIdEleve() . '">';
        //NomEleve
        echo '  <label class="colSpan2">'. 'NomEleve'.' :</label>
                <input class="spanFour" type="texte" name="nomEleve" value="' . $pai->getNomEleve() . '"' . $disabled . '>';
        //PrenomEleve
        echo '  <label class="colSpan2">'. 'PrenomomEleve'.' :</label>
                <input class="spanFour" type="texte" name="prenomEleve" value="' . $pai->getPrenomEleve() . '"' . $disabled . '>';
        //DDNEleve
        echo '  <label class="colSpan2">'. 'DDNEleve'.' :</label>
                <input class="spanFour" type="date" name="DDNEleve" value="' . $pai->getDDNEleve() . '"' . $disabled . '>';
        //montant
        echo '  <label class="colSpan2">'. 'Solde'.' :</label>
                <input class="spanFour" type="text" name="solde" value="' . $pai->getSoldeEleve() . '"' . $disabled . '>';
        echo '</div>';
        echo '</form>';
        ?>
    </div>
    <div class="demi"></div>
</main>