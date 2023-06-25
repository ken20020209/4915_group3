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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:43
