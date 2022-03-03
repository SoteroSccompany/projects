<?php
include_once('/strtec/DOM/header.php');
//Pega o id da menssagem e do menu 
$nomeBot = $_GET["nome"];
$idMenu = $_GET["id"];
$menu = new Menu();
$opcao = new Opcoes();
$table = $menu->getMenuId($idMenu);
if ($idMenu != null){
    if (isset($_POST["btn-save"])) {
        $menu = new Menu();
        $table = $menu->getMenuId($idMenu);
        $fk_menu = $table[0]["idMenu"];
        $fk_bot = $table[0]["fk_boot"];
        $opcaoNome = $_POST["opcaoName"];
        $opcaoContent = $_POST["opcaoContent"];
        $posicaocheck = $opcao->posicao($idMenu);
        if ($posicaocheck === 'no-data') {
            $posicao = 0;
        } else {
            $numero = $posicaocheck;
            $posicao = $numero + 1;
        }
        $opcao->save($opcaoNome, $opcaoContent, $posicao, $fk_bot, $fk_menu);
        echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/opcao-menu.php?nome=' . $nomeBot . '&id=' . $idMenu . '&fkMenu=' . $idMenu . '"
        </script>';
    } else if (isset($_POST["conclui"])){
        if ($opcao->checkoptMenuRegister($idMenu) === true){
            echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/boot-menu-create.php?nome=' . $nomeBot . '&id=' . $idMenu . '&fkMenu=' . $fk_menu . '"
        </script>';
        }else if($opcao->checkoptMenuRegister($idMenu) === false){
            
        echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/opcao-menu.php?nome=' . $nomeBot . '&id=' . $idMenu . '&checkmenuregister=fail"
        </script>';
        }
    }
} else {
    echo '<script language= "JavaScript">
     location.href="http://www.strtec.com.br/boot-menu-create.php?redirectfail=tentativa"
     </script>'; //Impedir o acesso a essa página sem ser pelo form
}


?>
<script type="text/javascript">
    function nulo() {
        optName = document.getElementById("opcaoName");
        optcontent = document.getElementById("opcaoContent");
        optName.value = "null";
        optcontent.value = "null";
        var form = document.getElementById("form");
        form.innerHTML = '<input type="input" name="conclui" hidden>';
        form.submit();
    }
</script>
<div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>
            Pagina de Controle do Robo            
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
            <li class="active">Menu</li>
            <li class="active">Opções</li>
        </ol>
    </section>
    <section class="content">
        <div class="box box-primary" style="width:80%; margin-left: 10%; margin-top: 2%;">
            <div class="box-header with-border">
                <h3 class="box-title">Adicione a opção correspondente ao menu: <?php echo $table[0]["nomeMenu"];   ?></h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
            <form role="form" method="POST" id="form">
                <div class="box-body">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Digite a opção</label>
                        <input type="text" class="form-control" id="opcaoName" name="opcaoName" placeholder="Digite a opção" required>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Digite o conteúdo da opção</label>
                        <input type="text" class="form-control" id="opcaoContent" name="opcaoContent" placeholder="Digite o conteúdo da opção" required>
                    </div>
                    <div class="form-group">
                        <button type="submit" class="btn btn-primary" name="btn-save">Adicionar</button>
                        <button type="submit" class="btn btn-dark" name="btn-close" onclick="nulo()">Concluir</button>
                    </div>
                </div>
            </form>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <?php if (isset($_GET["checkmenuregister"])) { ?>
            <div  style="width:80%; margin-left: 10%; margin-top: 2%;">
            <div class="box-body">
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                <h4><i class="icon fa fa-ban"></i> Alert!</h4>
                Não é possível concluir a configuração do Boot sem adicionar um menu
            </div>
            </div>
            </div>
        <?php } ?>

        <?php if (isset($_GET["fkMenu"])) {
            $opc = new Opcoes();
            $tables = $opc->showFk($_GET["fkMenu"]);
            foreach ($tables as $table) : ?>
                <div class="box" style="width:80%; margin-left: 10%; margin-top: 2%;">
                    <div class="alert alert-info alert-dismissible">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                        <h4>Opção adicionada</h4>
                        Opção: <?php echo $table["nomeOpcao"]; ?></br>
                        Conteúdo: <?php echo $table["opcao"]; ?>
                    </div>
                </div>
        <?php endforeach;
        } ?>

    </section>
</div>
<!-- /.content-wrapper -->
<?php
include_once("/strtec/DOM/footer.php");

?>