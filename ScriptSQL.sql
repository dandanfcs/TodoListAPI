--Rodar esse Scripts para gerar banco de dados e tabelas

CREATE DATABASE todolis;

CREATE TABLE tarefas(
    id integer AUTO_INCREMENT,
    nome varchar(200) not null,
    PRIMARY KEY(id)
);