<?php

 require "enfant.class.php";

class Employe
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_poste;
    private $_salaire;
    private $_service;
    private $_agence;
    private $_enfant = [];

    /*****************Accesseurs***************** */
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = strtoUpper($nom);
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche(DateTime $dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    public function getPoste()
    {
        return $this->_poste;
    }

    public function setPoste($poste)
    {
        $this->_poste = $poste;
    }

    public function getSalaire()
    {
        return $this->_salaire;
    }

    public function setSalaire($salaire)
    {
        $this->_salaire = $salaire;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }

    public function setAgence(Agence $agence)
    {
        $this->_agence = $agence;
    }

    public function getEnfants()
    {
        return $this->_enfants;
    }

    public function setEnfants(array $enfants)
    {
        $this->_enfants = $enfants;
    }
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
    public function toString()
    {
        $aff = "Nom :" . $this->getNom() . "\nPrenom :" . $this->getPrenom() . "\nDateEmbauche :" . $this->getDateEmbauche()->format('Y-m-d') . "\nPoste :" . $this->getPoste() . "\nSalaire annuel :" . $this->getSalaire() . "€\nService :" . $this->getService() . "\nAgence" . $this->getAgence()->toString().".\n";
        if (count($this->getEnfants()) > 0)
        {
            foreach ($this->getEnfants() as $enfant)
            {
                $aff .= $enfant->toString();
            }
        }
        else
        {
            $aff .= "Pas d'enfant";
        }
        return $aff;
    }

    public function calculeAnciennete() 
    {
        $dateNow = new DateTime("now");
        $interval = $dateNow->diff($this->getDateEmbauche(), true);
        return $interval->format('%y')*1; 
    }
    
    private function calculePrimeAnnuel()
    {
        return $this->getSalaire() * 0.5;
    }

    private function calculePrimeAnciennete()
    {
        return $this->getSalaire() * 0.02 * $this->calculeAnciennete();
    }

    public function calculePrimeTotal()
    {
        return $this->calculePrimeAnnuel() + $this->calculePrimeAnciennete();
    }

    public function envoieMessageVersement()
    {
        $dateNow = new DateTime("now");
        $dateVersement = (new DateTime())->setDate($dateNow->format('Y'), 11, 30);
        if ($dateVersement < $dateNow) 
        {
            return `Le versement transferé par la banque pour ${$this->getNom()} ${$this->getPrenom()} d'un montant de ${$this->calculePrimeTotal()}.`;
        }

        
    }

    public static function compareToNomPrenom($obj1, $obj2)
    {
        if ($obj1->getNom() < $obj2->getNom()) {
            return -1;
        } else if ($obj1->getNom() > $obj2->getNom()) {
            return 1;
        } else if ($obj1->getPrenom() < $obj2->getPrenom()) {
            return -1;
        } else if ($obj1->getPrenom() > $obj2->getPrenom()) {
            return 1;
        }
        return 0;
    }

    public static function compareToServiceNomPrenom($obj1, $obj2)
    {
        if ($obj1->getService() < $obj2->getService())
        {
            return -1;
        }
        else if ($obj1->getService() > $obj2->getService())
        {
            return 1;
        }
        else
        {
            return self::compareToNomPrenom($obj1, $obj2);
        }

    }

    function masseSalariale()
    {
        return $this->getSalaireAnnuel()+$this->primeAnnuelle();
    }

    public function recoitChequeVacances()
    {
        if (this->calculeAnciennete() > 1) 
        {
            return true;
        }else return false;
    }

    public function recoitChequeNoel() 
    {
        public string chequeNoel()
        {
            $nbrCheque = array("20" => "0", "30" => "0", "50" => "0"); 
            $reponse = "";
            foreach ($this->getEnfants() as $enfants)
            {
                switch ($enfants->chequeNoelEnfant())
                {
                    case 20: $nbrCheque[0]++; 
                    break;
                    case 30: $nbrCheque[1]++; 
                    break;
                    case 50: $nbrCheque[2]++; 
                    break;
                    default: 
                    break;
                }

            }
            if ($this->$nbrCheque->array_sum() == 0)  
                return "Pas de droit aux chèques Noel";
            }
            if ($nbrCheque[0] > 0) 
            {
                $reponse += $nbrCheque[0] + " chèque(s) de 20\n";
            }     
            if ($nbrCheque[1] > 0)
            {
                $reponse += $nbrCheque[1] + " chèque(s) de 30\n";
            } 
            if ($nbrCheque[2] > 0) 
            {
                $reponse += $nbrCheque[2] + " chèque(s) de 50\n";
            } 
            return reponse;
        }
}
    

?>