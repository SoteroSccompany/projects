<?php
include_once('/strtec/DOM/header.php');
$bot = new Boot();
$menu = new Menu();
$opt = new Opcoes();
if(isset($_GET["idMenu"]) && $_GET["idMenu"] !=null){    
$tabelaEdit = $menu->getMenuId($_GET["idMenu"]);
$menuopcoes = $opt->showFk($_GET["idMenu"]); 
if(isset($_POST["btn-edit"])){
    $menu->edit($_GET["idMenu"], $_POST["nomeMenu"]);
    echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Menu-edit.php?idMenu='.$tabelaEdit[0]["idMenu"].'"
        </script>';

}
if(isset($_GET["excludeoption"])){
    $opt->delete($_GET["excludeoption"]);echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Menu-edit.php?idMenu='.$tabelaEdit[0]["idMenu"].'"
    </script>';
}
}else{
    
    echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Boot-Edit.php?EditMenu=fail"
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
            Pagina de Edição do Menu
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
            <li class="active">Edição do Menu</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Edição do Menu</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <form role="form" method="POST">
                    <div class="box-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Nome Do Menu</label>
                            <input type="text" class="form-control" id="nomeMenu" name="nomeMenu" value="<?php echo $tabelaEdit[0]["nomeMenu"]; ?>" require>
                        </div>
                    </div>
                    <!-- /.box-body -->

                    <div class="box-footer">
                        <button type="submit" class="btn btn-primary" name="btn-edit">Alterar</button>
                        <a type="submit" class="btn btn-success" href="/Boot-Edit.php?idboot=<?php echo $tabelaEdit[0]["fk_boot"]; ?>">Cancelar</a>
                        <a type="submit" class="btn btn-danger" href="/Boot-Edit.php?idboot=<?php echo $tabelaEdit[0]["fk_boot"]; ?>& menuexclude=<?php echo $tabelaEdit[0]["idMenu"]; ?>
                        ?.">Apagar Menu</a>
                    </div>
                </form>

            </div>
        </div>
    </section>

    <section class="content">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Opções do menu</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">

                <?php foreach ($menuopcoes as $menuopcoe) : ?>
                    <div class="box box-default box-solid collapsed-box">
                        <div class="box-header with-border">
                            <h3 class="box-title"><?php echo $menuopcoe["nomeOpcao"]; ?></h3>

                            <div class="box-tools pull-right">
                                <a type="button" class="btn btn-primary-success" href="Option-edit.php?idopcao=<?php echo $menuopcoe["idOpcao"]; ?>">Editar Opção</a>
                                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-plus"></i>
                                </button>
                            </div>
                            <!-- /.box-tools -->
                        </div>
                        <!-- /.box-header -->
                        <div class="box-body" style="display: none;">
                            
                        <?php echo $menuopcoe["opcao"]; ?>
                        </div>
                        <!-- /.box-body -->
                    </div>
                <?php endforeach; ?>




            </div>
        </div>
    </section>



</div>

<?php include_once("/strtec/DOM/footer.php"); ?>