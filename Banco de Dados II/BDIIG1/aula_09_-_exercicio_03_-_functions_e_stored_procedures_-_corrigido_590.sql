### Exercício 01 ###

CREATE PROCEDURE listar_atrasos()

BEGIN
	select u.nome, e.dtadevolucao, datediff(curdate(), e.dtadevolucao) as dias_atraso 
	from usuario u, emprestimo e 
	where e.usuario_id = u.id and e.dtadevolvido is null and e.dtadevolucao < curdate();
END


CALL listar_atrasos();


### Exercício 02 ###

CREATE FUNCTION classifica_produto(qtd_estoque INT) RETURNS varchar(15)

BEGIN
	if(qtd_estoque between 0 and 5) then
		return 'Crítico';
	elseif (qtd_estoque between 6 and 25) then
		return 'Normal';
	else
		return 'Excesso';
	end if;
END


select nome, estoque, classifica_produto(estoque) from produtos;


### Exercício 03 ###

CREATE PROCEDURE aumenta_salarios(IN cargo_aumento INT, IN percentual_aumento FLOAT(7,2))

BEGIN
	update funcionario set salario = salario + (salario * percentual_aumento / 100)
		where cargo_id = cargo_aumento;
END


select * from funcionario where cargo_id = 2;
select * from funcionario where cargo_id = 2;
call aumenta_salarios(2,10);