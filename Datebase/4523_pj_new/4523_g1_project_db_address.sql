-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: 4523_g1_project_db
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `address` (
  `address_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the address\nXX000000000000000000-XX999999999999999999\nXX =\n‘KW’ for Kowloon\n‘NT’ for New Territories\n‘HK’ for Hong Kong Island\n\n',
  `name` varchar(30) DEFAULT NULL COMMENT 'The name\n\n',
  `district` varchar(30) DEFAULT NULL COMMENT 'The district of the address\n‘KW’ for Kowloon\n‘NT’ for New Territories\n‘HK’ for Hong Kong Island\n\n',
  `street` varchar(30) DEFAULT NULL COMMENT 'The street of the address\n\n',
  `building` varchar(30) DEFAULT NULL COMMENT 'The building of the address\n\n',
  `floor` varchar(5) DEFAULT NULL COMMENT 'the floor of the address\n\n',
  `unit` varchar(5) DEFAULT NULL COMMENT 'The unit of the address\n\n',
  PRIMARY KEY (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
INSERT INTO `address` VALUES (1,'Golden','Kowloon','Tai Nan Street','Lai Kin ','5','5C'),(2,'SingaLong','Hong Kong Island','Aberdeen Street','Lai Guon','10','10F'),(3,'Beef C.A','Kowloon','Austin Road','Peninsula','4','4H'),(4,'Fruit & Fresh','Hong Kong Island','Anton Street','White Tower','2','2G'),(5,'Omakasesan','Kowloon','Haiphong Road','Red Brick Cost','8','8A'),(6,'Good','Kowloon','Roaming Road','NA','G','023G'),(7,'God','Kowloon','Sunsine Street','NA','G','032G'),(8,'Asia-Res','Hong Kong Island','Globa Record','NA','G','101G');
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:43
