<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <title>FORMULÁRIO</title>
        <style>
            body { font-size:12px;font-family:Arial,Tahoma;background-color:#696969;color:white;margin:0px;padding:0px; }
            a { color:rgba(255,255,255,0.9); }
            a:visited { color:white; }
            a:hover {  }
            p { }
            ul { margin:0px;padding:0px;list-style-type:none; }
			.alunos {border:1px solid gray;width:400px;float:left;padding:15px;margin-bottom:10px;}
            .fl { float:left; }
            .fr { float:right; }
            .li-up { height:20px;width:100px;border:1px solid rgba(0,0,0,0.0); font-size:11px;padding:8px 5px 2px 5px; margin:0px 0px 0px 0px;letter-spacing: 2px;background-color:rgba(0,0,0,0.0);text-align:center; }
            .li-up:hover { border-bottom: 1px solid rgba(255,255,255,0.2);margin-top:0px;background-color:rgba(0,0,0,0.4);height:19px; }
            .active { border-bottom: 1px solid rgba(255,255,255,0.1);margin-top:0px;background-color:rgba(0,0,0,0.2);height:19px; }
            .menu-up { min-height:0px;font-family:Tahoma,Arial;font-size:11px;color:rgba(255,255,255,0.7);padding:0px; }
            .copyright { text-align:center;padding:15px;font-family:Tahoma,Arial;font-size:11px;color:rgba(255,255,255,0.6); }
            #BASE { padding:0px;width:900px; min-height:200px;background-color:rgba(0,0,0,0.3);margin:0 auto;border-bottom:1px solid rgba(255,255,255,0.2);border-left:1px solid rgba(255,255,255,0.2);border-right:1px solid rgba(255,255,255,0.2); }
            #SUPERIOR { margin:0px;height:30px;width:100%;padding:0px;background-color:rgba(0,0,0,0.4);border-bottom:1px solid rgba(255,255,255,0.2); }
            #TOPO { margin:0 auto;width:900px;height:30px;background-color:rgba(0,0,0,0.2); }
            #CONTEUDO { padding:15px;min-height:150px;background-color:rgba(0,0,0,0.0); }
            #RODAPE { min-height:50px;background-color:rgba(0,0,0,0.1);border-top:1px solid rgba(255,255,255,0.1); }
        </style>
    </head>
    <body>
        <div id="SUPERIOR">
            <div id="TOPO">
                <div class="menu-up">
                    <ul>
                        <a href="#"><li class="li-up fr active">FORMULÁRIO</li></a>
                    </ul>
                </div>
            </div>
        </div>
        <div id="BASE">
            <div id="CONTEUDO">
				<h2>ATIVIDADE II DE LINGUAGEM DE PROGRAMAÇÃO PARA WEB</h2>
				<hr/>
				<form action="processa.php" method="post">
					<!-- FORMULARIO DO ALUNO 1
					-------------------------------------------------------------------- -->
					<div class="alunos fl">
						<h3>Aluno 01</h3>
						<table>
							<tr>
								<td>Nome:</td>
								<td><input type="text" name="nome1" required value="Petruquio" /></td>
							</tr>
							<tr>
								<td>Idade</td>
								<td><input type="number" min="1" max="100" name="idade1" value="80" required/></td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Sexo:</td>
								<td>
									<input type="radio" id="masculino" name="sexo1" value="masculino" checked/>
									<label for="masculino">Masculino</label>
								</td>
								<td>
									<input type="radio" id="feminino" name="sexo1" value="feminino"/>
									<label for="feminino">Feminino</label>
								</td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Curso:</td>
								<td>
									<select name="curso1">
										<option value="Sistemas de Informação">Sistemas de Informação</option>
										<option value="Administração">Administração</option>
										<option value="Ciencias Contábeis">Ciencias Contábeis</option>
									</select>
								</td>
							</tr>
						</table>
					</div>
					<!-- FORMULARIO DO ALUNO 2
					-------------------------------------------------------------------- -->
					<div class="alunos fr">
						<h3>Aluno 02</h3>
						<table>
							<tr>
								<td>Nome:</td>
								<td><input type="text" name="nome2" Value="Dedé" required/></td>
							</tr>
							<tr>
								<td>Idade</td>
								<td><input type="number" min="1" max="100" name="idade2" value="55" required/></td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Sexo:</td>
								<td>
									<input type="radio" id="masculino" name="sexo2" value="masculino" checked/>
									<label for="masculino">Masculino</label>
								</td>
								<td>
									<input type="radio" id="feminino" name="sexo2" value="feminino"/>
									<label for="feminino">Feminino</label>
								</td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Curso:</td>
								<td>
									<select name="curso2">
										<option value="Sistemas de Informação">Sistemas de Informação</option>
										<option value="Administração">Administração</option>
										<option value="Ciencias Contábeis">Ciencias Contábeis</option>
									</select>
								</td>
							</tr>
						</table>
					</div>
					<!-- FORMULARIO DO ALUNO 3
					-------------------------------------------------------------------- -->
					<div class="alunos fl">
						<h3>Aluno 03</h3>
						<table>
							<tr>
								<td>Nome:</td>
								<td><input type="text" name="nome3" value="Didi" required/></td>
							</tr>
							<tr>
								<td>Idade</td>
								<td><input type="number" min="1" max="100" name="idade3" value="45" required/></td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Sexo:</td>
								<td>
									<input type="radio" id="masculino" name="sexo3" value="masculino" checked/>
									<label for="masculino">Masculino</label>
								</td>
								<td>
									<input type="radio" id="feminino" name="sexo3" value="feminino"/>
									<label for="feminino">Feminino</label>
								</td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Curso:</td>
								<td>
									<select name="curso3">
										<option value="Sistemas de Informação">Sistemas de Informação</option>
										<option value="Administração">Administração</option>
										<option value="Ciencias Contábeis">Ciencias Contábeis</option>
									</select>
								</td>
							</tr>
						</table>
					</div>
					<!-- FORMULARIO DO ALUNO 4
					-------------------------------------------------------------------- -->
					<div class="alunos fr">
						<h3>Aluno 04</h3>
						<table>
							<tr>
								<td>Nome:</td>
								<td><input type="text" name="nome4" value="Zacarias" required/></td>
							</tr>
							<tr>
								<td>Idade</td>
								<td><input type="number" min="1" max="100" name="idade4" value="50" required/></td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Sexo:</td>
								<td>
									<input type="radio" id="masculino" name="sexo4" value="masculino" checked/>
									<label for="masculino">Masculino</label>
								</td>
								<td>
									<input type="radio" id="feminino" name="sexo4" value="feminino"/>
									<label for="feminino">Feminino</label>
								</td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Curso:</td>
								<td>
									<select name="curso4">
										<option value="Sistemas de Informação">Sistemas de Informação</option>
										<option value="Administração">Administração</option>
										<option value="Ciencias Contábeis">Ciencias Contábeis</option>
									</select>
								</td>
							</tr>
						</table>
					</div>
					<!-- FORMULARIO DO ALUNO 5
					-------------------------------------------------------------------- -->
					<div class="alunos fl">
						<h3>Aluno 05</h3>
						<table>
							<tr>
								<td>Nome:</td>
								<td><input type="text" name="nome5" value="Mussum" required/></td>
							</tr>
							<tr>
								<td>Idade</td>
								<td><input type="number" min="1" max="100" name="idade5" value="40" required/></td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Sexo:</td>
								<td>
									<input type="radio" id="masculino" name="sexo5" value="masculino" checked/>
									<label for="masculino">Masculino</label>
								</td>
								<td>
									<input type="radio" id="feminino" name="sexo5" value="feminino"/>
									<label for="feminino">Feminino</label>
								</td>
							</tr>
						</table>
						<table>
							<tr>
								<td>Curso:</td>
								<td>
									<select name="curso5">
										<option value="Sistemas de Informação">Sistemas de Informação</option>
										<option value="Administração">Administração</option>
										<option value="Ciencias Contábeis">Ciencias Contábeis</option>
									</select>
								</td>
							</tr>
						</table>
					</div>
					<div style="clear:both;">
						<hr/>
						<button class="fr" name="enviar">Enviar</button>
					</div>
				</form>
				<div style="clear:both;"></div>
			</div>
            <div id="RODAPE"><div class="copyright">Desenvolvido por André Silveira Machado</div></div>
        </div>
        
    </body>
</html>
