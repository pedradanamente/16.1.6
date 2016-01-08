#Exerc�cio 01

create view vw_continente as 
select continent, sum(population) from country group by continent;

#Exerc�cio 02

create view vw_saldo as 
select agencia_numero, conta_numero, saldo(agencia_numero, conta_numero) from conta;

#Exerc�cio 03

alter view vw_saldo as 
select cliente.nome, conta.agencia_numero, conta.conta_numero, saldo(agencia_numero, conta_numero) as saldo 
from conta, cliente where conta.cliente_id = cliente.id;