<?php

class Eleves 
{

	/*****************Attributs***************** */

	private $_IdEleve;
	private $_NomEleve;
	private $_PrenomEleve;
	private $_DDNEleve;
	private $_SoldeEleve;
	private static $_attributes=["IdEleve","NomEleve","PrenomEleve","DDNEleve","SoldeEleve"];
	/***************** Accesseurs ***************** */


	public function getIdEleve()
	{
		return $this->_IdEleve;
	}

	public function setIdEleve(int $IdEleve)
	{
		$this->_IdEleve=$IdEleve;
	}

	public function getNomEleve()
	{
		return $this->_NomEleve;
	}

	public function setNomEleve(?string $NomEleve)
	{
		$this->_NomEleve=$NomEleve;
	}

	public function getPrenomEleve()
	{
		return $this->_PrenomEleve;
	}

	public function setPrenomEleve(?string $PrenomEleve)
	{
		$this->_PrenomEleve=$PrenomEleve;
	}

	public function getDDNEleve()
	{
		return is_null($this->_DDNEleve)?null:$this->_DDNEleve->format('Y-n-j');
	}

	public function setDDNEleve(?string $DDNEleve)
	{
		$this->_DDNEleve=is_null($DDNEleve)?null:DateTime::createFromFormat("Y-n-j",$DDNEleve);
	}

	public function getSoldeEleve()
	{
		return $this->_SoldeEleve;
	}

	public function setSoldeEleve(?float $SoldeEleve)
	{
		$this->_SoldeEleve=$SoldeEleve;
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
		return "IdEleve : ".$this->getIdEleve()."NomEleve : ".$this->getNomEleve()."PrenomEleve : ".$this->getPrenomEleve()."DDNEleve : ".$this->getDDNEleve()."SoldeEleve : ".$this->getSoldeEleve()."\n";
	}
}