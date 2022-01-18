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

        echo '<h2>' . 'Paiement' .'</h2>
        <form id="formulaire" method="post" action="index.php?page=actionPaiement&mode=' . $defaultMode . '">';
        if (isset($_GET['id'])) {
            $pai = PaiementsManager::findById($_GET['id']);
            $idPai = $pai->getIdPaiement();
        } else {
            $pai = new Paiements();
            $idPai = null;
        }

        $listeEleves = ElevesManager::getList();
        $listeModesDePaiement = ModesDePaiementManager::getList();
        

        echo '<div class="gridFormPaiement">';
        //id
        echo '  <input type="hidden" name="idPaiement" value="' . $pai->getIdPaiement() . '">';
        //date du Paiement
        echo '  <label class="colSpan2">'. 'DatePaiement'.' :</label>
                <input class="colSpan2" type="date" name="datePaiement" value="' . $pai->getDatePaiement() . '"' . $disabled . '>';
        //Eleves
        echo '  <label>'. 'Eleve' .' :</label>
                <select name="idEleve" '.$disabled.'>';
        foreach ($listeEleves as $unEleve) {
            
            echo '<option value="' . $unEleve->getIdEleve() . '">' . $unEleve->getNomEleve() .' '. $unEleve->getPrenomEleve() . '</option>';
        }
        echo '</select>';
        //montant
        echo '  <label class="colSpan2">'. 'Montant'.' :</label>
                <input class="colSpan2" type="text" name="montant" value="' . $pai->getMontantPaiement() . '"' . $disabled . '>';
        echo '</div>';
        //Mode de paiement
        echo '  <label>'. 'Mode de Paiement' .' :</label>
                <select name="idModeDePaiement" '.$disabled.'>';
        foreach ($listeModesDePaiement as $unModeDePaiement) {
            
            echo '<option value="' . $unModeDePaiement->getIdModeDePaiement() . '">' . $unModeDePaiement->getLibelleModeDePaiement() .'</option>';
        }
        echo '</select>';
        echo '</div>';
        echo '</form>';
        ?>
    </div>
    <div class="demi"></div>
</main>