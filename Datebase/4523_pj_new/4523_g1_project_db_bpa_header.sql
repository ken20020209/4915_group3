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
-- Table structure for table `bpa_header`
--

DROP TABLE IF EXISTS `bpa_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bpa_header` (
  `header_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the header of BPA\n0000000000-9999999999\n\n',
  `purchase_order_revision` tinyint NOT NULL COMMENT 'The purchase order whether need a revision\nYes\nNo\n\n',
  `create_date` date NOT NULL COMMENT 'The date which the BPA is created\nDDMMYYYY\n\n',
  `effective_dates` date NOT NULL COMMENT 'The effective date of BPA\nDDMMYYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID to identify the BPA supplier\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID to identify the BPA buyer\n0000000000-9999999999\n\n',
  `agreed_amount` int NOT NULL COMMENT 'The agreed amount between the seller and buyer \n\n\n\n',
  `currency` decimal(10,2) NOT NULL COMMENT 'The currency of BPA\n\n\n\n',
  `terms` varchar(30) DEFAULT NULL,
  `condition` varchar(30) DEFAULT NULL COMMENT 'If exist other requirements in this trade\n\n\n\n',
  PRIMARY KEY (`header_ID`),
  KEY `BPA_header_supplier_ID_fk_idx` (`supplier_ID`),
  KEY `BPA_header_buyer_ID_fk_idx` (`buyer_ID`),
  CONSTRAINT `BPA_header_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `BPA_header_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bpa_header`
--

LOCK TABLES `bpa_header` WRITE;
/*!40000 ALTER TABLE `bpa_header` DISABLE KEYS */;
INSERT INTO `bpa_header` VALUES (1,1,'2023-04-03','2023-12-12',3,1,1000,1000.00,NULL,NULL),(2,1,'2023-03-27','2023-10-30',2,3,800,800.00,NULL,NULL),(3,0,'2023-03-27','2023-10-30',3,2,3000,3000.00,NULL,NULL),(4,0,'2023-03-01','2023-10-09',4,1,1500,1500.00,NULL,NULL),(5,1,'2023-06-01','2023-08-18',1,1,10000,100.00,'',''),(6,1,'2023-01-01','2023-08-18',3,1,10000,120.00,'','');
/*!40000 ALTER TABLE `bpa_header` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:40
