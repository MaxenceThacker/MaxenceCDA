#------------------------------------------------------------------------
#                             Script MySQL
#------------------------------------------------------------------------

DROP DATABASE IF EXISTS `GestionCantineGenerateur`;
CREATE DATABASE  `GestionCantineGenerateur` DEFAULT CHARACTER SET utf8;
USE `GestionCantineGenerateur`;

-- 
-- Table structures for table `Roles`
--
CREATE TABLE Roles(
   IdRole INT AUTO_INCREMENT PRIMARY KEY,
   LibelleRole VARCHAR(50) 
)ENGINE=InnoDB;

-- 
-- Table structures for table `Eleves`
--
CREATE TABLE Eleves(
   IdEleve INT AUTO_INCREMENT PRIMARY KEY,
   NomEleve VARCHAR(150) ,
   PrenomEleve VARCHAR(150) ,
   DDNEleve DATE,
   SoldeEleve DOUBLE
)ENGINE=InnoDB;

-- 
-- Table structures for table `ModesDePaiement`
--
CREATE TABLE ModesDePaiement(
   IdModeDePaiement INT AUTO_INCREMENT PRIMARY KEY,
   LibelleModeDePaiement VARCHAR(50)
)ENGINE=InnoDB;


-- 
-- Table structures for table `Menus`
--
CREATE TABLE Menus(
   IdMenu INT AUTO_INCREMENT PRIMARY KEY,
   DateMenu DATE,
   LibelleMenu VARCHAR(50) ,
   PrixMenu DOUBLE
)ENGINE=InnoDB;

-- 
-- Table structures for table `Paiements`
--
CREATE TABLE Paiements(
   IdPaiement INT AUTO_INCREMENT PRIMARY KEY,
   MontantPaiement DOUBLE,
   DatePaiement DATE,
   IdEleve INT NOT NULL,
   IdModeDePaiement INT NOT NULL
)ENGINE=InnoDB;

-- 
-- Table structures for table `Reservation`
--
CREATE TABLE Reservations(
   IdReservation INT AUTO_INCREMENT PRIMARY KEY,
   IdEleve INT,
   IdMenu INT,
   DateReservation DATE
)ENGINE=InnoDB;





ALTER TABLE
    Reservations
ADD
    CONSTRAINT FK_Reservations_Eleves FOREIGN KEY(IdEleve) REFERENCES Eleves(IdEleve),
ADD
    CONSTRAINT FK_Reservations_Menus FOREIGN KEY(IdMenu) REFERENCES Menus(IdMenu);

ALTER TABLE
    Paiements
ADD
    CONSTRAINT FK_Paiements_Eleves FOREIGN KEY(IdEleve) REFERENCES Eleves(IdEleve),
ADD
    CONSTRAINT FK_Paiements_ModesDePaiement FOREIGN KEY(IdModeDePaiement) REFERENCES ModesDePaiement(IdModeDePaiement);


INSERT INTO `ModesDePaiement`(`idModeDePaiement`, `LibelleModeDePaiement`) VALUES (1,"Virement/CB");
INSERT INTO `ModesDePaiement`(`idModeDePaiement`, `LibelleModeDePaiement`) VALUES (2,"Chèques");
INSERT INTO `ModesDePaiement`(`idModeDePaiement`, `LibelleModeDePaiement`) VALUES (3,"Espèces");

INSERT INTO `Roles`(`IdRole`, `LibelleRole`) VALUES (1,"Admin");
INSERT INTO `Roles`(`IdRole`, `LibelleRole`) VALUES (2,"Proviseur");
INSERT INTO `Roles`(`IdRole`, `LibelleRole`) VALUES (3,"Secrétaire");
INSERT INTO `Roles`(`IdRole`, `LibelleRole`) VALUES (4,"Chef de Cuisine");



INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (1,"Dubois","Julette","1999-11-11",50);
INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (2,"Marnier","Sophie","2001-02-15",100);
INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (3,"Godart","Louis","2000-06-29",20);
INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (4,"Pichon","Mathieu","2000-04-02",60);
INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (5,"Chavain ","Natalie","2002-02-25",120);
INSERT INTO `Eleves`(`IdEleve`, `NomEleve`,`PrenomEleve`,`DDNEleve`,`SoldeEleve`) VALUES (6,"Dubois ","Juliette","2003-12-14",40);



INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (1,"2017-09-04","Charcutrie/Poulet/Glace", 6.5);
INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (2,"2017-09-05","Peche/Pâte/Baba", 6.5);
INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (3,"2017-09-06","Œuf/Curry/Compote", 6.5);
INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (4,"2017-09-07","Salade/Carbonade/Île", 6.5);
INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (5,"2017-09-08","Feuilleté/Steak/Crème", 6.5);
INSERT INTO `Menus`(`IdMenu`, `DateMenu`,`LibelleMenu`, `prixMenu`) VALUES (6,"2017-09-09","Soupe/Chili/Tarte", 6.5);

INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (1,50,"2017-09-05",1,2);
INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (2,50,"2017-09-10",2,2);
INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (3,20,"2017-09-25",3,1);
INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (4,30,"2017-10-14",4,1);
INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (5,80,"2017-09-25",5,1);
INSERT INTO `Paiements`(`IdPaiement`, `MontantPaiement`,`DatePaiement`,`IdEleve`,`IdModeDePaiement`) VALUES (6,40,"2017-09-05",6,3);

INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (1,3,1,"2017-09-04");
INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (2,2,2,"2017-09-09");
INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (3,4,3,"2017-09-24");
INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (4,5,4,"2017-09-13");
INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (5,1,5,"2017-09-24");
INSERT INTO `Reservations`(`idReservation`, `IdEleve`,`IdMenu`,`DateReservation`) VALUES (6,6,6,"2017-09-04");


  
