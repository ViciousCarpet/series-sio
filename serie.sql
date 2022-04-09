-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           5.7.33 - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour series
CREATE DATABASE IF NOT EXISTS `series` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `series`;

-- Listage de la structure de la table series. episodes
CREATE TABLE IF NOT EXISTS `episodes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nomEpisodes` varchar(500) DEFAULT NULL,
  `duree` time DEFAULT NULL,
  `idSerie` int(11) DEFAULT NULL,
  `numeroEpisodes` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_episodes_serie` (`idSerie`),
  CONSTRAINT `FK_episodes_serie` FOREIGN KEY (`idSerie`) REFERENCES `serie` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Listage des données de la table series.episodes : ~5 rows (environ)
/*!40000 ALTER TABLE `episodes` DISABLE KEYS */;
INSERT INTO `episodes` (`id`, `nomEpisodes`, `duree`, `idSerie`, `numeroEpisodes`) VALUES
	(1, 'aaa', '00:17:49', 1, 1),
	(2, 'bbb', '00:40:12', 1, 2),
	(3, 'ccc', '00:31:21', 1, 3),
	(4, 'ddd', '04:04:53', 2, 1),
	(5, 'blabla', '14:42:23', 12, 1);
/*!40000 ALTER TABLE `episodes` ENABLE KEYS */;

-- Listage de la structure de la table series. evaluer
CREATE TABLE IF NOT EXISTS `evaluer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `commentaire` varchar(500) DEFAULT NULL,
  `note` int(11) DEFAULT NULL,
  `idUser` int(11) DEFAULT NULL,
  `idEpisode` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_evaluer_identifiant` (`idUser`),
  KEY `FK_evaluer_episodes` (`idEpisode`),
  CONSTRAINT `FK_evaluer_episodes` FOREIGN KEY (`idEpisode`) REFERENCES `episodes` (`id`),
  CONSTRAINT `FK_evaluer_identifiant` FOREIGN KEY (`idUser`) REFERENCES `identifiant` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Listage des données de la table series.evaluer : ~3 rows (environ)
/*!40000 ALTER TABLE `evaluer` DISABLE KEYS */;
INSERT INTO `evaluer` (`id`, `commentaire`, `note`, `idUser`, `idEpisode`) VALUES
	(1, 'c\'etait nul', 1, 16, 1),
	(2, 'j\'ai adoré', 5, 16, 3),
	(3, 'j\'ai bien aimais mais il a des choses à améliorer', 3, 17, 2);
/*!40000 ALTER TABLE `evaluer` ENABLE KEYS */;

-- Listage de la structure de la table series. identifiant
CREATE TABLE IF NOT EXISTS `identifiant` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(500) DEFAULT NULL,
  `mdp` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

-- Listage des données de la table series.identifiant : ~5 rows (environ)
/*!40000 ALTER TABLE `identifiant` DISABLE KEYS */;
INSERT INTO `identifiant` (`id`, `login`, `mdp`) VALUES
	(16, 'alie', '55'),
	(17, 'kiki', '56'),
	(19, '0', '0'),
	(20, 'a', 'a'),
	(21, 'c', 'c');
/*!40000 ALTER TABLE `identifiant` ENABLE KEYS */;

-- Listage de la structure de la table series. partager
CREATE TABLE IF NOT EXISTS `partager` (
  `idUser` int(11) DEFAULT NULL,
  `idAmis` int(11) DEFAULT NULL,
  KEY `FK_partager_identifiant` (`idUser`),
  KEY `FK_partager_identifiant_2` (`idAmis`),
  CONSTRAINT `FK_partager_identifiant` FOREIGN KEY (`idUser`) REFERENCES `identifiant` (`id`),
  CONSTRAINT `FK_partager_identifiant_2` FOREIGN KEY (`idAmis`) REFERENCES `identifiant` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table series.partager : ~4 rows (environ)
/*!40000 ALTER TABLE `partager` DISABLE KEYS */;
INSERT INTO `partager` (`idUser`, `idAmis`) VALUES
	(16, 17),
	(20, 17),
	(20, 21),
	(20, 16);
/*!40000 ALTER TABLE `partager` ENABLE KEYS */;

-- Listage de la structure de la table series. rajouter
CREATE TABLE IF NOT EXISTS `rajouter` (
  `idUser` int(11) DEFAULT NULL,
  `idSerie` int(11) DEFAULT NULL,
  `episodesEnCour` int(11) DEFAULT NULL,
  `SaisonEnCour` int(11) DEFAULT NULL,
  KEY `FK_rajouter_identifiant` (`idUser`),
  KEY `FK_rajouter_serie` (`idSerie`),
  CONSTRAINT `FK_rajouter_identifiant` FOREIGN KEY (`idUser`) REFERENCES `identifiant` (`id`),
  CONSTRAINT `FK_rajouter_serie` FOREIGN KEY (`idSerie`) REFERENCES `serie` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table series.rajouter : ~3 rows (environ)
/*!40000 ALTER TABLE `rajouter` DISABLE KEYS */;
INSERT INTO `rajouter` (`idUser`, `idSerie`, `episodesEnCour`, `SaisonEnCour`) VALUES
	(16, 1, 5, 1),
	(17, 2, 15, 2),
	(20, 1, 1, 1);
/*!40000 ALTER TABLE `rajouter` ENABLE KEYS */;

-- Listage de la structure de la table series. serie
CREATE TABLE IF NOT EXISTS `serie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(500) DEFAULT NULL,
  `nombreSaisons` int(11) DEFAULT NULL,
  `nombreEpisodes` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- Listage des données de la table series.serie : ~5 rows (environ)
/*!40000 ALTER TABLE `serie` DISABLE KEYS */;
INSERT INTO `serie` (`id`, `nom`, `nombreSaisons`, `nombreEpisodes`) VALUES
	(1, 'GoT', 7, 152),
	(2, 'BreakingBad', 6, 354),
	(3, 'StrangerThings', 4, 245),
	(5, 'Elite', 10, 203),
	(12, 'Better Call Saul', 11, 159);
/*!40000 ALTER TABLE `serie` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
