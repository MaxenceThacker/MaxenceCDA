<?php

class Creations 
{

	/*****************Attributs***************** */

	private $_idCreation;
	private $_idAuteur;
	private $_idOeuvre;
	private static $_attributes=["idCreation","idAuteur","idOeuvre"];
	/***************** Accesseurs ***************** */


	public function getIdCreation()
	{
		return $this->_idCreation;
	}

	public function setIdCreation(int $idCreation)
	{
		$this->_idCreation=$idCreation;
	}

	public function getIdAuteur()
	{
		return $this->_idAuteur;
	}

	public function setIdAuteur(int $idAuteur)
	{
		$this->_idAuteur=$idAuteur;
	}

	public function getIdOeuvre()
	{
		return $this->_idOeuvre;
	}

	public function setIdOeuvre(int $idOeuvre)
	{
		$this->_idOeuvre=$idOeuvre;
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
		return "IdCreation : ".$this->getIdCreation()."IdAuteur : ".$this->getIdAuteur()."IdOeuvre : ".$this->getIdOeuvre()."\n";
	}
}