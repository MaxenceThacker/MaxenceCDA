<?php

class Categories 
{

	/*****************Attributs***************** */

	private $_id;
	private $_libelle_categorie;
	private static $_attributes=["id","libelle_categorie"];
	/***************** Accesseurs ***************** */


	public function getId()
	{
		return $this->_id;
	}

	public function setId(int $id)
	{
		$this->_id=$id;
	}

	public function getLibelle_categorie()
	{
		return $this->_libelle_categorie;
	}

	public function setLibelle_categorie(string $libelle_categorie)
	{
		$this->_libelle_categorie=$libelle_categorie;
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
		return "Id : ".$this->getId()."Libelle_categorie : ".$this->getLibelle_categorie()."\n";
	}
}