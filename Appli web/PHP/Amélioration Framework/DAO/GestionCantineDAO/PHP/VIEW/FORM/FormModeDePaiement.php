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

        echo '<h2>' . 'ModeDePaiement' .'</h2>
        <form id="formulaire" method="post" action="index.php?page=actionModeDePaiement&mode=' . $defaultMode . '">';
        if (isset($_GET['id'])) {
            $men = ModesDePaiementManager::findById($_GET['id']);
            $idMen = $men->getIdModeDePaiement();
        } else {
            $men = new ModesDePaiement();
            $idMen = null;
        }

        

        echo '<div class="gridForm">';
        //id
        echo '  <input type="hidden" name="idModeDePaiement" value="' . $men->getIdModeDePaiement() . '">';
        
        //LibelleModeDePaiement
        echo '  <label class="colSpan2">'. 'LibelleoModeDePaiement'.' :</label>
                <input class="spanFour" type="texte" name="libelleModeDePaiement" value="' . $men->getLibelleModeDePaiement() . '"' . $disabled . '>';
        echo '</div>';
        echo '</form>';
        ?>
    </div>
    <div class="demi"></div>
</main>