<?php
$uti = UsersManager::findByEmail($_POST['email']);
if ($uti != false) {
    echo "motBDD " . $uti->getMDPUser() . "  saisi" . $_POST['motDePasse'] . "crypte   " . crypte($_POST['motDePasse']) . "<br>";
    if (crypte($_POST['motDePasse']) == $uti->getMDPUser()) {
        echo 'connection reussie';
        $_SESSION['utilisateur'] = $uti;
        header("location:index.php?page=accueil");
    } else {
        echo '<div class="erreur">le mot de passe est incorrect</div>';
        header("refresh:3;url=index.php?page=connection");
    }
} else {
    echo "<div class="erreur">l'email n'existe pas</div>";
    header("refresh:3;url=index.php?page=connection");
}