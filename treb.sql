CREATE TABLE Jogador(
 Id serial NOT NULL PRIMARY KEY,
 Email varchar(256),
 Nome varchar(256),
 Senha varchar(256),
 Status varchar(256)
 );

CREATE TABLE Plataforma(
 Id serial NOT NULL PRIMARY KEY,
 NomePlataforma varchar(256)
 );
 
 CREATE TABLE Jogos(
 Id serial NOT NULL PRIMARY KEY,
 DescricaoJogo varchar(256),
 Distribuidora varchar(256),
 Genero varchar(256),
 NomeJogo varchar(256),
 Produtora varchar(256),
 Site varchar(256)
 );
 
 CREATE TABLE JogoDaPlataforma(
 Id serial NOT NULL PRIMARY KEY,
 IdPlataforma INTEGER,
 IdJogos INTEGER,
 DataLancamento DATE,
 FOREIGN KEY(IdPlataforma) REFERENCES Plataforma(Id),
 FOREIGN KEY(IdJogos) REFERENCES Jogos(Id)
 );
 
 CREATE TABLE ControleDeJogos(
 Id serial NOT NULL PRIMARY KEY,
 IdJogoDaPlataforma INTEGER,
 Adiquirir BOOLEAN,
 DataAdquirir DATE,
 Troco BOOLEAN,
 Vendo BOOLEAN,
 FOREIGN KEY(IdJogoDaPlataforma) REFERENCES JogoDaPlataforma(Id)
 );