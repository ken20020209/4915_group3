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
-- Table structure for table `delivery_request_handler`
--

DROP TABLE IF EXISTS `delivery_request_handler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery_request_handler` (
  `ID` int NOT NULL AUTO_INCREMENT COMMENT '0000000000-9999999999',
  `delivery_request_ID` int NOT NULL COMMENT 'The ID to identify each delivery request\n0000000000-9999999999\n\n',
  `delivery_staff_ID` int NOT NULL COMMENT 'The ID to identify each Delivery staff\n0000000000-9999999999\n\n',
  PRIMARY KEY (`ID`),
  KEY `Delivery_Request_Handler_delivery_request_ID_fk_idx` (`delivery_request_ID`),
  KEY `Delivery_Request_Handler_delivery_staff_ID_fk_idx` (`delivery_staff_ID`),
  CONSTRAINT `Delivery_Request_Handler_delivery_request_ID_fk` FOREIGN KEY (`delivery_request_ID`) REFERENCES `delivery_request` (`delivery_request_ID`),
  CONSTRAINT `Delivery_Request_Handler_delivery_staff_ID_fk` FOREIGN KEY (`delivery_staff_ID`) REFERENCES `user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_request_handler`
--

LOCK TABLES `delivery_request_handler` WRITE;
/*!40000 ALTER TABLE `delivery_request_handler` DISABLE KEYS */;
INSERT INTO `delivery_request_handler` VALUES (1,1,1),(2,2,2),(3,3,2),(4,4,3);
/*!40000 ALTER TABLE `delivery_request_handler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:42
