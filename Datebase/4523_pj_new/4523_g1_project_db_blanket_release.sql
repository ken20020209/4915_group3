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
-- Table structure for table `blanket_release`
--

DROP TABLE IF EXISTS `blanket_release`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `blanket_release` (
  `release_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the Blanket release\n0000000000-9999999999\n\n',
  `line_ID` int NOT NULL COMMENT 'The ID to identify the header\\n0000000000-9999999999\\n\\n',
  `create_date` date NOT NULL COMMENT 'The date where the Blanket release is created\nDDMMYYYY\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'The expected delivery date of the Blanket release\nDDMMYYYY\n\n',
  `item_qty` int NOT NULL COMMENT 'The quantity of each item\n\n\n\n',
  `shipment_ID` int DEFAULT NULL,
  PRIMARY KEY (`release_ID`),
  KEY `Blanket_Release_line_ID_fk_idx` (`line_ID`),
  KEY `Blanket_shipment_ID_fk_idx` (`shipment_ID`),
  CONSTRAINT `Blanket_Release_line_ID_fk` FOREIGN KEY (`line_ID`) REFERENCES `bpa_lines` (`lines_ID`),
  CONSTRAINT `Blanket_shipment_ID_fk` FOREIGN KEY (`shipment_ID`) REFERENCES `address` (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `blanket_release`
--

LOCK TABLES `blanket_release` WRITE;
/*!40000 ALTER TABLE `blanket_release` DISABLE KEYS */;
INSERT INTO `blanket_release` VALUES (1,1,'2023-09-17','2023-08-22',150,NULL),(2,2,'2023-05-29','2023-09-03',120,NULL),(3,3,'2023-03-22','2023-04-01',140,NULL),(4,4,'2023-04-16','2023-04-29',130,NULL),(5,2,'2023-06-17','2023-06-17',99,NULL),(6,2,'2023-06-17','2023-06-17',99,NULL),(7,1,'2023-06-17','2023-06-17',99,NULL),(8,2,'2023-06-17','2023-06-17',99,NULL),(9,2,'2023-06-17','2023-06-17',99,NULL),(10,7,'2023-06-18','2023-06-18',9999,NULL);
/*!40000 ALTER TABLE `blanket_release` ENABLE KEYS */;
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
