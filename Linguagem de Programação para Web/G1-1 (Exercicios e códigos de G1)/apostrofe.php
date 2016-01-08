<?php ini_set('default_charset','UTF-8'); ?>
<?php
$output = shell_exec(ls -al);
$output = `ls -al`;
echo "<pre>Apóstrofe: $output</pre>";
?> 