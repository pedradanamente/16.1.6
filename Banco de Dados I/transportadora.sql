CREATE DATABASE `transportadora`;
USE `transportadora`;


CREATE TABLE IF NOT EXISTS `cidade` (
  `cidade` varchar(55) NOT NULL,
  `uf` char(2) NOT NULL,
  PRIMARY KEY (`cidade`,`uf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `cidade` (`cidade`, `uf`) VALUES
	('Almoço', 'PA'),
	('Anta Gorda', 'RS'),
	('Braço do Trombudo', 'SC'),
	('Coité de Nóia', 'AL'),
	('Coxixola', 'PB'),
	('Dormentes', 'PE'),
	('Entrepelado', 'RS'),
	('Feliz Natal', 'MT'),
	('Jijoca de Jericoacoara', 'CE'),
	('Lagoa da Confusão', 'TO'),
	('Não-Me-Toque', 'RS'),
	('Passa e Fica', 'RN'),
	('Passa Tempo', 'MG'),
	('Pendências', 'RN'),
	('Pintópolis', 'MG'),
	('Sombrio', 'SC'),
	('Uaua', 'BA'),
	('Venha-ver', 'RN');


CREATE TABLE IF NOT EXISTS `cliente` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `uf` char(2) NOT NULL,
  `cidade` varchar(55) NOT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `fone` varchar(15) DEFAULT NULL,
  `email` varchar(55) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cidade` (`cidade`,`uf`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`cidade`, `uf`) REFERENCES `cidade` (`cidade`, `uf`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

INSERT INTO `cliente` (`id`, `uf`, `cidade`, `nome`, `cpf`, `fone`, `email`, `cep`) VALUES
	(1, 'PA', 'Almoço', 'João do Arroz', '362.400.816-97', '(87) 1307-6085', 'joaoarroz@gmail.com', '68633-615'),
	(2, 'RS', 'Anta Gorda', 'Sonia do Feijão', '565.678.697-44', '(74) 9280-4882', 'soniafeijao@gmail.com', '92281-864'),
	(3, 'AL', 'Coité de Nóia', 'Paulo do Silo', '965.676.386-69', '(45) 7212-3348', 'paulosilo@gmail.com', '55653-986'),
	(4, 'BA', 'Uaua', 'Pedro da Soja', '445.926.498-50', '(30) 4462-3011', 'pedrosoja@gmail.com', '46891-181'),
	(5, 'CE', 'Jijoca de Jericoacoara', 'Antonio do Mercado', '958.465.250-64', '(95) 2310-8545', 'antoniomercado@gmail.com', '30052-857'),
	(6, 'MG', 'Passa Tempo', 'Ana do Silo', '615.120.453-89', '(77) 3362-1412', 'anasilo@gmail.com', '58984-274'),
	(7, 'MT', 'Feliz Natal', 'Nicolau do Gado', '372.843.303-67', '(49) 1639-1272', 'nicolaugado@gmail.com', '40228-188'),
	(8, 'MG', 'Pintópolis', 'Ivo do Silo', '617.930.900-70', '(93) 6399-2670', 'ivosilo@gmail.com', '53481-208'),
	(9, 'PB', 'Coxixola', 'Patricia da Batata', '772.718.274-90', '(21) 1743-1266', 'patriciabatata@gmail.com', '24105-477'),
	(10, 'PE', 'Dormentes', 'Fred do Silo', '965.176.581-47', '(90) 4707-4233', 'fredsilo@gmail.com', '66658-898'),
	(11, 'RN', 'Pendências', 'Silvio do Silo', '565.383.118-24', '(59) 7526-9496', 'silviosilo@gmail.com', '59576-181'),
	(12, 'RN', 'Passa e Fica', 'Toni do Abatedouro', '754.250.686-77', '(58) 9034-8458', 'toniabatedouro@gmail.com', '82028-756'),
	(13, 'RN', 'Venha-ver', 'Maria do Silo', '850.906.984-30', '(51) 8570-8288', 'mariasilo@gmail.com', '32363-147'),
	(14, 'RS', 'Não-Me-Toque', 'Junior do Milho', '272.343.801-17', '(56) 2795-4777', 'juniormilho@gmail.com', '56653-489'),
	(15, 'RS', 'Entrepelado', 'Maria da Cebola', '187.300.842-50', '(54) 3184-7410', 'mariacebola@gmail.com', '65150-786'),
	(16, 'SC', 'Braço do Trombudo', 'Silomar do Tomate', '838.755.262-73', '(84) 1280-6893', 'silomartomate@gmail.com', '97977-637'),
	(17, 'SC', 'Sombrio', 'Julieta do Algodão', '136.148.232-61', '(26) 9455-2399', 'julieetalgodao@gmail.com', '15228-545'),
	(18, 'TO', 'Lagoa da Confusão', 'José do Silo', '488.491.892-19', '(95) 3943-7833', 'josesilo@gmail.com', '37544-137');


CREATE TABLE IF NOT EXISTS `frete` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `dest_id` int(10) unsigned NOT NULL,
  `dest_uf` char(2) NOT NULL,
  `dest_cidade` varchar(55) NOT NULL,
  `rem_id` int(10) unsigned NOT NULL,
  `rem_uf` char(2) NOT NULL,
  `rem_cidade` varchar(55) NOT NULL,
  `peso` float(10,2) NOT NULL,
  `dtaembarque` date DEFAULT NULL,
  `dtaentrega` date DEFAULT NULL,
  `valorcarga` float(17,2) DEFAULT NULL,
  `valorfrete` float(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `frete_ibfk_2` (`dest_id`),
  KEY `frete_ibfk_4` (`rem_cidade`,`rem_uf`),
  KEY `frete_ibfk_1` (`rem_id`),
  KEY `frete_ibfk_3` (`dest_cidade`,`dest_uf`),
  CONSTRAINT `frete_ibfk_4` FOREIGN KEY (`rem_cidade`, `rem_uf`) REFERENCES `cidade` (`cidade`, `uf`),
  CONSTRAINT `frete_ibfk_1` FOREIGN KEY (`rem_id`) REFERENCES `cliente` (`id`),
  CONSTRAINT `frete_ibfk_2` FOREIGN KEY (`dest_id`) REFERENCES `cliente` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frete_ibfk_3` FOREIGN KEY (`dest_cidade`, `dest_uf`) REFERENCES `cidade` (`cidade`, `uf`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

INSERT INTO `frete` (`id`, `dest_id`, `dest_uf`, `dest_cidade`, `rem_id`, `rem_uf`, `rem_cidade`, `peso`, `dtaembarque`, `dtaentrega`, `valorcarga`, `valorfrete`) VALUES
	(1, 3, 'AL', 'Coité de Nóia', 1, 'PA', 'Almoço', 7636.00, '2015-01-10', '2015-01-19', 9744624.00, 5489.00),
	(2, 5, 'CE', 'Jijoca de Jericoacoara', 2, 'RS', 'Anta Gorda', 16117.00, '2015-01-25', '2015-02-04', 5451637.00, 4203.00),
	(3, 6, 'MG', 'Passa Tempo', 4, 'BA', 'Uaua', 5676.00, '2015-02-17', '2015-03-05', 8823316.00, 5551.00),
	(4, 12, 'RN', 'Passa e Fica', 7, 'MT', 'Feliz Natal', 13030.00, '2015-03-04', '2015-03-12', 5863668.00, 4147.00),
	(5, 8, 'MG', 'Pintópolis', 9, 'PB', 'Coxixola', 13121.00, '2015-03-28', '2015-04-18', 2748394.00, 5084.00),
	(6, 10, 'PE', 'Dormentes', 14, 'RS', 'Não-Me-Toque', 8518.00, '2015-04-12', '2015-05-06', 6949965.00, 5976.00),
	(7, 11, 'RN', 'Pendências', 15, 'RS', 'Entrepelado', 2228.00, '2015-05-02', '2015-05-30', 4606643.00, 3631.00),
	(8, 13, 'RN', 'Venha-ver', 16, 'SC', 'Braço do Trombudo', 1585.00, '2015-06-03', NULL, 2083322.00, 5227.00),
	(9, 8, 'TO', 'Lagoa da Confusão', 17, 'SC', 'Sombrio', 17240.00, '2015-06-23', NULL, 7395684.00, 4244.00);
