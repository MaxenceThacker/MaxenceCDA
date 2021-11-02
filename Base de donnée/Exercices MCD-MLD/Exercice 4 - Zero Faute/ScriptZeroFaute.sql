#------------------------------------------------------------------------
#                             Script MySQL
#------------------------------------------------------------------------

DROP DATABASE IF EXISTS `Nike`;
CREATE DATABASE  `Nike` DEFAULT CHARACTER SET utf8;
USE `Nike`
-- 
-- Table structures for table `Catégories`
--
CREATE TABLE Catégories(
   idCatégorie INT AUTO_INCREMENT PRIMARY KEY ,
   nomCatégorie VARCHAR(50) ,
   nomSous_Categorie VARCHAR(50) ,
   idCatégorie_1 INT NOT NULL
   
)ENGINE=InnoDB;


-- 
-- Table structures for table `Modeles`
--
CREATE TABLE Modeles(
   idModele INT AUTO_INCREMENT PRIMARY KEY ,
   
   numModele VARCHAR(8) ,
   nomModele VARCHAR(50) ,
   dateSurMarcheModele DATE

)ENGINE=InnoDB;

-- 
-- Table structures for table `Fautes`
--
CREATE TABLE Fautes(
   idFaute INT AUTO_INCREMENT PRIMARY KEY ,
   numFaute INT,
   titreFaute VARCHAR(50) ,
   idCatégorie INT NOT NULL

)ENGINE=InnoDB;

-- 
-- Table structures for table `Produits`
--
CREATE TABLE Produits(
   idProduit INT AUTO_INCREMENT PRIMARY KEY ,
   numSerieProduit VARCHAR(6) ,
   numProduit VARCHAR(4) ,
   anneeProducProduit DATE,
   idModele INT NOT NULL
   
)ENGINE=InnoDB;

-- 
-- Table structures for table `Series`
--
CREATE TABLE Series(
   idSerie INT AUTO_INCREMENT PRIMARY KEY ,
   numSerie VARCHAR(50) ,
   numProduitSerie VARCHAR(50) ,
   idProduit INT NOT NULL
   
)ENGINE=InnoDB;

-- 
-- Table structures for table `appartient`
--
CREATE TABLE appartient(
   idFaute INT AUTO_INCREMENT PRIMARY KEY,
   idProduit INT,
   dateDetectionFaute DATE NOT NULL,
   dateReparationFaute DATE
    
)ENGINE=InnoDB;

-- 
-- Table structures for table `fait_parti`
--
CREATE TABLE fait_parti(
   idProduit INT PRIMARY KEY ,
   idSerie INT,
   
)ENGINE=InnoDB;


ALTER TABLE Categories 
ADD CONSTRAINT Fk_Sous_Categorie FOREIGN KEY(idCatégorie_1) REFERENCES Catégories(idCatégorie)
ADD CONSTRAINT Fk_Categorie FOREIGN KEY(idCatégorie) REFERENCES Catégories(idCatégorie);

ALTER TABLE Modeles 
ADD CONSTRAINT Fk_Modele FOREIGN KEY(idModele) REFERENCES Modeles(idModele);

ALTER TABLE Fautes
ADD CONSTRAINT Fk_Faute FOREIGN KEY(idFaute) REFERENCES Fautes(idFaute);

ALTER TABLE fait_parti
ADD CONSTRAINT Fk_Produit FOREIGN KEY(idProduit) REFERENCES Produits(idProduit)
ADD CONSTRAINT Fk_Serie FOREIGN KEY(idSerie) REFERENCES Series(idSerie);