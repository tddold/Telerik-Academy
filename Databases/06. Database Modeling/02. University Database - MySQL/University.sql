-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: university
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courses` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Departaments_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Courses_Departaments1_idx` (`Departaments_ID`),
  CONSTRAINT `fk_Courses_Departaments1` FOREIGN KEY (`Departaments_ID`) REFERENCES `departaments` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,'Introduction to Computers and Computing',1),(2,'Programming Concepts',1),(3,'Basic Drawing',1),(4,'Graphic Communications',1),(5,'Electronic Devices and Analog Circuits',2);
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departaments`
--

DROP TABLE IF EXISTS `departaments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departaments` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Faculties_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Departaments_Faculties1_idx` (`Faculties_ID`),
  CONSTRAINT `fk_Departaments_Faculties1` FOREIGN KEY (`Faculties_ID`) REFERENCES `faculties` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departaments`
--

LOCK TABLES `departaments` WRITE;
/*!40000 ALTER TABLE `departaments` DISABLE KEYS */;
INSERT INTO `departaments` VALUES (1,'Computer systems and technologies',1),(2,'Electronics',1),(3,'Automation, Information and Control Engineering',1),(4,'Electrical',1),(5,'Industrial ecology',1),(6,'Industrial Engineering (English)',1),(7,'Optoelectronics and Laser Technology',1),(8,'Signaling equipment and automated systems security',1),(9,'Mechanical and Instrument Engineering',2),(10,'Manufacturing Technologies',2),(11,'Mechatronics',2),(12,'Transport Equipment and Technology',2),(13,'Aeronautical Engineering',2),(14,'Industrial Management',2),(15,'Polygraphy',2);
/*!40000 ALTER TABLE `departaments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculties`
--

DROP TABLE IF EXISTS `faculties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faculties` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculties`
--

LOCK TABLES `faculties` WRITE;
/*!40000 ALTER TABLE `faculties` DISABLE KEYS */;
INSERT INTO `faculties` VALUES (1,'Electronics and Automatics'),(2,'Mechanical and Instrument Engineering');
/*!40000 ALTER TABLE `faculties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professors`
--

DROP TABLE IF EXISTS `professors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professors` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Departaments_ID` int(11) NOT NULL,
  `Courses_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Professors_Departaments1_idx` (`Departaments_ID`),
  KEY `fk_Professors_Courses1_idx` (`Courses_ID`),
  CONSTRAINT `fk_Professors_Courses1` FOREIGN KEY (`Courses_ID`) REFERENCES `courses` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professors_Departaments1` FOREIGN KEY (`Departaments_ID`) REFERENCES `departaments` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professors`
--

LOCK TABLES `professors` WRITE;
/*!40000 ALTER TABLE `professors` DISABLE KEYS */;
INSERT INTO `professors` VALUES (1,'Petrov',1,1),(2,'Ivanov',1,2),(3,'Peshev',2,2),(4,'Georgiev',3,3);
/*!40000 ALTER TABLE `professors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Faculties_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Students_Faculties_idx` (`Faculties_ID`),
  CONSTRAINT `fk_Students_Faculties` FOREIGN KEY (`Faculties_ID`) REFERENCES `faculties` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Pesho Peshev',1),(2,'Ivan Ivanov',1),(3,'Gosho Goshev',2),(4,'Mitko Mitev',2);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentscurses`
--

DROP TABLE IF EXISTS `studentscurses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studentscurses` (
  `Students_ID` int(11) NOT NULL DEFAULT '0',
  `Courses_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Students_ID`,`Courses_ID`),
  KEY `fk_StudentsCurses_Students1_idx` (`Students_ID`),
  KEY `fk_StudentsCurses_Courses1_idx` (`Courses_ID`),
  CONSTRAINT `fk_StudentsCurses_Courses1` FOREIGN KEY (`Courses_ID`) REFERENCES `courses` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_StudentsCurses_Students1` FOREIGN KEY (`Students_ID`) REFERENCES `students` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentscurses`
--

LOCK TABLES `studentscurses` WRITE;
/*!40000 ALTER TABLE `studentscurses` DISABLE KEYS */;
INSERT INTO `studentscurses` VALUES (1,1),(1,2),(1,3),(1,4),(2,1),(2,2),(2,3),(3,4),(3,5),(4,4),(4,5);
/*!40000 ALTER TABLE `studentscurses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titles`
--

DROP TABLE IF EXISTS `titles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `titles` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titles`
--

LOCK TABLES `titles` WRITE;
/*!40000 ALTER TABLE `titles` DISABLE KEYS */;
INSERT INTO `titles` VALUES (1,'Ph. D'),(2,'Academician'),(3,'Senior assistant');
/*!40000 ALTER TABLE `titles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titlesprofessors`
--

DROP TABLE IF EXISTS `titlesprofessors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `titlesprofessors` (
  `Titles_ID` int(11) NOT NULL DEFAULT '0',
  `Professors_ID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Titles_ID`,`Professors_ID`),
  KEY `fk_TitlesProfessors_Titles1_idx` (`Titles_ID`),
  KEY `fk_TitlesProfessors_Professors1_idx` (`Professors_ID`),
  CONSTRAINT `fk_TitlesProfessors_Professors1` FOREIGN KEY (`Professors_ID`) REFERENCES `professors` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TitlesProfessors_Titles1` FOREIGN KEY (`Titles_ID`) REFERENCES `titles` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titlesprofessors`
--

LOCK TABLES `titlesprofessors` WRITE;
/*!40000 ALTER TABLE `titlesprofessors` DISABLE KEYS */;
INSERT INTO `titlesprofessors` VALUES (1,1),(1,4),(2,2),(3,3);
/*!40000 ALTER TABLE `titlesprofessors` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-10-07  4:00:25
