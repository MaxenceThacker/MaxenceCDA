<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = PaiementsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe grid-columns-span-7">Liste des Paiements </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormPaiements&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">MontantPaiement</div>';
echo '<div class="caseListe">DatePaiement</div>';
echo '<div class="caseListe">IdEleve</div>';
echo '<div class="caseListe">IdModeDePaiement</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getMontantPaiement().'</div>';
echo '<div class="caseListe">'.$unObjet->getDatePaiement().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdEleve().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdModeDePaiement().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormPaiements&mode=Afficher&id='.$unObjet->getIdPaiement().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormPaiements&mode=Modifier&id='.$unObjet->getIdPaiement().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormPaiements&mode=Supprimer&id='.$unObjet->getIdPaiement().'"><i class="fas fa-trash-alt"></i></a></div>';
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