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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:40
