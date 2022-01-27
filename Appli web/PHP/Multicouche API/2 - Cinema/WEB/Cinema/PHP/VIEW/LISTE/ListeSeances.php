<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = SeancesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe grid-columns-span-7">Liste des Seances </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormSeances&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">idFilm</div>';
echo '<div class="caseListe">idSalle</div>';
echo '<div class="caseListe">horaireSeance</div>';
echo '<div class="caseListe">dateSeance</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getIdFilm().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdSalle().'</div>';
echo '<div class="caseListe">'.$unObjet->getHoraireSeance().'</div>';
echo '<div class="caseListe">'.$unObjet->getDateSeance().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormSeances&mode=Afficher&id='.$unObjet->getIdSeance().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormSeances&mode=Modifier&id='.$unObjet->getIdSeance().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormSeances&mode=Supprimer&id='.$unObjet->getIdSeance().'"><i class="fas fa-trash-alt"></i></a></div>';
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