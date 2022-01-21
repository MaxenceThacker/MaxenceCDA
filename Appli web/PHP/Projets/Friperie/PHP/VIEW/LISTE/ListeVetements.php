<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = VetementsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe grid-columns-span-7">Liste des Vetements </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormVetements&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">libelleVetement</div>';
echo '<div class="caseListe">prixVetement</div>';
echo '<div class="caseListe">idCategorie</div>';
echo '<div class="caseListe">idUsure</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getLibelleVetement().'</div>';
echo '<div class="caseListe">'.$unObjet->getPrixVetement().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdCategorie().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdUsure().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormVetements&mode=Afficher&id='.$unObjet->getIdVetement().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormVetements&mode=Modifier&id='.$unObjet->getIdVetement().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormVetements&mode=Supprimer&id='.$unObjet->getIdVetement().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-7">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';