<?php

class TypesDeFournisseur 
{

	/*****************Attributs***************** */

	private $_idTypeDeFournisseur;
	private $_libelleTypeDeFournisseur;
	private static $_attributes=["idTypeDeFournisseur","libelleTypeDeFournisseur"];
	/***************** Accesseurs ***************** */


	public function getIdTypeDeFournisseur()
	{
		return $this->_idTypeDeFournisseur;
	}

	public function setIdTypeDeFournisseur(int $idTypeDeFournisseur)
	{
		$this->_idTypeDeFournisseur=$idTypeDeFournisseur;
	}

	public function getLibelleTypeDeFournisseur()
	{
		return $this->_libelleTypeDeFournisseur;
	}

	public function setLibelleTypeDeFournisseur(?string $libelleTypeDeFournisseur)
	{
		$this->_libelleTypeDeFournisseur=$libelleTypeDeFournisseur;
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
		return "IdTypeDeFournisseur : ".$this->getIdTypeDeFournisseur()."LibelleTypeDeFournisseur : ".$this->getLibelleTypeDeFournisseur()."\n";
	}
}