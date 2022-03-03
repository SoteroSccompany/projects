<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class MenssagemClass extends Model
{
    public function save($obj)
    {   
        $data = date('Y-m-d');
        $data_format = str_replace('/','-',$data);
        $msg  = $obj->getmsg();
        $hora = $obj->gethora();
        $fk_conversa = $obj->getfk_conversa();
        $fk_pessoa = $obj->getfk_pessoa();
        $conect = new ConexaoClass();
        
                
        if($conect->comand("INSERT INTO menssagem (msg, data, hora, fk_conversa, fk_pessoa) VALUES('$msg', '$data_format','$hora','$fk_conversa','$fk_pessoa')"))
        {
            return true;
        }else{
            return false;
        }
        
    }

    public function findLastRegister($fk_pessoa)
    {
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * from menssagem where fk_pessoa = '$fk_pessoa' ORDER BY idMenssagem DESC");
        if($table > 0){
            return $table;
        }else{
            return false;
        }
    }

    public function delete($obj)
    {
        $conect = new ConexaoClass();
        $fk = $obj->getfk_pessoa();
        $conect->comand("DELETE FROM menssagem WHERE fk_pessoa = '$fk'");
        return true;
        

    }
}