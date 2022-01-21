<?php

class VetementsManager 
{

	public static function add(Vetements $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Vetements $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Vetements $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Vetements::getAttributes(),"Vetements",["idVetement" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Vetements::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Vetements",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}