<?php

class TypesDeFournisseurManager 
{

	public static function add(TypesDeFournisseur $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(TypesDeFournisseur $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(TypesDeFournisseur $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(TypesDeFournisseur::getAttributes(),"TypesDeFournisseur",["idTypeDeFournisseur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?TypesDeFournisseur::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"TypesDeFournisseur",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}