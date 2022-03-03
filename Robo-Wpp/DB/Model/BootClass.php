<?php
require_once("/strtec/DB/ConexaoClass.php");
require_once("/strtec/DB/Model.php");
//Função das classes -> conexão e funções do banco como inserção, update, etc

class BootClass extends Model
{
    public function showid()
    {   
        $id = $this->getidboot();
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM boot Where idBoot='$id'");
        if($table != null){
            return $table;
        }else{
            return false;
        }
    }

    public function show()
    {
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM boot");
        if($table != null){
            return $table;
        }else{
            return false;
        }

    }

    public function LastId($obj)
    {
        $nome = $obj->getnome();
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM boot where Nome = '$nome'");
        if($table != null){
            return $table;
        }else{
            return false;
        }
    }

    public function checkname($obj)
    {
        $nome = $obj->getnome();
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM boot where Nome = '$nome'");
        if($table != null){
            return true;
        }else{
            return false;
        }
    }

    public function save()//realizar um estatico para ficar mais fácil a manipulação
    {       
                  
            $nome = $this->getnome();
            $obj = new ConexaoClass();
            if($obj->comand("INSERT INTO boot(Nome, status) VALUES('$nome', 'inativo')")){
                return true;
            }else{
                return false;
            }
        
    } 

    public function edit()
    {    
                  
            $nome = $this->getnome();
            $id = $this->getid();
            $obj = new ConexaoClass();
            echo $nome.$id;
            if($obj->comand("UPDATE boot set Nome='$nome' where idBoot ='$id'")){
                return true;
            }else{
                return false;
            }
        
    } 

    public function changeStatusOn()
    {
        $id = $this->getidboot();
        $con = new ConexaoClass();
        $con->comand("UPDATE boot SET status ='ativo' WHERE idBoot = '$id'");
        return true;
    }
    
    public function changeStatusOff()
    {
        $id = $this->getidboot();
        $con = new ConexaoClass();
        $con->comand("UPDATE boot SET status ='inativo' WHERE idBoot = '$id'");
        return true;
    }

    public function getActive()//Utilizar para verificar se tem ativo e para não deixar nenhum desativo
    {
        $conect = new ConexaoClass();
        $table = $conect->select("SELECT * FROM boot where status = 'ativo'");
        if($table != null){
            return $table;
        }else{
            return false;
        }
    }

    public function delete()
    {
        $idboot = $this->getidboot();
        $con = new ConexaoClass();
        $con->comand("DELETE FROM boot WHERE idBoot = '$idboot'");
    }

    public function checkstatus()
    {
        $con = new ConexaoClass();
        $id = $this->getid();
        $table = $con->select("SELECT * FROM boot WHERE idBoot='$id' AND status='ativo'");
        if($table == null){
            return true;
        }else{
            return false;
        }

    }

}