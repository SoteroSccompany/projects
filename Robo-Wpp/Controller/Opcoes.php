<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/OpcoesClass.php");


class Opcoes
{

    public function save($opcaoNome, $opcaoContent, $posicao, $fk_bot, $fk_menu)
    {
        $opt = new OpcoesClass();
        $opt->setopcaoNome($opcaoNome);
        $opt->setopcaoContent($opcaoContent);
        $opt->setposicao($posicao);
        $opt->setfkbot($fk_bot);
        $opt->setfkmenu($fk_menu);
        if ($opt->save()) {
            return true;
        } else {
            return false;
        }
    }

    public function posicao($fk_menu)
    {
        $obj = new OpcoesClass();
        $obj->setfkmenu($fk_menu);
        $table = $obj->findFkOpcoes();
        if ($table != false) {
            return intval($table[0]["posicao"]);
        } else {
            return 'no-data';
        }
    }

    public function showFk($fk_menu)
    {
        $obj = new OpcoesClass();
        $obj->setfkmenu($fk_menu);
        $table = $obj->showFkMenu();
        return $table;
    }

   

   

    public function showid($idopcao)
    { //->getidopcao();
        $obj = new OpcoesClass();
        $obj->setidopcao($idopcao);
        $table = $obj->showid();
        return $table;
    }

    public function checkoptMenuRegister($fk_menu)
    {
        $obj = new OpcoesClass();
        $obj->setfkmenu($fk_menu);
        if ($obj->findFkOpcoes() === false) {
            return false;
        } else {
            return true;
        }
    }


    public function edit($idopcao, $nomeopcao, $opcao)
    {
        $obj = new OpcoesClass();
        $obj->setidopcao($idopcao);
        $obj->setnomeopcao($nomeopcao);
        $obj->setopcao($opcao);
        if($obj->edit()){
            return true;
        }else{
            return false;
        }

    }

    public function delete($idopcao)
    {
        $obj = new OpcoesClass();
        $obj->setidopcao($idopcao);
        if($obj->delete()){
            return true;
        }else{
            return false;
        }
    }

}
