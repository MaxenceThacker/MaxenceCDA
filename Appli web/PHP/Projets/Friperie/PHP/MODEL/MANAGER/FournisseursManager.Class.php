<?php

class FournisseursManager 
{

	public static function add(Fournisseurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Fournisseurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Fournisseurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Fournisseurs::getAttributes(),"Fournisseurs",["idFournisseur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Fournisseurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Fournisseurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}