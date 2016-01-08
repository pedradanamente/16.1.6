CONFIGURAÇÃO DO APACHE
httpd.conf::
1) rewrite module descomentar ---> url amigavel

2) error document ---> responsavel por paginas de erro personalizadas

3) Diretório dos documentos par leitura do apache
Root Document e Directory:
Linha 189: DocumentRoot "C:/htdocs"
Linha 216: <Directory "C:/htdocs">

4) Nome do aplicativo
wamp server --- aplicativo

CONFIGURAÇÃO DO PHP
php.ini::
Linha 174: short_open_tag = on //tags basicas do php
Linha 440: max_execution_time = 30 //tempo maximo para submeter uma tarefa
Linha 450: max_input_time = 60 //Tempo maximo para submeter em formularios tempo de upload
Linha 531: display_errors = On //Mostrar erros
Linha 514: error_reporting = E_ALL | E_STRICT //Tipos de erros ---> Definir para: E_ALL & E_DEPRECATED & E_NOTICE
Linha 879: upload_max_filesize = 128M //Tamanho máximo de um arquivo 128M (padrão: 2M)
Linha 882: max_file_uploads = 20 //Numero maximo de uploads simultaneos