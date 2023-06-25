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
-- Table structure for table `purchasers_request`
--

DROP TABLE IF EXISTS `purchasers_request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchasers_request` (
  `purchasers_request_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the purchaser''s request\n0000000000-9999999999\n\n\n',
  `requestor_ID` int NOT NULL COMMENT 'The ID to identify the requestor\n0000000000-9999999999\n\n',
  `restaurant_ID` int NOT NULL COMMENT 'To represent different restaurants.\nXX00000000-XX99999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify the item\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity of  each item purchased.\n\n\n\n',
  `priority_id` int NOT NULL COMMENT 'To represent who go first one\n1\n2\n\n',
  `status_ID` int DEFAULT NULL COMMENT 'The ID to identify the status\\n0000000000-9999999999\\n\\n',
  `create_date` date NOT NULL COMMENT 'The date of the request \nYYYYMMDD\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'Expect the date of delivery\nYYYYMMDD\n\n',
  `remarks` varchar(50) DEFAULT NULL COMMENT 'Additional details or request from customer\n\n',
  PRIMARY KEY (`purchasers_request_id`),
  KEY `Purchasers_Request_requestor_ID_fk_idx` (`requestor_ID`),
  KEY `Purchasers_Request_restaurant_ID_fk_idx` (`restaurant_ID`),
  KEY `Purchasers_Request_item_ID_fk_idx` (`item_ID`),
  KEY `Purchasers_Request_status_ID_fk_idx` (`status_ID`),
  CONSTRAINT `Purchasers_Request_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `Purchasers_Request_requestor_ID_fk` FOREIGN KEY (`requestor_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `Purchasers_Request_restaurant_ID_fk` FOREIGN KEY (`restaurant_ID`) REFERENCES `restaurant` (`restaurant_ID`),
  CONSTRAINT `Purchasers_Request_status_ID_fk` FOREIGN KEY (`status_ID`) REFERENCES `status` (`status_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasers_request`
--

LOCK TABLES `purchasers_request` WRITE;
/*!40000 ALTER TABLE `purchasers_request` DISABLE KEYS */;
INSERT INTO `purchasers_request` VALUES (3,1,1,1,99,1,1000,'2023-06-13','2023-06-20','qw'),(4,1,1,2,99,2,1000,'2023-06-13','2023-06-13',''),(5,1,1,1,9999,2,1200,'2023-06-13','2023-06-13',''),(6,1,1,2,88,3,1000,'2023-06-13','2023-06-13',''),(7,1,1,1,123,4,1000,'2023-06-13','2023-06-13','');
/*!40000 ALTER TABLE `purchasers_request` ENABLE KEYS */;
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
