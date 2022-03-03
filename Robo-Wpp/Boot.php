<?php
include_once('/strtec/DOM/header.php');
if (isset($_GET['id'])) {
    $obj = new Pessoa();
    $obj->exclude($_GET['id']);
}
if (isset($_GET["active"])) {
    $boot = new Boot();
        $checkactive = $boot->changeStatus($_GET["active"]);
        if ($checkactive == true) {
            echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/Boot.php"
        </script>';
        }else{
            
        }
    
}
if (isset($_GET["bootexclude"])) {
    $boot = new Boot();
    if ($boot->checkstatus($_GET["bootexclude"]) && $boot->checknumboot()) {
        $boot->delete($_GET["bootexclude"]);
        echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Boot.php"
    </script>';
    } else if ($boot->checkstatus($_GET["bootexclude"]) == false && $boot->checknumboot()) {
        echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Boot.php?bootActivo=fail"
    </script>';
    } else if ($boot->checknumboot() == false) {
        echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Boot.php?NumBot=fail"
    </script>';
    }
}
?>
<script type="text/javascript">
    function activeForm() {
        document.getElementById("bootname").value = "";
        x = document.getElementById('Form-Add');
        x.style.display = "inline";
    }

    function desactiveForm() {
        document.getElementById("bootname").value = "";
        x = document.getElementById('Form-Add');
        x.style.display = "none";
    }
</script>
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper">
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
    <!-- Main content -->
    <section class="content">

        <?php if (isset($_GET["redirectFail"])) { ?>
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alerta!</h4>
                Não é possível acessar essa página desta forma.
            </div>
        <?php } ?>

        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Data Table With Full Features</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <table id="example1" class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>Identidicador do contato</th>
                            <th>Nome do Robo</th>
                            <th>Status</th>
                            <th>Ações</th>
                        </tr>
                    </thead>
                    <?php $tables = Boot::show();
                    if ($tables == false) { ?>
                        <tbody>
                            <td>Não foram encontrando registros no banco de dados =(</td>
                            <?php } else {
                            foreach ($tables as $table) : ?>
                                <td><?php echo $table["idBoot"]; ?></td>
                                <td><?php echo $table["Nome"]; ?></td>
                                <td><?php echo $table["status"]; ?></td>
                                <td>
                                    <a type="button" class="btn  btn-primary" href="/Boot.php?active=<?php echo $table["idBoot"] ?>">Ativar Boot</a>
                                    <a type="button" class="btn  btn-success" href="/Boot-Edit.php?idboot=<?php echo $table["idBoot"] ?>">Editar Boot</a>
                                    <a type="button" class="btn  btn-danger" href="/Boot.php?bootexclude=<?php echo $table["idBoot"] ?>">Apagar Boot</a>
                                </td>
                        </tbody>
                <?php endforeach;
                        } ?>
                </table>
            </div>
            <div class="box-footer">
                <a class="btn btn-info" onclick="activeForm()">Criar novo robo</a>
            </div>
        </div>
        <?php if (isset($_GET["save"])) { ?>
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alerta!</h4>
                Não foi possível inserir o nome no banco de dados. Tente novamente mais tarde.
            </div>
        <?php } ?>
        <?php if (isset($_GET["NumBot"])) { ?>
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alerta!</h4>
                Esse boot é o úncio boot. Adicione outro boot para excluir esse
            </div>
        <?php } ?>
        <?php if (isset($_GET["bootActivo"])) { ?>
            <div class="alert alert-info alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alerta!</h4>
                Esse boot está ativo, ele não pode ser removido. Desative o boot primeiro.
            </div>
        <?php } ?>
        <?php if (isset($_GET["check"])) { ?>
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-info"></i> Alerta!</h4>
                Este nome de Robo já existe! Tente outo.
            </div>
        <?php } ?>

        <?php if (isset($_GET["register"])) { ?>
            <div class="alert alert-info">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-info"></i> Alerta!</h4>
                Robo cadastrado com sucesso!
            </div>
        <?php } ?>


        <?php if (isset($_GET["EditBoot"])) { ?>
            <div class="alert alert-danger alert-dismissible">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-info"></i> Alerta!</h4>
                Você não pode acessar essa página. Comece a edição do robô para acessar.
            </div>
        <?php } ?>


        <div id="Form-Add" style="display: none;">
            <div class="box box-primary">
                <div class="box-header with-border">
                    <h3 class="box-title">Adicionar novo Robo</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form role="form" method="POST">
                    <div class="box-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Digite o nome do Robo</label>
                            <input type="text" class="form-control" id="bootname" name="bootname" placeholder="Digite um nome desejado" required>
                        </div>
                        <div class="form-group">
                            <button type="submit" class="btn btn-primary" name="btn-save" onclick="Clean()">Salvar</button>
                            <a class="btn btn-danger" onclick="desactiveForm()">Cancelar</a>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </section>
</div>
<?php

include_once("/strtec/DOM/footer.php");
if (isset($_POST["btn-save"])) {
    $nome = $_POST["bootname"];
    $qnt = $_POST["qntmenu"];
    $check = Boot::checkName($nome);
    if ($check) {
        $boot = new Boot();
        $boot->save($nome);
        echo '<script language= "JavaScript">
        location.href="http://www.strtec.com.br/boot-menu-create.php?nome=' . $nome . '"
        </script>';
        return;
    } else {

        echo '<script language= "JavaScript">
    location.href="http://www.strtec.com.br/Boot.php?check=00"
    </script>';
        return;
    } //fazer else if se der problema interno
}
?>