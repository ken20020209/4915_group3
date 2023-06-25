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
-- Table structure for table `food_beverage`
--

DROP TABLE IF EXISTS `food_beverage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `food_beverage` (
  `Food_Beverage_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of the\nfood and beverage \n0000000000-9999999999\n\n',
  `category_ID` int NOT NULL COMMENT 'The ID of the category\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of the food and beverage\n\n\n\n',
  `description` varchar(30) DEFAULT NULL COMMENT 'The description of the food and beverage\n\n\n\n',
  PRIMARY KEY (`Food_Beverage_ID`),
  KEY `Food_Beverage_category_ID_fk_idx` (`category_ID`),
  CONSTRAINT `Food_Beverage_category_ID_fk` FOREIGN KEY (`category_ID`) REFERENCES `item_category` (`category_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `food_beverage`
--

LOCK TABLES `food_beverage` WRITE;
/*!40000 ALTER TABLE `food_beverage` DISABLE KEYS */;
INSERT INTO `food_beverage` VALUES (1,1,'Apple',NULL),(2,2,'Coca-cola',NULL),(3,1,'Fish',NULL);
/*!40000 ALTER TABLE `food_beverage` ENABLE KEYS */;
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
