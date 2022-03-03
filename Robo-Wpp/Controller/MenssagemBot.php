<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/MenssagemBotClass.php");


class MenssagemBot
{
   public function save($fk_pessoa,$fk_conversa,$fk_msg,$msg)
   {       
        date_default_timezone_set('America/Sao_Paulo');   
        $obj = new MenssagemBotClass();
        $obj->setmsg($msg);
        $obj->sethora(date('H:i:s', time()));
        $obj->setfk_pessoa($fk_pessoa);
        $obj->setfk_conversa($fk_conversa);
        $obj->setfk_menssagem($fk_msg);
        
        if($obj->save($obj)){//TRATAMENTO DE ERRO
            return true;
        }else{
            return false;
        }
   }

   public static function find($fk_pessoa)
   {
       $obj = new MenssagemBotClass();
       $table = $obj->find($fk_pessoa);
       return $table;

   }

   public static function findMsgPessoa($fk_pessoa)
   {
       $obj = new MenssagemBotClass();
       $table = $obj->findMsgPessoa($fk_pessoa);
       return $table;

   }

   public function delete($fk_pessoa)
   {
        $obj = new MenssagemBotClass();
        $obj->setfk_pessoa($fk_pessoa);
        $obj->delete($obj);
        return true;
   }

    
}