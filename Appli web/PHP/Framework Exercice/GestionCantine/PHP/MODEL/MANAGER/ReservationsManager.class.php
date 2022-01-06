<?php

class ReservationsManager
{
    public static function add(Reservations $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Reservations (IdEleve,IdMenu,DateReservation) VALUES (:idEleve,:libelleReservation,:dateReservation)");
        $q->bindValue(":idEleve", $obj->getIdEleve());
        $q->bindValue(":libelleReservation", $obj->getLibelleReservation());
        $q->bindValue(":dateReservation", $obj->getDateReservation());
        $q->execute();
    }

    public static function update(Reservations $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Reservations SET IdReservation=:idReservation,IdEleve=:idEleve,IdMenu=:idMenu,DateReservation=:dateReservation WHERE IdReservation=:idReservation");
        $q->bindValue(":idEleve", $obj->getIdEleve());
        $q->bindValue(":libelleReservation", $obj->getLibelleReservation());
        $q->bindValue(":dateReservation", $obj->getDateReservation());
        $q->execute();
    }

    public static function delete(Reservations $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Reservations WHERE IdReservation=" . $obj->getIdReservation());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;
        $q = $db->query("SELECT * FROM Reservations WHERE IdReservation =" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Reservations($results);
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
        $q = $db->query("SELECT * FROM Reservations");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Reservations($donnees);
            }
        }
        return $liste;
    }

    public static function getListByEleve($idEleve)
    {
        $idEleve=(int) $idEleve;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Paiements where IdEleve=$idEleve");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Users($donnees);
            }
        }
        return $liste; 
    } 

    public static function getListByMenu($idMenu)
    {
        $idMenu=(int) $idMenu;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Paiements where IdMenu=$idMenu");
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