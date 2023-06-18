CREATE DATABASE  IF NOT EXISTS `4523_g1_project_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `4523_g1_project_db`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
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
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `address` (
  `address_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the address\nXX000000000000000000-XX999999999999999999\nXX =\n‘KW’ for Kowloon\n‘NT’ for New Territories\n‘HK’ for Hong Kong Island\n\n',
  `name` varchar(30) DEFAULT NULL COMMENT 'The name\n\n',
  `district` varchar(30) DEFAULT NULL COMMENT 'The district of the address\n‘KW’ for Kowloon\n‘NT’ for New Territories\n‘HK’ for Hong Kong Island\n\n',
  `street` varchar(30) DEFAULT NULL COMMENT 'The street of the address\n\n',
  `building` varchar(30) DEFAULT NULL COMMENT 'The building of the address\n\n',
  `floor` varchar(5) DEFAULT NULL COMMENT 'the floor of the address\n\n',
  `unit` varchar(5) DEFAULT NULL COMMENT 'The unit of the address\n\n',
  PRIMARY KEY (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
INSERT INTO `address` VALUES (1,'Golden','Kowloon','Tai Nan Street','Lai Kin ','5','5C'),(2,'SingaLong','Hong Kong Island','Aberdeen Street','Lai Guon','10','10F'),(3,'Beef C.A','Kowloon','Austin Road','Peninsula','4','4H'),(4,'Fruit & Fresh','Hong Kong Island','Anton Street','White Tower','2','2G'),(5,'Omakasesan','Kowloon','Haiphong Road','Red Brick Cost','8','8A'),(6,'Good','Kowloon','Roaming Road','NA','G','023G'),(7,'God','Kowloon','Sunsine Street','NA','G','032G'),(8,'Asia-Res','Hong Kong Island','Globa Record','NA','G','101G');
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `blanket_release`
--

DROP TABLE IF EXISTS `blanket_release`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `blanket_release` (
  `release_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the Blanket release\n0000000000-9999999999\n\n',
  `line_ID` int NOT NULL COMMENT 'The ID to identify the header\\n0000000000-9999999999\\n\\n',
  `create_date` date NOT NULL COMMENT 'The date where the Blanket release is created\nDDMMYYYY\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'The expected delivery date of the Blanket release\nDDMMYYYY\n\n',
  `item_qty` int NOT NULL COMMENT 'The quantity of each item\n\n\n\n',
  `shipment_ID` int DEFAULT NULL,
  PRIMARY KEY (`release_ID`),
  KEY `Blanket_Release_line_ID_fk_idx` (`line_ID`),
  KEY `Blanket_shipment_ID_fk_idx` (`shipment_ID`),
  CONSTRAINT `Blanket_Release_line_ID_fk` FOREIGN KEY (`line_ID`) REFERENCES `bpa_lines` (`lines_ID`),
  CONSTRAINT `Blanket_shipment_ID_fk` FOREIGN KEY (`shipment_ID`) REFERENCES `address` (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `blanket_release`
--

LOCK TABLES `blanket_release` WRITE;
/*!40000 ALTER TABLE `blanket_release` DISABLE KEYS */;
INSERT INTO `blanket_release` VALUES (1,1,'2023-09-17','2023-08-22',150,NULL),(2,2,'2023-05-29','2023-09-03',120,NULL),(3,3,'2023-03-22','2023-04-01',140,NULL),(4,4,'2023-04-16','2023-04-29',130,NULL),(5,2,'2023-06-17','2023-06-17',99,NULL),(6,2,'2023-06-17','2023-06-17',99,NULL),(7,1,'2023-06-17','2023-06-17',99,NULL),(8,2,'2023-06-17','2023-06-17',99,NULL),(9,2,'2023-06-17','2023-06-17',99,NULL);
/*!40000 ALTER TABLE `blanket_release` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bpa_header`
--

DROP TABLE IF EXISTS `bpa_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bpa_header` (
  `header_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the header of BPA\n0000000000-9999999999\n\n',
  `purchase_order_revision` tinyint NOT NULL COMMENT 'The purchase order whether need a revision\nYes\nNo\n\n',
  `create_date` date NOT NULL COMMENT 'The date which the BPA is created\nDDMMYYYY\n\n',
  `effective_dates` date NOT NULL COMMENT 'The effective date of BPA\nDDMMYYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID to identify the BPA supplier\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID to identify the BPA buyer\n0000000000-9999999999\n\n',
  `agreed_amount` int NOT NULL COMMENT 'The agreed amount between the seller and buyer \n\n\n\n',
  `currency` decimal(10,2) NOT NULL COMMENT 'The currency of BPA\n\n\n\n',
  `terms` varchar(30) DEFAULT NULL,
  `condition` varchar(30) DEFAULT NULL COMMENT 'If exist other requirements in this trade\n\n\n\n',
  PRIMARY KEY (`header_ID`),
  KEY `BPA_header_supplier_ID_fk_idx` (`supplier_ID`),
  KEY `BPA_header_buyer_ID_fk_idx` (`buyer_ID`),
  CONSTRAINT `BPA_header_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `BPA_header_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bpa_header`
--

LOCK TABLES `bpa_header` WRITE;
/*!40000 ALTER TABLE `bpa_header` DISABLE KEYS */;
INSERT INTO `bpa_header` VALUES (1,1,'2023-04-03','2023-12-12',3,1,1000,1000.00,NULL,NULL),(2,1,'2023-03-27','2023-10-30',2,3,800,800.00,NULL,NULL),(3,0,'2023-03-27','2023-10-30',3,2,3000,3000.00,NULL,NULL),(4,0,'2023-03-01','2023-10-09',4,1,1500,1500.00,NULL,NULL),(5,1,'2023-06-01','2023-08-18',1,1,10000,100.00,'',''),(6,1,'2023-01-01','2023-08-18',3,1,10000,120.00,'','');
/*!40000 ALTER TABLE `bpa_header` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bpa_lines`
--

DROP TABLE IF EXISTS `bpa_lines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bpa_lines` (
  `lines_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the BPA line \n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID to identify the header\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify the BPA item\n0000000000-9999999999\n\n',
  `promised_qty` int NOT NULL COMMENT 'The promised quantity of item\n\n\n\n',
  `UOM` varchar(50) DEFAULT NULL,
  `MoQ` int DEFAULT NULL,
  `price` decimal(10,2) NOT NULL COMMENT 'The price of BPA lines\n\n\n\n',
  `amount` int NOT NULL COMMENT 'The amount of item in each BPA lines\n\n\n\n',
  `reference` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`lines_ID`),
  KEY `BPA_lines_header_ID_fk_idx` (`header_ID`),
  KEY `BPA_lines_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `BPA_lines_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `bpa_header` (`header_ID`),
  CONSTRAINT `BPA_lines_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bpa_lines`
--

LOCK TABLES `bpa_lines` WRITE;
/*!40000 ALTER TABLE `bpa_lines` DISABLE KEYS */;
INSERT INTO `bpa_lines` VALUES (1,1,1,36,'Kg',3,100.00,300,NULL),(2,2,2,4,'Kg',3,180.00,720,NULL),(3,3,3,7,'Kg',6,120.00,840,NULL),(4,4,4,14,'Kg',6,60.00,840,NULL),(5,1,1,35,'1',1,1.00,1,NULL),(6,1,2,3,'Kg',6,660.00,56,NULL),(7,6,1,10000,'1kg',0,1.00,20000,'no');
/*!40000 ALTER TABLE `bpa_lines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cpa`
--

DROP TABLE IF EXISTS `cpa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cpa` (
  `CPA_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of CPA\n0000000000-9999999999\n\n',
  `create_date` date NOT NULL COMMENT 'the create date of CPA\nDD/MM/YYYY\n\n',
  `effective_date` date NOT NULL COMMENT 'The effective date of CPA\nDD/MM/YYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID of the supplier to identify different suppliers\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID of the buyers to identify different suppliers \n0000000000-9999999999\n\n',
  `terms` varchar(30) NOT NULL COMMENT 'The terms of CPA.\n\n\n\n',
  `condition` varchar(30) NOT NULL COMMENT 'The condition of CPA.\n\n\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID of the item\n0000000000-9999999999\n\n',
  PRIMARY KEY (`CPA_ID`),
  KEY `CPA_supplier_ID_fk_idx` (`supplier_ID`),
  KEY `CPA_buyer_ID_fk_idx` (`buyer_ID`),
  KEY `CPA_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `CPA_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `CPA_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `CPA_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cpa`
--

LOCK TABLES `cpa` WRITE;
/*!40000 ALTER TABLE `cpa` DISABLE KEYS */;
INSERT INTO `cpa` VALUES (1,'2023-03-10','2023-03-12',1,3,'NA','NA',1),(2,'2023-03-27','2023-03-30',2,3,'NA','NA',2),(3,'2023-03-27','2023-03-20',3,2,'NA','NA',3),(4,'2023-03-01','2023-03-07',4,3,'NA','NA',4);
/*!40000 ALTER TABLE `cpa` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_request`
--

LOCK TABLES `delivery_request` WRITE;
/*!40000 ALTER TABLE `delivery_request` DISABLE KEYS */;
INSERT INTO `delivery_request` VALUES (1,1,1,3,4,3000,'2023-03-16','2023-03-20','12:34:56','10:04:32',1),(2,2,2,4,5,3000,'2023-04-23','2023-04-27','11:54:20','12:06:49',2),(3,3,3,2,7,3000,'2023-02-28','2023-03-05','14:52:11','15:07:23',2),(4,4,4,1,4,3000,'2023-03-06','2023-03-17','16:43:22','17:23:45',3);
/*!40000 ALTER TABLE `delivery_request` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `dept_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each department\n0000000000-9999999999\n\n',
  `dept_name` varchar(30) NOT NULL COMMENT 'The name of each department\n\n',
  `description` varchar(50) DEFAULT NULL COMMENT 'What kind of service provide the department\n\n',
  PRIMARY KEY (`dept_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Accounting',NULL),(2,'Human resources',NULL),(3,'Marketing',NULL),(4,'Service',NULL),(5,'Management',NULL),(6,'Restaurant',NULL);
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department_role`
--

DROP TABLE IF EXISTS `department_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department_role` (
  `dept_id` int NOT NULL COMMENT 'The ID to identify the department\n0000000000-9999999999\n\n',
  `role_id` int NOT NULL COMMENT 'The ID to identify the role\n0000000000-9999999999\n\n',
  PRIMARY KEY (`dept_id`,`role_id`),
  KEY `role_id_fk_idx` (`role_id`),
  CONSTRAINT `department_role_dept_id_fk` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dept_id`),
  CONSTRAINT `department_role_role_id_fk` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department_role`
--

LOCK TABLES `department_role` WRITE;
/*!40000 ALTER TABLE `department_role` DISABLE KEYS */;
INSERT INTO `department_role` VALUES (6,1),(5,2),(4,3),(1,4),(3,5),(2,6);
/*!40000 ALTER TABLE `department_role` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `Invoice_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify different invoice\n0000000000-9999999999\n\n',
  `purchase_order_ID` int NOT NULL COMMENT 'The ID to identify the purchase order\nCCCCBBYYYYMMDDSSSS\n\nCCCC - Company Code\nBB - Branch\nYYYY - Year\nMM - Month\nDD - Day\nSSSS - Sequence number per day\n\n',
  `arrival_date` date NOT NULL COMMENT 'The date of arrival \nDDMMYYYY\n\n',
  `shipping_date` date NOT NULL COMMENT 'The date of shipping\nDDMMYYYY\n\n',
  PRIMARY KEY (`Invoice_ID`),
  KEY `Invoice_purchase_order_ID_fk_idx` (`purchase_order_ID`),
  CONSTRAINT `Invoice_purchase_order_ID_fk` FOREIGN KEY (`purchase_order_ID`) REFERENCES `purchase_order_all` (`Purchase_order_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
INSERT INTO `invoice` VALUES (1,1,'2023-04-25','2023-04-19'),(2,2,'2023-03-17','2023-03-11'),(3,3,'2023-02-11','2023-02-01'),(4,4,'2023-04-11','2023-04-01');
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `item_category`
--

DROP TABLE IF EXISTS `item_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_category` (
  `category_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of the category\n0000000000-9999999999\n\n',
  `category_name` varchar(30) NOT NULL COMMENT 'The name of the category\n\n\n\n',
  `description` varchar(30) DEFAULT NULL COMMENT 'The description of the item\n\n\n\n',
  PRIMARY KEY (`category_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_category`
--

LOCK TABLES `item_category` WRITE;
/*!40000 ALTER TABLE `item_category` DISABLE KEYS */;
INSERT INTO `item_category` VALUES (1,'Food',NULL),(2,'Drink',NULL),(3,'Seasoning',NULL);
/*!40000 ALTER TABLE `item_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `new_view`
--

DROP TABLE IF EXISTS `new_view`;
/*!50001 DROP VIEW IF EXISTS `new_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `new_view` AS SELECT 
 1 AS `role_id`,
 1 AS `role_name`,
 1 AS `role_description`,
 1 AS `department name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `notify_message`
--

DROP TABLE IF EXISTS `notify_message`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notify_message` (
  `notify_message_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify different notify_message\n0000000000-9999999999\n\n',
  `notify_rule_id` int NOT NULL COMMENT 'The ID to identify the purchase order\n0000000000-9999999999\n\n',
  `message` varchar(255) NOT NULL COMMENT 'The message to notify user\n\n\n\n',
  PRIMARY KEY (`notify_message_id`),
  KEY `notify_message_notify_rule_id_fk_idx` (`notify_rule_id`),
  CONSTRAINT `notify_message_notify_rule_id_fk` FOREIGN KEY (`notify_rule_id`) REFERENCES `notify_rule` (`notify_rule_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notify_message`
--

LOCK TABLES `notify_message` WRITE;
/*!40000 ALTER TABLE `notify_message` DISABLE KEYS */;
/*!40000 ALTER TABLE `notify_message` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notify_rule`
--

DROP TABLE IF EXISTS `notify_rule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notify_rule` (
  `notify_rule_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify different rule\n0000000000-9999999999\n\n',
  `user_id` int NOT NULL COMMENT 'The ID to identify the purchase order\n0000000000-9999999999\n\n\n',
  `tablename` varchar(30) NOT NULL COMMENT 'The date of table name\n\n\n\n\n',
  `colum` varchar(30) NOT NULL COMMENT 'The date of colum name\n\n\n\n',
  `pk` varchar(45) NOT NULL COMMENT 'The primary key of table\n\n\n\n',
  `condition` varchar(30) NOT NULL COMMENT 'the condition with table data.\nabove\nbelow\nequal\n\n',
  `compare_value` int DEFAULT NULL COMMENT 'The value compare with table data.\n\n\n\n',
  PRIMARY KEY (`notify_rule_id`),
  CONSTRAINT `notify_rule_user_id_fk` FOREIGN KEY (`notify_rule_id`) REFERENCES `user` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notify_rule`
--

LOCK TABLES `notify_rule` WRITE;
/*!40000 ALTER TABLE `notify_rule` DISABLE KEYS */;
/*!40000 ALTER TABLE `notify_rule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partner_brand`
--

DROP TABLE IF EXISTS `partner_brand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partner_brand` (
  `partner_brand_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify  the partner brand\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of the partner brand\n\n\n\n',
  `type` varchar(30) NOT NULL COMMENT 'Which occupational category is?\n\n\n\n',
  `remarks` varchar(30) DEFAULT NULL COMMENT 'The remark that they have to add \n\n\n\n',
  PRIMARY KEY (`partner_brand_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partner_brand`
--

LOCK TABLES `partner_brand` WRITE;
/*!40000 ALTER TABLE `partner_brand` DISABLE KEYS */;
INSERT INTO `partner_brand` VALUES (1,'Salon Canton','Chinese',NULL),(2,'Le Cochon Gaulois','French',NULL),(3,'Omakase','Japanese',NULL),(4,'Pizza Squad','Italian',NULL),(5,'Lotus Feed You','Indian',NULL);
/*!40000 ALTER TABLE `partner_brand` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `permission`
--

DROP TABLE IF EXISTS `permission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permission` (
  `permission_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the permission\n0000000000-9999999999\n\n',
  `permission_name` varchar(30) NOT NULL COMMENT 'The name of type permission\nall use case name\n\n',
  `permission_description` varchar(50) DEFAULT NULL COMMENT 'What kind of permission is',
  PRIMARY KEY (`permission_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permission`
--

LOCK TABLES `permission` WRITE;
/*!40000 ALTER TABLE `permission` DISABLE KEYS */;
INSERT INTO `permission` VALUES (1,'Full-permission',NULL),(2,'Semi-permission',NULL),(3,'No-permission',NULL);
/*!40000 ALTER TABLE `permission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ppo_header`
--

DROP TABLE IF EXISTS `ppo_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ppo_header` (
  `header_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of PPO header to identify different PPO Header\n0000000000-9999999999\n\n',
  `purchase_order_revision_ID` char(2) NOT NULL COMMENT 'The ID of purchase order to identify different purchase order revision times\n00-99\n\n',
  `create_date` date NOT NULL COMMENT 'the date that create the purchase order\nDDMMYYYY\n\n',
  `effective_date` date NOT NULL COMMENT 'the date that the purchase order happens\nDDMMYYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID to identify the supplier of PPO header\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID to identify the buyer of PPO header\n0000000000-9999999999\n\n',
  `tentative_schedules` date NOT NULL COMMENT 'The tentative schedule of PPO header\nDDMMYYYY\n\n',
  `amount` int NOT NULL COMMENT 'The amount of item bought\n\n\n\n',
  `currency` decimal(10,2) NOT NULL COMMENT 'The price of the purchase order\n\n\n\n',
  `term` varchar(30) NOT NULL COMMENT '?',
  `condition` varchar(30) NOT NULL COMMENT '?',
  PRIMARY KEY (`header_ID`),
  KEY `PPO_header_supplier_ID_fk_idx` (`supplier_ID`),
  KEY `PPO_header_buyer_ID_fk_idx` (`buyer_ID`),
  CONSTRAINT `PPO_header_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `PPO_header_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ppo_header`
--

LOCK TABLES `ppo_header` WRITE;
/*!40000 ALTER TABLE `ppo_header` DISABLE KEYS */;
INSERT INTO `ppo_header` VALUES (1,'1','2023-02-11','2023-03-22',1,1,'2023-03-21',2000,2000.00,'NA','NA'),(2,'2','2023-02-19','2023-03-14',2,3,'2023-03-13',1632,1632.00,'NA','NA'),(3,'3','2023-03-19','2023-04-12',3,2,'2023-04-11',1460,1460.00,'NA','NA'),(4,'4','2023-04-26','2023-05-17',4,1,'2023-05-16',2100,2100.00,'NA','NA');
/*!40000 ALTER TABLE `ppo_header` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `purchase_order_all`
--

DROP TABLE IF EXISTS `purchase_order_all`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_order_all` (
  `Purchase_order_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the purchase order all \nCCCCBBYYYYMMDDSSSS\n\nCCCC - Company Code\nBB - Branch\nYYYY - Year\nMM - Month\nDD - Day\nSSSS - Sequence number per day\n\n',
  `BR_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `SR_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `SPO_relase_ID` int DEFAULT NULL COMMENT 'The ID to identify the release of purchase order all\n0000000000-9999999999\n\n',
  `purchasers_request_ID` int DEFAULT NULL COMMENT 'The ID to identify the purchaser request of purchase order all\\n0000000000-9999999999\\n\\n',
  `delivery_note_ID` int DEFAULT NULL COMMENT 'The ID to identify the delivery note of purchase order all\n0000000000-9999999999\n\n',
  `description` varchar(50) DEFAULT NULL COMMENT 'The details of this purchase order all\n\n\n\n',
  PRIMARY KEY (`Purchase_order_ID`),
  KEY `purchase_order_all_BR_relase_ID_fk_idx` (`BR_relase_ID`),
  KEY `purchase_order_all_SR_relase_ID_fk_idx` (`SR_relase_ID`),
  KEY `purchase_order_all_SPO_relase_ID_fk_idx` (`SPO_relase_ID`),
  KEY `purchase_order_all_purchasers_request_ID_fk_idx` (`purchasers_request_ID`),
  KEY `purchase_order_all_delivery_note_ID_fk_idx` (`delivery_note_ID`),
  CONSTRAINT `purchase_order_all_BR_relase_ID_fk` FOREIGN KEY (`BR_relase_ID`) REFERENCES `blanket_release` (`release_ID`),
  CONSTRAINT `purchase_order_all_delivery_note_ID_fk` FOREIGN KEY (`delivery_note_ID`) REFERENCES `delivery_request` (`delivery_request_ID`),
  CONSTRAINT `purchase_order_all_purchasers_request_ID_fk` FOREIGN KEY (`purchasers_request_ID`) REFERENCES `purchasers_request` (`purchasers_request_id`),
  CONSTRAINT `purchase_order_all_SPO_relase_ID_fk` FOREIGN KEY (`SPO_relase_ID`) REFERENCES `spo_release` (`release_ID`),
  CONSTRAINT `purchase_order_all_SR_relase_ID_fk` FOREIGN KEY (`SR_relase_ID`) REFERENCES `schedule_release` (`release_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_all`
--

LOCK TABLES `purchase_order_all` WRITE;
/*!40000 ALTER TABLE `purchase_order_all` DISABLE KEYS */;
INSERT INTO `purchase_order_all` VALUES (1,1,1,1,3,3,NULL),(2,2,2,2,4,2,NULL),(3,3,3,3,7,1,NULL),(4,4,4,4,5,2,NULL),(5,5,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(6,6,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(7,7,NULL,NULL,3,NULL,'kryptonTextBoxRemark'),(8,8,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(9,9,NULL,NULL,4,NULL,'kryptonTextBoxRemark'),(10,NULL,NULL,4,5,NULL,'kryptonTextBoxRemark');
/*!40000 ALTER TABLE `purchase_order_all` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `purchasers_request` VALUES (3,1,1,1,99,1,1000,'2023-06-13','2023-06-13',''),(4,1,1,2,99,2,1000,'2023-06-13','2023-06-13',''),(5,1,1,1,9999,2,1000,'2023-06-13','2023-06-13',''),(6,1,1,2,88,3,1000,'2023-06-13','2023-06-13',''),(7,1,1,1,123,4,1000,'2023-06-13','2023-06-13','');
/*!40000 ALTER TABLE `purchasers_request` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restaurant`
--

DROP TABLE IF EXISTS `restaurant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restaurant` (
  `restaurant_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each restaurant\nXX00000000-XX99999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of each restaurant\n\n',
  `address_ID` int NOT NULL COMMENT 'The ID to identify each address\nXX000000000000000000-XX999999999999999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `type` varchar(20) NOT NULL COMMENT 'Type of the the restaurant\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n‘FR’ for French\n\n',
  `phone` char(8) NOT NULL COMMENT 'The phone number of the restaurant. (Hong Kong number)\n00000000-\n99999999\n\n',
  PRIMARY KEY (`restaurant_ID`),
  KEY `Restaurant_address_ID_fk_idx` (`address_ID`),
  CONSTRAINT `Restaurant_address_ID_fk` FOREIGN KEY (`address_ID`) REFERENCES `address` (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurant`
--

LOCK TABLES `restaurant` WRITE;
/*!40000 ALTER TABLE `restaurant` DISABLE KEYS */;
INSERT INTO `restaurant` VALUES (1,'Good',6,'1','12345678'),(2,'God',7,'2','98765432'),(3,'Asia-Res',8,'2','67439867');
/*!40000 ALTER TABLE `restaurant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restaurant_stock_item`
--

DROP TABLE IF EXISTS `restaurant_stock_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restaurant_stock_item` (
  `restaurant_ID` int NOT NULL COMMENT 'The ID to identify each restaurant\nXX00000000-XX99999999\n\nXX:\n‘JP’ for Japan\n‘CH’ for Chinese\n‘TW’ for Taiwan\n‘IN’ for India\n‘VT’ for Vietnam\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID to identify each item\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity of each item in the stock',
  `remarks` varchar(50) DEFAULT NULL COMMENT 'The remark that they have to add \n\n',
  `expected_inventory` int DEFAULT NULL COMMENT 'Expiry date of each item\\\\\\\\nYYYYMMDD\\\\\\\\n\\\\\\\\n',
  PRIMARY KEY (`restaurant_ID`,`item_ID`),
  KEY `Restaurant_Stock_Item_item_ID_fk_idx` (`item_ID`),
  CONSTRAINT `Restaurant_Stock_Item_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `Restaurant_Stock_Item_restaurant_ID_fk` FOREIGN KEY (`restaurant_ID`) REFERENCES `restaurant` (`restaurant_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurant_stock_item`
--

LOCK TABLES `restaurant_stock_item` WRITE;
/*!40000 ALTER TABLE `restaurant_stock_item` DISABLE KEYS */;
INSERT INTO `restaurant_stock_item` VALUES (1,1,150,NULL,NULL),(2,2,150,NULL,NULL),(3,3,150,NULL,NULL);
/*!40000 ALTER TABLE `restaurant_stock_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `restaurantstockdetail`
--

DROP TABLE IF EXISTS `restaurantstockdetail`;
/*!50001 DROP VIEW IF EXISTS `restaurantstockdetail`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `restaurantstockdetail` AS SELECT 
 1 AS `item_ID`,
 1 AS `item_name`,
 1 AS `category_name`,
 1 AS `name`,
 1 AS `qty`,
 1 AS `remarks`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `role_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the role\n0000000000-9999999999\n\n',
  `role_name` varchar(30) NOT NULL COMMENT 'The name of role',
  `role_description` varchar(50) DEFAULT NULL COMMENT 'The title of the role',
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Restaurant manger',NULL),(2,'Restaurant Sub-manager',NULL),(3,'PTSA',NULL),(4,'Accountant',NULL),(5,'Sales',NULL),(6,'HR staff',NULL);
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role_permission`
--

DROP TABLE IF EXISTS `role_permission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role_permission` (
  `role_id` int NOT NULL COMMENT 'The ID to identify the \nrole\n0000000000-9999999999\n\n',
  `permission_id` int NOT NULL COMMENT 'The ID to identify the permission\n0000000000-9999999999\n\n',
  PRIMARY KEY (`role_id`,`permission_id`),
  KEY `permission_id_fk_idx` (`permission_id`),
  CONSTRAINT `Role_Permission_permission_id_fk` FOREIGN KEY (`permission_id`) REFERENCES `permission` (`permission_id`),
  CONSTRAINT `Role_Permission_role_id_fk` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role_permission`
--

LOCK TABLES `role_permission` WRITE;
/*!40000 ALTER TABLE `role_permission` DISABLE KEYS */;
INSERT INTO `role_permission` VALUES (1,1),(2,1),(4,2),(5,2),(6,2),(3,3);
/*!40000 ALTER TABLE `role_permission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule_release`
--

DROP TABLE IF EXISTS `schedule_release`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule_release` (
  `release_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the schedule release\n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID to identify the header of schedule release\\\\n0000000000-9999999999\\\\n\\\\n',
  `create_date` date NOT NULL COMMENT 'The date that is created this schedule release\nDDMMYYYY\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'The expected delivery date of this schedule release\nDDMMYYYY\n\n',
  PRIMARY KEY (`release_ID`),
  KEY `schedule_release_header_ID_fk_idx` (`header_ID`),
  CONSTRAINT `schedule_release_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `ppo_header` (`header_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule_release`
--

LOCK TABLES `schedule_release` WRITE;
/*!40000 ALTER TABLE `schedule_release` DISABLE KEYS */;
INSERT INTO `schedule_release` VALUES (1,1,'2023-09-17','2023-09-22'),(2,2,'2023-05-29','2023-06-03'),(3,3,'2023-03-22','2023-04-01'),(4,4,'2023-04-16','2023-04-29');
/*!40000 ALTER TABLE `schedule_release` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spo_header`
--

DROP TABLE IF EXISTS `spo_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spo_header` (
  `header_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the SPO header\n0000000000-9999999999\n\n',
  `create_date` date NOT NULL COMMENT 'The date when the SPO header created\nDDMsMYYYY\n\n',
  `effective_date` date NOT NULL COMMENT 'the effective date of the SPO header\nDDMMYYYY\n\n',
  `supplier_ID` int NOT NULL COMMENT 'The ID to identify the supplier of the SPO header\n0000000000-9999999999\n\n',
  `buyer_ID` int NOT NULL COMMENT 'The ID to identify the buyer of SPO header\n0000000000-9999999999\n\n',
  `expected_delivery_date` date NOT NULL COMMENT 'The expected delivery date of SPO header\nDDMMYYYY\n\n',
  `terms` varchar(30) DEFAULT NULL,
  `condition` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`header_ID`),
  KEY `SPO_header_buyer_ID_fk_idx` (`buyer_ID`),
  KEY `SPO_header_supplier_ID_fk_idx` (`supplier_ID`),
  CONSTRAINT `SPO_header_buyer_ID_fk` FOREIGN KEY (`buyer_ID`) REFERENCES `user` (`user_id`),
  CONSTRAINT `SPO_header_supplier_ID_fk` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spo_header`
--

LOCK TABLES `spo_header` WRITE;
/*!40000 ALTER TABLE `spo_header` DISABLE KEYS */;
INSERT INTO `spo_header` VALUES (1,'2023-03-04','2023-05-04',1,1,'2023-03-17','NA','NA'),(2,'2023-04-12','2023-06-12',2,3,'2023-04-19','NA','NA'),(3,'2023-05-11','2023-07-11',3,2,'2023-05-18','NA','NA'),(4,'2023-06-12','2023-08-12',4,1,'2023-06-22','NA','NA');
/*!40000 ALTER TABLE `spo_header` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spo_lines`
--

DROP TABLE IF EXISTS `spo_lines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spo_lines` (
  `lines_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of the SPO Lines that identify different SPO Lines\n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID of headers that identify different headers\n0000000000-9999999999\n\n',
  `item_ID` int NOT NULL COMMENT 'The ID of the item\n0000000000-9999999999\n\n',
  `qty` int NOT NULL COMMENT 'The quantity of the item',
  `price` decimal(10,2) NOT NULL COMMENT 'The price of each item\n\n\n\n',
  `UOM` varchar(50) NOT NULL COMMENT 'The UOM of SPO_line\n\n\n\n',
  `amount` int NOT NULL COMMENT 'The total number of item purchased\n\n\n\n',
  `CPA_ID` int NOT NULL COMMENT 'The ID of the CPA that identify different CPA\n0000000000-9999999999\n\n',
  `Quotation_ID` int NOT NULL COMMENT 'The ID of the Quotation that identify different Quotation\n0000000000-9999999999\n\n',
  PRIMARY KEY (`lines_ID`),
  KEY `SPO_lines_header_ID_fk_idx` (`header_ID`),
  KEY `SPO_lines_item_ID_fk_idx` (`item_ID`),
  KEY `SPO_lines_CPA_ID_fk_idx` (`CPA_ID`),
  CONSTRAINT `SPO_lines_CPA_ID_fk` FOREIGN KEY (`CPA_ID`) REFERENCES `cpa` (`CPA_ID`),
  CONSTRAINT `SPO_lines_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `spo_header` (`header_ID`),
  CONSTRAINT `SPO_lines_item_ID_fk` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spo_lines`
--

LOCK TABLES `spo_lines` WRITE;
/*!40000 ALTER TABLE `spo_lines` DISABLE KEYS */;
INSERT INTO `spo_lines` VALUES (11,1,1,50,200.00,'Kg',10000,4,1),(22,2,7,60,250.00,'Kg',15000,2,2),(33,3,3,90,180.00,'Kg',16200,3,3),(44,4,5,70,210.00,'Kg',14700,1,4);
/*!40000 ALTER TABLE `spo_lines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spo_release`
--

DROP TABLE IF EXISTS `spo_release`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `spo_release` (
  `release_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the SPO release\n0000000000-9999999999\n\n',
  `header_ID` int NOT NULL COMMENT 'The ID to identify header of SPO release\n0000000000-9999999999\n\n',
  PRIMARY KEY (`release_ID`),
  KEY `SPO_Release_header_ID_fk_idx` (`header_ID`),
  CONSTRAINT `SPO_Release_header_ID_fk` FOREIGN KEY (`header_ID`) REFERENCES `spo_header` (`header_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spo_release`
--

LOCK TABLES `spo_release` WRITE;
/*!40000 ALTER TABLE `spo_release` DISABLE KEYS */;
INSERT INTO `spo_release` VALUES (1,1),(5,1),(2,2),(3,3),(4,4);
/*!40000 ALTER TABLE `spo_release` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status`
--

DROP TABLE IF EXISTS `status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status` (
  `status_ID` int NOT NULL COMMENT 'The ID of the status\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of the Status\n',
  `description` varchar(30) DEFAULT NULL COMMENT 'The description of the status\n\n\n\n',
  PRIMARY KEY (`status_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status`
--

LOCK TABLES `status` WRITE;
/*!40000 ALTER TABLE `status` DISABLE KEYS */;
INSERT INTO `status` VALUES (1000,'wait to process','request'),(1100,'error process','request'),(1200,'complete process','request'),(2000,'wait to delivery','delivery request'),(2100,'delivered','delivery request'),(3000,'wait to despatch','warehouse'),(3100,'complete despatch','warehouse');
/*!40000 ALTER TABLE `status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `supplier_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each supplier\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of each supplier\n\n',
  `phone` char(8) NOT NULL COMMENT 'The phone number of the user. (Hong Kong number)\n00000000-99999999\n\n',
  `e-mail` varchar(50) NOT NULL COMMENT 'The email of the customer\nValidate email\n\n',
  `address_ID` int NOT NULL COMMENT 'The ID to identify each address.\nXX000000000000000000-XX999999999999999999\n\nXX :\n\n‘US’ for user\n‘SU’ for supplier\n‘WH’ for warehouse\n‘RE’ for restaurant\n\n',
  `contact_person_ID` int NOT NULL COMMENT 'The ID to identify contact person\n0000000000-9999999999\n\n',
  `remarks` varchar(50) DEFAULT NULL COMMENT 'The remark that they have to add \n\n\n\n',
  PRIMARY KEY (`supplier_ID`),
  KEY `supplier_address_ID_fk_idx` (`address_ID`),
  KEY `supplier_contact_person_ID_fk_idx` (`contact_person_ID`),
  CONSTRAINT `supplier_address_ID_fk` FOREIGN KEY (`address_ID`) REFERENCES `address` (`address_id`),
  CONSTRAINT `supplier_contact_person_ID_fk` FOREIGN KEY (`contact_person_ID`) REFERENCES `supplier_contact_person` (`contact_person_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Sea Ken','12345678','sea@gmail.com',1,1,''),(2,'ASDF','45609274','asdf@gmail.com',2,2,NULL),(3,'Glory Sandy','48129745','glory@gmail.com',4,3,NULL),(4,'Cola','76379076','cola@gmail.com',3,4,NULL),(5,'Roger July','56432874','july@gmail.com',5,5,NULL);
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_contact_person`
--

DROP TABLE IF EXISTS `supplier_contact_person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier_contact_person` (
  `contact_person_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID of the contact person\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of the contact person\n\n\n\n',
  `phone` char(8) NOT NULL COMMENT 'The phone number of the user. (Hong Kong number)\n00000000-99999999\n\n',
  `e-mail` varchar(50) NOT NULL COMMENT 'The e-mail of user\nValidate email\n\n',
  `gender` char(1) NOT NULL COMMENT 'The gender of the contact person\n‘F’ for female\n‘M’ for Male\n\n',
  PRIMARY KEY (`contact_person_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_contact_person`
--

LOCK TABLES `supplier_contact_person` WRITE;
/*!40000 ALTER TABLE `supplier_contact_person` DISABLE KEYS */;
INSERT INTO `supplier_contact_person` VALUES (1,'Sam','12345678','sam@gmail.com','m'),(2,'Helen','78536570','helen@gmail.com','f'),(3,'Ken','54327865','ken@gmail.com','m'),(4,'Oscar','74358986','oscar@gmail.com','m'),(5,'Yuksen','96436789','yuksen@gmail.com','m');
/*!40000 ALTER TABLE `supplier_contact_person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `user_id` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each user.',
  `first_name` varchar(30) DEFAULT NULL COMMENT 'The name of the user\n\n',
  `last_name` varchar(30) DEFAULT NULL COMMENT 'The last name of the user',
  `role_id` int DEFAULT NULL COMMENT 'The ID to identify role',
  `user_name` varchar(30) DEFAULT NULL COMMENT 'The name for login',
  `password` varchar(30) DEFAULT NULL COMMENT 'The password for login',
  `gender` char(1) DEFAULT NULL COMMENT 'The gender of the user\n‘F’ for female\n‘M’ for Male\n',
  `phone` char(8) DEFAULT NULL COMMENT 'The phone number of the user. (Hong Kong number)',
  `e-mail` varchar(50) DEFAULT NULL COMMENT 'The e-mail of user\n\n',
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_name_UNIQUE` (`user_name`),
  KEY `User_role_id_fk_idx` (`role_id`),
  CONSTRAINT `User_role_id_fk` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Sam','Yau',1,'sam123','123123','m','12345678','sam@gmail.com'),(2,'Helen','Chung',3,'helenc','456789','f','78536570','helen@gmail.com'),(3,'Ken','Leung',2,'ken124','123321','m','54327865','ken@gmail.com'),(4,'Oscar','Chu',3,'oscar456','098765','m','74358986','oscar@gmail.com'),(5,'Yuksen','Lam',3,'sing654','567890','m','96436789','yuksen@gmail.com');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `vehicle_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify each vehicle \n0000000000-9999999999\n\n',
  `position` varchar(30) DEFAULT NULL COMMENT 'The position of the vehicle during the delivery\n\n',
  `type` varchar(30) NOT NULL COMMENT 'The type of vehicle\nMotorcycle, car, truck\n\n',
  `capacity` int NOT NULL COMMENT 'The area of the vehicle which can  deliver the item\n\n',
  PRIMARY KEY (`vehicle_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,NULL,'Car',4),(2,NULL,'Truck',2),(3,NULL,'Motorcycle',2);
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouse` (
  `warehouse_ID` int NOT NULL AUTO_INCREMENT COMMENT 'The ID to identify the warehouse\n0000000000-9999999999\n\n',
  `name` varchar(30) NOT NULL COMMENT 'The name of warehouse',
  `address_id` int NOT NULL COMMENT 'The ID to identify the address of warehouse\nXX000000000000000000-XX999999999999999999\nXX =\n‘KW’ for Kowloon\n‘NT’ for New Territories\n‘HK’ for Hong Kong Island\n\n',
  PRIMARY KEY (`warehouse_ID`),
  KEY `Warehouse_address_id_fk_idx` (`address_id`),
  CONSTRAINT `Warehouse_address_id_fk` FOREIGN KEY (`address_id`) REFERENCES `address` (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse`
--

LOCK TABLES `warehouse` WRITE;
/*!40000 ALTER TABLE `warehouse` DISABLE KEYS */;
INSERT INTO `warehouse` VALUES (1,'topFreezer',3),(2,'bottomFreezer',4),(3,'drinkHouse',1),(4,'seasoningHouse',2);
/*!40000 ALTER TABLE `warehouse` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `warehouse_item` VALUES (1,1,6498,20230815),(1,2,6410,20230815),(1,3,6666,20230815),(2,4,6666,20230812),(2,5,6666,20230812),(3,2,6498,20231030),(3,6,6666,20230820),(4,7,6666,20231030);
/*!40000 ALTER TABLE `warehouse_item` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Final view structure for view `new_view`
--

/*!50001 DROP VIEW IF EXISTS `new_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `new_view` AS select `role`.`role_id` AS `role_id`,`role`.`role_name` AS `role_name`,`role`.`role_description` AS `role_description`,`department`.`dept_name` AS `department name` from ((`role` join `department`) join `department_role`) where ((`role`.`role_id` = `department_role`.`role_id`) and (`department`.`dept_id` = `department_role`.`dept_id`)) order by `role`.`role_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `restaurantstockdetail`
--

/*!50001 DROP VIEW IF EXISTS `restaurantstockdetail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `restaurantstockdetail` AS select `item`.`item_ID` AS `item_ID`,`item`.`item_name` AS `item_name`,`item_category`.`category_name` AS `category_name`,`partner_brand`.`name` AS `name`,`restaurant_stock_item`.`qty` AS `qty`,`restaurant_stock_item`.`remarks` AS `remarks` from (((`restaurant_stock_item` join `item`) join `item_category`) join `partner_brand`) where ((`restaurant_stock_item`.`item_ID` = `item`.`item_ID`) and (`item`.`category_ID` = `item_category`.`category_ID`) and (`item`.`partner_brand_ID` = `partner_brand`.`partner_brand_ID`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-18 15:43:11
