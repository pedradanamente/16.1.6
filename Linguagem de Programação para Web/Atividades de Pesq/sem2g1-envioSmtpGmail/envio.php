<?php
session_start();
/* Configuração para o PHP.INI 
 * ------------------------------ */
ini_set('display_errors', 1);
ini_set('default_charset','UTF-8');
date_default_timezone_set('America/Sao_Paulo');

/* POST
 * ------------------------------ */
if (isset($_POST["Enviar"])) {
    require_once("class.phpmailer.php");
    $_SESSION['smtpUsuario'] = $_POST['smtpUsuario'];
    $_SESSION['smtpSenha'] = $_POST['smtpSenha'];
    $_SESSION['from'] = $_POST['from'];
    $_SESSION['Nome'] = $_POST['Nome'];
    $smtpUsuario = $_SESSION['smtpUsuario'];
    $smtpSenha = $_SESSION['smtpSenha'];
    $de_nome		= $_SESSION['Nome'];
    $from		= $_SESSION['from'];
    $Fone		= $_POST["Fone"];
    $subject		= $_POST["subject"];
    $para		= $_POST["para"];
    $Mensagem	= $_POST["Mensagem"];
    $corpo 		= ""
            . "$Mensagem\n\n"
            . "Att $de_nome,\n"
            . "$Fone";
    function smtpmailer($para, $from, $de_nome, $subject, $corpo) { 
            global $error, $smtpUsuario, $smtpSenha;
            $mail = new PHPMailer();
            $mail->IsSMTP();		// Ativar SMTP
            $mail->SMTPDebug = 0;		// Debugar: 1 = erros e mensagens, 2 = mensagens apenas
            $mail->SMTPAuth = true;		// Autenticação ativada
            $mail->SMTPSecure = 'tls';	// SSL REQUERIDO pelo GMail
            $mail->Host = 'smtp.gmail.com';	// SMTP utilizado
            $mail->Port = 587;  		// A porta 587 deverá estar aberta em seu servidor
            $mail->Username = $smtpUsuario;
            $mail->Password = $smtpSenha;
            $mail->SetFrom($from, $de_nome);
            $mail->Subject = $subject;
            $mail->Body = $corpo;
            $mail->AddAddress($para);
            if(!$mail->Send()) {
                    $error = '<div class="sent">Mail error: '.$mail->ErrorInfo.'</div>'; 
                    return false;
            } else {
                    $error = '<div class="sent">Enviado com sucesso!</div>';
                    return true;
            }
    }
    if (smtpmailer($para, $from, $de_nome, $subject, $corpo)) {
        //sent
    }
    if (!empty($error)) echo $error;
}
?>

<!-- Formulário
--------------------------------- -->
<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
	<meta name="author" content="André Silveira Machado" />
        <title>SMTP GMAIL</title>
        <style>
            body { margin:0px;padding:0px; font-family:Arial,Tahoma,Ubuntu;font-size:12px;color:white;background-color:gray; }
            p { margin:4px; }
            label { font-size: 12px; font-family: Arial;}
            a:link { text-decoration:none; }
            textarea { font-size:12px;border:1px solid rgba(255,255,255,0.5);height:100px;width:875px;margin-left:0px;background-color:rgba(0,0,0,0.4);color:yellow;padding:5px; }
            button { font-size:12px;height:25px;width:80px; border:1px solid rgba(255,255,255,0.5);padding-left:5px;padding-right:5px; background-color:rgba(0,0,0,0.4);color:yellow; }
            input { font-size:12px;height:20px; border:1px solid rgba(255,255,255,0.5);padding-left:5px;padding-right:5px; background-color:rgba(0,0,0,0.4);color:yellow; }
            #BASE { width:900px;margin:0 auto;border:1px solid rgba(0,0,0,0.3);background-color:rgba(255,255,255,0.2);padding:0px; }
            #TOPO { background-color:rgba(255,255,255,0.6);min-height:40px;border:1px solid rgba(255,255,255,0.4);color:black;padding:0 5px 0 5px;margin:0px; }
            #SMTP { min-height:200px; }
            .Topic { border-bottom:1px solid gray; padding:10px; font-size:16px; color:white;  }
            .Topic:hover { color:blue; background-color:rgba(255,255,255,0.8); }
            .remetente { width:440px; background-color:rgba(0,0,0,0.1);height: 185px;margin:0px;padding:5px;border-bottom:1px solid gray; }
            .destinatario { width:440px; background-color:rgba(0,0,0,0.1);height: 185px;margin:0px;padding:5px;border-bottom:1px solid gray; }
            .corpo { width:890px;clear:both;padding:5px 5px 5px 5px;min-height:100px; }
            .sent { font-family:Tahoma,Arial;font-size:12px;padding:10px;min-height:20px;width:100%;background-color:rgba(250,128,114,0.4);color:white;margin-bottom:10px;border-bottom:1px solid gray; }
            .fl { float:left; }
            .fr { float:right; }
        </style>
        <script>function formFromSame() {  variavel = document.getElementById("smtpUsuario").value; document.getElementById("from").value = variavel; } </script>
    </head>
    <body>
    <div id="BASE">
        <div id="TOPO">
            <p><strong>Atividade de pesq. #03 - SMTP - Envio de e-mails por Smtp do Gmail</strong></p>
            <p><strong>Referência da pesquisa:</strong> <a href="http://www.gn10.com.br/blog/dicas/envie-emails-php-smtp-gmail-google-apps/" target="_blank"><span  class="referencia">http://www.gn10.com.br/blog/dicas/envie-emails-php-smtp-gmail-google-apps/</span></a></p>
       </div>
        <a href="#"><div class="Topic"><strong>SMTP GMAIL</strong></div></a>
        <div id="SMTP">
            <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
                <div class="remetente fl">
                    <p><strong>REMETENTE</strong></p>
                    <table>
                        <tr>
                            <td><label for="smtpUsuario">Usuário (Smtp):</label></td>
                            <td><input id="smtpUsuario" onchange="formFromSame();" type="email" name="smtpUsuario" size="35" placeholder="exemplo@gmail.com" <?php if (isset($_SESSION['smtpUsuario'])) { ?> value="<?php echo $_SESSION['smtpUsuario']; ?>" <?php } ?> required/></td>
                        </tr>
                        <tr>
                            <td><label for="smtpSenha">Senha (Smtp):</label></td>
                            <td><input type="password" name="smtpSenha" size="35" <?php if (isset($_SESSION['smtpSenha'])) { ?> value="<?php echo $_SESSION['smtpSenha']; ?>" <?php } ?> required/></td>
                        </tr>
                        <tr>
                            <td><label for="from">Reply To:</label></td>
                            <td><input id="from" type="email" name="from" size="35" <?php if (isset($_SESSION['from'])) { ?> value="<?php echo $_SESSION['from']; ?>" <?php } ?> required/></td>
                        </tr>
                        <tr>
                            <td><label for="Nome">Nome:</label></td>
                            <td><input type="text" name="Nome" size="35" <?php if (isset($_SESSION['Nome'])) { ?> value="<?php echo $_SESSION['Nome']; ?>" <?php } ?> required/></td>
                        </tr>
                        <tr>
                            <td><label for="Fone">Telefone:</label></td>
                            <td><input type="tel" name="Fone" size="35" required/></td>
                        </tr>
                    </table>
                </div>
                <div class="destinatario fl">
                    <p><strong>DESTINATÁRIO</strong></p>
                    <table>
                        <tr>
                            <td><label for="para">E-mail:</label></td>
                            <td><input type="email" name="para" size="35" required/></td>
                        </tr>
                    </table>
                </div>
                <div class="corpo">
                    <table>
                        <tr>
                            <td><label for="subject">Assunto:</label></td>
                            <td><input style="width:520px;" type="text" name="subject" size="35" required/></td>
                        </tr>
                    </table>
                    <p><strong>MENSAGEM</strong></p>
                    <textarea name="Mensagem" rows="8" cols="40" maxlength="1024"></textarea>
                    <p>Sem suporte a códigos html</p>
                    <div style="clear:both;"></div>
                    <hr/>
                    <button class="fr" name="Enviar">Enviar</button>
                    <div style="clear:both;"></div>
                </div>
            </form>
        </div>
    </div>
    </body>
</html>