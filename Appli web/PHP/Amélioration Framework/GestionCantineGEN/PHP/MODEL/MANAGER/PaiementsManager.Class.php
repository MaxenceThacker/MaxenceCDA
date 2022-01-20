<?php

class PaiementsManager 
{

	public static function add(Paiements $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Paiements $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Paiements $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Paiements::getAttributes(),"Paiements",["IdPaiement" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Paiements::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Paiements",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}