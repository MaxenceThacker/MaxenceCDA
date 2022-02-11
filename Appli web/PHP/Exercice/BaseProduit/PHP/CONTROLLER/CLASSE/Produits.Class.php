<?php

class Produits 
{

	/*****************Attributs***************** */

	private $_id;
	private $_id_categorie_id;
	private $_libelle_produit;
	private $_prix_produit;
	private static $_attributes=["id","id_categorie_id","libelle_produit","prix_produit"];
	/***************** Accesseurs ***************** */


	public function getId()
	{
		return $this->_id;
	}

	public function setId(int $id)
	{
		$this->_id=$id;
	}

	public function getId_categorie_id()
	{
		return $this->_id_categorie_id;
	}

	public function setId_categorie_id(?int $id_categorie_id)
	{
		$this->_id_categorie_id=$id_categorie_id;
	}

	public function getLibelle_produit()
	{
		return $this->_libelle_produit;
	}

	public function setLibelle_produit(string $libelle_produit)
	{
		$this->_libelle_produit=$libelle_produit;
	}

	public function getPrix_produit()
	{
		return $this->_prix_produit;
	}

	public function setPrix_produit(int $prix_produit)
	{
		$this->_prix_produit=$prix_produit;
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
		return "Id : ".$this->getId()."Id_categorie_id : ".$this->getId_categorie_id()."Libelle_produit : ".$this->getLibelle_produit()."Prix_produit : ".$this->getPrix_produit()."\n";
	}
}