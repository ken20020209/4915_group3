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
-- Table structure for table `warehouse_item`
--

DROP TABLE IF EXISTS `warehouse_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouse_item` (
  `warehouse_ID` int NOT NULL COMMENT 'The ID to identify the warehouse\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify each item inside the warehouse\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity to identify each item inside the warehouse\n\n',
  `expected_inventory` int DEFAULT NULL COMMENT 'The expiry date of each item inside the warehouse\\nYYYYMMDD\\n\\n',
  PRIMARY KEY (`warehouse_ID`,`item_ID`),
  KEY `Warehouse_item_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `Warehouse_item_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `Warehouse_item_warehouse_ID_fk` FOREIGN KEY (`warehouse_ID`) REFERENCES `warehouse` (`warehouse_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse_item`
--

LOCK TABLES `warehouse_item` WRITE;
/*!40000 ALTER TABLE `warehouse_item` DISABLE KEYS */;
INSERT INTO `warehouse_item` VALUES (1,1,3,20230815),(1,2,0,20230815),(1,3,2,20230815),(2,4,6666,20230812),(2,5,6666,20230812),(3,6,6666,20230820),(4,7,6666,20231030);
/*!40000 ALTER TABLE `warehouse_item` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:47
