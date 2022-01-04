<?php
 
class Employe
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_poste;
    private $_salaire;
    private $_service;

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
        $aff = "Nom :" . $this->getNom() . "\nPrenom :" . $this->getPrenom() . "\nDateEmbauche :" . $this->getDateEmbauche()->format('Y-m-d') . "\nPoste :" . $this->getPoste() . "\nSalaire annuel :" . $this->getSalaire() . "€\nService :" . $this->getService() . "\n";
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
}
?>