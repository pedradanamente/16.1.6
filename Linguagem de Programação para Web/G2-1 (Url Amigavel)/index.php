<!doctype html>
<html lang="pt-br">
<head>
	<meta charset="UTF-8">
	<title>Url amigavel</title>
	<link rel="stylesheet" type="text/css" href="http://localhost/lpweb/G2-1/css/andremachado.css"/>
	<script src="http://localhost/lpweb/G2-1/js/andremachado.js"></script>
	<script src="js/jquery1111.min.js"></script>
</head>

<body>
	<div id="fixado">
		<div class="topo">
			<ul>
				<li><a href="inicial"><div>Página Inicial</div></a></li>
			</ul>
			<ul>
				<li><a href="exemplo"><div>Exemplo usando valor variavel</div></a></li>
			</ul>
		</div>
	</div>
	<div id="base">
		<div id="right">
			<div class="menu">
				<ul>
					<li>
						<a href="insert"><div>Insert</div></a>
					</li>
					<li>
						<a href="update"><div>Update</div></a>
					</li>
					<li>
						<a href="select"><div>Select</div></a>
					</li>
					<li>
						<a href="delete"><div>Delete</div></a>
					</li>
				</ul>
			</div>
			<div class="menu">
				<ul>
					<li>
						<a href="alter"><div>Alter</div></a>
					</li>
					<li>
						<a href="create"><div>Create</div></a>
					</li>
					<li>
						<a href="drop"><div>Drop</div></a>
					</li>
				</ul>
			</div>
			<div class="menu">
				<ul>
					<li>
						<a href="grant"><div>Grant</div></a>
					</li>
					<li>
						<a href="revoke"><div>Revoke</div></a>
					</li>
				</ul>
			</div>
			<div class="menu">
				<ul>
					<li>
						<a href="begin_work"><div>Begin Work</div></a>
					</li>
					<li>
						<a href="commit"><div>Commit</div></a>
					</li>
					<li>
						<a href="rollback"><div>Rollback</div></a>
					</li>
				</ul>
			</div>
		</div>
		<div id= "conteudo">
			<?php
			if (isset($_GET['url'])) {
					$url = $_GET['url'];
				if (!file_exists("paginas/$url.php")) {
					$url = "404";
				}
			}else {
				$url = "inicial";
			}
			include("paginas/$url.php");
			?>
		</div>
		<div id = "rodape">
			André Silveira Machado
		</div>
	</div>
</body>
</html>