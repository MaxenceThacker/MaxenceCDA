<?php

class Enfant
{
  
    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_age;

    /*****************Accesseurs***************** */

    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getAge()
    {
        return $this->_age;
    }

    public function setAge($age)
    {
        $this->_age = $age;
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
        foreach ($data as $key => $value)
        {
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
        return "Nom d'enfant :" . $this->getNom() . "\nPrenom d'enfant :" . $this->getPrenom() . "\nAge :" . $this->getAge()."\n";
    }

   
    public chequeNoelEnfant()
        {
            $age = $this->getAge();
            if ($age < 11)
                return 20;
            else if ($age < 16)
                return 30;
            else if ($age < 19)
                return 50;
            return 0;
        }
     
}
?>