create table TipoDeContrato(
	Id Serial primary key,
	Nome VARCHAR(30) not null 
);

create table funcionario (
	Id Serial primary key,
	Nome VARCHAR(255) not null,
	Cpf VARCHAR(11) unique not null,
	Email VARCHAR(255) unique not null,
	Senha VARCHAR(255) not null,
	Sexo char not null,
	Salario decimal(10, 2) not null,
	TipoDeContratoId int not null,
	DataDeCadastro timestamp not null,
	DataDeAtualizacao timestamp,
	foreign key (TipoDeContratoId) references TipoDeContrato(Id)
);
