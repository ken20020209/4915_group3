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
-- Table structure for table `ppo_lines`
--

DROP TABLE IF EXISTS `ppo_lines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ppo_lines` (
  `lines_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the PPO lines\n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID to identify the PPO lines header\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify the PPO lines item\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity of PPO lines\n\n\n\n',
  `UOM` varchar(50) NOT NULL,
  `price` decimal(10,2) NOT NULL COMMENT 'The price in this PPO lines\n\n\n\n',
  `amount` int NOT NULL COMMENT 'The amount of this PPO lines\n\n\n\n',
  `reference` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`lines_ID`),
  KEY `PPO_lines_header_ID_fk_idx` (`header_ID`),
  KEY `PPO_lines_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `PPO_lines_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `ppo_header` (`header_ID`),
  CONSTRAINT `PPO_lines_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ppo_lines`
--

LOCK TABLES `ppo_lines` WRITE;
/*!40000 ALTER TABLE `ppo_lines` DISABLE KEYS */;
INSERT INTO `ppo_lines` VALUES (1,1,6,20,'Lt',90.00,1800,NULL),(2,2,3,70,'Kg',120.00,8400,NULL),(3,3,2,44,'Kg',180.00,7920,NULL),(4,4,5,29,'Kg',70.00,2030,NULL);
/*!40000 ALTER TABLE `ppo_lines` ENABLE KEYS */;
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
