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
-- Table structure for table `cpa`
--

DROP TABLE IF EXISTS `cpa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cpa` (
  `CPA_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of CPA\n0000000000-9999999999\n\n',
  `create_date` date NOT NULL COMMENT 'the create date of CPA\nDD/MM/YYYY\n\n',
  `effective_date` date NOT NULL COMMENT 'The effective date of CPA\nDD/MM/YYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID of the supplier to identify different suppliers\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID of the buyers to identify different suppliers \n0000000000-9999999999\n\n',
  `terms` varchar(30) NOT NULL COMMENT 'The terms of CPA.\n\n\n\n',
  `condition` varchar(30) NOT NULL COMMENT 'The condition of CPA.\n\n\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID of the item\n0000000000-9999999999\n\n',
  PRIMARY KEY (`CPA_ID`),
  KEY `CPA_supplier_ID_fk_idx` (`supplier_ID`),
  KEY `CPA_buyer_ID_fk_idx` (`buyer_ID`),
  KEY `CPA_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `CPA_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `CPA_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `CPA_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cpa`
--

LOCK TABLES `cpa` WRITE;
/*!40000 ALTER TABLE `cpa` DISABLE KEYS */;
INSERT INTO `cpa` VALUES (1,'2023-03-10','2023-03-12',1,3,'NA','NA',1),(2,'2023-03-27','2023-03-30',2,3,'NA','NA',2),(3,'2023-03-27','2023-03-20',3,2,'NA','NA',3),(4,'2023-03-01','2023-03-07',4,3,'NA','NA',4);
/*!40000 ALTER TABLE `cpa` ENABLE KEYS */;
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
