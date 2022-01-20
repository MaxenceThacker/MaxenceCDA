<?php

class Menus 
{

	/*****************Attributs***************** */

	private $_IdMenu;
	private $_DateMenu;
	private $_LibelleMenu;
	private $_PrixMenu;
	private static $_attributes=["IdMenu","DateMenu","LibelleMenu","PrixMenu"];
	/***************** Accesseurs ***************** */


	public function getIdMenu()
	{
		return $this->_IdMenu;
	}

	public function setIdMenu(int $IdMenu)
	{
		$this->_IdMenu=$IdMenu;
	}

	public function getDateMenu()
	{
		return is_null($this->_DateMenu)?null:$this->_DateMenu->format('Y-n-j');
	}

	public function setDateMenu(?string $DateMenu)
	{
		$this->_DateMenu=is_null($DateMenu)?null:DateTime::createFromFormat("Y-n-j",$DateMenu);
	}

	public function getLibelleMenu()
	{
		return $this->_LibelleMenu;
	}

	public function setLibelleMenu(?string $LibelleMenu)
	{
		$this->_LibelleMenu=$LibelleMenu;
	}

	public function getPrixMenu()
	{
		return $this->_PrixMenu;
	}

	public function setPrixMenu(?float $PrixMenu)
	{
		$this->_PrixMenu=$PrixMenu;
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
		return "IdMenu : ".$this->getIdMenu()."DateMenu : ".$this->getDateMenu()."LibelleMenu : ".$this->getLibelleMenu()."PrixMenu : ".$this->getPrixMenu()."\n";
	}
}