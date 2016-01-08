### Exemplo sortear_func ###

CREATE PROCEDURE sortear_func(IN quantidade INT)
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
	select * from funcionario order by rand() limit quantidade;
END

### Executando a procedure conta_func ###

call sortear_func(5);

#########################################################
#########################################################


### Exemplo conta_func ###

CREATE DEFINER=`root`@`localhost` PROCEDURE `conta_func`(OUT `quantidade` VARCHAR(50), IN `cargo` VARCHAR(50))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
	select concat(c.nome,': ',count(f.id)) INTO quantidade from funcionario f, cargo c 
		where f.cargo_id = c.id and c.nome = cargo;
END;


### Executando a procedure conta_func ###

call conta_func(@qtd,"Gerente");
select @qtd;

#########################################################
#########################################################


### Exemplo elevar_ao_quadrado ###

CREATE PROCEDURE elevar_ao_quadrado(INOUT numero INT)
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
	select numero * numero into numero;
END

### Executando a procedure elevar_ao_quadrado ###

set @num = 3;
call elevar_ao_quadrado(@num);
select @num;

#########################################################
#########################################################