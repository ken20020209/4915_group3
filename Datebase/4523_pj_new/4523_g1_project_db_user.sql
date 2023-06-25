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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Sam','Yau',1,'sam123','123123','m','12345678','sam@gmail.com'),(2,'Helen','Chung',21,'helen1','123123','f','78536570','helen@gmail.com'),(3,'Ken','Leung',2,'ken124','123321','m','54327865','ken@gmail.com'),(4,'Oscar','Chu',3,'oscar456','098765','m','74358986','oscar@gmail.com'),(5,'Yuksen','Lam',3,'sing654','567890','m','96436789','yuksen@gmail.com'),(6,'Helen','Chung',22,'helen2','123123','f','55555555','helen2@gmail.com'),(7,'Helen','Chung',23,'helen3','123123','f','11111111','helen3@gmail.com'),(8,'Helen','Chung',7,'HelenD','123123','f','12341234','de;iveryHelen@gmail.com'),(9,'Helen','Chung',4,'HelenA','123123','f','54123654','accountingHelen@gmail.com');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 16:45:46
