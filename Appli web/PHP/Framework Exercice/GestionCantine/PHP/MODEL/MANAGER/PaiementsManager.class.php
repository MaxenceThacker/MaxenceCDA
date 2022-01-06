<?php

class PaiementsManager

{
    public static function add(Paiements $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Paiements (MontantPaiement,DatePaiement,IdEleve,IdModeDePaiement) VALUES (:montantPaiement,:datePaiement,:idEleve,:idModeDePaiement)");
        $q->bindValue(":montantPaiement", $obj->getMontantPaiement());
        $q->bindValue(":datePaiement", $obj->getDatePaiement());
        $q->bindValue(":idEleve", $obj->getIdEleve());
        $q->bindValue(":idModeDePaiement", $obj->getIdModeDePaiement());
        $q->execute();
    }

    public static function update(Paiements $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Paiements SET MontantPaiement=:montantPaiement,DatePaiement=:datePaiement,IdEleve=:idEleve,IdModeDePaiement=:idModeDePaiement WHERE IdPaiement=:idPaiement");
        $q->bindValue(":montantPaiement", $obj->getMontantPaiement());
        $q->bindValue(":datePaiement", $obj->getDatePaiement());
        $q->bindValue(":idEleve", $obj->getIdEleve());
        $q->bindValue(":idModeDePaiement", $obj->getIdModeDePaiement());
        $q->execute();
    }

    public static function delete(Paiements $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Paiements WHERE IdPaiement=" . $obj->getIdPaiement());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;
        $q = $db->query("SELECT * FROM Paiements WHERE IdPaiement =" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Paiements($results);
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
        $q = $db->query("SELECT * FROM Paiements");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Paiements($donnees);
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

    public static function getListByModeDePaiement($idModeDePaiement)
    {
        $idModeDePaiement=(int) $idModeDePaiement;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Paiements where IdModeDePaiement=$idModeDePaiement");
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