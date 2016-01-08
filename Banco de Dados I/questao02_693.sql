/* A lista com todos os clientes ordenada alfabeticamente por estado e depois por cidade. */
select id, nome, uf, cidade from cliente order by uf asc, cidade asc;

/* A lista de clientes que possui o termo "Silo" no final do nome.*/
select id, nome from cliente where nome like '%silo';

/* A lista dos três últimos fretes embarcados, contendo a cidade do remetente, cidade do destinatário, a data do embarque e a data da entrega.*/ 
select id, rem_cidade, dest_cidade, dtaembarque, dtaentrega from frete order by dtaembarque desc limit 3;

/* A lista com todos os fretes cujo destino seja o estado do Rio Grande do Norte. */
select id, dest_uf from frete where dest_uf = 'RN';

/* A lista com todos os fretes cujo destino seja o estado do Rio Grande do Norte e o remetente seja da região SUL. */
select id, dest_uf, rem_uf from frete where dest_uf = 'RN' and (rem_uf = 'RS' or rem_uf = 'SC' or rem_uf = 'PR');
/* ou */ 
select id, dest_uf, rem_uf from frete where dest_uf = 'RN' and rem_uf IN ('RS','SC','PR');

/* A média de peso de todas as cargas. */
select avg(peso) from frete;

/* Cidade e estado do remetente e destinatário cujos fretes foram embarcados no mês de março deste ano. */
select id, rem_uf, rem_cidade, dest_uf, dest_cidade, dtaembarque from frete where dtaembarque between '2015-03-01' and '2015-03-31';

/* A média do valor da carga agrupada por estado de origem. */
select rem_uf, avg(valorcarga) from frete group by rem_uf; 

/* A soma total do valor do frete agrupada por estado de destino. */
select dest_uf, sum(valorfrete) from frete group by dest_uf;

/* A lista de fretes que ainda não foram entregues, apresentando primeiro os que foram embarcados mais recentemente. */
select id, dtaentrega, dtaembarque from frete where dtaentrega is null order by dtaembarque desc;

/* O número total de entregas concluídas. */
select count(dtaentrega) as total_entregas_concluidas from frete where dtaentrega is not null;

/* O estado de origem, o estado de destino e o tempo de entrega (em dias) para cada um dos fretes que já foram entregues. */
select id, rem_uf, dest_uf, datediff(dtaentrega, dtaembarque) from frete where dtaentrega is not null;

/* A lista de estados que enviaram duas ou mais cargas. */
select rem_uf as Estados_Enviaram, count(rem_uf) as Qnt_Cargas from frete group by rem_uf having count(rem_uf) >= 2;

/* O valor do frete mais barato e o valor do frete mais caro. */
select max(valorfrete), min(valorfrete) from frete;

/* A lista de fretes contendo o id do remetente e destinatário, a cidade e estado dos mesmos no formado “Cidade/UF”, as datas de embarque e entrega, o valor da carga e o valor do frete. */
select rem_id, concat(rem_cidade,'/',rem_uf) as 'Cidade/UF Remetente', dest_id, concat(dest_cidade,'/',dest_uf) as 'Cidade/UF Destinatário', dtaembarque, dtaentrega, valorcarga, valorfrete from frete;