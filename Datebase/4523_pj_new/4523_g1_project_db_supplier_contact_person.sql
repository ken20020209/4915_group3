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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:44
