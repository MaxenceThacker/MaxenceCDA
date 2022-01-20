<?php

class Paiements 
{

	/*****************Attributs***************** */

	private $_IdPaiement;
	private $_MontantPaiement;
	private $_DatePaiement;
	private $_IdEleve;
	private $_IdModeDePaiement;
	private static $_attributes=["IdPaiement","MontantPaiement","DatePaiement","IdEleve","IdModeDePaiement"];
	/***************** Accesseurs ***************** */


	public function getIdPaiement()
	{
		return $this->_IdPaiement;
	}

	public function setIdPaiement(int $IdPaiement)
	{
		$this->_IdPaiement=$IdPaiement;
	}

	public function getMontantPaiement()
	{
		return $this->_MontantPaiement;
	}

	public function setMontantPaiement(?float $MontantPaiement)
	{
		$this->_MontantPaiement=$MontantPaiement;
	}

	public function getDatePaiement()
	{
		return is_null($this->_DatePaiement)?null:$this->_DatePaiement->format('Y-n-j');
	}

	public function setDatePaiement(?string $DatePaiement)
	{
		$this->_DatePaiement=is_null($DatePaiement)?null:DateTime::createFromFormat("Y-n-j",$DatePaiement);
	}

	public function getIdEleve()
	{
		return $this->_IdEleve;
	}

	public function setIdEleve(int $IdEleve)
	{
		$this->_IdEleve=$IdEleve;
	}

	public function getIdModeDePaiement()
	{
		return $this->_IdModeDePaiement;
	}

	public function setIdModeDePaiement(int $IdModeDePaiement)
	{
		$this->_IdModeDePaiement=$IdModeDePaiement;
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
				$this->$methode($value===""?null:$value);
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
		return "IdPaiement : ".$this->getIdPaiement()."MontantPaiement : ".$this->getMontantPaiement()."DatePaiement : ".$this->getDatePaiement()."IdEleve : ".$this->getIdEleve()."IdModeDePaiement : ".$this->getIdModeDePaiement()."\n";
	}
}