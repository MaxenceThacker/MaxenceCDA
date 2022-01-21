<?php

class Vetements 
{

	/*****************Attributs***************** */

	private $_idVetement;
	private $_libelleVetement;
	private $_prixVetement;
	private $_idCategorie;
	private $_idUsure;
	private static $_attributes=["idVetement","libelleVetement","prixVetement","idCategorie","idUsure"];
	/***************** Accesseurs ***************** */


	public function getIdVetement()
	{
		return $this->_idVetement;
	}

	public function setIdVetement(int $idVetement)
	{
		$this->_idVetement=$idVetement;
	}

	public function getLibelleVetement()
	{
		return $this->_libelleVetement;
	}

	public function setLibelleVetement(?string $libelleVetement)
	{
		$this->_libelleVetement=$libelleVetement;
	}

	public function getPrixVetement()
	{
		return $this->_prixVetement;
	}

	public function setPrixVetement(?float $prixVetement)
	{
		$this->_prixVetement=$prixVetement;
	}

	public function getIdCategorie()
	{
		return $this->_idCategorie;
	}

	public function setIdCategorie(int $idCategorie)
	{
		$this->_idCategorie=$idCategorie;
	}

	public function getIdUsure()
	{
		return $this->_idUsure;
	}

	public function setIdUsure(int $idUsure)
	{
		$this->_idUsure=$idUsure;
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
		return "IdVetement : ".$this->getIdVetement()."LibelleVetement : ".$this->getLibelleVetement()."PrixVetement : ".$this->getPrixVetement()."IdCategorie : ".$this->getIdCategorie()."IdUsure : ".$this->getIdUsure()."\n";
	}
}