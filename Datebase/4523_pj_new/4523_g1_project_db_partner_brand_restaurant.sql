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
-- Table structure for table `partner_brand_restaurant`
--

DROP TABLE IF EXISTS `partner_brand_restaurant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partner_brand_restaurant` (
  `partner_brand_ID` int NOT NULL COMMENT 'The ID to identify the partner branch\n0000000000-9999999999\n\n',
  `restaurant_ID` int NOT NULL COMMENT 'The ID to identify the Restaurant\nXX00000000-XX99999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n\n',
  PRIMARY KEY (`partner_brand_ID`,`restaurant_ID`),
  KEY `Partner_Brand_Restaurant__fk_idx` (`restaurant_ID`),
  CONSTRAINT `Partner_Brand_Restaurant__fk` FOREIGN KEY (`restaurant_ID`) REFERENCES `restaurant` (`restaurant_ID`),
  CONSTRAINT `Partner_Brand_Restaurant_partner_brand_ID_fk` FOREIGN KEY (`partner_brand_ID`) REFERENCES `partner_brand` (`partner_brand_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partner_brand_restaurant`
--

LOCK TABLES `partner_brand_restaurant` WRITE;
/*!40000 ALTER TABLE `partner_brand_restaurant` DISABLE KEYS */;
INSERT INTO `partner_brand_restaurant` VALUES (3,1),(4,1),(2,2),(5,2),(1,3);
/*!40000 ALTER TABLE `partner_brand_restaurant` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:44
