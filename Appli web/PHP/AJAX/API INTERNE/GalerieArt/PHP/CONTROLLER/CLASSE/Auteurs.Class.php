<?php

class Auteurs 
{

	/*****************Attributs***************** */

	private $_idAuteur;
	private $_nomAuteur;
	private $_prenomAuteur;
	private $_dateNaissanceAuteur;
	private static $_attributes=["idAuteur","nomAuteur","prenomAuteur","dateNaissanceAuteur"];
	/***************** Accesseurs ***************** */


	public function getIdAuteur()
	{
		return $this->_idAuteur;
	}

	public function setIdAuteur(int $idAuteur)
	{
		$this->_idAuteur=$idAuteur;
	}

	public function getNomAuteur()
	{
		return $this->_nomAuteur;
	}

	public function setNomAuteur(string $nomAuteur)
	{
		$this->_nomAuteur=$nomAuteur;
	}

	public function getPrenomAuteur()
	{
		return $this->_prenomAuteur;
	}

	public function setPrenomAuteur(string $prenomAuteur)
	{
		$this->_prenomAuteur=$prenomAuteur;
	}

	public function getDateNaissanceAuteur()
	{
		return $this->_dateNaissanceAuteur->format('Y-n-j');
	}

	public function setDateNaissanceAuteur(string $dateNaissanceAuteur)
	{
		$this->_dateNaissanceAuteur=DateTime::createFromFormat("Y-n-j",$dateNaissanceAuteur);
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
		return "IdAuteur : ".$this->getIdAuteur()."NomAuteur : ".$this->getNomAuteur()."PrenomAuteur : ".$this->getPrenomAuteur()."DateNaissanceAuteur : ".$this->getDateNaissanceAuteur()."\n";
	}
}