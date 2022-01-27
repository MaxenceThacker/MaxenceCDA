<?php

class SallesManager 
{

	public static function add(Salles $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Salles $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Salles $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Salles::getAttributes(),"Salles",["idSalle" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Salles::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Salles",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}