<?php

class Films 
{

	/*****************Attributs***************** */

	private $_idFilm;
	private $_libelleFilm;
	private $_dureeMinuteFilm;
	private static $_attributes=["idFilm","libelleFilm","dureeMinuteFilm"];
	/***************** Accesseurs ***************** */


	public function getIdFilm()
	{
		return $this->_idFilm;
	}

	public function setIdFilm(int $idFilm)
	{
		$this->_idFilm=$idFilm;
	}

	public function getLibelleFilm()
	{
		return $this->_libelleFilm;
	}

	public function setLibelleFilm(?string $libelleFilm)
	{
		$this->_libelleFilm=$libelleFilm;
	}

	public function getDureeMinuteFilm()
	{
		return $this->_dureeMinuteFilm;
	}

	public function setDureeMinuteFilm(?int $dureeMinuteFilm)
	{
		$this->_dureeMinuteFilm=$dureeMinuteFilm;
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
		return "IdFilm : ".$this->getIdFilm()."LibelleFilm : ".$this->getLibelleFilm()."DureeMinuteFilm : ".$this->getDureeMinuteFilm()."\n";
	}
}