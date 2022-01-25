<?php

class Auteurs_OeuvresManager 
{

	public static function add(Auteurs_Oeuvres $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Auteurs_Oeuvres $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Auteurs_Oeuvres $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Auteurs_Oeuvres::getAttributes(),"Auteurs_Oeuvres",["idAuteur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Auteurs_Oeuvres::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Auteurs_Oeuvres",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}