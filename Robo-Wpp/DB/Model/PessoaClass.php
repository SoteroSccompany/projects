<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class PessoaClass extends Model
{
    //O find retorna a tabela com os dados, o check só verifica

    private static function checkregister($nome, $telefone)//aqui pode ser número, nome ou e-mail
    {
        //Nome da pessoa está vindo nulo do script .py
        //ATENÇÃO AO BOT !!
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT nome, telefone FROM pessoa WHERE nome = '$nome' and telefone = '$telefone'");
        
        if($table > 0)
        {
            return false;
        }else{
            return true;
        }
    }

    public function save($obj)//realizar um estatico para ficar mais fácil a manipulação
    {
        //Lembre, json é objeto e a caracteistica
        //lembrar para transformar em json = json_encode
        //tratamento de erro para não inserir null
        //saber se existe outro registro no banco
        
        if(PessoaClass::checkregister($obj->getnome(), $obj->gettelefone())){            
            $nome = $obj->getnome();
            $telefone = $obj->gettelefone();
            $obj = new ConexaoClass();
            //Tratamento de erro necessário
            $obj->comand("INSERT INTO  pessoa(nome, telefone) VALUES ('$nome','$telefone')");

            return true;
        }else{
            return false;
        }
    }

    public function update($obj)
    {   
        $id = $obj->getid();
        $nome = $obj->getnome();
        $telefone = $obj->gettelefone();
        $obj = new ConexaoClass();
        $obj->comand("UPDATE pessoa SET nome = '$nome', telefone = '$telefone' WHERE idPessoa = $id");
        return true;

    }

    public function find($nome, $telefone)
    {
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM pessoa WHERE  nome ='$nome' AND telefone='$telefone'");
        if($table != null)
        {
            return $table;
        }else{
            return false;
        }
    }

    public function findTel($telefone)
    {
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM pessoa WHERE  telefone='$telefone'");
        if($table != null)
        {
            return $table;
        }else{
            return false;
        }
    }


    public function finder($id)
    {
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM pessoa WHERE idPessoa = '$id'");
        if($table != null)
        {
            return $table;
        }else{
            return false;
        }
    }
    
    public function show()
    {
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM pessoa INNER JOIN conversa on conversa.fk_idpessoa = pessoa.idPessoa");
        if($table != null)
        {
            return $table;
        }else{
            return 0;
        }
    }

    public function exclude($obj)
    {
        $id = $obj->getid();
        $obj = new ConexaoClass();//Já deixa conectado a variavéis privadas, sla... ou as sessions igual no slim
        $obj->comand("DELETE FROM  pessoa WHERE idPessoa = $id");
        return true;
    }

    public function checkNewContactWpp($telefone, $nome)
    {
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM pessoa WHERE telefone = '$telefone' and nome = '$nome'");
        if($table != null)
        {
            return true;//Se tiver registro, vai retornar true

        }else{
            return false;
        }
    }

}