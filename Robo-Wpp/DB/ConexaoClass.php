<?php


class ConexaoClass extends MySQLi {//Ta extendendo a uma classe pai, que é a classe do mysql

    public $host, $user, $password, $database, $connection; //atributos
    
    private $hostinfo = 'localhost', $userinfo='root', $passinfo='', $baseinfo = 'boot';

    public function __construct() {//O construtor é exigido na chamada da classe, por isso construtor.
        $this->host = $this->hostinfo;//construtor
        $this->user = $this->userinfo;
        $this->password = $this->passinfo;
        $this->database = $this->baseinfo;//Com o this aqui ele usa o set, para colocar alguma info, o this é para isso.
        $this->connect_me();
        //Lembrando que o this é para selecionar algo com sua funçção, ou ao que ele foi atribuido para fazer etc...
    }
    

    private function connect_me() {
        $this->connection = $this->connect($this->host, $this->user, $this->password, $this->database);
        if ($this->connect_error) {
            die($this->connect_error);
        }
    }

    // Utilizado apenas para SELECT!
    public function select($comandoSQL) {
        $result = $this->query($comandoSQL); //prop herdada do pai 

        if ($this->error) {
            return $this->error;
        } else { 
            $index = 0;            
            while ($row = $result->fetch_assoc()) {
                $data[$index] = $row;
                $index++;
            } 
                       
            if($index!=0){
                return $data;
            }
            else{
                return 0;
                
            }
        }
    }

    // Utilizado para INSERT, UPDATE e DELETE
    public function comand($comandoSQL) {
        $this->query($comandoSQL);//Este query é da propia função pai do metodo.
        if ($this->error) {
            return $this->error;
        } else {
            return true;
        }
    }

}
