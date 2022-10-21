-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: jags
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `correo` varchar(30) NOT NULL,
  `contrasenia` varchar(30) NOT NULL,
  `codigoAdmin` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`correo`),
  CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`correo`) REFERENCES `usuario` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES ('ale','jo','1'),('root@gmail.com','root','1');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deporte`
--

DROP TABLE IF EXISTS `deporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deporte` (
  `idDeporte` int(11) NOT NULL AUTO_INCREMENT,
  `nombreDeporte` varchar(30) NOT NULL,
  PRIMARY KEY (`idDeporte`),
  UNIQUE KEY `nombreDeporte` (`nombreDeporte`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deporte`
--

LOCK TABLES `deporte` WRITE;
/*!40000 ALTER TABLE `deporte` DISABLE KEYS */;
INSERT INTO `deporte` VALUES (2,'Basket'),(5,'cachi'),(3,'Futbol'),(4,'Golf');
/*!40000 ALTER TABLE `deporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `distancia`
--

DROP TABLE IF EXISTS `distancia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `distancia` (
  `idPuntuacion` int(11) NOT NULL,
  `kilometros` int(11) DEFAULT NULL,
  `metros` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPuntuacion`),
  CONSTRAINT `distancia_ibfk_1` FOREIGN KEY (`idPuntuacion`) REFERENCES `puntuacion` (`idPuntuacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `distancia`
--

LOCK TABLES `distancia` WRITE;
/*!40000 ALTER TABLE `distancia` DISABLE KEYS */;
/*!40000 ALTER TABLE `distancia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipo` (
  `idEquipo` int(11) NOT NULL AUTO_INCREMENT,
  `idEvento` int(11) NOT NULL,
  `idDeporte` int(11) DEFAULT NULL,
  `nombreEquipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idEquipo`,`idEvento`),
  KEY `idEvento` (`idEvento`),
  KEY `idDeporte` (`idDeporte`),
  CONSTRAINT `equipo_ibfk_1` FOREIGN KEY (`idDeporte`) REFERENCES `deporte` (`idDeporte`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (2,1,2,'Nacional'),(3,1,2,'Peñarol'),(4,1,3,'Barcelona'),(5,1,4,'Uruguay'),(6,1,3,'Real Madrid'),(10,1,5,'LOL'),(11,1,5,'DOTA');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `idEvento` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `resultado` int(11) DEFAULT NULL,
  `hora` int(11) DEFAULT NULL,
  `minuto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (12,'2002-02-02',1,23,21),(13,'0000-00-00',2,12,32),(14,'0000-00-00',1,12,23),(15,'0000-00-00',1,12,65),(16,'0222-02-02',2,2,2),(17,'2012-02-02',2,2,32),(56,'2032-05-09',1,12,30),(87,'2003-02-02',2,2,32),(123,'0223-01-23',1,12,32),(234,'2012-12-02',1,12,12),(321,'2050-05-23',3,10,0),(323,'2000-12-03',1,78,21),(345,'0002-02-02',2,2,2),(776,'2020-02-02',1,32,32),(345345,'2018-01-01',1,12,30),(76756675,'2050-05-23',3,10,0);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `integra`
--

DROP TABLE IF EXISTS `integra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `integra` (
  `idEquipo` int(11) NOT NULL,
  `idJugador` int(11) NOT NULL,
  PRIMARY KEY (`idEquipo`,`idJugador`),
  KEY `idJugador` (`idJugador`),
  CONSTRAINT `integra_ibfk_1` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`),
  CONSTRAINT `integra_ibfk_2` FOREIGN KEY (`idJugador`) REFERENCES `jugador` (`idJugador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `integra`
--

LOCK TABLES `integra` WRITE;
/*!40000 ALTER TABLE `integra` DISABLE KEYS */;
/*!40000 ALTER TABLE `integra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugador`
--

DROP TABLE IF EXISTS `jugador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jugador` (
  `idJugador` int(11) NOT NULL AUTO_INCREMENT,
  `edad` int(11) DEFAULT NULL,
  `nroCamiseta` int(11) DEFAULT NULL,
  `nombreJugador` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idJugador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugador`
--

LOCK TABLES `jugador` WRITE;
/*!40000 ALTER TABLE `jugador` DISABLE KEYS */;
/*!40000 ALTER TABLE `jugador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lugar`
--

DROP TABLE IF EXISTS `lugar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lugar` (
  `idLugar` int(11) NOT NULL AUTO_INCREMENT,
  `nombreLugar` varchar(30) DEFAULT NULL,
  `pais` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idLugar`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lugar`
--

LOCK TABLES `lugar` WRITE;
/*!40000 ALTER TABLE `lugar` DISABLE KEYS */;
/*!40000 ALTER TABLE `lugar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `miembro`
--

DROP TABLE IF EXISTS `miembro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `miembro` (
  `correo` varchar(30) NOT NULL,
  `contrasenia` varchar(30) DEFAULT NULL,
  `Membresia` char(2) DEFAULT NULL,
  PRIMARY KEY (`correo`),
  CONSTRAINT `miembro_ibfk_1` FOREIGN KEY (`correo`) REFERENCES `usuario` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `miembro`
--

LOCK TABLES `miembro` WRITE;
/*!40000 ALTER TABLE `miembro` DISABLE KEYS */;
INSERT INTO `miembro` VALUES ('alejobuc@gmail.com','123','1'),('gise@gmail.com','123','1'),('joaco@gmail.com','123','1'),('pitu@gmail.com','123','1'),('test123','123','1'),('testVIP','123','1');
/*!40000 ALTER TABLE `miembro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participa`
--

DROP TABLE IF EXISTS `participa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participa` (
  `idEquipo` int(11) NOT NULL,
  `idEvento` int(11) NOT NULL,
  `resultado` int(11) DEFAULT NULL,
  PRIMARY KEY (`idEquipo`,`idEvento`),
  KEY `idEvento` (`idEvento`),
  CONSTRAINT `participa_ibfk_1` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`),
  CONSTRAINT `participa_ibfk_2` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participa`
--

LOCK TABLES `participa` WRITE;
/*!40000 ALTER TABLE `participa` DISABLE KEYS */;
INSERT INTO `participa` VALUES (2,87,100),(2,345345,5),(3,321,60),(3,345345,3);
/*!40000 ALTER TABLE `participa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pasa`
--

DROP TABLE IF EXISTS `pasa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pasa` (
  `idEvento` int(11) NOT NULL,
  `idLugar` int(11) DEFAULT NULL,
  PRIMARY KEY (`idEvento`),
  KEY `idLugar` (`idLugar`),
  CONSTRAINT `pasa_ibfk_2` FOREIGN KEY (`idLugar`) REFERENCES `lugar` (`idLugar`),
  CONSTRAINT `pasa_ibfk_3` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pasa`
--

LOCK TABLES `pasa` WRITE;
/*!40000 ALTER TABLE `pasa` DISABLE KEYS */;
/*!40000 ALTER TABLE `pasa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prueba`
--

DROP TABLE IF EXISTS `prueba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prueba` (
  `fecha` date NOT NULL,
  PRIMARY KEY (`fecha`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prueba`
--

LOCK TABLES `prueba` WRITE;
/*!40000 ALTER TABLE `prueba` DISABLE KEYS */;
INSERT INTO `prueba` VALUES ('0000-00-00'),('1200-12-10'),('2000-02-02');
/*!40000 ALTER TABLE `prueba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publicidad` (
  `idPublicidad` int(11) NOT NULL AUTO_INCREMENT,
  `empresa` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idPublicidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidad`
--

LOCK TABLES `publicidad` WRITE;
/*!40000 ALTER TABLE `publicidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `publicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puntos`
--

DROP TABLE IF EXISTS `puntos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puntos` (
  `idPuntuacion` int(11) NOT NULL,
  `puntaje` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPuntuacion`),
  CONSTRAINT `puntos_ibfk_1` FOREIGN KEY (`idPuntuacion`) REFERENCES `puntuacion` (`idPuntuacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puntos`
--

LOCK TABLES `puntos` WRITE;
/*!40000 ALTER TABLE `puntos` DISABLE KEYS */;
/*!40000 ALTER TABLE `puntos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puntuacion`
--

DROP TABLE IF EXISTS `puntuacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puntuacion` (
  `idPuntuacion` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idPuntuacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puntuacion`
--

LOCK TABLES `puntuacion` WRITE;
/*!40000 ALTER TABLE `puntuacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `puntuacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `realiza`
--

DROP TABLE IF EXISTS `realiza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `realiza` (
  `idEvento` int(11) NOT NULL,
  `idDeporte` int(11) DEFAULT NULL,
  PRIMARY KEY (`idEvento`),
  KEY `idDeporte` (`idDeporte`),
  CONSTRAINT `realiza_ibfk_2` FOREIGN KEY (`idDeporte`) REFERENCES `deporte` (`idDeporte`),
  CONSTRAINT `realiza_ibfk_3` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `realiza`
--

LOCK TABLES `realiza` WRITE;
/*!40000 ALTER TABLE `realiza` DISABLE KEYS */;
/*!40000 ALTER TABLE `realiza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscribe`
--

DROP TABLE IF EXISTS `suscribe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suscribe` (
  `correo` varchar(30) NOT NULL,
  `idEvento` int(11) NOT NULL,
  PRIMARY KEY (`correo`,`idEvento`),
  KEY `idEvento` (`idEvento`),
  CONSTRAINT `suscribe_ibfk_1` FOREIGN KEY (`correo`) REFERENCES `miembro` (`correo`),
  CONSTRAINT `suscribe_ibfk_2` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscribe`
--

LOCK TABLES `suscribe` WRITE;
/*!40000 ALTER TABLE `suscribe` DISABLE KEYS */;
/*!40000 ALTER TABLE `suscribe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiempo`
--

DROP TABLE IF EXISTS `tiempo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiempo` (
  `idPuntuacion` int(11) NOT NULL,
  `minutos` int(11) DEFAULT NULL,
  `segundos` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPuntuacion`),
  CONSTRAINT `tiempo_ibfk_1` FOREIGN KEY (`idPuntuacion`) REFERENCES `puntuacion` (`idPuntuacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiempo`
--

LOCK TABLES `tiempo` WRITE;
/*!40000 ALTER TABLE `tiempo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiempo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiene` (
  `correo` varchar(30) NOT NULL,
  `idPublicidad` int(11) NOT NULL,
  PRIMARY KEY (`correo`,`idPublicidad`),
  KEY `idPublicidad` (`idPublicidad`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`correo`) REFERENCES `usuarionom` (`correo`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`idPublicidad`) REFERENCES `publicidad` (`idPublicidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `correo` varchar(30) NOT NULL,
  `contrasenia` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('ale','jo'),('alejobuc@gmail.com','123'),('gise@gmail.com','123'),('joaco@gmail.com','123'),('pitu@gmail.com','123'),('root@gmail.com','root'),('test','123'),('test123','123'),('test2','123'),('testVIP','123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarionom`
--

DROP TABLE IF EXISTS `usuarionom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarionom` (
  `correo` varchar(30) NOT NULL,
  `contrasenia` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`correo`),
  CONSTRAINT `usuarionom_ibfk_1` FOREIGN KEY (`correo`) REFERENCES `usuario` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarionom`
--

LOCK TABLES `usuarionom` WRITE;
/*!40000 ALTER TABLE `usuarionom` DISABLE KEYS */;
INSERT INTO `usuarionom` VALUES ('test','123'),('test2','123');
/*!40000 ALTER TABLE `usuarionom` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-02 21:24:34
