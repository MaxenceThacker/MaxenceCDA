DROP DATABASE IF EXISTS "Ajouter le nom de la base";
CREATE DATABASE IF NOT EXISTS "Ajouter le nom de la base";
USE "Ajouter le nom de la base";

--
--  EtatsReserves
--

CREATE TABLE EtatsReserves(
   IdEtatReserve INT AUTO_INCREMENT  PRIMARY KEY,
   LibelleEtatReserve VARCHAR(50)
) ENGINE=InnoDB;

--
--  Themes
--

CREATE TABLE Themes(
   IdTheme INT AUTO_INCREMENT PRIMARY KEY,
   NomTheme VARCHAR(50)
)ENGINE=InnoDB;

--
--  Auteurs
--

CREATE TABLE Auteurs(
   IdAuteur INT AUTO_INCREMENT PRIMARY KEY,
   NomAutheur VARCHAR(50)
)ENGINE=InnoDB;

--
--  Genres
--

CREATE TABLE Genres(
   IdGenre INT AUTO_INCREMENT PRIMARY KEY,
   NomGenre VARCHAR(50)
)ENGINE=InnoDB;

--
--  Editeurs
--

CREATE TABLE Editeurs(
   IdEditeur INT AUTO_INCREMENT PRIMARY KEY,
   NomEditeur VARCHAR(50)
)ENGINE=InnoDB;

--
--  Usures
--

CREATE TABLE Usures(
   IdUsure INT AUTO_INCREMENT PRIMARY KEY,
   CodeUsure VARCHAR(50)

--
--  CategoriesProfessionnelles
--

CREATE TABLE CategoriesProfessionnelles(
   IdCategorieProfessionnelle INT AUTO_INCREMENT PRIMARY KEY,
   LibelleCategPro VARCHAR(50)
)ENGINE=InnoDB;

--
--  MotsCles
--

CREATE TABLE MotsCles(
   IdMotCle INT AUTO_INCREMENT PRIMARY KEY,
   LibelleMotCle VARCHAR(50)
)ENGINE=InnoDB;

--
--  Livres
--

CREATE TABLE Livres(
   IdLivre INT AUTO_INCREMENT PRIMARY KEY,
   TitreLivre VARCHAR(50) ,
   CodeCatalogue VARCHAR(50) ,
   IdEditeur INT NOT NULL,
   IdTheme INT NOT NULL
)ENGINE=InnoDB;

--
--  Exemplaires
--

CREATE TABLE Exemplaires(
   IdExemplaire INT AUTO_INCREMENT PRIMARY KEY, 
   DateAcquisition DATE,
   Disponibilite BOOLEAN,
   CodeRayon VARCHAR(50) ,
   IdUsure INT NOT NULL,
   IdLivre INT NOT NULL
)ENGINE=InnoDB;

--
--  Abonnes
--

CREATE TABLE Abonnes(
   IdAbonne INT AUTO_INCREMENT PRIMARY KEY,
   MatriculeAbonne VARCHAR(50) ,
   NomAbonne VARCHAR(50) ,
   AdresseAbonne VARCHAR(50) ,
   TelephoneAbonne VARCHAR(50) ,
   DateAdhesion DATE,
   DateNaissance DATE,
   IdCategorieProfessionnelle INT NOT NULL,
   PRIMARY KEY(IdAbonne),
   FOREIGN KEY(IdCategorieProfessionnelle) REFERENCES CategoriesProfessionnelles(IdCategorieProfessionnelle)
)ENGINE=InnoDB;

--
--  Reservations
--

CREATE TABLE Reservations(
   IdEtatReserve INT,
   IdLivre INT,
   IdAbonne INT,
   DateDebutReservation DATETIME,
   DateDemandeReservation DATE,
   PRIMARY KEY(IdEtatReserve, IdLivre, IdAbonne),
   FOREIGN KEY(IdEtatReserve) REFERENCES EtatsReserves(IdEtatReserve),
   FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre),
   FOREIGN KEY(IdAbonne) REFERENCES Abonnes(IdAbonne)
)ENGINE=InnoDB;

--
--  Definitions
--

CREATE TABLE Definitions(
   IdGenre INT,
   IdLivre INT,
   PRIMARY KEY(IdGenre, IdLivre),
   FOREIGN KEY(IdGenre) REFERENCES Genres(IdGenre),
   FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre)
)ENGINE=InnoDB;

--
--  Compositions
--

CREATE TABLE Compositions(
   IdAuteur INT,
   IdLivre INT,
   PRIMARY KEY(IdAuteur, IdLivre),
   FOREIGN KEY(IdAuteur) REFERENCES Auteurs(IdAuteur),
   FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre)
)ENGINE=InnoDB;

--
--  EmpruntExemplaires
--

CREATE TABLE EmpruntExemplaires(
   IdExemplaire INT,
   IdAbonne INT,
   DateEmprunt DATETIME,
   DateRetourEffective DATETIME,
   PRIMARY KEY(IdExemplaire, IdAbonne),
   FOREIGN KEY(IdExemplaire) REFERENCES Exemplaires(IdExemplaire),
   FOREIGN KEY(IdAbonne) REFERENCES Abonnes(IdAbonne)
)ENGINE=InnoDB;

--  Identifications
--

CREATE TABLE Identifications(
   IdLivre INT,
   IdMotCle INT,
   PRIMARY KEY(IdLivre, IdMotCle),
   FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre),
   FOREIGN KEY(IdMotCle) REFERENCES MotsCles(IdMotCle)
)ENGINE=InnoDB;

ALTER TABLE Livres 
ADD CONSTRAINT Fk_Livres_Editeur FOREIGN KEY(IdEditeur) REFERENCES Editeurs(IdEditeur),
ADD CONSTRAINT Fk_Livres_Theme FOREIGN KEY(IdTheme) REFERENCES Themes(IdTheme);
ALTER TABLE Exemplaires
ADD CONSTRAINT Fk_Exemplaires_Usure FOREIGN KEY(IdUsure) REFERENCES Usures(IdUsure),
ADD CONSTRAINT Fk_Livres_Livre FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
