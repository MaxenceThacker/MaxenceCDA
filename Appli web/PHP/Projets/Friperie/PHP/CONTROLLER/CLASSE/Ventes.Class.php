<?php

class Ventes 
{

	/*****************Attributs***************** */

	private $_idVetement;
	private $_idFournisseur;
	private static $_attributes=["idVetement","idFournisseur"];
	/***************** Accesseurs ***************** */


	public function getIdVetement()
	{
		return $this->_idVetement;
	}

	public function setIdVetement(int $idVetement)
	{
		$this->_idVetement=$idVetement;
	}

	public function getIdFournisseur()
	{
		return $this->_idFournisseur;
	}

	public function setIdFournisseur(int $idFournisseur)
	{
		$this->_idFournisseur=$idFournisseur;
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
		return "IdVetement : ".$this->getIdVetement()."IdFournisseur : ".$this->getIdFournisseur()."\n";
	}
}