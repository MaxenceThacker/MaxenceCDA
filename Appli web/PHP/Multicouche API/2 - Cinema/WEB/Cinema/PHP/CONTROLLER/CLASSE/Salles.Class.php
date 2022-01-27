<?php

class Salles 
{

	/*****************Attributs***************** */

	private $_idSalle;
	private $_nbrPlaceSalle;
	private static $_attributes=["idSalle","nbrPlaceSalle"];
	/***************** Accesseurs ***************** */


	public function getIdSalle()
	{
		return $this->_idSalle;
	}

	public function setIdSalle(int $idSalle)
	{
		$this->_idSalle=$idSalle;
	}

	public function getNbrPlaceSalle()
	{
		return $this->_nbrPlaceSalle;
	}

	public function setNbrPlaceSalle(?int $nbrPlaceSalle)
	{
		$this->_nbrPlaceSalle=$nbrPlaceSalle;
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
		return "IdSalle : ".$this->getIdSalle()."NbrPlaceSalle : ".$this->getNbrPlaceSalle()."\n";
	}
}