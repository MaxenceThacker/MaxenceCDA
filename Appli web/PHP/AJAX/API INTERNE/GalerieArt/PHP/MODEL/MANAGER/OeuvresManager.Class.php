<?php

class OeuvresManager 
{

	public static function add(Oeuvres $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Oeuvres $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Oeuvres $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Oeuvres::getAttributes(),"Oeuvres",["idOeuvre" => $id])[0];
	}
	

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Oeuvres::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Oeuvres",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}