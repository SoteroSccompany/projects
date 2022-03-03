<?php
session_start();
include_once('/strtec/DOM/header.php');
if (isset($_GET['id'])) {
  $id = Pessoa::finder($_GET['id']);
} else {
  $id = null;
}
//isset é se tiver!!
?>
<div class="content-wrapper">
  <!-- Content Header (Page header) -->
  <section class="content-header">
    <h1>
      Pagina de Contatos
      <small>Contatos salvos</small>
    </h1>
    <ol class="breadcrumb">
      <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
      <li class="active">Tabela de Contatos</li>
    </ol>
  </section>
  <section class="content">

    <form class="row g-3" method="POST">
      <!--Pode melhorar, otimizar, colcando em alguma função, etc  -->
      <input type="hidden" name="id-hidden" value="<?php echo $id[0]['idPessoa']; ?>">
      <div class="col-md-6">
        <label for="inputEmail4" class="form-label">Nome</label>
        <input type="text" class="form-control" id="nome" name="nome" value="<?php echo $id[0]['nome']; ?>">
      </div>
      <div class="col-md-6">
        <label for="inputPassword4" class="form-label">Telefone</label>
        <input type="number" class="form-control" id="telefone" name="telefone" value="<?php echo $id[0]['telefone']; ?>">
      </div>
      <div class="col-12">
        <button type="submit" class="btn btn-primary" name="btn">Sign in</button>
      </div>
    </form>
  </section>

  <?php if (isset($_POST['btn'])) {
    if ($_POST['id-hidden'] == null) {
      $obj = new Pessoa();
      $obj->Inserir($_POST['nome'], $_POST['telefone']);
    } else {
      $obj = new Pessoa();
      $obj->editar($_POST['id-hidden'], $_POST['nome'], $_POST['telefone']);
    }
  } ?>