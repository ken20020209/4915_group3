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
-- Table structure for table `warehousedispatchinstruction`
--

DROP TABLE IF EXISTS `warehousedispatchinstruction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehousedispatchinstruction` (
  `Instruction_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify different DispatchInstruction\n0000000000-9999999999\n\n',
  `warehouse_ID` int NOT NULL COMMENT 'The ID to identify the purchase order\n0000000000-9999999999\n\n',
  `handler` int DEFAULT NULL COMMENT 'The ID to identify the handler\\n0000000000-9999999999\\n\\n',
  `remark` varchar(30) DEFAULT NULL COMMENT 'The remark that they have to add \n\n\n\n',
  `itemID` int NOT NULL COMMENT 'The ID to identify the item\n0000000000-9999999999\n\n',
  `status_id` int DEFAULT NULL COMMENT 'The ID to identify the status\\n0000000000-9999999999\\n\\n',
  `Purchasers_Request_id` int NOT NULL COMMENT 'The ID to identify the purchasers request\n0000000000-9999999999\n\n',
  PRIMARY KEY (`Instruction_ID`),
  KEY `WarehouseDispatchInstruction__fk_idx` (`warehouse_ID`,`itemID`),
  KEY `WarehouseDispatchInstruction_handler_fk_idx` (`handler`),
  KEY `WarehouseDispatchInstruction_status_id_fk_idx` (`status_id`),
  KEY `WarehouseDispatchInstruction_Purchasers_Request_id_fk_idx` (`Purchasers_Request_id`),
  CONSTRAINT `WarehouseDispatchInstruction_handler_fk` FOREIGN KEY (`handler`) REFERENCES `user` (`user_id`),
  CONSTRAINT `WarehouseDispatchInstruction_Purchasers_Request_id_fk` FOREIGN KEY (`Purchasers_Request_id`) REFERENCES `purchasers_request` (`purchasers_request_id`),
  CONSTRAINT `WarehouseDispatchInstruction_status_id_fk` FOREIGN KEY (`status_id`) REFERENCES `status` (`status_ID`),
  CONSTRAINT `WarehouseDispatchInstruction_warehouse_ID_itemID_fk` FOREIGN KEY (`warehouse_ID`, `itemID`) REFERENCES `warehouse_item` (`warehouse_ID`, `item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehousedispatchinstruction`
--

LOCK TABLES `warehousedispatchinstruction` WRITE;
/*!40000 ALTER TABLE `warehousedispatchinstruction` DISABLE KEYS */;
INSERT INTO `warehousedispatchinstruction` VALUES (1,1,1,'',1,3000,3),(2,2,2,NULL,4,3000,4),(3,3,3,NULL,6,3000,5),(4,4,4,NULL,7,3000,6),(5,1,NULL,'kryptonTextBoxRemark',1,3000,3),(6,1,NULL,'kryptonTextBoxRemark',1,3000,3),(7,1,NULL,'kryptonTextBoxRemark',1,3000,3),(8,1,NULL,'kryptonTextBoxRemark',1,3000,3),(9,1,NULL,'kryptonTextBoxRemark',1,3000,7),(10,1,NULL,'kryptonTextBoxRemark',1,3000,7),(11,1,NULL,NULL,2,3000,6),(12,1,NULL,NULL,2,3000,6);
/*!40000 ALTER TABLE `warehousedispatchinstruction` ENABLE KEYS */;
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
