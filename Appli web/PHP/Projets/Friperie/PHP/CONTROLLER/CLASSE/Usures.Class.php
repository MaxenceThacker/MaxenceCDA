<?php

class Usures 
{

	/*****************Attributs***************** */

	private $_idUsure;
	private $_libelleUsure;
	private static $_attributes=["idUsure","libelleUsure"];
	/***************** Accesseurs ***************** */


	public function getIdUsure()
	{
		return $this->_idUsure;
	}

	public function setIdUsure(int $idUsure)
	{
		$this->_idUsure=$idUsure;
	}

	public function getLibelleUsure()
	{
		return $this->_libelleUsure;
	}

	public function setLibelleUsure(?string $libelleUsure)
	{
		$this->_libelleUsure=$libelleUsure;
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
		return "IdUsure : ".$this->getIdUsure()."LibelleUsure : ".$this->getLibelleUsure()."\n";
	}
}