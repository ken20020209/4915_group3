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
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `item_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The quantity to identify each item inside the warehouse\n0000000000-9999999999\n\n',
  `item_name` varchar(50) NOT NULL,
  `price` decimal(10,2) NOT NULL COMMENT 'The price of each item\n\n\n\n',
  `size` varchar(30) NOT NULL COMMENT 'The size of the product\nS, M, L\n\n',
  `category_ID` int NOT NULL COMMENT 'The ID that identify the category\n0000000000-9999999999\n\n',
  `partner_brand_ID` int NOT NULL COMMENT 'The ID of the partner’s brand\n0000000000-9999999999\n\n',
  PRIMARY KEY (`item_ID`),
  KEY `item_category_ID_fk_idx` (`category_ID`),
  KEY `item_partner_brand_ID_fk_idx` (`partner_brand_ID`),
  CONSTRAINT `item_category_ID_fk` FOREIGN KEY (`category_ID`) REFERENCES `item_category` (`category_ID`),
  CONSTRAINT `item_partner_brand_ID_fk` FOREIGN KEY (`partner_brand_ID`) REFERENCES `partner_brand` (`partner_brand_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'Fish',100.00,'2Kg',1,1),(2,'Beef',180.00,'1kg',1,1),(3,'Chicken',120.00,'2.5Kg',1,1),(4,'Vegetable',60.00,'1Kg',1,1),(5,'Fruit',70.00,'1.5Kg',1,1),(6,'Drinks',90.00,'5lt',2,1),(7,'Seasoning',50.00,'2Kg',3,1);
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
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
