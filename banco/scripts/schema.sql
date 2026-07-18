create table funcionario (
	Id Serial primary key,
	Nome VARCHAR(255) not null,
	Cpf VARCHAR(11) unique not null,
	Email VARCHAR(255) unique not null,
	Sexo char not null,
	Salario decimal(10, 2) not null,
	TipoDeContrato VARCHAR(30) not null,
	DataDeCadastro timestamp not null,
	DataDeAtualizacao timestamp
);