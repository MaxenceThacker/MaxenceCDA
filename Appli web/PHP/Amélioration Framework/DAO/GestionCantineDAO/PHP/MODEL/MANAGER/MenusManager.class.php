<?php

class MenusManager
{
    public static function add(Menus $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Menus $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Menus $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Menus::getAttributes(),"Menus",["idMenu" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?Menus::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"Menus",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}