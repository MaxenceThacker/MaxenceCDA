<?php


if ($_POST['motDePasse'] == $_POST['confirmation']) 
{
    $uti = UsersManager::findByEmail($_POST['email']);
    if ($uti == false) 
    {
        $u = new Users($_POST);
        $u->setMDPUser(crypte($u->getMDPUser()));
        UsersManager::add($u);
        header("location:index.php?page=connection");
    } else 
    {
        echo "<div class="erreur">l'email existe deja</div>";
    }
} else  
{

    echo '<div class="erreur">la confirmation ne correspond pas au mot de passe</div>';
}
header("refresh:3;url=index.php?page=inscription");
