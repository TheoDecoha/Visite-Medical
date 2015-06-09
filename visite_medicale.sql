-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Mer 11 Septembre 2013 à 13:53
-- Version du serveur: 5.5.24-log
-- Version de PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `visite_medicale`
--

-- --------------------------------------------------------

--
-- Structure de la table `departement`
--

CREATE TABLE IF NOT EXISTS `departement` (
  `num_auto` int(5) NOT NULL AUTO_INCREMENT,
  `num_departement` int(2) NOT NULL,
  `num_vm` int(2) NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date DEFAULT NULL,
  PRIMARY KEY (`num_auto`),
  KEY `num_vm` (`num_vm`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=2 ;

--
-- Contenu de la table `departement`
--

INSERT INTO `departement` (`num_auto`, `num_departement`, `num_vm`, `date_debut`, `date_fin`) VALUES
(1, 49100, 1, '2013-10-16', '2013-10-31');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE IF NOT EXISTS `medecin` (
  `num_medecin` int(2) NOT NULL AUTO_INCREMENT,
  `nom_m` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `prenom_m` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `sexe_m` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `spécialité` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `adresse` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `cp` int(5) NOT NULL,
  `date_actuelle` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`num_medecin`),
  KEY `num_medecin` (`num_medecin`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Contenu de la table `medecin`
--

INSERT INTO `medecin` (`num_medecin`, `nom_m`, `prenom_m`, `sexe_m`, `spécialité`, `adresse`, `cp`, `date_actuelle`) VALUES
(1, 'Armand', 'Maxence', 'F', 'Pédiatre', '15 rue de la tour Effel', 75000, '0000-00-00 00:00:00'),
(2, 'Decoha', 'Théo', 'H', 'Chirurgien', '12 square des caléides', 49000, '0000-00-00 00:00:00'),
(3, 'Charraud', 'Bastien', 'H', 'Cardiologue', '17 rue de l''absentéisme', 69000, '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

CREATE TABLE IF NOT EXISTS `visite` (
  `num_visite` int(4) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `commentaire` longtext COLLATE utf8_unicode_ci NOT NULL,
  `action_a_prevoir` longtext COLLATE utf8_unicode_ci NOT NULL,
  `num_medecin` int(2) NOT NULL,
  `date_actuelle` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`num_visite`),
  KEY `num_medecin` (`num_medecin`),
  KEY `num_medecin_2` (`num_medecin`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=2 ;

--
-- Contenu de la table `visite`
--

INSERT INTO `visite` (`num_visite`, `date`, `commentaire`, `action_a_prevoir`, `num_medecin`, `date_actuelle`) VALUES
(1, '2013-09-20', 'RDV pour genou en miette. Incapable de jouer au badminton. ', 'Couper au dessus du genou !', 1, '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `vm`
--

CREATE TABLE IF NOT EXISTS `vm` (
  `num_vm` int(3) NOT NULL AUTO_INCREMENT,
  `nom` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `prenom` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `sexe` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `identifiant` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `mp` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`num_vm`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Contenu de la table `vm`
--

INSERT INTO `vm` (`num_vm`, `nom`, `prenom`, `sexe`, `identifiant`, `mp`) VALUES
(1, 'Delohen', 'Kévin', 'H', 'kevin', '9d5e3ecdeb4cdb7acfd63075ae046672'),
(2, 'Secheur', 'Max', 'H', 'max', '2ffe4e77325d9a7152f7086ea7aa5114');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `departement`
--
ALTER TABLE `departement`
  ADD CONSTRAINT `departement_ibfk_1` FOREIGN KEY (`num_vm`) REFERENCES `vm` (`num_vm`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `visite_ibfk_1` FOREIGN KEY (`num_medecin`) REFERENCES `medecin` (`num_medecin`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
