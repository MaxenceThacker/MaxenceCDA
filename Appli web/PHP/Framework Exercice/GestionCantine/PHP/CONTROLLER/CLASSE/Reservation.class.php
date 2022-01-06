<?php

class Reservations 
{

	/*****************Attributs***************** */

	private $_idReservation;
	private $_idEleve;
	private $_idMenu;
    private $_dateReservation;

	/***************** Accesseurs ***************** */


	public function getIdReservation()
	{
		return $this->_idReservation;
	}

	public function setIdReservation($idReservation)
	{
		$this->_idReservation=$idReservation;
	}

	public function getIdEleve()
	{
		return $this->_idEleve;
	}

	public function setIdEleve($idEleve)
	{
		$this->_idEleve=$idEleve;
	}

	public function getIdMenu()
	{
		return $this->_idMenu;
	}

	public function setIdMenu($idMenu)
	{
		$this->_idMenu=$idMenu;
	}

	public function getDateReservation()
	{
		return $this->_dateReservation;
	}

	public function setDateReservation(DateTime $dateReservation)
	{
		$this->_dateReservation=$dateReservation;
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
		return "IdReservation : ".$this->getIdReservation()."IdEleve : ".$this->getIdEleve()."IdMenu : ".$this->getIdMenu()."Date : ".$this->getDateReservation()."\n";
	}

}