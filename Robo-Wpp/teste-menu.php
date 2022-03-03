<?php
include_once("/strtec/Controller/Boot.php");
include_once("/strtec/Controller/Menu.php");
include_once("/strtec/Controller/Opcoes.php");

//Construção do menu principal -> com as opções 

//Pegar o id do boot no que está ativo.
$bot = new Boot();
$tableBoot = $bot->idAtivo();
$idBoot = $tableBoot[0]["idBoot"];
$menu = new Menu();
$table = $menu->getMenu($idBoot);

echo Opcoes::optcheck();

//Posições do menu 
$exibicoes = $menu->getMenuExibicao($idBoot);
//sizeof() -> função para saber o número de registros
$tablesize = sizeof($exibicoes);
for ($i = 0; $i < $tablesize; $i++) {
    echo "Digite: " . $exibicoes[$i]["posição"] . ": " . $exibicoes[$i]["nomeMenu"] . " </br>";
}
?>
<form method="POST">
    <input type="text" name="escolha">
    <input type="submit" name="send">
</form>
<?php

//ESTRUTURA PARA MOSTRAR AS OPÇÕES
if (isset($_POST["send"]) && !isset($_SESSION["opt"])) {

    //Função para verificar em qual opção foi clicada e para exibir
    for ($i = 0; $i < $tablesize; $i++) {
        if ($_POST["escolha"] == $exibicoes[$i]["posição"]) {
            $idmenu = $exibicoes[$i]["idMenu"];
            $opt = new Opcoes();
            $table = $opt->showFk($idmenu);
            $tabletam = sizeof($table);
            $_SESSION["fkMenu"] = $idmenu;
            $_SESSION["opcao"] = $table[$i]["posicao"];
            $_SESSION["opt"] = true; //Estrutura para saber se pode entrar no laço ou passa para oo de opções
            //Mudar o nome das variaveis para o código não embaralhar  
            $menu ="";
            for ($e = 0; $e < $tabletam; $e++) {
                echo "Digite: " . $table[$e]["posicao"] . " Para " . $table[$e]["nomeOpcao"] . "</br>";
                $menu = $menu." Digite: ". $table[$e]["posicao"] . " Para " . $table[$e]["nomeOpcao"] . "";
                
            }
            echo $menu;
        }
    }
}
?>
<form method="POST">
    <input type="text" name="escolhaopt">
    <input type="submit" name="sendopt">
</form>

<?php
if (isset($_SESSION["opt"])) {
    $opt = new Opcoes();
    $table = $opt->showFk($_SESSION["fkMenu"]);
    $tabletam = sizeof($table);
    //faz um for dentro da tabela para mostrar 


}


?>