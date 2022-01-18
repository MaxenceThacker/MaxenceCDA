<?php

class Roles 
{

	/*****************Attributs***************** */

	private $_idRole;
	private $_libelleRole;
	private static $_attributes=["idRole","libelleRole"];

	/***************** Accesseurs ***************** */


	public function getIdRole()
	{
		return $this->_idRole;
	}

	public function setIdRole($idRole)
	{
		$this->_idRole=$idRole;
	}

	public function getLibelleRole()
	{
		return $this->_libelleRole;
	}

	public function setLibelleRole($libelleRole)
	{
		$this->_libelleRole=$libelleRole;
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
    
}