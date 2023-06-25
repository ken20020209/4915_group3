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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:40
