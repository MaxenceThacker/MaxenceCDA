<?php

class Oeuvres 
{

	/*****************Attributs***************** */

	private $_idOeuvre;
	private $_titreOeuvre;
	private $_typeOeuvre;
	private $_dateOeuvre;
	private static $_attributes=["idOeuvre","titreOeuvre","typeOeuvre","dateOeuvre"];
	/***************** Accesseurs ***************** */


	public function getIdOeuvre()
	{
		return $this->_idOeuvre;
	}

	public function setIdOeuvre(int $idOeuvre)
	{
		$this->_idOeuvre=$idOeuvre;
	}

	public function getTitreOeuvre()
	{
		return $this->_titreOeuvre;
	}

	public function setTitreOeuvre(string $titreOeuvre)
	{
		$this->_titreOeuvre=$titreOeuvre;
	}

	public function getTypeOeuvre()
	{
		return $this->_typeOeuvre;
	}

	public function setTypeOeuvre(string $typeOeuvre)
	{
		$this->_typeOeuvre=$typeOeuvre;
	}

	public function getDateOeuvre()
	{
		return $this->_dateOeuvre->format('Y-n-j');
	}

	public function setDateOeuvre(string $dateOeuvre)
	{
		$this->_dateOeuvre=DateTime::createFromFormat("Y-n-j",$dateOeuvre);
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
		return "IdOeuvre : ".$this->getIdOeuvre()."TitreOeuvre : ".$this->getTitreOeuvre()."TypeOeuvre : ".$this->getTypeOeuvre()."DateOeuvre : ".$this->getDateOeuvre()."\n";
	}
}