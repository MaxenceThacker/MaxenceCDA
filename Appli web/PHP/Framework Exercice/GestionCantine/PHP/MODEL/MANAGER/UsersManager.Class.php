<?php

class UsersManager
{
    public static function add(Users $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Users (NomUser,PrenomUser,MDPUser,EmailUser,IdRole) VALUES (:nomUser,:prenomUser,:MDPUser,:emailUser,:idRole)");
        $q->bindValue(":nomUser", $obj->getNomUser());
        $q->bindValue(":prenomUser", $obj->getPrenomUser());
        $q->bindValue(":MDPUser", $obj->getMDPUser());
        $q->bindValue(":emailUser", $obj->getEmailUser());
        $q->bindValue(":idRole", $obj->getIdRole());
        $q->execute();
    }

    public static function update(Users $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Users SET IdUser=:idUser,NomUser=:nomUser,PrenomUser=:prenomUser,MDPUser=:MDPUser,EmailUser=:emailUser,IdRole=:idRole WHERE IdUser=:idUser");
        $q->bindValue(":idUser", $obj->getIdUser());
        $q->bindValue(":nomUser", $obj->getNomUser());
        $q->bindValue(":prenomUser", $obj->getPrenomUser());
        $q->bindValue(":MDPUser", $obj->getMDPUser());
        $q->bindValue(":emailUser", $obj->getEmailUser());
        $q->bindValue(":idRole", $obj->getIdRole());
        $q->execute();
    }

    public static function delete(Users $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Users WHERE IdUser=" . $obj->getIdUser());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;
        $q = $db->query("SELECT * FROM Users WHERE IdUser =" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Users($results);
        }
        else
        {
            return false;
        }
    }

    public static function getList()
    {
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Users");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Users($donnees);
            }
        }
        return $liste;
    }
    
    public static function findByEmail($emailUser)
    {
		$db = DbConnect::getDb();
        if (!in_array(";",str_split($emailUser)))
        {
            $q = $db->query("SELECT * FROM Users WHERE EmailUser ='" . $emailUser . "'");
            $results = $q->fetch(PDO::FETCH_ASSOC);
            if ($results != false)
            {
                return new Users($results);
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public static function getListByRole($idRole)
    {
        $idRole=(int) $idRole;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Users where IdRole=$idRole");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Users($donnees);
            }
        }
        return $liste;  
    }
}
