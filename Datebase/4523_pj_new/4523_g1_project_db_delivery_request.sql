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
-- Table structure for table `delivery_request`
--

DROP TABLE IF EXISTS `delivery_request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery_request` (
  `delivery_request_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each delivery request\n0000000000-9999999999\n\n',
  `delivery_address_ID` int NOT NULL COMMENT 'The ID to identify each delivery address\n0000000000-9999999999\n\n',
  `receive_address_ID` int NOT NULL COMMENT 'The ID to identify each receive address\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify each \n0000000000-9999999999\n\n',
  `quantity` int NOT NULL COMMENT 'The quantity of each delivery item\n\n\n\n',
  `status_ID` int DEFAULT NULL COMMENT 'The Status of delivery\\n0000000000-9999999999\\n\\n',
  `create_date` date NOT NULL COMMENT 'The create date of delivery request\nDDMMYYYY\n\n',
  `delivery_date` date NOT NULL COMMENT 'The delivery date of delivery request\nDDMMYYYY\n\n',
  `receive_time` time DEFAULT NULL COMMENT 'The time when receive the request\nHHMMSS\n\n',
  `delivery_time` time DEFAULT NULL COMMENT 'The time of delivery\nHHMMSS\n\n',
  `vehicle_ID` int NOT NULL COMMENT 'The ID to identify each vehicle\n0000000000-9999999999\n\n',
  PRIMARY KEY (`delivery_request_ID`),
  KEY `Delivery_Request_delivery_address_ID_fk_idx` (`delivery_address_ID`),
  KEY `Delivery_Request_receive_address_ID_fk_idx` (`receive_address_ID`),
  KEY `Delivery_Request_item_ID_fk_idx` (`item_ID`),
  KEY `Delivery_Request_status_ID_fk_idx` (`status_ID`),
  KEY `Delivery_Request_vehicle_ID_fk_idx` (`vehicle_ID`),
  CONSTRAINT `Delivery_Request_delivery_address_ID_fk` FOREIGN KEY (`delivery_address_ID`) REFERENCES `address` (`address_id`),
  CONSTRAINT `Delivery_Request_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `Delivery_Request_receive_address_ID_fk` FOREIGN KEY (`receive_address_ID`) REFERENCES `address` (`address_id`),
  CONSTRAINT `Delivery_Request_status_ID_fk` FOREIGN KEY (`status_ID`) REFERENCES `status` (`status_ID`),
  CONSTRAINT `Delivery_Request_vehicle_ID_fk` FOREIGN KEY (`vehicle_ID`) REFERENCES `vehicle` (`vehicle_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_request`
--

LOCK TABLES `delivery_request` WRITE;
/*!40000 ALTER TABLE `delivery_request` DISABLE KEYS */;
INSERT INTO `delivery_request` VALUES (1,1,1,3,4,3000,'2023-03-16','2023-03-20','12:34:56','10:04:32',1),(2,2,2,4,5,3000,'2023-04-23','2023-04-27','11:54:20','12:06:49',2),(3,3,3,2,7,3100,'2023-02-28','2023-03-05','14:52:11','15:07:23',2),(4,4,4,1,4,3000,'2023-03-06','2023-03-17','16:43:22','17:23:45',3),(5,3,2,5,5,3200,'2023-03-05','2023-04-20','15:00:00','15:00:00',2),(6,3,1,6,5,3100,'2023-05-04','2023-08-20','15:00:00','16:00:00',3),(7,3,2,2,7,3200,'2023-05-01','2023-05-20','15:00:00','15:00:00',2);
/*!40000 ALTER TABLE `delivery_request` ENABLE KEYS */;
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
