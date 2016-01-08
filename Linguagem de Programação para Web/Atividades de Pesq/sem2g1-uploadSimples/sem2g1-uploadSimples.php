<?php
/* Configuração para o PHP.INI 
 * ------------------------------ */
ini_set('display_errors', 1);
ini_set('default_charset','UTF-8');

/* Configuração do Script de Upload 
 * ------------------------------ */
$uploaddir = "uploads/"; //diretorio ex: "images/"
$tamanho_maximo = 3000000; //tamanho máximo do arquivo

/* Script de Upload 
 * ------------------------------ */
if (isset($_POST["envio"])) {
    $uploadfile = $uploaddir . $_FILES['userfile']['name'];
    if (move_uploaded_file($_FILES['userfile']['tmp_name'], $uploaddir . $_FILES['userfile']['name'])) {
        echo "<div style='font-size:12px;font-family:Tahoma;color:blue;'><strong>O arquivo é valido e foi carregado com sucesso.</strong></div>\n";
        if (($_FILES['userfile']['type']=="image/jpeg")||($_FILES['userfile']['type']=="image/png")||($_FILES['userfile']['type']=="image/gif")) { echo "<div><img src='$uploadfile' height='100'/></div>"; }
    } else {
        echo "<div style='font-size:12px;font-family:Tahoma;color:red;'><strong>Possivel ataque de upload!</strong></div>\n";
    }
}
?> 

<!-- Formulário de Upload
--------------------------------- -->
<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
	<meta name="author" content="André Silveira Machado" />
    </head>
    <body>
        <form enctype="multipart/form-data" action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <input type="hidden" name="MAX_FILE_SIZE" value="<?php echo $tamanho_maximo; ?>" />
        Send this file: <input name="userfile" type="file" />
        <input type="submit" name="envio" value="Send File" />
        </form>
        <?php
        if(is_dir($uploaddir)) {
        $instanciadir = dir($uploaddir);
        while($arquivo = $instanciadir->read()) {
            echo '<a href='.$uploaddir.$arquivo.' target="_blank">'.$arquivo.'</a><br />';
        }
        $instanciadir->close();
        }
        else { if (!empty($uploaddir)) { echo '<div style="color:red;font-weight:bold;font-size:12px;font-family:Tahoma;">Diretório de destino '.$uploaddir.' não existe!</div>'; } }
        ?>
        <hr/>
        <p style="margin-top:0px;margin-bottom:4px;font-size:12px;font-family:Tahoma;"><strong>Função do Script:</strong> Upload simples de arquivos sem o uso de banco de dados</p>
    </body>
</html>