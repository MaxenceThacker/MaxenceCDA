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

        echo '<h2>' . 'Menu' .'</h2>
        <form id="formulaire" method="post" action="index.php?page=actionMenu&mode=' . $defaultMode . '">';
        if (isset($_GET['id'])) {
            $men = MenusManager::findById($_GET['id']);
            $idMen = $men->getIdMenu();
        } else {
            $men = new Menus();
            $idMen = null;
        }

        

        echo '<div class="gridForm">';
        //id
        echo '  <input type="hidden" name="idMenu" value="' . $men->getIdMenu() . '">';
        //DateMenu
        echo '  <label class="colSpan2">'. 'DateMenu'.' :</label>
                <input class="spanFour" type="date" name="dateMenu" value="' . $men->getDateMenu() . '"' . $disabled . '>';
        //LibelleMenu
        echo '  <label class="colSpan2">'. 'LibelleomMenu'.' :</label>
                <input class="spanFour" type="texte" name="libelleMenu" value="' . $men->getLibelleMenu() . '"' . $disabled . '>';
        //PrixMenu
        echo '  <label class="colSpan2">'. 'PrixMenu'.' :</label>
                <input class="spanFour" type="number" name="prixMenu" value="' . $men->getPrixMenu() . '"' . $disabled . '>';
        echo '</div>';
        echo '</form>';
        ?>
    </div>
    <div class="demi"></div>
</main>