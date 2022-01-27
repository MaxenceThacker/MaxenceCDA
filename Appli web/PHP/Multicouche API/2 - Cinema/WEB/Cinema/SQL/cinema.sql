-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 27 jan. 2022 à 14:43
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `cinema`
--
CREATE DATABASE IF NOT EXISTS `cinema` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `cinema`;

-- --------------------------------------------------------

--
-- Structure de la table `films`
--

DROP TABLE IF EXISTS `films`;
CREATE TABLE IF NOT EXISTS `films` (
  `idFilm` int(11) NOT NULL AUTO_INCREMENT,
  `libelleFilm` varchar(50) DEFAULT NULL,
  `dureeMinuteFilm` int(11) DEFAULT NULL,
  PRIMARY KEY (`idFilm`),
  UNIQUE KEY `libelleFilm` (`libelleFilm`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `films`
--

INSERT INTO `films` (`idFilm`, `libelleFilm`, `dureeMinuteFilm`) VALUES
(1, 'Eternal Sunshine of the Spotless Mind', 133),
(2, 'Vol au-dessus d\'un nid de coucou', 108);

-- --------------------------------------------------------

--
-- Structure de la table `salles`
--

DROP TABLE IF EXISTS `salles`;
CREATE TABLE IF NOT EXISTS `salles` (
  `idSalle` int(11) NOT NULL AUTO_INCREMENT,
  `nbrPlaceSalle` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSalle`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `salles`
--

INSERT INTO `salles` (`idSalle`, `nbrPlaceSalle`) VALUES
(1, 100),
(2, 75);

-- --------------------------------------------------------

--
-- Structure de la table `seances`
--

DROP TABLE IF EXISTS `seances`;
CREATE TABLE IF NOT EXISTS `seances` (
  `idSeance` int(11) NOT NULL AUTO_INCREMENT,
  `idFilm` int(11) DEFAULT NULL,
  `idSalle` int(11) DEFAULT NULL,
  `horaireSeance` time DEFAULT NULL,
  `dateSeance` datetime DEFAULT NULL,
  PRIMARY KEY (`idSeance`),
  KEY `idFilm` (`idFilm`),
  KEY `idSalle` (`idSalle`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `seances`
--

INSERT INTO `seances` (`idSeance`, `idFilm`, `idSalle`, `horaireSeance`, `dateSeance`) VALUES
(1, 1, 1, '14:30:00', '2022-01-29 14:30:00'),
(2, 2, 2, '20:00:00', '2022-01-29 20:00:00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
