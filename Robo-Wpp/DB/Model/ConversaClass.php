<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class ConversaClass extends Model
{

    

    public function save()//realizar um estatico para ficar mais fácil a manipulação
    {       
                  
            $fk_id =  $this->getfk_idpessoa();
            $status = $this->getstatus();
            $obj = new ConexaoClass();
            if($obj->comand("INSERT INTO conversa(status, fk_idpessoa, opt) VALUES('$status', '$fk_id', 'false')")){
                return true;
            }else{
                return false;
            }
        
    } 
    
    public function find($obj)//Utilizar apenas o objeto. Mais fácil e o código fica mais limpo 
    {
        $fk_id = $obj->getfkid();//Testar se funciona com o $this 
        //Otimizar os códigos 
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT * FROM conversa WHERE  fk_idpessoa='$fk_id'");
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
        $table = $conect->select("SELECT * FROM conversa WHERE idConversa = '$id'");
        if($table != null)
        {
            return $table;
        }else{
            return false;
        }
    }

    public function finderStatus($obj)//Método pode ser etático
    {
        $telefone = $obj->getTelefoneFindStatus();
        $conect = New ConexaoClass();
        $table = $conect->select("SELECT conversa.status FROM conversa INNER JOIN pessoa on conversa.fk_idpessoa = pessoa.idPessoa
        WHERE pessoa.telefone = '$telefone'");
        if($table[0]["status"] =="Ativo")
        {
            return true;
        }else{
            return false;
        }
    }

    public function delete($obj)
    {
        $fk_idpessoa = $obj->getfk_idPessoa();
        $conect = new ConexaoClass();
        $conect->comand("DELETE FROM conversa WHERE fk_idpessoa = '$fk_idpessoa'");

    }

    public function StatusOn($obj)
    {
        $fk_pessoa = $obj->getfk_pessoa();
        $conect = new ConexaoClass();
        $conect->comand("UPDATE conversa SET status = 'Ativo' WHERE fk_idpessoa = '$fk_pessoa'");
        return true;    
    }
    public function StatusOff($obj)
    {
        $fk_pessoa = $obj->getfk_pessoa();
        $conect = new ConexaoClass();
        $conect->comand("UPDATE conversa SET status = 'Inativo' WHERE fk_idpessoa = '$fk_pessoa'");
        return true;            
    }

    public function editOpt()
    {
        $con = new ConexaoClass();
        $id = $this->getidPessoa();
        $opt = $this->getopt();
        $con->comand("UPDATE conversa SET opt='$opt' WHERE fk_idpessoa='$id' ");
        
    }
   

}