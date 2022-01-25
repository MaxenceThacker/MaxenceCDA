<?php
$listeAuteursOeuvres = Auteurs_OeuvresManager::getList();
?>
<select>
    <option value="defaut" selected>--Choisissez votre Auteur et ses oeuvres--</option>
    <?php
                foreach ($listeAuteursOeuvres as $elt) {
                    echo '<option value="' . $elt->getIdAuteur() . '">' . $elt->getNomAuteur() . " " . $elt->getPrenomAuteur() . " " . $elt->getTitreOeuvre() . '</option>';
                }   
    ?>
</select>
<div class="countOeuvres"></div>