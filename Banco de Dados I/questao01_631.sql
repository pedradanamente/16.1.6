create table paciente(
	id integer not null auto_increment,
	nome varchar(255) not null,
	logradouro varchar(255),
	numero varchar(55),
	bairro varchar(55),
	cep char(9),
	fone varchar(15) not null,
	primary key(id)
);

create table medico(
	id integer not null auto_increment,
	nome varchar(255) not null,
	crm varchar(15) not null,
	fone varchar(15),
	primary key(id)
);

create table exame(
	id integer not null auto_increment,
	nome varchar(255),
	procedimento text not null,
	primary key(id)
);

create table consulta(
	id integer not null auto_increment,
	medico_id integer not null,
	paciente_id integer not null,
	dtahora datetime not null,
	confirmada enum('S','N') not null,
	realizada enum('S','N') not null,
	primary key(id),
	foreign key(medico_id) references medico(id),
	foreign key(paciente_id) references paciente(id)
);

create table consulta_exame(
	id integer not null auto_increment,
	exame_id integer not null,
	consulta_id integer not null,
	resultado text not null,
	primary key(id),
	foreign key(exame_id) references exame(id),
	foreign key(consulta_id) references consulta(id)
);

insert paciente values(
	default,
	'Fulano de Tal',
	'Acacia Avenue',
	'666',
	'Centro',
	'12345-678',
	'51 1234-5678'
);

insert medico values(
	default,
	'Doutor Octopos',
	'1234567890',
	'51 1234-5678'
);

insert exame values(
	default,
	'Eletroencefalograma',
	'Procedimento, procedimento, blablabla, procedimento'
);

insert consulta values(
	default,
	1,
	1,
	now(),
	'S',
	'N'
);

insert consulta_exame values(
	default,
	1,
	1,
	'Na capa da gaita'
);