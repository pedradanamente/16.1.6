CREATE TABLE cliente (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(255) NULL,
  email VARCHAR(255) NULL,
  fone VARCHAR(25) NULL,
PRIMARY KEY(id));


CREATE TABLE agencia (
  numero INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(255) NULL,
  cidade VARCHAR(255) NULL,
PRIMARY KEY(numero));


CREATE TABLE conta (
  agencia_numero INTEGER UNSIGNED NOT NULL,
  conta_numero INTEGER UNSIGNED NOT NULL,
  cliente_id INTEGER UNSIGNED NOT NULL,
PRIMARY KEY(conta_numero, agencia_numero),
  FOREIGN KEY(cliente_id)
    REFERENCES cliente(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(agencia_numero)
    REFERENCES agencia(numero)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);


CREATE TABLE movimentacao (
  id INTEGER UNSIGNED  NOT NULL AUTO_INCREMENT,
  agencia_numero INTEGER UNSIGNED NOT NULL,
  conta_numero INTEGER UNSIGNED NOT NULL,
  tipo ENUM('D','C') NULL,
  valor FLOAT(22,2) NULL,
PRIMARY KEY(id),
  FOREIGN KEY(conta_numero, agencia_numero)
    REFERENCES conta(conta_numero, agencia_numero)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);


CREATE TABLE transferencia (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  rem_agencia_numero INTEGER UNSIGNED NOT NULL,
  rem_conta_numero INTEGER UNSIGNED NOT NULL,
  dst_agencia_numero INTEGER UNSIGNED NOT NULL,
  dst_conta_numero INTEGER UNSIGNED NOT NULL,
  valor FLOAT(22,2) NULL,
PRIMARY KEY(id),
  FOREIGN KEY(dst_conta_numero, dst_agencia_numero)
    REFERENCES conta(conta_numero, agencia_numero)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(rem_conta_numero, rem_agencia_numero)
    REFERENCES conta(conta_numero, agencia_numero)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);
      

INSERT INTO `agencia` (`numero`,`nome`,`cidade`) VALUES (101,"AG CDS","Cachoeira do Sul");
INSERT INTO `agencia` (`numero`,`nome`,`cidade`) VALUES (102,"AG SCS","Santa Cruz do Sul");
INSERT INTO `agencia` (`numero`,`nome`,`cidade`) VALUES (103,"AG SM","Santa Maria");


INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (1,"Minerva Zamora","suspendisse@innecorci.ca","+55 51 9462-7182");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (2,"Juliet Watts","ipsum@hymenaeos.net","+55 51 9462-4016");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (3,"Alana Walsh","vitae.diam@quisquenonummy.edu","+55 51 9977-5279");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (4,"Hedda Frazier","dolor@disparturientmontes.com","+55 51 9130-7644");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (5,"Carlos Holden","nulla.magna@eunulla.co.uk","+55 51 9996-7533");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (6,"Allegra Holden","non.leo@pharetra.co.uk","+55 51 9945-2887");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (7,"Guy Parks","purus@loremeu.net","+55 51 9013-9680");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (8,"Melinda Mclaughlin","hymenaeos.ut@augue.edu","+55 51 9736-3251");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (9,"Felicia Zamora","commodo.hendrerit@adipiscingelit.net","+55 51 9657-0142");
INSERT INTO `cliente` (`id`,`nome`,`email`,`fone`) VALUES (10,"Xerxes Whitehead","dictum@ligula.net","+55 51 9662-8540");


INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (103,3001,1);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (101,1001,2);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (103,3002,3);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (101,1002,4);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (101,1003,5);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (102,2001,6);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (101,1004,7);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (101,1005,8);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (102,2002,9);
INSERT INTO `conta` (`agencia_numero`,`conta_numero`,`cliente_id`) VALUES (102,2003,10);


INSERT INTO `movimentacao` (`id`, `agencia_numero`, `conta_numero`, `tipo`, `valor`) VALUES
	(1, 103, 3001, 'C', 1220.35),
	(2, 101, 1001, 'C', 760.21),
	(3, 103, 3002, 'C', 3420.70),
	(4, 101, 1002, 'C', 562.30),
	(5, 101, 1003, 'C', 1670.50),
	(6, 102, 2001, 'C', 905.90),
	(7, 101, 1004, 'C', 132.90),
	(8, 101, 1005, 'C', 360.60),
	(9, 102, 2002, 'C', 4560.30),
	(10, 102, 2003, 'C', 3200.00),
	(11, 103, 3002, 'D', 300.00),
	(12, 103, 3001, 'D', 170.25),
	(13, 101, 1003, 'D', 600.00),
	(14, 102, 2002, 'D', 1230.50),
	(15, 101, 1004, 'C', 900.30),
	(16, 101, 1001, 'D', 150.00),
	(17, 103, 3002, 'C', 150.00);


INSERT INTO `transferencia` (`id`, `rem_agencia_numero`, `rem_conta_numero`, `dst_agencia_numero`, `dst_conta_numero`, `valor`) VALUES
	(1, 101, 1001, 103, 3002, 150.00);
