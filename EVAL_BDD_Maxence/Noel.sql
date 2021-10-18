#------------------------------------------------------------------------
#                             Script MySQL
#------------------------------------------------------------------------

DROP DATABASE IF EXISTS `Noel`;
CREATE DATABASE  `Noel` DEFAULT CHARACTER SET utf8;
USE `Noel`
-- 
-- Table structures for table `Cadeaux`
--
CREATE TABLE Cadeaux(
   idCadeau INT AUTO_INCREMENT PRIMARY KEY,
   numCadeau VARCHAR(15) ,
   designationCadeau VARCHAR(250) ,
   UNIQUE(numCadeau)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Enfant`
--
CREATE TABLE Enfants(
   idEnfant INT AUTO_INCREMENT PRIMARY KEY,
   numEnfant VARCHAR(15) ,
   nomEnfant VARCHAR(120) ,
   prenomEnfant VARCHAR(120) ,
   adresseEnfant VARCHAR(200) ,
   sexeEnfant BOOLEAN ,
   voeuEnfant VARCHAR(250) ,
   pourcentageSagesseEnfant DECIMAL(3,2)  ,
   idCadeau INT NOT NULL,
   UNIQUE(idCadeau),
   UNIQUE(numEnfant)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Lutins`
--
CREATE TABLE Lutins(
   idLutin INT AUTO_INCREMENT PRIMARY KEY,
   numLutin VARCHAR(20) ,
   nomLutin VARCHAR(120) ,
   prenomLutin VARCHAR(120) ,
   UNIQUE(numLutin)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Traineaux`
--
CREATE TABLE Traineaux(
   idTraineau INT AUTO_INCREMENT PRIMARY KEY,
   numTraineau VARCHAR(10) ,
   tailleTraineau SMALLINT,
   dateMiseEnServiceTraineau DATE,
   UNIQUE(numTraineau)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Rennes`
--
CREATE TABLE Rennes(
   id_Renne INT AUTO_INCREMENT PRIMARY KEY,
   nomRenne VARCHAR(120) ,
   sexeRenne BOOLEAN ,
   dateDeNaissanceRenne DATE
)ENGINE=InnoDB;

-- 
-- Table structures for table `Tournees`
--
CREATE TABLE Tournees(
   idCadeau INT PRIMARY KEY,
   idLutin INT PRIMARY KEY,
   idTraineau INT PRIMARY KEY,
   numTournee VARCHAR(15) ,
   nomConducteurTournee VARCHAR(120) ,
   heureDepartTournee VARCHAR(50) ,
   UNIQUE(numTournee)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Entretien`
--
CREATE TABLE Entretiens(
   idLutin INT PRIMARY KEY,
   idTraineau INT PRIMARY KEY,
   dateDerniereRevision DATE,
   nomLutinResponsable VARCHAR(120)
)ENGINE=InnoDB;

-- 
-- Table structures for table `Montures`
--
CREATE TABLE Montures(
   idTraineau INT PRIMARY KEY,
   id_Renne INT PRIMARY KEY
)ENGINE=InnoDB;

ALTER TABLE Enfants 
ADD CONSTRAINT FK_Cadeau FOREIGN KEY(idCadeau) REFERENCES Cadeaux(idCadeau);

ALTER TABLE Tournees
ADD CONSTRAINT FK_Cadeau FOREIGN KEY(idCadeau) REFERENCES Cadeaux(idCadeau)
ADD CONSTRAINT FK_Lutin FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin)
ADD CONSTRAINT FK_Traineau FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);

ALTER TABLE Entretiens
ADD CONSTRAINT FK_Lutin FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin)
ADD CONSTRAINT FK_Traineau FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);

ALTER TABLE Montures
ADD CONSTRAINT FK_Traineau FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau)
ADD CONSTRAINT FK_Renne FOREIGN KEY(id_Renne) REFERENCES Rennes(id_Renne);