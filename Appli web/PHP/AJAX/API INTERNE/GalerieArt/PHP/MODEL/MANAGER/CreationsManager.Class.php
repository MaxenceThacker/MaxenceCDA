<?php

class CreationsManager 
{

	public static function add(Creations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Creations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Creations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Creations::getAttributes(),"Creations",["idCreation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Creations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Creations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}