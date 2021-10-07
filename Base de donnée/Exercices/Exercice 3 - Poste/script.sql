#------------------------------------------------------------------------
#                             Script MySQL
#------------------------------------------------------------------------

DROP DATABASE IF EXISTS `POSTE`;
CREATE DATABASE  `POSTE` DEFAULT CHARACTER SET utf8;
USE `POSTE`
-- 
-- Table structures for table `BureauxDePostes`
--

CREATE TABLE BureauxDePostes(
   idBureauDePoste INT AUTO_INCREMENT PRIMARY KEY,
   adresseBureauDePoste VARCHAR(150) ,
   villeBureauDePoste VARCHAR(130) ,
   cpBureauDePoste VARCHAR(5)
)ENGINE=InnoDB;

-- 
-- Table structures for table `TypesDeTransports`
--

CREATE TABLE TypesDeTransports(
   idTypeDeTransports INT AUTO_INCREMENT,
   libelleTypeDeTransport VARCHAR(50) ,
   PRIMARY KEY(idTypeDeTransports)
);
ALTER TABLE TypesDeTransports ENGINE=InnoDB; 

-- 
-- Table structures for table `TypesCourriers`
--

CREATE TABLE TypesCourriers(
   idTypeCourrier INT AUTO_INCREMENT,
   nomTypeCourrier VARCHAR(50) ,
   PRIMARY KEY(idTypeCourrier)
);
ALTER TABLE TypesCourriers ENGINE=InnoDB; 

-- 
-- Table structures for table `Emeteurs`
--

CREATE TABLE Emeteurs(
   idEmeteur INT AUTO_INCREMENT,
   nomRueEmeteur VARCHAR(150) ,
   numRueEmeteur VARCHAR(10) ,
   PRIMARY KEY(idEmeteur)
);
ALTER TABLE Emeteurs ENGINE=InnoDB; 

-- 
-- Table structures for table `CentresDeTri_`
--

CREATE TABLE CentresDeTri_(
   idCentreDeTri_ INT AUTO_INCREMENT,
   PRIMARY KEY(idCentreDeTri_)
);
ALTER TABLE CentresDeTri_ ENGINE=InnoDB; 

-- 
-- Table structures for table `Destinataires`
--

CREATE TABLE Destinataires(
   idDestinataire INT AUTO_INCREMENT,
   numRueDestinataire VARCHAR(10) ,
   nomRueDestinataire VARCHAR(150) ,
   PRIMARY KEY(idDestinataire)
);
ALTER TABLE Destinataires ENGINE=InnoDB; 

-- 
-- Table structures for table `TaxesCarbone`
--

CREATE TABLE TaxesCarbone(
   idTaxeCarbone INT AUTO_INCREMENT,
   tauxTaxeCarbone VARCHAR(50) ,
   PRIMARY KEY(idTaxeCarbone)
);
ALTER TABLE TaxesCarbone ENGINE=InnoDB; 

-- 
-- Table structures for table `Suivis`
--

CREATE TABLE Suivis(
   idSuivi INT AUTO_INCREMENT,
   numSuivi INT,
   idEmeteur INT NOT NULL,
   idDestinataire INT NOT NULL,
   PRIMARY KEY(idSuivi),
   UNIQUE(numSuivi),
   FOREIGN KEY(idEmeteur) REFERENCES Emeteurs(idEmeteur),
   FOREIGN KEY(idDestinataire) REFERENCES Destinataires(idDestinataire)
);
ALTER TABLE Suivis ENGINE=InnoDB; 

-- 
-- Table structures for table `Courriers`
--

CREATE TABLE Courriers(
   idCourrier INT AUTO_INCREMENT,
   numCourrier INT,
   idTypeCourrier INT NOT NULL,
   PRIMARY KEY(idCourrier),
   UNIQUE(idTypeCourrier),
   UNIQUE(numCourrier),
   FOREIGN KEY(idTypeCourrier) REFERENCES TypesCourriers(idTypeCourrier)
);
ALTER TABLE Courriers ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_15`
--

CREATE TABLE Asso_15(
   idCourrier INT,
   idDestinataire INT,
   PRIMARY KEY(idCourrier, idDestinataire),
   FOREIGN KEY(idCourrier) REFERENCES Courriers(idCourrier),
   FOREIGN KEY(idDestinataire) REFERENCES Destinataires(idDestinataire)
);
ALTER TABLE Asso_15 ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_16`
--

CREATE TABLE Asso_16(
   idCourrier INT,
   idEmeteur INT,
   PRIMARY KEY(idCourrier, idEmeteur),
   FOREIGN KEY(idCourrier) REFERENCES Courriers(idCourrier),
   FOREIGN KEY(idEmeteur) REFERENCES Emeteurs(idEmeteur)
);
ALTER TABLE Asso_16 ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_18`
--

CREATE TABLE Asso_18(
   idCourrier INT,
   idCentreDeTri_ INT,
   PRIMARY KEY(idCourrier, idCentreDeTri_),
   FOREIGN KEY(idCourrier) REFERENCES Courriers(idCourrier),
   FOREIGN KEY(idCentreDeTri_) REFERENCES CentresDeTri_(idCentreDeTri_)
);
ALTER TABLE Asso_18 ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_19`
--

CREATE TABLE Asso_19(
   idBureauDePoste INT,
   idCentreDeTri_ INT,
   PRIMARY KEY(idBureauDePoste, idCentreDeTri_),
   FOREIGN KEY(idBureauDePoste) REFERENCES BureauxDePostes(idBureauDePoste),
   FOREIGN KEY(idCentreDeTri_) REFERENCES CentresDeTri_(idCentreDeTri_)
);
ALTER TABLE Asso_19 ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_20`
--

CREATE TABLE Asso_20(
   idBureauDePoste INT,
   idTypeDeTransports INT,
   PRIMARY KEY(idBureauDePoste, idTypeDeTransports),
   FOREIGN KEY(idBureauDePoste) REFERENCES BureauxDePostes(idBureauDePoste),
   FOREIGN KEY(idTypeDeTransports) REFERENCES TypesDeTransports(idTypeDeTransports)
);
ALTER TABLE Asso_20 ENGINE=InnoDB; 

-- 
-- Table structures for table `Asso_21`
--

CREATE TABLE Asso_21(
   idTypeDeTransports INT,
   idTaxeCarbone INT,
   PRIMARY KEY(idTypeDeTransports, idTaxeCarbone),
   FOREIGN KEY(idTypeDeTransports) REFERENCES TypesDeTransports(idTypeDeTransports),
   FOREIGN KEY(idTaxeCarbone) REFERENCES TaxesCarbone(idTaxeCarbone)
);
ALTER TABLE Asso_21 ENGINE=InnoDB; 
