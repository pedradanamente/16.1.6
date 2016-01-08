<img class="fl" src="imagens/inicial.png" width="100" height="100"/>
<h1 >Alter (ou Alterar Objeto)</h1>
<hr/>
<button class="mostrar" onclick="MENU_OPENCLOSE()">DETALHES</button>
<div id="details" class="details">
	<ul>
		<li><strong>Subconjunto:</strong> DDL - Linguagem de Definição de Dados</li>
		<li><strong>Função:</strong> Alterar Objeto</li>
		<li><strong>Descrição do comando:</strong> permite ao usuário alterar um objeto, por exemplo adicionar, deletar, ou modificar uma coluna a uma tabela existente.</li>
		<li>
			<strong>Exemplo:</strong>
			<p>Para adicionar uma coluna na tabela, use a seguinte sintaxe:</p>
		<pre>
		ALTER TABLE table_name
		ADD column_name datatype
		</pre>
			<p>Para excluir uma coluna na tabela, use a seguinte sintaxe:</p>
		<pre>
		ALTER TABLE table_name
		DROP COLUMN column_name
		</pre>
			<p>Para mudar o tipo dos dados de uma coluna na tabela, use a seguinte sintaxe:</p>
			
			<strong>SQL Server / MS Access:</strong>
		<pre>
		ALTER TABLE table_name
		ALTER COLUMN column_name datatype
		</pre>
			<strong>MySQL / Oracle:</strong>
		<pre>
		ALTER TABLE table_name
		MODIFY COLUMN column_name datatype
		</pre>
			<strong>Oracle 10G and later:</strong>
		<pre>
		ALTER TABLE table_name
		MODIFY column_name datatype
		</pre>
		</li>
	</ul>
	<hr/>
</div>
<div style="height:50px;"></div>