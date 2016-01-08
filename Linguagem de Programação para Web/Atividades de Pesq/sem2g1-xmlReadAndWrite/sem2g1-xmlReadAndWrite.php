<?php
/* Configuração para o PHP.INI 
 * ------------------------------ */
ini_set('display_errors', 1);
ini_set('default_charset','UTF-8');
date_default_timezone_set('America/Sao_Paulo');

/* Configuração do Script
 * ------------------------------ */
$diretorio="arquivos/";

/* Funções
 * ------------------------------ */
function Read($arquivo) {
    $dom = new DOMDocument();
    $dom->load($arquivo);
    $books = $dom->getElementsByTagName( "book" );
    echo "<br/>Conteúdo do arquivo xml:";
    foreach ($books as $book)  {
        $authors = $book->getElementsByTagName( "author" );
        $author = $authors->item(0)->nodeValue;
        $publishers = $book->getElementsByTagName( "publisher" );
        $publisher = $publishers->item(0)->nodeValue;
        $titles = $book->getElementsByTagName( "title" );
        $title = $titles->item(0)->nodeValue;
        echo "<pre>";
        echo "<strong>Título:</strong> $title - <strong>Autor:</strong> $author - <strong>Publicador:</strong> $publisher <br/>";
        echo "</pre>";
    }
}
function Write($title1,$title2,$author1,$author2,$publisher1,$publisher2) {
    $books = array();
    $books [] = array(
    'title' => $title1,
    'author' => $author1,
    'publisher' => $publisher1
    );
    $books [] = array(
    'title' => $title2,
    'author' => $author2,
    'publisher' => $publisher2
    );

    $dom = new DOMDocument();
    $dom->formatOutput = true;

    $r = $dom->createElement( "books" );
    $dom->appendChild( $r );

    foreach( $books as $book )
    {
    $b = $dom->createElement( "book" );

    $author = $dom->createElement( "author" );
    $author->appendChild(
    $dom->createTextNode( $book['author'] )
    );
    $b->appendChild( $author );

    $title = $dom->createElement( "title" );
    $title->appendChild(
    $dom->createTextNode( $book['title'] )
    );
    $b->appendChild( $title );

    $publisher = $dom->createElement( "publisher" );
    $publisher->appendChild(
    $dom->createTextNode( $book['publisher'] )
    );
    $b->appendChild( $publisher );

    $r->appendChild( $b );
    }
    
    global $diretorio;
    $fileSave = rand(100000000, 900000000).".xml";
    $dir_fileSave=$diretorio.$fileSave;
    $fp = fopen($dir_fileSave, "a");
    $escreve = fwrite($fp, $dom->saveXML());
    fclose($fp);
            
    echo "<div style='min-height:100px;background-color:rgba(255,255,255,0.2);margin-top:15px;padding:5px;border:1px solid gray;margin-bottom:15px;'>";
    echo "<div style='font-weight:bold;color:yellow;'>Xml gerado com sucesso!<br/>Nome do arquivo: $fileSave</div>";
    echo "<pre style='color:yellow;'>".$dom->saveXML()."</pre>";
    echo "</div>";    
}

/* put your code here
 * ------------------------------ */
?>

<!-- Formulário HTML
--------------------------------- -->
<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
	<meta name="author" content="André Silveira Machado" />
        <title>sem2g1-xmlReadAndWrite</title>
        <style>
            body { background-color:#838b83;font-family:Ubuntu,Tahoma,Arial;font-size:14px;color:white; }
            h3 { margin:0px;padding:0px;font-family:Ubuntu,Tahoma,Arial; }
            p { margin-top:0px;margin-bottom:0px;padding-top:0px;padding-bottom:0px; }
            hr { clear:both; }
            a { color:white; text-decoration: none; }
            a:visited { color:white; }
            a:hover { color:yellow; }
            input { padding:4px 4px 4px 4px; background-color:rgba(0,0,0,0.8);color:gold;border:1px solid gray; }
            button { margin-bottom:10px;width:100px;height:30px;font-family:Arial;background-color:rgba(0,0,0,0.8);border:1px solid rgba(255,255,255,0.4);color:white;font-size:14px;clear:both; }
            .fl { float:left; }
            .fr { float:right; }
            .TopicXml { margin:-10px;padding:10px;height:20px; }
            .TopicXml:hover { background-color:rgba(255,255,255,0.8);color:blue; }
            .referencia { color:black; }
            .referencia:hover { color:blue; }
            #BASE { width:900px;margin:0 auto; }
            #TOPO { background-color:rgba(255,255,255,0.6);margin-top:0px;min-height:40px;border:1px solid rgba(255,255,255,0.4);color:black;padding:5px;margin-bottom:15px; }
            #READ { background-color:rgba(0,0,0,0.5);margin-top:0px;min-height:20px;border:1px solid rgba(255,255,255,0.4);color:white;padding:10px;margin-bottom:15px; }
            #WRITE { background-color:rgba(0,0,0,0.5);margin-top:0px;min-height:20px;border:1px solid rgba(255,255,255,0.4);color:white;padding:10px;margin-bottom:15px; }
        </style>
        <script> function formOpen($variavelOpen,$variavelClose) { document.getElementById($variavelOpen).style.display = "block";document.getElementById($variavelClose).style.display = "none"; } </script>
    </head>
    <body>
        <div id="BASE">
            <div id="TOPO">
                <p><strong>Atividade de pesq. #02 - XML - Leitura e Escrita de arquivos xml</strong></p>
                <p><strong>Referência da pesquisa:</strong> <a href="http://www.ibm.com/developerworks/br/library/os-xmldomphp/" target="_blank"><span  class="referencia">http://www.ibm.com/developerworks/br/library/os-xmldomphp/</span></a></p>
           </div>
            <div id="READ">
                <a href="#"><div class="TopicXml" onclick="formOpen('formRead','formWrite');"><h3>LEITOR XML</h3></div></a>
                <div id="formRead" style="display:block;">
                <form action="<?php echo $_SERVER['PHP_SELF']; ?>" enctype="multipart/form-data" method="post">
                    <br/>
                    Send this file: <input type="file" name="userfile" />
                    <?php
                    if (isset($_POST["formReadButton"])) {
                        $arquivo=$_FILES['userfile']['tmp_name'];
                        echo "<br/>";
                        if (!empty($arquivo)&&($_FILES['userfile']['type']=="text/xml")) { Read($arquivo); } else { echo "<br/>Faça upload de um arquivo xml!"; }
                    }
                    ?>
                    <div class="fr"><button name="formReadButton">Enviar</button></div>
                </form>
                <hr/>
                <p><strong>Observação:</strong> A leitura só funciona para arquivos xmls com o padrao dos gerados por este script!</p>
            
                </div>
            </div>
            <div id="WRITE">
                <a href="#"><div class="TopicXml" onclick="formOpen('formWrite','formRead');"><h3>GERADOR XML</h3></div></a>
                <div id="formWrite" style="display:none;">
                    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" enctype="multipart/form-data" method="post">
                        <div style="margin-bottom:10px;margin-top:10px;">Este exemplo gera um arquivo xml com dois livros que contém três caracteristicas, preencha elas:</div>
                        <div>
                            <p class="fl" style="margin-right:20px;margin-top:4px;"><strong>Livro 1 ---></strong></p>
                            <label>Titulo:</label><input type="text" name="title1" value="z" required/>
                            <label>Autor:</label><input type="text" name="author1" value="x" required/>
                            <label>Publicador:</label><input type="text" name="publisher1" value="y" required/>
                        </div>
                        <div>
                            <p class="fl" style="margin-right:20px;margin-top:4px;"><strong>Livro 2 ---></strong></p>
                            <label>Titulo:</label><input type="text" name="title2" value="z" required/>
                            <label>Autor:</label><input type="text" name="author2" value="y" required/>
                            <label>Publicador:</label><input type="text" name="publisher2" value="x" required/>
                        </div>
                    <?php
                    if (isset($_POST["formWriteButton"])) {
                        $title1=$_POST["title1"];
                        $title2=$_POST["title2"];
                        $author1=$_POST["author1"];
                        $author2=$_POST["author2"];
                        $publisher1=$_POST["publisher1"];
                        $publisher2=$_POST["publisher2"];
                        Write($title1,$title2,$author1,$author2,$publisher1,$publisher2);
                        echo "<script>formOpen('formWrite','formRead');</script>";
                    }
                    ?>
                        <div class="fr"><button name="formWriteButton">Enviar</button></div>
                    </form>
                    <hr/>
                    <p><strong>Diretório destino do arquivo:</strong> <?php echo $diretorio; ?></p>
                </div>
            </div>
        </div>
    </body>
</html>
