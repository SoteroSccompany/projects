<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/MenuClass.php");


class Menu
{

    public function checkMenuRegister($idboot)
    {
        $obj = new MenuClass();
        $obj->setfkBoot($idboot);
        if($obj->findFkBootExibicao() == false){
            return false;
        }else{
            return true;
        }

    }

   public function save($nome,$posicao,$fk_boot)
   {       
        $obj = new MenuClass();
        $obj->setnome($nome);
        $obj->setposicao($posicao);
        $obj->setfk_boot($fk_boot);
        if($obj->save($obj)){
            return true;
        }else{
            return false;
        }


   }

   public function posicao($fk_boot)
   {
       $obj = new MenuClass();
       $obj->setfkBoot($fk_boot);
       $table = $obj->findFkBoot();
       if($table != false){
           return intval($table[0]["posição"]);
       }else{
           return false;
       }
   }

   public function getMenu($fk_boot)
   {
       $obj = new MenuClass();
       $obj->setfkBoot($fk_boot);
       $table = $obj->findFkBoot($fk_boot);       
       if($table != false){
           return $table;
       }else{
           return 'NotData';
       }
    }

    public function getMenuExibicao($fk_boot)
   {
       $obj = new MenuClass();
       $obj->setfkBoot($fk_boot);
       $table = $obj->findFkBootExibicao($fk_boot);       
       if($table != false){
           return $table;
       }else{
           return 'NotData';
       }
    }

    public function getMenuId($idmenu)
   {
       $obj = new MenuClass();
       $obj->setidMenu($idmenu);
       $table = $obj->findId($idmenu);       
       if($table != false){
           return $table;
       }else{
           return 'NotData';
       }
    }
    public function show()
    {
        $obj = new MenuClass();
        $table = $obj->show();       
        if($table != false){
            return $table;
        }else{
            return 'NotData';
        }
     }

     public function edit($idmenu, $nomeMenu)
     {
         $men = new MenuClass();
         $men->setidmenu($idmenu);
         $men->setnomemenu($nomeMenu);
         if($men->edit()){
             return true;
         }else{
             return false;
         }

     }

     public function exclude($idmenu)
     {
         $objmen = new MenuClass();
         $objOpt = new Opcoes();
         $tabblemns = $objOpt->showFk($idmenu);
         foreach($tabblemns as $tabblemn):
            $objOpt->delete($tabblemn["idOpcao"]);
         endforeach;
         $objmen->setidmenu($idmenu);
         $objmen->delete();

     }

    
}