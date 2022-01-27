<?php

class FilmsManager 
{

	public static function add(Films $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Films $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Films $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Films::getAttributes(),"Films",["idFilm" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Films::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Films",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}