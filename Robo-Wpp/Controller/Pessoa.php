<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/PessoaClass.php");
require_once("Conversa.php");
require_once("Menssagem.php");
require_once("MenssagemBot.php");


class Pessoa
{  
    //Funções estaticas 
    public static function newContact($telefone, $nome)
    {
        $obje = new PessoaClass();
        $check = $obje->checkNewContactWpp($telefone, $nome);
        if($check == true){
            return true;

        }else{

            return false;

        }

    }
     
     public static function listAll()
     {
         $obj = new PessoaClass();      
         $table = $obj->show();
         return $table;
     }
 
     public static function finder($id)
     {
         //Retorna com os valores, e é solicitado na view
         $obj = new PessoaClass();  
         $table = $obj->finder($id);
         return $table;
     }

     public function addmsg($telefone,$msg00,$msgbot00)
     {
         //Função para salvar novas menssagens enviadas
         $obj = new PessoaClass();
         $conv = new Conversa();
         $table = $obj->findTel($telefone);
         $idFk = $table[0]["idPessoa"];        
         $msg = new Menssagem();
         $convtable = $conv->find($idFk);
         $msg->save($convtable[0]["idConversa"],$convtable[0]["fk_idpessoa"],$msg00);  
         //Função para salvar menssagem do bot:        
         $msgbot = new MenssagemBot();
         $msgtable = $msg->find($idFk);
         $msgbot->save($idFk,$convtable[0]["idConversa"],$msgtable[0]["idMenssagem"],$msgbot00);           
        
         return true; //inseriu

     }



    //FUNÇÕES PÚBLICAS
     public function findIdTel($telefone)
     {
         $obj = new PessoaClass();
         $table = $obj->findTel($telefone);
         $idTel = $table[0]["idPessoa"];
         return $idTel;
     }


    public function add($nome, $telefone,$msgwpp,$msgBot)
    {   //Função para adicionar o contato e salvar a primeira conversa
        
        //Trtamento de erro caso não deixe inserir
        $obj = new PessoaClass(); //Tratamento de erro
        $obj->setnome($nome);
        $obj->settelefone($telefone);
        if($obj->save($obj)){
            //Função para criar a conversa. 
            $conv = new Conversa();
            $table = $obj->find($nome,$telefone);
            $idFk = $table[0]["idPessoa"];          
            $conv->save($idFk);//MANDAR O OBJETO 
            //TRATAR ERRO DA CONVERSA?
            //Função para salvar a menssagem
            $msg = new Menssagem();
            $convtable = $conv->find($idFk);//VERIFICAR O MÉTODO PARA ISSO
            $msg->save($convtable[0]["idConversa"],$convtable[0]["fk_idpessoa"],$msgwpp);  
            //Função para salvar menssagem do bot:        
            $msgbot = new MenssagemBot();
            $msgtable = $msg->find($idFk);
            $msgbot->save($idFk,$convtable[0]["idConversa"],$msgtable[0]["idMenssagem"],$msgBot);
           
            return true; //inseriu
        }else{
            return false; //não inseriu
        }

    }

    //Função aqui ou outro lugar para retornar o número de linhas
   



    //Organizar as funções dentro do código
    public function Inserir($nome, $telefone)
    {   //Trtamento de erro caso não deixe inserir
        $msgwpp = "hello Word";
        $msgBot = "ola";
        $obj = new PessoaClass(); //Tratamento de erro
        $obj->setnome($nome);
        $obj->settelefone($telefone);
        if($obj->save($obj)){            
            //Função para criar a conversa. 
            $conv = new Conversa();
            $table = $obj->find($nome,$telefone);
            $idFk = $table[0]["idPessoa"];          
            $conv->save($idFk);//MANDAR O OBJETO 
            //TRATAR ERRO DA CONVERSA?
            //Função para salvar a menssagem
            $msg = new Menssagem();
            $convtable = $conv->find($idFk);//VERIFICAR O MÉTODO PARA ISSO
            $msg->save($convtable[0]["idConversa"],$convtable[0]["fk_idpessoa"],$msgwpp);  
            //Função para salvar menssagem do bot:        
            $msgbot = new MenssagemBot();
            $msgtable = $msg->find($idFk);
            $msgbot->save($idFk,$convtable[0]["idConversa"],$msgtable[0]["idMenssagem"],$msgBot);  
           
            

            //METODO ATIGO PARA SALVAR A CONVERSA E A MENSSAGEM 
            /*
            $conv = new Conversa();
            $table = $obj->find(null,$nome,$telefone);
            $idFk = $table[0]["idPessoa"];
            if($conv->save($idFk))//tratar erro?
            {
                $msg = new Menssagem();
                $msgtable = $conv->findid(null,null,$idFk);
                $msg->save($msgtable[0]["idConversa"],$msgtable[0]["fk_idpessoa"],$msgwpp);
                return header('Location: /');
            }else{
            }*/
            
        }else{
            session_start();
            $_SESSION['null-insert'] = 'true';//Da para automatizar esse processo

            return '<script language= "JavaScript">
            location.href="http://www.strtec.com.br"
            </script>';
        }

    }

    public function editar($id, $nome, $telefone)
    {    

        $obj = new PessoaClass();  
        $obj->setid($id);
        $obj->setnome($nome);
        $obj->settelefone($telefone);
        //Arrumar a exclusão no index, para tirar o get
        if($obj->update($obj)){
             return '<script language= "JavaScript">
            location.href="http://www.strtec.com.br"
            </script>';
        }else{
            //Tratamento de erro
        }       
    }

    public function exclude($id)
    {
        $obj = new PessoaClass();  
        $objcv = new Conversa();
        $objmsg = new Menssagem();
        $objmsgBot = new MenssagemBot();
        $obj->setid($id);
        $objmsgBot->delete($id);
        $objmsg->delete($id);
        $objcv->delete($id);
        if($obj->exclude($obj)){            
            return '<script language= "JavaScript">
            location.href="http://www.strtec.com.br"
            </script>';
        }else{
            //erros tratamentos
            '<script language= "JavaScript">
            location.href="http://www.google.com.br"
            </script>';
        }

    }

    
}