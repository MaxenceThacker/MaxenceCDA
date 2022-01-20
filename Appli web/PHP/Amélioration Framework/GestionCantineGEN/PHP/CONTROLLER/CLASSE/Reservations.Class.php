<?php

class Reservations 
{

	/*****************Attributs***************** */

	private $_IdReservation;
	private $_IdEleve;
	private $_IdMenu;
	private $_DateReservation;
	private static $_attributes=["IdReservation","IdEleve","IdMenu","DateReservation"];
	/***************** Accesseurs ***************** */


	public function getIdReservation()
	{
		return $this->_IdReservation;
	}

	public function setIdReservation(int $IdReservation)
	{
		$this->_IdReservation=$IdReservation;
	}

	public function getIdEleve()
	{
		return $this->_IdEleve;
	}

	public function setIdEleve(?int $IdEleve)
	{
		$this->_IdEleve=$IdEleve;
	}

	public function getIdMenu()
	{
		return $this->_IdMenu;
	}

	public function setIdMenu(?int $IdMenu)
	{
		$this->_IdMenu=$IdMenu;
	}

	public function getDateReservation()
	{
		return is_null($this->_DateReservation)?null:$this->_DateReservation->format('Y-n-j');
	}

	public function setDateReservation(?string $DateReservation)
	{
		$this->_DateReservation=is_null($DateReservation)?null:DateTime::createFromFormat("Y-n-j",$DateReservation);
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
		return "IdReservation : ".$this->getIdReservation()."IdEleve : ".$this->getIdEleve()."IdMenu : ".$this->getIdMenu()."DateReservation : ".$this->getDateReservation()."\n";
	}
}