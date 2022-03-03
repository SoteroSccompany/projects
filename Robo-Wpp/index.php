<?php
include_once('/strtec/DOM/header.php');
if (isset($_GET['id'])) {
  $obj = new Pessoa();
  $obj->exclude($_GET['id']);
}
?>
<!-- Content Wrapper. Contains page content -->
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

  <!-- Main content -->
  <section class="content">

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
              <th>Nome</th>
              <th>Telefone</th>
              <th>Status da conversa</th>
              <th>Ações</th>
            </tr>
          </thead>
          <tbody>
            <?php $conversas = Pessoa::listall();
            if($conversas == 0){
              echo "<td>Não foram encontrando registros no banco de dados =(</td>";
              echo "<td></td>";
              echo "<td></td>";
              echo "<td></td>";
            }else{foreach($conversas as $conversa):            
            ?>
            <tr>
              <td><?php echo $conversa['idPessoa']; ?></td>
              <td><?php if($conversa['nome']==null){echo "nome não adicionado";}else{echo $conversa['nome'];} ?></td>
              <td><?php echo $conversa['telefone']; ?></td>
              <td><?php if($conversa["status"] == "Ativo"){echo"Conversa Ativa";}else if($conversa["status"] == "Inativo"){echo"Conversa Inativa";} ?></td>
              <td>
                <a type="button" class="btn  btn-primary" href="/conversa.php?id=<?php echo $conversa['idPessoa'];?>">Ver Conversa</a>
                <button type="button" class="btn  btn-success">Editar Contato</button>
                <a type="button" class="btn  btn-danger" href="/index.php?id=<?php echo $conversa['idPessoa'];?>">Excluir Contato</a>
              </td>
            </tr>
            <?php endforeach; }?>
          </tbody>
        </table>
  </section>
  <!-- /.content -->
</div>
<!-- /.content-wrapper -->
<?php include_once("/strtec/DOM/footer.php"); ?>