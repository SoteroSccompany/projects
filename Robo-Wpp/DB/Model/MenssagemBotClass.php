<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class MenssagemBotClass extends Model
{
    public function save($obj)
    {   
        $data = date('Y-m-d');
        $data_format = str_replace('/','-',$data);
        $msg  = $obj->getmsg();
        $hora = $obj->gethora();
        $fk_pessoa = $obj->getfk_pessoa();
        $fk_conversa = $obj->getfk_conversa();
        $fk_menssagem = $obj->getfk_menssagem();
        $conect = new ConexaoClass();
        
                
        if($conect->comand("INSERT INTO menssagembot (msgBot, dataBot, horaBot, fk_pessoa, fk_conversa, fk_menssagem) VALUES ('$msg', '$data_format','$hora','$fk_pessoa','$fk_conversa', '$fk_menssagem')"))
        {
            return true;
        }else{
            return false;
        }
        
    }

    public function find($fk_pessoa)
    {
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM menssagembot INNER JOIN menssagem ON menssagembot.fk_menssagem = menssagem.idMenssagem INNER JOIN pessoa ON menssagem.fk_pessoa = pessoa.idPessoa
        WHERE pessoa.idPessoa = '$fk_pessoa'");
        if($table > 0){
            return $table;
        }else{
            return false;
        }
    }

    public function findMsgPessoa($fk_pessoa)
    {
        //
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM menssagem LEFT JOIN menssagembot on menssagem.fk_pessoa = menssagembot.fk_pessoa WHERE menssagem.fk_pessoa = '$fk_pessoa'");
        if($table > 0){
            $tableSize = sizeof($table);
            $tablesize = $tableSize - 1;
            return $table[$tablesize]["msg"];
        }else{
            return false;
        }
    }

    public function delete($obj)
    {
        $conect = new ConexaoClass();
        $fk = $obj->getfk_pessoa();
        $conect->comand("DELETE FROM menssagembot WHERE fk_pessoa = '$fk'");
        return true;
        

    }
}