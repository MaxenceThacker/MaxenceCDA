<?php

class ModesDePaiementManager
{
    public static function add(ModesDePaiement  $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(ModesDePaiement  $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(ModesDePaiement  $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(ModesDePaiement ::getAttributes(),"ModesDePaiement ",["idModeDePaiement" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?ModesDePaiement ::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"ModesDePaiement ",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}