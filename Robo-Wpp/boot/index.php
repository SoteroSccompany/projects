<?php
//Sem header, pq o arquivo, irá ler o que está dentro do php
//Abrir e fechar a tag php a cada resposta
require_once("/strtec/Controller/Pessoa.php");
require_once("/strtec/Controller/Conversa.php");
require_once("/strtec/Controller/Menssagem.php");
require_once("/strtec/Controller/Boot.php");
include_once("/strtec/Controller/Menu.php");
include_once("/strtec/Controller/Opcoes.php");
// NÃO PRECISA 
//DEVE SER MENOR. NÃO PRECISA DESSE TANTO DE REQUIRE, FAZER UM ARQUIVO FUNCTION.
session_start();
?>

<?php

$menuSelect;

$data = date('d-m-Y');

$msgwpp = $_GET['msg']; //colcocar como se fosse o nome
$telefone = $_GET['telefone'];
$nome = $_GET['nome'];

//Variavél de controle 


$check = Pessoa::newContact($telefone, $nome);
$status = Conversa::Status($telefone);

//Pegar o id do boot no que está ativo.
$bot = new Boot();
$tableBoot = $bot->idAtivo();
$idBoot = $tableBoot[0]["idBoot"];
$menu = new Menu();
$table = $menu->getMenu($idBoot);


//Posições do menu 
$exibicoes = $menu->getMenuExibicao($idBoot);
//sizeof() -> função para saber o número de registros
$tablesize = sizeof($exibicoes);
$msgbot01 = "";
$msgbot00 = "";
for ($o = 0; $o < $tablesize; $o++) {
    $msgbot01 = $msgbot01 . "
    Digite: " . $exibicoes[$o]["posição"] . " Para " . $exibicoes[$o]["nomeMenu"] . "";
    $msgbot00 = $msgbot00 . "" . $exibicoes[$o]["posição"] . " Para " . $exibicoes[$o]["nomeMenu"] . "</br>";
}

if ($check == true && $status != true) {
    //Salvar a menssagem se já estiver verificado!!!!       
    $objPessoa = new Pessoa();
    $objPessoa->addmsg($telefone, $msgwpp, $msgbot00);

    echo "Olá é um prazer falar com você novamente!
    " . $msgbot01;
    //Mudar o status para ativo
    Conversa::changeStatusOn($telefone);
    //Aqui entra o update. do status, não criando outra conversa.



} else if ($check == true && $status == true) {
    //Pega a menssagem e coloca em um switch case
    $objPessoa = new Pessoa();
    $conv = new Conversa();
    //$menu = $conv->FindMenu($telefone);//retirar menu da programação para reduzir o código
    //Deve verificar se se tem alguma option com true, se tiver, cairá na segunda parte da escolha 
    //Para alterar o status de opt, deve mudar pelo id do menu
    //De inicio vai verificar se tem alguma que está em true, se tiver, vai tratar conforme o menu escolhido
    $menuOpt = $conv->FindOpt($telefone);
    $btmsg00 = "";
    if ($menuOpt == 'false') {
        for ($i = 0; $i < $tablesize; $i++) {
            if ($msgwpp == $exibicoes[$i]["posição"]) {
                $idmenu = $exibicoes[$i]["idMenu"];
                $opt = new Opcoes();
                $conv->changeOpt($telefone,'true');
                $table = $opt->showFk($idmenu);
                $tabletam = sizeof($table);
                $_SESSION["choice"] = true;
                //Mudar o nome das variaveis para o código não embaralhar  
                $menu = "";
                for ($e = 0; $e < $tabletam; $e++) {
                    echo "Digite: " . $table[$e]["posicao"] . " Para " . $table[$e]["nomeOpcao"] . "
                    
                ";
                    $btmsg00 = $btmsg00 . " " . "Digite: " . $table[$e]["posicao"] . " Para " . $table[$e]["nomeOpcao"] . " </br>";
                    //Adicionar ao banco de dados a resposta do boot e da pessoa
                }
            }
        }
        

    }else if ($menuOpt == 'true') {
        for ($i = 0; $i < $tablesize; $i++) {
            $idmenu = $exibicoes[$i]["idMenu"];
            $opt = new Opcoes();
            $table = $opt->showFk($idmenu);
            //verificar qual status que alterou pelo id do menu e alterar
            $tableM = 0;
            if (is_countable($table)) {
                $tableM = sizeof($table);
            }
            //Mudar o nome das variaveis para o código não embaralhar              
            $menu = "";
            for ($e = 0; $e < $tableM; $e++) {
                if ($msgwpp == $table[$e]["posicao"]) {
                    echo "" . $table[$e]["opcao"];
                    $btmsg00 = $btmsg00 . " " .$table[$e]["opcao"];
                    $_SESSION["choice"] = true;
                    Opcoes::OffOpt($table[$e]["fk_menu"]);
                    Conversa::changeStatusOff($telefone);
                }

                //echo "Digite: " . $table[$e]["posicao"] . " Para " . $table[$e]["nomeOpcao"] . "";
                //Adicionar ao banco de dados a resposta do boot e da pessoa
            }
        }
        $objPessoa->addmsg($telefone,$msgwpp,$btmsg00);
    }
    if (!isset($_SESSION["choice"])) {
        echo "Não compreendemos sua resposta
         Envie novamente uma das opções";
         $msgbt = "Não compreendemos sua resposta
         Envie novamente uma das opções";
         $objPessoa->addmsg($telefone,$msgwpp, $msgbt);
    }
}else if ($check == false) {
    
    $_SESSION["choice"] = true;
    $obj = new Pessoa();
    if ($obj->add($nome, $telefone, $msgwpp, $msgbot00)) {
        echo "Olá! já realizamos o seu cadastro! 
        " . $msgbot01;
    } else {
        echo "Não foi possível realizar o seu cadastro =(";
    }
}

?>