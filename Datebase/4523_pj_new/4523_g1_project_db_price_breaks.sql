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
-- Table structure for table `price_breaks`
--

DROP TABLE IF EXISTS `price_breaks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `price_breaks` (
  `price_break_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each price breaks\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity item of prices breaks\n\n\n\n',
  `price_break` decimal(10,2) NOT NULL COMMENT 'The price reduced\n\n\n\n',
  `discount` decimal(10,2) NOT NULL COMMENT 'What is the discount of that price breaks\n\n\n\n',
  `effective_date` date NOT NULL COMMENT 'The effective date of each price breaks\nDDMMYYYY\n\n',
  PRIMARY KEY (`price_break_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `price_breaks`
--

LOCK TABLES `price_breaks` WRITE;
/*!40000 ALTER TABLE `price_breaks` DISABLE KEYS */;
INSERT INTO `price_breaks` VALUES (1,150,100.00,150.00,'2023-04-18'),(2,140,160.00,100.00,'2023-06-24'),(3,120,147.00,30.00,'2023-03-11'),(4,130,210.00,50.00,'2023-02-21'),(5,110,135.00,130.00,'2023-04-17');
/*!40000 ALTER TABLE `price_breaks` ENABLE KEYS */;
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
