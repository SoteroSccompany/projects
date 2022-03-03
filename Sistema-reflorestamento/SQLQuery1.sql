CREATE DATABASE dbSituacaoDeAprendizagem

use dbSituacaoDeAprendizagem

CREATE TABLE Usuario(
	codUsuario int identity (0,1) primary key,
	nome varchar(100),
	telefone char(11),
	cpf char (11),
	email varchar (50),
	loginn varchar (25) not null,
	senha varchar (6) not null,
	tipoUsuario smallint,
	codUsuarioResp int FOREIGN KEY REFERENCES Usuario(CodUsuario)
)
CREATE TABLE Reflorestamento(
	codCalculo int identity (0,1) primary key,
	ano int,
	estado char (2),
	numArvoresCortadas int,
	volumeM3 decimal (9,2), --Pode 11 digitos sendo que dois serão da virgula 
	arvoreARepor int ,
	arvoreAPagar money ,
	codUsuarioResp int FOREIGN KEY REFERENCES Usuario(CodUsuario),
	codAdmValidação int FOREIGN KEY REFERENCES Usuario(CodUsuario)
)

INSERT INTO Usuario values (null,null,null,null,'Admin','admin',1,null)
select * from Usuario

--delete from Usuario where codUsuarioResp is null --para colocar null, deve usar o is 
use master
drop database dbSituacaoDeAprendizagem