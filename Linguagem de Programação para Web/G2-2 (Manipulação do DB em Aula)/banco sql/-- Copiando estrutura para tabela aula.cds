-- Copiando estrutura para tabela aula.cds
CREATE TABLE IF NOT EXISTS `cds` (
  `idCd` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCd` varchar(50) NOT NULL,
  `emStock` int(10) unsigned NOT NULL,
  `emEncomenda` int(10) unsigned NOT NULL,
  `emReserva` int(10) unsigned NOT NULL,
  `Genero` enum('Classical','Popular') NOT NULL,
  `Categoria` varchar(20) NOT NULL,
  `RowUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idCd`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela aula.cds: 24 rows
/*!40000 ALTER TABLE `cds` DISABLE KEYS */;
INSERT INTO `cds` (`idCd`, `nomeCd`, `emStock`, `emEncomenda`, `emReserva`, `Genero`, `Categoria`, `RowUpdate`) VALUES
	(1aula, 'Bloodshot', 10, 5, 3, 'Popular', 'Rock', '2014-10-13 10:40:35'),
	(2, 'The Most Favorite Opera Duets', 10, 5, 3, 'Classical', 'Opera', '2014-10-13 10:40:35'),
	(3, 'New Orleans Jazz', 17, 4, 1, 'Popular', 'Jazz', '2014-10-13 10:40:35'),
	(4, 'Music for Ballet Class', 9, 4, 2, 'Classical', 'Dance', '2014-10-13 10:40:35'),
	(5, 'Music for Solo Violin', 24, 2, 5, 'Classical', 'General', '2014-10-13 10:40:35'),
	(6, 'Cie li di Toscana', 16, 6, 8, 'Classical', 'Vocal', '2014-10-13 10:40:35'),
	(7, 'Mississippi Blues', 2, 25, 6, 'Popular', 'Blues', '2014-10-13 10:40:35'),
	(8, 'Pure', 32, 3, 10, 'Popular', 'Jazz', '2014-10-13 10:40:35'),
	(9, 'Mud on the Tires', 12, 15, 13, 'Popular', 'Country', '2014-10-13 10:40:35'),
	(10, 'The Essence', 5, 20, 10, 'Popular', 'New Age', '2014-10-13 10:40:35'),
	(11, 'Embrace', 24, 11, 14, 'Popular', 'New Age', '2014-10-13 10:40:35'),
	(12, 'The Magic of Satie', 42, 17, 17, 'Classical', 'General', '2014-10-13 10:40:35'),
	(13, 'Swan Lake', 25, 44, 28, 'Classical', 'Dance', '2014-10-13 10:40:35'),
	(14, '25 Classical Favorites', 32, 15, 12, 'Classical', 'General', '2014-10-13 10:40:35'),
	(15, 'La Boheme', 20, 10, 5, 'Classical', 'Opera', '2014-10-13 10:40:35'),
	(16, 'Bach Cantatas', 23, 12, 8, 'Classical', 'General', '2014-10-13 10:40:35'),
	(17, 'Golden Road', 23, 10, 17, 'Popular', 'Country', '2014-10-13 10:40:35'),
	(18, 'Live in Paris', 18, 20, 10, 'Popular', 'Jazz', '2014-10-13 10:40:35'),
	(19, 'Richland Woman Blues', 22, 5, 7, 'Popular', 'Blues', '2014-10-13 10:40:35'),
	(20, 'Morimur (after J. S. Bach)', 28, 17, 16, 'Classical', 'General', '2014-10-13 10:40:35'),
	(21, 'The Best of Italian Opera', 10, 35, 12, 'Classical', 'Opera', '2014-10-13 10:40:35'),
	(22, 'Runaway Soul', 15, 30, 14, 'Popular', 'Blues', '2014-10-13 10:40:35'),
	(23, 'Stages', 42, 0, 8, 'Popular', 'Blues', '2014-10-13 10:40:35'),
	(24, 'Bach: Six Unaccompanied', 16, 8, 8, 'Classical', 'General', '2014-10-13 10:40:35');