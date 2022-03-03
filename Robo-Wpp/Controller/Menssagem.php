<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/MenssagemClass.php");


class Menssagem
{
   public function save($fk_conversa,$fk_pessoa,$msg)
   {       
        date_default_timezone_set('America/Sao_Paulo');   
        $obj = new MenssagemClass();
        $obj->setmsg($msg);
        $obj->sethora(date('H:i:s', time()));
        $obj->setfk_conversa($fk_conversa);
        $obj->setfk_pessoa($fk_pessoa);
        if($obj->save($obj)){//TRATAMENTO DE ERRO
            return true;
        }else{
            return false;
        }
   }

   public static function find($fk_pessoa)
   {
       $obj = new MenssagemClass();
       $table = $obj->findLastRegister($fk_pessoa);
       return $table;

   }

   public function delete($fk_pessoa)
   {
    //Saber o pq do static kkkk
    $obj = new MenssagemClass();
    $obj->setfk_pessoa($fk_pessoa);
    $obj->delete($obj);
    return true;
   }

    
}