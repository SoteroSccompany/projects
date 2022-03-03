--CREATE DATABASE dbSituacaoDeAprendizagem

use dbSituacaoDeAprendizagem
go
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
CREATE TABLE Reflorestamento(
	codCalculo int identity (0,1) primary key,
	ano int not null,
	estado char (2)not null,
	numArvoresCortadas int not null,
	volumeM3 decimal (9,2)not null, --Pode 11 digitos sendo que dois serão da virgula 
	arvoreARepor int not null ,
	arvoreAPagar money not null,
	codUsuarioResp int not null FOREIGN KEY REFERENCES Usuario(CodUsuario),
	codAdmValidação int not null FOREIGN KEY REFERENCES Usuario(CodUsuario)
)
drop database dbSituacaoDeAprendizagem
INSERT INTO Usuario values ('Admin','99999999999','99999999999','admin@admin.com','Admin','admin',0,0)
select * from Usuario

--delete from Usuario where codUsuarioResp is null --para colocar null, deve usar o is 
