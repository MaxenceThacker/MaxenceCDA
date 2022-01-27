<?php

class SeancesManager 
{

	public static function add(Seances $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Seances $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Seances $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Seances::getAttributes(),"Seances",["idSeance" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Seances::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Seances",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}