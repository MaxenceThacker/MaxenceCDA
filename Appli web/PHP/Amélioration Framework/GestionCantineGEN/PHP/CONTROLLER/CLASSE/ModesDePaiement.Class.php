<?php

class ModesDePaiement 
{

	/*****************Attributs***************** */

	private $_IdModeDePaiement;
	private $_LibelleModeDePaiement;
	private static $_attributes=["IdModeDePaiement","LibelleModeDePaiement"];
	/***************** Accesseurs ***************** */


	public function getIdModeDePaiement()
	{
		return $this->_IdModeDePaiement;
	}

	public function setIdModeDePaiement(int $IdModeDePaiement)
	{
		$this->_IdModeDePaiement=$IdModeDePaiement;
	}

	public function getLibelleModeDePaiement()
	{
		return $this->_LibelleModeDePaiement;
	}

	public function setLibelleModeDePaiement(?string $LibelleModeDePaiement)
	{
		$this->_LibelleModeDePaiement=$LibelleModeDePaiement;
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
		return "IdModeDePaiement : ".$this->getIdModeDePaiement()."LibelleModeDePaiement : ".$this->getLibelleModeDePaiement()."\n";
	}
}