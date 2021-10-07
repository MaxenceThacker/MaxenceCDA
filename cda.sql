-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 06 sep. 2021 à 15:21
-- Version du serveur :  5.7.31
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `cda`
--

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `villeID` varchar(5) NOT NULL,
  `villeName` varchar(30) NOT NULL,
  `villeDepartementNumber` varchar(24) DEFAULT NULL,
  `villePostalCode` varchar(24) DEFAULT NULL,
  `villeUpdateDate` varchar(24) DEFAULT NULL,
  PRIMARY KEY (`villeID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`villeID`, `villeName`, `villeDepartementNumber`, `villePostalCode`, `villeUpdateDate`) VALUES
('1', 'Dunkerque', '59', '59140', '23032021'),
('2', 'Calais', '62', '62100', '10072021'),
('3', 'SaintOmer', '62', '62500', '7082021'),
('4', 'Lens', '62', '62300', '25052021'),
('5', 'Lille', '59', '59000', '25022021');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
