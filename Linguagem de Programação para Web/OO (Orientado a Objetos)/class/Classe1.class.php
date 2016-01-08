<?php
class Classe1 {

	private $var1 = "Olá var1!<hr/>";
	protected $var2 = "Olá var2!<hr/>";
	protected $var3 = "Olá var3!<hr/>";

	public function bomDia() {
		print "Classe1 {$this -> var1} <hr/>";
		print "Classe1 {$this -> var2} <hr/>";
		print "Classe1 {$this -> var3} <hr/>";
	}
	
}

?>