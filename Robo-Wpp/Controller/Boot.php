<?php
//Função do controller -> mandar para a classe, lá será feito a inserção, o update e exclude, aqui recebe o dado
require_once("/strtec/DB/Model/BootClass.php");

class Boot
{

    public function checkunic($idbootchange)
    {

        $tables = $this->show();
        foreach ($tables as $table) :
            if ($table["status"] == 'ativo' && $table["idBoot"] != $idbootchange) {
                $this->changeStatus($table["idBoot"]);
            }
        endforeach;
    }

    public function checknumboot()
    {
        $table = $this->show();
        if (is_countable($table)) {
            $tamanhotab = sizeof($table);
        }
        if ($tamanhotab > 1) {
            return true;
        } else {
            return false;
        }
    }

    public function checkstatus($idboot)
    {
        $bt = new BootClass();
        $bt->setid($idboot);
        if ($bt->checkstatus()) {
            return true;
        } else {
            return false;
        }
    }

    public function numbot()
    {
        $check = 0;
        $tables = $this->show();
        foreach ($tables as $table) :
            if ($table["status"] == 'inativo') {
                $check  += 1;
            }
        endforeach;
        return $check;
    }

    public function changeStatus($id)
    {
        
            $check = $this->numbot();
            $opt = new Opcoes();
            $boot = new BootClass();
            $boot->setidboot($id);            
            $this->checkunic($id);
            $table = $boot->showid();
            if ($table[0]["status"] == 'inativo') {
                if ($boot->changeStatusOn()) {
                    return true;
                } else {
                    return false;
                }
            } else if ($table[0]["status"] == 'ativo') {
                $opt->changeopt($table["idBoot"]);
                if ($boot->changeStatusOff()) {
                    return true;
                } else {
                    return false;
                }
            }
    }

    public static function show()
    {
        $boot = new BootClass();
        $table = $boot->show();
        return $table;
    }

    public static function showid($idboot)
    {
        $boot = new BootClass();
        $boot->setidboot($idboot);
        $table = $boot->showid();
        return $table;
    }

    //Funções estaticas 
    public static function checkName($name)
    {
        $obj = new BootClass();
        $obj->setnome($name);
        if ($obj->checkname($obj) == false) {
            return true;
        } else {
            return false;
        }
    }

    //Funções públicas


    public function idAtivo()
    {
        $obj = new BootClass();
        $table = $obj->getActive();
        return $table;
    }

    public function getidBoot($nome)
    {
        $obj = new BootClass();
        $obj->setnome($nome);
        $table = $obj->lastId($obj);
        $id = $table[0]["idBoot"];
        return $id;
    }

    public function save($name)
    {
        $obj = new BootClass();
        $obj->setnome($name);
        if ($obj->save()) {
            return true;
        } else {
            return false;
        }
    }

    public function edit($id, $name)
    {
        $obj = new BootClass();
        $obj->setid($id);
        $obj->setnome($name);
        if ($obj->edit()) {
            return true;
        } else {
            return false;
        }
    }

    public function delete($idboot)
    {
        $objboot = new BootClass();
        $objMenu = new Menu();
        $tablemens = $objMenu->getMenu($idboot);
        foreach ($tablemens as $tablemen) :
            $objMenu->exclude($tablemen["idMenu"]);
        endforeach;
        $objboot->setidboot($idboot);
        $objboot->delete();
    }
}
