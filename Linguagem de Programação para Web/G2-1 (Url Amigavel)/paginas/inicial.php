<img class="fl" src="imagens/inicial.png" width="100" height="100"/>
<h1 >Url amigavel</h1>
<hr/>
<p><strong>Referência:</strong> <a href="http://blog.thiagobelem.net/aprendendo-urls-amigaveis/" target="_blank">Blog do Thiago Belem (urls amigaveis)</a></p>
<div>
	<ul type="1">
		<li>Descomentar a linha "<strong>LoadModule rewrite_module modules/mod_rewrite.so</strong>" no httpd.conf</li>
		<li>Criar arquivo .htaccess na pasta raiz da página</li>
		<li>Escrever dentro do .htaccess os redirecionamentos de endereço como o exemplo a seguir: </li>	
	</ul>
	<pre>
	<<nobug/>IfModule mod_rewrite.c>
		RewriteEngine On

		RewriteRule ^inicial/?$ index.php?url=inicial [NC,L]
		RewriteRule ^exemplo/?$ index.php?url=exemplo [NC,L]

		RewriteRule ^insert/?$ index.php?url=insert [NC,L]
		RewriteRule ^update/?$ index.php?url=update [NC,L]
		RewriteRule ^select/?$ index.php?url=select [NC,L]
		RewriteRule ^delete/?$ index.php?url=delete [NC,L]

		RewriteRule ^alter/?$ index.php?url=alter [NC,L]
		RewriteRule ^create/?$ index.php?url=create [NC,L]
		RewriteRule ^drop/?$ index.php?url=drop [NC,L]

		RewriteRule ^grant/?$ index.php?url=grant [NC,L]
		RewriteRule ^revoke/?$ index.php?url=revoke [NC,L]

		RewriteRule ^begin_work/?$ index.php?url=begin_work [NC,L]
		RewriteRule ^commit/?$ index.php?url=commit [NC,L]
		RewriteRule ^rollback/?$ index.php?url=rollback [NC,L]
	<<nobug/>/IfModule>
	</pre>
</div>
<div style="height:50px;"></div>