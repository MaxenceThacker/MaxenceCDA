<?php
$d = MenusManager::getList(null,["idMenu"=>1,"LibelleMenu"=>"%i%"],"libelleMenu DESC",null,true,true);
var_dump($d);