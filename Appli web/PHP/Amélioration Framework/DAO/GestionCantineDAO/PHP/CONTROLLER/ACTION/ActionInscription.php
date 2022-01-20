<?php


if ($_POST['MDPUser'] == $_POST['confirmation']) 
{
    $uti = UsersManager::getList($_POST['emailUser']);
    if ($uti == false) 
    {
        $u = new Users($_POST);
        $u->setMDPUser(crypte($u->getMDPUser()));
        UsersManager::add($u);
        header("location:index.php?page=accueil");
    } else 
    {
        echo '<div class="erreur">l\'email existe deja</div>';
    }
} else  
{

    echo '<div class="erreur">la confirmation ne correspond pas au mot de passe</div>';
}
header("refresh:3;url=index.php?page=inscription");
