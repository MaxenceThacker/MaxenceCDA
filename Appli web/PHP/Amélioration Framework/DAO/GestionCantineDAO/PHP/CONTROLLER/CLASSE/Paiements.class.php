<?php

class Paiements 
{

	/*****************Attributs***************** */

    private $_idPaiement;
	private $_montantPaiement;
    private $_datePaiement;
    private $_idEleve;
	private $_idModeDePaiement;
	private static $_attributes=["idPaiement","montantPaiement","datePaiement","idEleve","idModeDePaiement"];

	/***************** Accesseurs ***************** */


	public function getIdPaiement()
	{
		return $this->_idPaiement;
	}

	public function setIdPaiement($idPaiement)
	{
		$this->_idPaiement=$idPaiement;
	}

	public function getMontantPaiement()
	{
		return $this->_montantPaiement;
	}

	public function setMontantPaiement($montantPaiement)
	{
		$this->_montantPaiement=$montantPaiement;
	}

	public function getDatePaiement()
	{
		return $this->_datePaiement;
	}

	public function setDatePaiement(DateTime $datePaiement)
	{
		$this->_datePaiement=$datePaiement;
	}

	public function getIdEleve()
	{
		return $this->_idEleve;
	}

	public function setIdEleve(DateTime $idEleve)
	{
		$this->_idEleve=$idEleve;
	}

	public function getIdModeDePaiement()
	{
		return $this->_idModeDePaiement;
	}

	public function setIdModeDePaiement($idModeDePaiement)
	{
		$this->_idModeDePaiement=$idModeDePaiement;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
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
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdPaiement : ".$this->getIdPaiement()."Montant : ".$this->getMontantPaiement()."Date : ".$this->getDatePaiement()."IdEleve : ".$this->getIdEleve()."IdModeDePaiement : ".$this->getIdModeDePaiement()."\n";
	}

}