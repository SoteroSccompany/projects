<?php 
class Model{

    private $values = []; 

    //Para toda vez que um metodo for chamado __Call

    public function __call($name, $args)
    {
        $method = substr($name, 0, 3); //O 3 vai do 0,1,2 para saber qual é o method
        $fieldname = substr($name, 3, strlen($name));
        //Pega o metodo pela escrita, pela função da call.
        switch($method)
        {
            case "get":
                return (isset($this->values[$fieldname])) ? $this->values[$fieldname] : NULL;

            break;

            case "set":
                
                $this->values[$fieldname] = $args[0];

            break;
        }
    }

    public function setData($data = array())
    {
        foreach($data as $key => $value){

            $this->{"set".$key}($value);//Tudo que for dinamico no php se coloca em {}

        }
    }

    public function getValues()
    {//mesmo que o atributo fosse publico, não é boa pratica acessar ele direto no user, sempre fazer isso.
        return $this->values;
    }    

}

?>