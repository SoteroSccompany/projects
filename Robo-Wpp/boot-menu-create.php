<?php
include_once('/strtec/DOM/header.php');
$boot = new Boot();
$idboot = $boot->getidBoot($_GET["nome"]);
if ($idboot != null) {
    $menu = new Menu();
    if (isset($_POST["btn-save"])) {
        $tituloMenu = $_POST["menuTitulo"];
        $posicaocheck = $menu->posicao($idboot);
        if ($posicaocheck === false) {
            $posicao = 0;
        } else {

            $numero = intval($posicaocheck);
            $posicao = $numero + 1;
            echo $posicao;
        }
        $menu->save($tituloMenu, $posicao, $idboot);
        $menu = $menu->getMenu($idboot);
        $idMenu = $menu[0]["idMenu"];
        //Ir para a url para configurar a opção que será enviada para o cliente
        echo '<script language= "JavaScript">
                location.href="http://www.strtec.com.br/opcao-menu.php?nome=' . $_GET["nome"] . '&id=' . $idMenu . '"
                </script>';
    } else if (isset($_POST["conclui"])) {
        if ($menu->checkMenuRegister($idboot) === false) {
            echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/boot-menu-create.php?nome=' . $_GET["nome"] . '&checkmenuregister=fail"
        </script>';        
        } else if ($menu->checkMenuRegister($idboot) === true) {
            echo '<script language= "JavaScript">
                location.href="http://www.strtec.com.br/Boot.php?register=finish&nome=' . $_GET["nome"] . '"
                </script>';
        }
    }
} else {
    echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Boot.php?redirectFail=tentativa"
    </script>'; //Impedir o acesso a essa página sem ser pelo form
}
?>
<!-- Content Wrapper. Contains page content -->
<script type="text/javascript">
    function nulo() {
        var txt = document.getElementById("menuTitulo");
        txt.value = "null"
        var form = document.getElementById("form");
        form.innerHTML = '<input type="input" name="conclui" hidden>';
        form.submit();
        //<input type="input" name="conclui" hidden>
    }
</script>
<div class="content-wrapper">
    <?php if (isset($_GET["redirectfail"])) { ?>
        <div class="alert alert-danger alert-dismissible">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <h4><i class="icon fa fa-ban"></i> Alerta!</h4>
            Não é possível acessar essa página desta forma.
        </div>
    <?php } ?>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>
            Pagina de Controle do Robo
            <small>Contatos salvos</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
            <li class="active">Tabela de Robos</li>
        </ol>
    </section>

    <section class="content">
        <div class="box box-primary" style="width:80%; margin-left: 10%; margin-top: 2%;">
            <div class="box-header with-border">
                <h3 class="box-title">Adicione menu ao seu robo</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
            <form role="form" method="POST" id="form">
                <div class="box-body">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Digite o titulo do Menu</label>
                        <input type="text" class="form-control" id="menuTitulo" name="menuTitulo" placeholder="Digite o titulo do menu" required>
                    </div>
                    <div class="form-group">
                        <button type="submit" class="btn btn-primary" name="btn-save">Salvar</button>
                        <button type="submit" class="btn btn-sucess" name="btn-ok" onclick="nulo()">Concluir</button>
                    </div>
                </div>
            </form>
        </div>

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

        <?php if (isset($_GET["id"])) {
            $menu = new Menu();
            $tables = $menu->getMenu($idboot);
            foreach ($tables as $table) : ?>
                <div class="box box-primary" style="width:80%; margin-left: 10%; margin-top: 2%;">
                    <div class="alert alert-info alert-dismissible">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                        <h4>Menu adicionado</h4>
                        Menu: <?php echo $table["nomeMenu"]; ?>
                    </div>
                </div>
        <?php endforeach;
        } ?>

    </section>
</div>
<!-- /.content-wrapper -->
<?php
include_once("/strtec/DOM/footer.php"); ?>