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
-- Table structure for table `spo_lines`
--

DROP TABLE IF EXISTS `spo_lines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spo_lines` (
  `lines_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of the SPO Lines that identify different SPO Lines\n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID of headers that identify different headers\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID of the item\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity of the item',
  `price` decimal(10,2) NOT NULL COMMENT 'The price of each item\n\n\n\n',
  `UOM` varchar(50) NOT NULL COMMENT 'The UOM of SPO_line\n\n\n\n',
  `amount` int NOT NULL COMMENT 'The total number of item purchased\n\n\n\n',
  `CPA_ID` int NOT NULL COMMENT 'The ID of the CPA that identify different CPA\n0000000000-9999999999\n\n',
  `Quotation_ID` int NOT NULL COMMENT 'The ID of the Quotation that identify different Quotation\n0000000000-9999999999\n\n',
  PRIMARY KEY (`lines_ID`),
  KEY `SPO_lines_header_ID_fk_idx` (`header_ID`),
  KEY `SPO_lines_item_ID_fk_idx` (`item_ID`),
  KEY `SPO_lines_CPA_ID_fk_idx` (`CPA_ID`),
  CONSTRAINT `SPO_lines_CPA_ID_fk` FOREIGN KEY (`CPA_ID`) REFERENCES `cpa` (`CPA_ID`),
  CONSTRAINT `SPO_lines_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `spo_header` (`header_ID`),
  CONSTRAINT `SPO_lines_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spo_lines`
--

LOCK TABLES `spo_lines` WRITE;
/*!40000 ALTER TABLE `spo_lines` DISABLE KEYS */;
INSERT INTO `spo_lines` VALUES (11,1,1,50,200.00,'Kg',10000,4,1),(22,2,7,60,250.00,'Kg',15000,2,2),(33,3,3,90,180.00,'Kg',16200,3,3),(44,4,5,70,210.00,'Kg',14700,1,4);
/*!40000 ALTER TABLE `spo_lines` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:41
