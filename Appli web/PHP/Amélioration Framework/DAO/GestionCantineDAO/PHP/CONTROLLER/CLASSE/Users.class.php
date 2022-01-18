<?php

class Users 
{

	/*****************Attributs***************** */

	private $_idUser;
	private $_nomUser;
	private $_prenomUser;
    private $_emailUser;
	private $_MDPUser;
	private $_idRole;
	private static $_attributes=["idUser","nomUser","prenomUser","emailUser","MDPUser","idRole"];

	/***************** Accesseurs ***************** */


	public function getIdUser()
	{
		return $this->_idUser;
	}

	public function setIdUser($idUser)
	{
		$this->_idUser=$idUser;
	}

	public function getNomUser()
	{
		return $this->_nomUser;
	}

	public function setNomUser($nomUser)
	{
		$this->_nomUser=$nomUser;
	}

	public function getPrenomUser()
	{
		return $this->_prenomUser;
	}

	public function setPrenomUser($prenomUser)
	{
		$this->_prenomUser=$prenomUser;
	}

	public function getMDPUser()
	{
		return $this->_MDPUser;
	}

	public function setMDPUser($MDPUser)
	{
		$this->_MDPUser=$MDPUser;
	}

	public function getEmailUser()
	{
		return $this->_emailUser;
	}

	public function setEmailUser($emailUser)
	{
		$this->_emailUser=$emailUser;
	}

	public function getIdRole()
	{
		return $this->_idRole;
	}

	public function setIdRole($idRole)
	{
		$this->_idRole=$idRole;
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
		return "IdUtilisiteur : ".$this->getIdUser()."Nom : ".$this->getNomUser()."Prenom : ".$this->getPrenomUser()."MotDePasse : ".$this->getMDPUser()."AdresseMail : ".$this->getEmailUser()."Role : ".$this->getIdRole()."\n";
	}

}