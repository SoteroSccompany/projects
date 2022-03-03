<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/ConversaClass.php");
require_once("Menssagem.php");
require_once("Pessoa.php");


class Conversa
{
    public function save($fkid)
    {
        $status = "Ativo";
        $obj = new ConversaClass();
        $obj->setstatus($status);
        $obj->setfk_idpessoa($fkid);
        if ($obj->save()) {
            return true;
        } else {
            return false;
        }
    }

    public function FindOpt($telefone)
    {
        $obj = new ConversaClass();

        $pessoaFk = new Pessoa();

        $fk_pessoa = $pessoaFk->findIdTel($telefone);

        $obj->setfkid($fk_pessoa);

        $table = $obj->find($obj);

        return $table[0]["opt"];
    }

    public function FindidPessoa($telefone)
    {
        $pessoaFk = new Pessoa();
        $fk_pessoa = $pessoaFk->findIdTel($telefone);
        return $fk_pessoa;
    }

    

    public function find($fkid) //fazer igual nas ou
    {
        $obj = new ConversaClass();
        $obj->setfkid($fkid);
        $table = $obj->find($obj);
        return $table;
    }

    public function findonlyid($id)
    {
        $obj = new ConversaClass();
        $table = $obj->finder($id);
        return $table;
    }

    public function delete($fk_idPessoa)
    {
        $obj = new ConversaClass();
        $obj->setfk_idPessoa($fk_idPessoa);
        $obj->delete($obj);
        return true;
    }

    public function changeOpt($telefone,$opt)
    {
        $idPessoa = $this->FindidPessoa($telefone);//Retorna o id da pessoa
        $obj = new ConversaClass();
        $obj->setidPessoa($idPessoa);
        $obj->setopt($opt);
        $obj->editOpt();

    }

    public static function Status($telefone)
    {
        $obj = new ConversaClass();
        $obj->setTelefoneFindStatus($telefone);
        if ($obj->finderStatus($obj)) {
            return true;
        } else {
            return false;
        }
    }

    public static function changeStatusOn($telefone)
    {
        $obj = new ConversaClass();
        $pessoaFk = new Pessoa();
        $fk_pessoa = $pessoaFk->findIdTel($telefone);
        $obj->setfk_pessoa($fk_pessoa);
        if ($obj->StatusOn($obj)) {
            return true;
        } else {
            return false;
        }
    }
    public static function changeStatusOff($telefone)
    {
        $obj = new ConversaClass();

        $pessoaFk = new Pessoa();

        $fk_pessoa = $pessoaFk->findIdTel($telefone);

        $obj->setfk_pessoa($fk_pessoa);

        if ($obj->StatusOff($obj)) {
            return true;
        } else {
            return false;
        }
    }


}
