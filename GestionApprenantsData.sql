create database GestionApprenant
use GestionApprenant

create table Apprenant(	IdAp int IDENTITY(1,1) PRIMARY KEY,
						nom varchar(12),
						prenom varchar(12),
						email varchar(30),
						telephone int,
						adresse varchar(30),
						pays varchar(20),
						ville varchar(20),
						specialite varchar(20)) 

						drop table Apprenant

						SELECT COUNT(IdAp)FROM Apprenant


insert into Apprenant values('Houssni','Ouchad','email@email.com','066666666','Boualam safi','Maroc','Safi','JEE')
insert into Apprenant values('Adil','Samid','email@email.com','066666666','Boualam safi','Maroc','Safi','JEE')

