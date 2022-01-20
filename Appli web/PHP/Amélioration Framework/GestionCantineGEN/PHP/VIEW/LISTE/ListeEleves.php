<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ElevesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe grid-columns-span-7">Liste des Eleves </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormEleves&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">NomEleve</div>';
echo '<div class="caseListe">PrenomEleve</div>';
echo '<div class="caseListe">DDNEleve</div>';
echo '<div class="caseListe">SoldeEleve</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getNomEleve().'</div>';
echo '<div class="caseListe">'.$unObjet->getPrenomEleve().'</div>';
echo '<div class="caseListe">'.$unObjet->getDDNEleve().'</div>';
echo '<div class="caseListe">'.$unObjet->getSoldeEleve().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormEleves&mode=Afficher&id='.$unObjet->getIdEleve().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormEleves&mode=Modifier&id='.$unObjet->getIdEleve().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormEleves&mode=Supprimer&id='.$unObjet->getIdEleve().'"><i class="fas fa-trash-alt"></i></a></div>';
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