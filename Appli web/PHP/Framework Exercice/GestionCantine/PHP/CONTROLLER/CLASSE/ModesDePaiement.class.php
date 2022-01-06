<?php

class ModesDePaiement 
{

	/*****************Attributs***************** */

	private $_idModeDePaiement;
	private $_libelleModeDePaiement;

	/***************** Accesseurs ***************** */


	public function getIdModeDePaiement()
	{
		return $this->_idModeDePaiement;
	}

	public function setIdModeDePaiement($idModeDePaiement)
	{
		$this->_idModeDePaiement=$idModeDePaiement;
	}

	public function getLibelleModeDePaiement()
	{
		return $this->_libelleModeDePaiement;
	}

	public function setLibelleModeDePaiement($libelleModeDePaiement)
	{
		$this->_libelleModeDePaiement=$libelleModeDePaiement;
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