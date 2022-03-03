<?php
include_once('/strtec/DOM/header.php');
$bot = new Boot();
$menu = new Menu();
$opt = new Opcoes();
if (isset($_GET["idboot"]) && $_GET["idboot"]!=null){

    $tabelas = $menu->getMenu($_GET["idboot"]);
    $bootEdit = $bot->showid($_GET["idboot"]);

    if (isset($_POST["btn-edit"])) {
        $bot->edit($bootEdit[0]["idBoot"], $_POST["nomeRobo"]);

        echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Boot.php"
        </script>';
    }

    if(isset($_GET["menuexclude"])){
        $menu->exclude($_GET["menuexclude"]);
        echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Boot-Edit.php?idboot='.$_GET["idboot"].'"
        </script>';

    }


} else {
    echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Boot.php?EditBoot=fail"
        </script>';
}

?>

<script>
    function ativa() {
        var x = document.getElementById("854785");
        if (x.style.display === 'none') {
            x.style.display = 'inline';
        } else {
            x.style.display = 'none';
        }
    }
</script>

<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>
            Pagina de Edição do Robô
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
            <li class="active">Tabela de Robos</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Edição do Robo</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <form role="form" method="POST">
                    <div class="box-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Nome Do Robo</label>
                            <input type="text" class="form-control" id="nomeRobo" name="nomeRobo" value="<?php echo $bootEdit[0]["Nome"]; ?>" require>
                        </div>
                    </div>
                    <!-- /.box-body -->

                    <div class="box-footer">
                        <button type="submit" class="btn btn-primary" name="btn-edit">Alterar</button>
                        <a type="submit" class="btn btn-danger" href="/Boot.php">Cancelar</a>
                    </div>
                </form>

            </div>
        </div>
    </section>
    <section class="content">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Menus do Robo</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">

                <?php foreach ($tabelas as $tabela) : ?>
                    <div class="box box-default box-solid collapsed-box">
                        <div class="box-header with-border">
                            <h3 class="box-title"><?php echo $tabela["nomeMenu"]; ?></h3>

                            <div class="box-tools pull-right">
                                <a type="button" class="btn btn-primary-success" href="/Menu-edit.php?idMenu=<?php echo $tabela["idMenu"] ?>">Editar Nome do Menu</a>
                                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-plus"></i>
                                </button>
                            </div>
                            <!-- /.box-tools -->
                        </div>
                        <!-- /.box-header -->
                        <div class="box-body" style="display: none;">
                            <?php $tabelaOpts = $opt->showFk($tabela["idMenu"]);
                            foreach ($tabelaOpts as $tabelaOpt) :  ?>

                                <div class="box box-default box-solid collapsed-box">
                                    <div class="box-header with-border">
                                        <h3 class="box-title"><?php echo $tabelaOpt["nomeOpcao"]; ?></h3>

                                        <div class="box-tools pull-right">
                                        <a type="button" class="btn btn-primary-success" href="/Option-edit.php?idopcao=<?php echo $tabelaOpt["idOpcao"] ?>">Editar Opção</a>
                                            <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-plus"></i>
                                            </button>
                                        </div>
                                        <!-- /.box-tools -->
                                    </div>
                                    <!-- /.box-header -->
                                    <div class="box-body" style="display: none;">
                                        <?php echo $tabelaOpt["opcao"]; ?>
                                    </div>
                                    <!-- /.box-body -->
                                </div>




                            <?php endforeach; ?>

                        </div>
                        <!-- /.box-body -->
                    </div>
                <?php endforeach; ?>

                <?php if (isset($_GET["EditMenu"])) { ?>
                    <div class="alert alert-danger alert-dismissible">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                        <h4><i class="icon fa fa-info"></i> Alerta!</h4>
                        Você não pode acessar essa página via url. Comece a edição para acessar!
                    </div>
                <?php } ?>



            </div>
        </div>
    </section>
</div>

<?php include_once("/strtec/DOM/footer.php"); ?>