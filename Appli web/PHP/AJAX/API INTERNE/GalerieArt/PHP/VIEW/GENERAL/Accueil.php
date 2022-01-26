<?php
$listeAuteurs = AuteursManager::getList();
?>
<div class="padd1"></div>
<div>
    <div class="flex06"></div>
    <div class="column">
    <?php
        echo creerSelect(null,"idAi",["libelleTypeProduit"]);
    ?>  
        <div class="countOeuvre column"></div>
    </div>
    <div class="flex06"></div>
   
</div>