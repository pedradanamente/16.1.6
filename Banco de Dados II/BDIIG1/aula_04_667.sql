-- --------------------------------------------------------
-- Servidor:                     localhost
-- Versão do servidor:           5.6.17 - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura para tabela bd2a4.itensvenda
CREATE TABLE IF NOT EXISTS `itensvenda` (
  `venda_id` int(11) NOT NULL AUTO_INCREMENT,
  `produto_id` int(11) unsigned NOT NULL,
  `qtd` int(11) NOT NULL,
  PRIMARY KEY (`venda_id`,`produto_id`),
  KEY `FK_itensvenda_produtos` (`produto_id`),
  CONSTRAINT `FK_itensvenda_produtos` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela bd2a4.itensvenda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `itensvenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `itensvenda` ENABLE KEYS */;


-- Copiando estrutura para tabela bd2a4.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `estoque` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela bd2a4.produtos: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`id`, `nome`, `estoque`) VALUES
	(1, 'Feijão', 10),
	(2, 'Arroz', 5),
	(3, 'Farinha', 15);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;


/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
