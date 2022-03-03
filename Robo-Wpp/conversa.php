<?php
include_once("/strtec/DOM/header.php");
$contato = Pessoa::finder($_GET["id"]);
$id = $contato[0]["idPessoa"];
$nome = $contato[0]["nome"];
$telefone = $contato[0]["telefone"];
?>
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>
            Conversa: 
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
            <li class="active">Tabela de Contatos</li>
        </ol>
    </section>
    <div class="box box-primary direct-chat direct-chat-primary">
        <div class="box-header with-border">
            <h3 class="box-title">Direct Chat</h3>

    
        </div>
        <!-- /.box-header -->
        <div class="box-body">
            <!-- Conversations are loaded here -->
            <div class="direct-chat-messages">
                <!-- Message. Default to the left -->
                <!-- Menssagem começa aqui -->
                <?php $menssagens = MenssagemBot::find($id);
                      $msgpessoas = MenssagemBot::findMsgPessoa($id);
                if($menssagens == false){

                }else{
                    foreach($menssagens as $menssagem):
                                
               ?>
               <!-- FOREACH AQUI PARA COLOCAR AS MENSSAGENS QUE VIERAM ANTES DAS MENSSAGENS DO BOOT -->

                 <!-- Message to the right -->
                 <div class="direct-chat-msg right">
                    <div class="direct-chat-info clearfix">
                        <span class="direct-chat-name pull-right"><?php if ($nome != "") {echo $menssagem["nome"];} else {echo $menssagem["telefone"];} ?></span>
                        <span class="direct-chat-timestamp pull-left"><?php echo $menssagem["data"]; ?> - <?php echo $menssagem["hora"]; ?></span>
                    </div>
                    <!-- /.direct-chat-info -->
                    <img class="direct-chat-img" src="/res/dist/img/user3-128x128.jpg" alt="Message User Image"><!-- /.direct-chat-img -->
                    <div class="direct-chat-text">
                        <?php echo $menssagem["msg"] ;?> 
                    </div>
                    <!-- /.direct-chat-text -->
                </div>

                <div class="direct-chat-msg">
                    <div class="direct-chat-info clearfix">
                        <span class="direct-chat-name pull-left">STR-ROBO</span>
                        <span class="direct-chat-timestamp pull-right"><?php echo $menssagem["dataBot"]; ?> - <?php echo $menssagem["horaBot"]; ?></span>
                    </div>
                    <!-- /.direct-chat-info -->
                    <img class="direct-chat-img" src="/res/dist/img/user1-128x128.jpg" alt="Message User Image"><!-- /.direct-chat-img -->
                    <div class="direct-chat-text">
                        <?php echo $menssagem["msgBot"];?>
                    </div>
                    <!-- /.direct-chat-text -->
                </div>

               

                <?php endforeach; } ?>
                <!-- /.direct-chat-msg -->
            </div>
            <!--/.direct-chat-messages-->            
            <!-- /.direct-chat-pane -->
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
            <form action="#" method="post">
                <div class="input-group">
                    <input type="text" name="message" placeholder="Type Message ..." class="form-control">
                    <span class="input-group-btn">
                        <button type="submit" class="btn btn-primary btn-flat">Send</button>
                    </span>
                </div>
            </form>
        </div>
        <!-- /.box-footer-->
    </div>


    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
<?php
include_once("/strtec/DOM/footer.php")
?>