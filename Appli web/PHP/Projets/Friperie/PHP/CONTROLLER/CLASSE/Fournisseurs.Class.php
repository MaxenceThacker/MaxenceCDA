<?php

class Fournisseurs 
{

	/*****************Attributs***************** */

	private $_idFournisseur;
	private $_nomFournisseur;
	private $_adresseFournisseur;
	private $_prenomFournisseur;
	private $_idTypeDeFournisseur;
	private static $_attributes=["idFournisseur","nomFournisseur","adresseFournisseur","prenomFournisseur","idTypeDeFournisseur"];
	/***************** Accesseurs ***************** */


	public function getIdFournisseur()
	{
		return $this->_idFournisseur;
	}

	public function setIdFournisseur(int $idFournisseur)
	{
		$this->_idFournisseur=$idFournisseur;
	}

	public function getNomFournisseur()
	{
		return $this->_nomFournisseur;
	}

	public function setNomFournisseur(?string $nomFournisseur)
	{
		$this->_nomFournisseur=$nomFournisseur;
	}

	public function getAdresseFournisseur()
	{
		return $this->_adresseFournisseur;
	}

	public function setAdresseFournisseur(?string $adresseFournisseur)
	{
		$this->_adresseFournisseur=$adresseFournisseur;
	}

	public function getPrenomFournisseur()
	{
		return $this->_prenomFournisseur;
	}

	public function setPrenomFournisseur(?string $prenomFournisseur)
	{
		$this->_prenomFournisseur=$prenomFournisseur;
	}

	public function getIdTypeDeFournisseur()
	{
		return $this->_idTypeDeFournisseur;
	}

	public function setIdTypeDeFournisseur(int $idTypeDeFournisseur)
	{
		$this->_idTypeDeFournisseur=$idTypeDeFournisseur;
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
		return "IdFournisseur : ".$this->getIdFournisseur()."NomFournisseur : ".$this->getNomFournisseur()."AdresseFournisseur : ".$this->getAdresseFournisseur()."PrenomFournisseur : ".$this->getPrenomFournisseur()."IdTypeDeFournisseur : ".$this->getIdTypeDeFournisseur()."\n";
	}
}