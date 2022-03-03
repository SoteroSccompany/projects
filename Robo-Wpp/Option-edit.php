<?php
include_once('/strtec/DOM/header.php');
$bot = new Boot();
$menu = new Menu();
$opt = new Opcoes();
if (isset($_GET["idopcao"]) && $_GET["idopcao"] != null) {
    $tabelaEdit = $opt->showid($_GET["idopcao"]);
    if (isset($_POST["btn-edit"])) {
        $opt->edit($_GET["idopcao"], $_POST["nomeOpcao"], $_POST["opcao"]);
    }
} else {
    echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Menu-edit.php?idMenu=' . $tabelaEdit[0]["fk_menu"] . '"
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

    function deletar(fkmenu, idopt) {
        $("#modal").modal("show");
        setTimeout(1000);

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
                <h3 class="box-title">Edição Opção e conteúdo de opção</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <form role="form" method="POST">
                    <div class="box-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Nome Da Opção</label>
                            <input type="text" class="form-control" id="nomeOpcao" name="nomeOpcao" value="<?php echo $tabelaEdit[0]["nomeOpcao"]; ?>" require>
                            <label for="exampleInputEmail1">Conteúdo da Opção</label>
                            <input type="text" class="form-control" id="opcao" name="opcao" value="<?php echo $tabelaEdit[0]["opcao"]; ?>" require>
                        </div>
                    </div>
                    <!-- /.box-body -->

                    <div class="box-footer">
                        <button type="submit" class="btn btn-primary" name="btn-edit">Alterar</button>
                        <a type="submit" class="btn btn-success" href="/Boot-Edit.php?idboot=<?php echo $tabelaEdit[0]["fk_boot"]; ?>">Cancelar</a>
                        <a type="submit" class="btn btn-danger" href="" onclick="deletar(<?php echo $tabelaEdit[0]['fk_menu']; ?>, <?php echo $tabelaEdit[0]['idOpcao']; ?>)">Apagar Opçao</a>
                    </div>
                </form>

            </div>
        </div>
    </section>
    <section class="content">
    <div class="modal" id="modal">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">×</span></button>
                    <h4 class="modal-title">Default Modal</h4>
                </div>
                <div class="modal-body">
                    <p>One fine body…</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    </section>



</div>

<?php include_once("/strtec/DOM/footer.php"); ?>