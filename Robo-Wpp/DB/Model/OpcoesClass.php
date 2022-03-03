<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class OpcoesClass extends Model
{

    public function save()
    {
        $con = new ConexaoClass();
        //$opcaoNome, $opcaoContent, $posicao, $fk_bot, $fk_menu
        $opcaoNome = $this->getopcaoNome();
        $opcaoContent = $this->getopcaoContent();
        $posicao = $this->getposicao();
        $fk_bot = $this->getfkbot();
        $fk_menu = $this->getfkmenu();
        if ($con->comand("INSERT INTO opcao(nomeOpcao, opcao, posicao, fk_boot, fk_menu) VALUES ('$opcaoNome','$opcaoContent','$posicao','$fk_bot','$fk_menu')")) {
            return true;
        } else {
            return false;
        }
    }

    public function findFkOpcoes()
    {
        $idMenu = $this->getfkmenu();
        $con = new ConexaoClass();
        $table = $con->select("SELECT * FROM opcao WHERE fk_menu = '$idMenu' ORDER BY posicao DESC");
        if ($table != null) {
            return $table;
        } else {
            return false;
        }
    }

    public function showFkMenu()
    {
        $obj = new ConexaoClass();
        $fk_menu = $this->getfkmenu();
        $table = $obj->select("SELECT * FROM opcao WHERE fk_menu = '$fk_menu'");
        return $table;
    } 

    public function showid()
    {
        $obj = new ConexaoClass();
        $idopcao = $this->getidopcao();
        $table = $obj->select("SELECT * FROM opcao WHERE idOpcao = '$idopcao'");
        return $table;
    }

    public function edit()
    {
        $obj = new ConexaoClass();
        $idopcao = $this->getidopcao();
        $nomeopcao = $this->getnomeopcao();
        $opcao = $this->getopcao();
        $obj->comand("UPDATE opcao SET nomeOpcao ='$nomeopcao', opcao='$opcao' WHERE idOpcao='$idopcao' ");

    }

    public function delete()
    {
        $obj = new ConexaoClass();
        $id = $this->getidopcao();
        $obj->comand("DELETE FROM opcao WHERE idOpcao ='$id'");

    }
}
