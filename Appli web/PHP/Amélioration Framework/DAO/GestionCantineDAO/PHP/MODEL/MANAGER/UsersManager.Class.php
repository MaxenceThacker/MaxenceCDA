<?php

class UsersManager
{
    public static function add(Users $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Users $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Users $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Users::getAttributes(),"Users",["idUser" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?Users::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"Users",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}
