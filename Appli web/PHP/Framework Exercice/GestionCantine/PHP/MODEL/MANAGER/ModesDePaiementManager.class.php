<?php

class ModesDePaiementManager
{
    public static function add(ModesDePaiement $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO ModesDePaiement (LibelleModeDePaiement) VALUES (:libelleModeDePaiement)");
        $q->bindValue(":libelleModeDePaiement", $obj->getLibelleModeDePaiement());
        $q->execute();
    }

    public static function update(ModesDePaiement $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE ModesDePaiement SET IdModeDePaiement=:idModeDePaiementLibelleModeDePaiement=:libelleModeDePaiement WHERE IdModeDePaiement=:idModeDePaiement");
        $q->bindValue(":libelleModeDePaiement", $obj->getLibelleModeDePaiement());
        $q->execute();
    }

    public static function delete(ModesDePaiement $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM ModesDePaiement WHERE IdModeDePaiement=" . $obj->getIdModeDePaiement());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;
        $q = $db->query("SELECT * FROM ModesDePaiement WHERE IdModeDePaiement =" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new ModesDePaiement($results);
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
        $q = $db->query("SELECT * FROM ModesDePaiement");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new ModesDePaiement($donnees);
            }
        }
        return $liste;
    }
}