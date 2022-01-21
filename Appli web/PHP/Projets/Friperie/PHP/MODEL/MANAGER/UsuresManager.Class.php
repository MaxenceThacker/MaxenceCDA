<?php

class UsuresManager 
{

	public static function add(Usures $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Usures $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Usures $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Usures::getAttributes(),"Usures",["idUsure" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Usures::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Usures",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}