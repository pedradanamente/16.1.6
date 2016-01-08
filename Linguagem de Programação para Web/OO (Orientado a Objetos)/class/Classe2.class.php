<?php
class Classe2 extends Classe1 {

	public function bomDia() {
		echo "<hr/><strong>Chamando a função da Classe 1 dentro da Classe 2:</strong><hr/>";
		Classe1::bomDia();

		echo "<hr/><strong>Mostrando atributos da Classe 1 dentro da Classe 2:</strong><hr/>";
		print "Classe2 {$this -> var1} <hr/>";
		print "Classe2 {$this -> var2} <hr/>";
		print "Classe2 {$this -> var3} <hr/>";
	}

}

?>