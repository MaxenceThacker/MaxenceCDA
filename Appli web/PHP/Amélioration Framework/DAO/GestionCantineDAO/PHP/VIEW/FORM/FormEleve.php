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
            $ele = ElevesManager::findById($_GET['id']);
            $idEle = $ele->getIdEleve();
        } else {
            $ele = new Eleves();
            $idEle = null;
        }

        

        echo '<div class="gridForm">';
        //id
        echo '  <input type="hidden" name="idEleve" value="' . $ele->getIdEleve() . '">';
        //NomEleve
        echo '  <label class="colSpan2">'. 'NomEleve'.' :</label>
                <input class="spanFour" type="texte" name="nomEleve" value="' . $ele->getNomEleve() . '"' . $disabled . '>';
        //PrenomEleve
        echo '  <label class="colSpan2">'. 'PrenomomEleve'.' :</label>
                <input class="spanFour" type="texte" name="prenomEleve" value="' . $ele->getPrenomEleve() . '"' . $disabled . '>';
        //DDNEleve
        echo '  <label class="colSpan2">'. 'DDNEleve'.' :</label>
                <input class="spanFour" type="date" name="DDNEleve" value="' . $ele->getDDNEleve() . '"' . $disabled . '>';
        //montant
        echo '  <label class="colSpan2">'. 'Solde'.' :</label>
                <input class="spanFour" type="text" name="solde" value="' . $ele->getSoldeEleve() . '"' . $disabled . '>';
        echo '</div>';
        echo '</form>';
        ?>
    </div>
    <div class="demi"></div>
</main>