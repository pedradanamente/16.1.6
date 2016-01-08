CREATE TABLE profissao (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cargo VARCHAR(25)  NULL,
PRIMARY KEY(id));

CREATE TABLE cliente (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  profissao_id INTEGER UNSIGNED NULL,
  nome VARCHAR(255) NULL,
  dtanasc DATE  NULL,
  fone VARCHAR(15) NULL,
PRIMARY KEY(id),
  FOREIGN KEY(profissao_id)
    REFERENCES profissao(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);
      
INSERT INTO profissao VALUES (1,'Programador');
INSERT INTO profissao VALUES (2,'Analista de Sistemas');
INSERT INTO profissao VALUES (3,'Administrador de BD');
INSERT INTO profissao VALUES (4,'Suporte Técnico');

INSERT INTO cliente VALUES (1,1,'Maria Antônia','1985-10-08','(51) 1234-5032');
INSERT INTO cliente VALUES (2,2,'João Silva','1992-08-30','(51) 5432-1231');
INSERT INTO cliente VALUES (3,4,'José Santos','1990-02-10','(51) 3451-2123');
INSERT INTO cliente VALUES (4,1,'Ana Costa','1988-04-17','(51) 5431-2513');