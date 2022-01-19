<?php

class ElevesManager
{
    public static function add(Eleves $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Eleves $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Eleves $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Eleves::getAttributes(),"Eleves",["idEleve" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?Eleves::getAttributes():$nomColonnes;
		
 		return DAO::select($nomColonnes,"Eleves",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}