<?php

class Menus 
{

	/*****************Attributs***************** */

	private $_idMenu;
	private $_dateMenu;
	private $_libelleMenu;
    private $_prixMenu;
	private static $_attributes=["idMenu","dateMenu","libelleMenu","prixMenu"];

	/***************** Accesseurs ***************** */


	public function getIdMenu()
	{
		return $this->_idMenu;
	}

	public function setIdMenu($idMenu)
	{
		$this->_idMenu=$idMenu;
	}

	public function getDateMenu()
	{
		return $this->_dateMenu;
	}

	public function setDateMenu(DateTime $dateMenu)
	{
		$this->_dateMenu=$dateMenu;
	}

	public function getLibelleMenu()
	{
		return $this->_libelleMenu;
	}

	public function setLibelleMenu($libelleMenu)
	{
		$this->_libelleMenu=$libelleMenu;
	}

	public function getPrixMenu()
	{
		return $this->_prixMenu;
	}

	public function setPrixMenu($prixMenu)
	{
		$this->_prixMenu=$prixMenu;
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
				$this->$methode($value);
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
		return "IdMenu : ".$this->getIdMenu()."Date : ".$this->getDateMenu()."Libelle : ".$this->getLibelleMenu()."Prix : ".$this->getPrixMenu()."\n";
	}

}