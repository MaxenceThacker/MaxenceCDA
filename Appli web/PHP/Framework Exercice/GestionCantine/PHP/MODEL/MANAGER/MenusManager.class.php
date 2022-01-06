<?php

class MenusManager
{
    public static function add(Menus $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Menus (DateMenu,LibelleMenu,PrixMenu) VALUES (:dateMenu,:libelleMenu,:prixMenu)");
        $q->bindValue(":dateMenu", $obj->getDateMenu());
        $q->bindValue(":libelleMenu", $obj->getLibelleMenu());
        $q->bindValue(":prixMenu", $obj->getPrixMenu());
        $q->execute();
    }

    public static function update(Menus $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Menus SET IdMenu=:idMenu,DateMenu=:dateMenu,LibelleMenu=:libelleMenu,PrixMenu=:prixMenu WHERE IdMenu=:idMenu");
        $q->bindValue(":dateMenu", $obj->getDateMenu());
        $q->bindValue(":libelleMenu", $obj->getLibelleMenu());
        $q->bindValue(":prixMenu", $obj->getPrixMenu());
        $q->execute();
    }

    public static function delete(Menus $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Menus WHERE IdMenu=" . $obj->getIdMenu());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;
        $q = $db->query("SELECT * FROM Menus WHERE IdMenu =" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Menus($results);
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
        $q = $db->query("SELECT * FROM Menus");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Menus($donnees);
            }
        }
        return $liste;
    }
}