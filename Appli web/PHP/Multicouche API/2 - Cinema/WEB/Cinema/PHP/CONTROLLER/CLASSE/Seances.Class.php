<?php

class Seances 
{

	/*****************Attributs***************** */

	private $_idSeance;
	private $_idFilm;
	private $_idSalle;
	private $_horaireSeance;
	private $_dateSeance;
	private static $_attributes=["idSeance","idFilm","idSalle","horaireSeance","dateSeance"];
	/***************** Accesseurs ***************** */


	public function getIdSeance()
	{
		return $this->_idSeance;
	}

	public function setIdSeance(int $idSeance)
	{
		$this->_idSeance=$idSeance;
	}

	public function getIdFilm()
	{
		return $this->_idFilm;
	}

	public function setIdFilm(?int $idFilm)
	{
		$this->_idFilm=$idFilm;
	}

	public function getIdSalle()
	{
		return $this->_idSalle;
	}

	public function setIdSalle(?int $idSalle)
	{
		$this->_idSalle=$idSalle;
	}

	public function getHoraireSeance()
	{
		return is_null($this->_horaireSeance)?null:$this->_horaireSeance->format('%h:%i:%s');
	}

	public function setHoraireSeance(?string $horaireSeance)
	{

		if(is_null($horaireSeance))
		{
			$this->_horaireSeance=null;
		}
		else
		{
			list($hours, $minutes, $seconds) = sscanf($horaireSeance, '%d:%d:%d');
			$this->_horaireSeance=new DateInterval(sprintf('PT%dH%dM%dS', $hours, $minutes, $seconds));
		}	}

	public function getDateSeance()
	{
		return is_null($this->_dateSeance)?null:$this->_dateSeance->format('Y-n-j');
	}

	public function setDateSeance(?string $dateSeance)
	{
		$this->_dateSeance=is_null($dateSeance)?null:DateTime::createFromFormat("Y-n-j",$dateSeance);
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
		return "IdSeance : ".$this->getIdSeance()."IdFilm : ".$this->getIdFilm()."IdSalle : ".$this->getIdSalle()."HoraireSeance : ".$this->getHoraireSeance()."DateSeance : ".$this->getDateSeance()."\n";
	}
}