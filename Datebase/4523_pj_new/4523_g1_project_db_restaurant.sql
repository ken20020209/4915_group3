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
-- Table structure for table `restaurant`
--

DROP TABLE IF EXISTS `restaurant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restaurant` (
  `restaurant_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each restaurant\nXX00000000-XX99999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of each restaurant\n\n',
  `address_ID` int NOT NULL COMMENT 'The ID to identify each address\nXX000000000000000000-XX999999999999999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `type` varchar(20) NOT NULL COMMENT 'Type of the the restaurant\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `phone` char(8) NOT NULL COMMENT 'The phone number of the restaurant. (Hong Kong number)\n00000000-\n99999999\n\n',
  `manager_ID` int DEFAULT NULL,
  PRIMARY KEY (`restaurant_ID`),
  KEY `Restaurant_address_ID_fk_idx` (`address_ID`),
  KEY `Restaurant_manager_ID_fk_idx` (`manager_ID`),
  CONSTRAINT `Restaurant_address_ID_fk` FOREIGN KEY (`address_ID`) REFERENCES `address` (`address_id`),
  CONSTRAINT `Restaurant_manager_ID_fk` FOREIGN KEY (`manager_ID`) REFERENCES `user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurant`
--

LOCK TABLES `restaurant` WRITE;
/*!40000 ALTER TABLE `restaurant` DISABLE KEYS */;
INSERT INTO `restaurant` VALUES (1,'Good',6,'1','12345678',1),(2,'God',7,'2','98765432',NULL),(3,'Asia-Res',8,'2','67439867',NULL);
/*!40000 ALTER TABLE `restaurant` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:46
