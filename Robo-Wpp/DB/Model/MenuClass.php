<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class MenuClass extends Model
{



    public function save() //realizar um estatico para ficar mais fácil a manipulação
    {
        $conect = new ConexaoClass();
        $nome = $this->getnome();
        $posicao = $this->getposicao();
        $fk_boot = $this->getfk_boot();
        if ($conect->comand("INSERT INTO menu(nomeMenu, posição, fk_boot) values ('$nome','$posicao','$fk_boot')")) {
            return true;
        } else {
            return false;
        }
    }

    public function findFkBoot()
    {
        $idBoot = $this->getfkBoot();
        $con = new ConexaoClass();
        $table = $con->select("SELECT * FROM menu WHERE fk_boot = '$idBoot' ORDER BY idMenu DESC");
        if ($table != null) {
            return $table;
        } else {
            return false;
        }
    }

    public function findFkBootExibicao()
    {
        $tam = 0;
        $idBoot = $this->getfkBoot();
        $con = new ConexaoClass();
        $table = $con->select("SELECT * FROM menu WHERE fk_boot = '$idBoot' ORDER BY posição");
        if (is_countable($table)) {
            $tam = sizeof($table);
        }
        if ($tam > 0) {
            return $table;
        } else {
            return false;
        }
    }

    public function findId()
    {
        $idMenu = $this->getidMenu();
        $con = new ConexaoClass();
        $table = $con->select("SELECT * FROM menu WHERE idMenu = '$idMenu'");
        if ($table != null) {
            return $table;
        } else {
            return false;
        }
    }

    public function show()
    {
        //$idMenu = $this->getidMenu();
        $con = new ConexaoClass();
        $table = $con->select("SELECT * FROM menu");
        if ($table != null) {
            return $table;
        } else {
            return false;
        }
    }

    public function edit()
    {
        $con = new ConexaoClass();
        $idMenu = $this->getidmenu();
        $nomeMenu = $this->getnomemenu();
        if($con->comand("UPDATE menu SET nomeMenu = '$nomeMenu' WHERE idMenu='$idMenu'"))
        {
            return true;
        }else{
            return false;
        }
    }

    public function delete()
    {
        $idMenu = $this->getidmenu();
        $con = new ConexaoClass();
        $con->comand("DELETE FROM menu WHERE idMenu='$idMenu'");
    }
}
