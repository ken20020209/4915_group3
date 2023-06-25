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
-- Table structure for table `purchase_order_all`
--

DROP TABLE IF EXISTS `purchase_order_all`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_order_all` (
  `Purchase_order_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the purchase order all \nCCCCBBYYYYMMDDSSSS\n\nCCCC - Company Code\nBB - Branch\nYYYY - Year\nMM - Month\nDD - Day\nSSSS - Sequence number per day\n\n',
  `BR_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `SR_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `SPO_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `purchasers_request_ID` int DEFAULT NULL COMMENT 'The ID to identify the purchaser request of purchase order all\\n0000000000-9999999999\\n\\n',
  `delivery_note_ID` int DEFAULT NULL COMMENT 'The ID to identify the delivery note of purchase order all\n0000000000-9999999999\n\n',
  `description` varchar(50) DEFAULT NULL COMMENT 'The details of this purchase order all\n\n\n\n',
  PRIMARY KEY (`Purchase_order_ID`),
  KEY `purchase_order_all_BR_relase_ID_fk_idx` (`BR_relase_ID`),
  KEY `purchase_order_all_SR_relase_ID_fk_idx` (`SR_relase_ID`),
  KEY `purchase_order_all_SPO_relase_ID_fk_idx` (`SPO_relase_ID`),
  KEY `purchase_order_all_purchasers_request_ID_fk_idx` (`purchasers_request_ID`),
  KEY `purchase_order_all_delivery_note_ID_fk_idx` (`delivery_note_ID`),
  CONSTRAINT `purchase_order_all_BR_relase_ID_fk` FOREIGN KEY (`BR_relase_ID`) REFERENCES `blanket_release` (`release_ID`),
  CONSTRAINT `purchase_order_all_delivery_note_ID_fk` FOREIGN KEY (`delivery_note_ID`) REFERENCES `delivery_request` (`delivery_request_ID`),
  CONSTRAINT `purchase_order_all_purchasers_request_ID_fk` FOREIGN KEY (`purchasers_request_ID`) REFERENCES `purchasers_request` (`purchasers_request_id`),
  CONSTRAINT `purchase_order_all_SPO_relase_ID_fk` FOREIGN KEY (`SPO_relase_ID`) REFERENCES `spo_release` (`release_ID`),
  CONSTRAINT `purchase_order_all_SR_relase_ID_fk` FOREIGN KEY (`SR_relase_ID`) REFERENCES `schedule_release` (`release_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_all`
--

LOCK TABLES `purchase_order_all` WRITE;
/*!40000 ALTER TABLE `purchase_order_all` DISABLE KEYS */;
INSERT INTO `purchase_order_all` VALUES (1,1,1,1,3,3,NULL),(2,2,2,2,4,2,NULL),(3,3,3,3,7,1,NULL),(4,4,4,4,5,2,NULL),(5,5,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(6,6,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(7,7,NULL,NULL,3,NULL,'kryptonTextBoxRemark'),(8,8,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(9,9,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(10,NULL,NULL,4,5,NULL,'kryptonTextBoxRemark'),(11,10,NULL,NULL,5,NULL,'kryptonTextBoxRemark');
/*!40000 ALTER TABLE `purchase_order_all` ENABLE KEYS */;
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
