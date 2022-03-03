CREATE TABLE Reflorestamento(
	codCalculo int identity (0,1) primary key,
	ano int not null,
	estado char (2)not null,
	numArvoresCortadas int  null,
	volumeM3 decimal (9,2) null,
	arvoresARepor int null,
	valorAPAgar money null,
	CodcodUsuarioResp int not null FOREIGN KEY REFERENCES Usuario(CodUsuario)
	)
	
	CREATE TABLE Usuario(
	codUsuario int identity (0,1) primary key,
	nome varchar(100)not null,
	telefone char(11)not null,
	cpf char (11)not null,
	email varchar (50)not null,
	loginn varchar (25) not null,
	senha varchar (6) not null,
	tipoUsuario smallint not null,
	
	codUsuarioResp int not null FOREIGN KEY REFERENCES Usuario(CodUsuario)
) 

select * from Usuario
select * from Reflorestamento

                