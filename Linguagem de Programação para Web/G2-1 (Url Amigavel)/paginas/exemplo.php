<img class="fl" src="imagens/inicial.png" width="100" height="100"/>
<h1 >Exemplo usando valor variavel</h1>
<hr/>
<p><strong>Referência:</strong> <a href="http://blog.thiagobelem.net/aprendendo-urls-amigaveis-com-regras-complexas/" target="_blank">Blog do Thiago Belem (urls amigaveis com regras complexas)</a></p>
<p>No decorrer da solução de pesquisa encontrei um problema que foi postado no fórum Stack Overflow:</p>
<p><a href="http://pt.stackoverflow.com/questions/37557/url-amig%C3%A1vel-perdendo-estrutura-de-diret%C3%B3rio-para-arquivos-css-e-js?noredirect=1#comment72569_37557" target="_blank">Clique aqui para abrir o link do fórum</a></p>
<p>O motivo de eu não ter arrumado uma alternativa qualquer em objetivo de não perder ponto na avaliação da pesquisa, é que de forma proposital mantenho o código original com problema na url amigavel a partir do problema encontrado mostrar de forma forçada e buscar de cada um sua melhor alternativa junto ao professor na hora de apresentar, tendo como objetivo demonstrar aqui um problema ao fazer urls amigaveis e possiveis soluções, sendo a melhor solução considerada por mim seria fazer caminhos absolutos usando variaveis php segue o exemplo: <a href="http://stackoverflow.com/questions/6768793/get-the-full-url-in-php" target="_blank">clique aqui</a>.</p>
<hr style="margin-bottom:20px;"/>
<?php
if (!isset($_GET['id'])) { 
?>
<div>
	<?php
	$quantidade=rand(10,30);
	for ($i=1;$i<=$quantidade;$i++) {
	?>
	<div style="float:left;border:1px solid gray;width:200px;padding:0px 10px 0px 10px;margin-bottom:10px;margin-left:10px;">
		<p class="fl"><?php echo $i; ?></p>
		<p class="fr"><a href="exemplo/<?php echo $i; ?>">Pesquisar</a></p>
		<div style="clear:both;"></div>
	</div>
	<?php
	}
	?>
</div>
<?php
}else {
?>
<div>
	<h3 style="color:blue;">Você carregou o Id: <?php echo $_GET['id']; ?></h3>
</div>
<?php
}
?>
<div style="clear:both;height:50px;"></div>
