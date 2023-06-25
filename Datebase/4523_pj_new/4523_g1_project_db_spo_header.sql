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
-- Table structure for table `spo_header`
--

DROP TABLE IF EXISTS `spo_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spo_header` (
  `header_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the SPO header\n0000000000-9999999999\n\n',
  `create_date` date NOT NULL COMMENT 'The date when the SPO header created\nDDMsMYYYY\n\n',
  `effective_date` date NOT NULL COMMENT 'the effective date of the SPO header\nDDMMYYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID to identify the supplier of the SPO header\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID to identify the buyer of SPO header\n0000000000-9999999999\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'The expected delivery date of SPO header\nDDMMYYYY\n\n',
  `terms` varchar(30) DEFAULT NULL,
  `condition` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`header_ID`),
  KEY `SPO_header_buyer_ID_fk_idx` (`buyer_ID`),
  KEY `SPO_header_supplier_ID_fk_idx` (`supplier_ID`),
  CONSTRAINT `SPO_header_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `SPO_header_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spo_header`
--

LOCK TABLES `spo_header` WRITE;
/*!40000 ALTER TABLE `spo_header` DISABLE KEYS */;
INSERT INTO `spo_header` VALUES (1,'2023-03-04','2023-05-04',1,1,'2023-03-17','NA','NA'),(2,'2023-04-12','2023-06-12',2,3,'2023-04-19','NA','NA'),(3,'2023-05-11','2023-07-11',3,2,'2023-05-18','NA','NA'),(4,'2023-06-12','2023-08-12',4,1,'2023-06-22','NA','NA');
/*!40000 ALTER TABLE `spo_header` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:45
