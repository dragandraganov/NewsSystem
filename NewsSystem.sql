-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: newssystem
-- ------------------------------------------------------
-- Server version	5.6.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201504280708526_AutomaticMigration','NewsSystem.Data.Migrations.Configuration','�\0\0\0\0\0\0�X�n�6}/������3my\'i��I0r�gZ�V��(\rIe���>�����B�^��E���<w��]�������@H\Z�}<\Z�p?(\'v�Vo~�?����2���C)w���$��Q���q������\"��J��8rH;\'����a#�e��R�h��;���J	��0Y�㎗�Z7$�&�\r|��F*�FD�:g����m�cE\Zyv/�S\"桗�a�M(�\"LBa�Y%~���S,��T�8\Zx|Z�iVxm8�%�Xm��Y����V[�ٔ	-ԉ�(#�|d�oJ s��Ț�L�&R%;���%��/�Yğ�Ox�X�N��\Z�t\'���|�Ua�,�-�y�i4�jgr�f\\����\r*\'K��8x*�pDApG��5d��ho�ZPŠT���d[s���ǉ���uE��+�	���}�CJ��O�5�w(A.���) ���(«5�;A܍v�4�I�/����4�A?/0��y\Zc�z��*��A\0�7 c�k��\'�5�u�l��iT��;��+F�*]�\Z%�kg�C\0�m�?u��Q�C�Q8�k,��R�7!�1e!���}�r��ȟ�_��hdOw�z>�RF����s���#�v�<2�E(�0��C�v�S��wi��[���ke����R��Z���x�4Yd��q9��Q�*��+_�Ƭ��p�lN�-݉;\'I�4�u+Ŋ����7��G9��˞jn�5��h�Z�:QpE�T��-���� ����-.5���.�U�Ka��~�y��\"x�NiZf����_ov��	#���Oc�F|[��tQ��\0���y��C�+�#T9��R���(�u����x��ֱ��\0�Ŷ�d}c ^��vP���M����.�봸ݾ=N������Uܕ��\"F��j����d�\0�I-��ma��h���|�}aE�׏SF�\ZSJ�	�+�*����ѻ����)v�\\��O4Tt��2��l1g�,W(Cg�D��HDOi�a#��ؿc��=��ά�[t\'�a���K��-�\rGk&�	Be3ɝ\0���SƯ1�<�ϭ�ɳ�Z��~��I_��ml^����2F{s_�*v���Կu��+\ZV��_G�-ef|�F���\"�0E0��\\(�\"��m��l�.:�Kl��MU��s)��g�.�uv������mvQ�k��fRM�[�1����8[ 4E���VyJ��pc�nb~ P�H�댺�(a�ܷ�#O��p�������n��\"�aw/(	�d�Q���o���?�)�{�\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `news`
--

DROP TABLE IF EXISTS `news`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `news` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` longtext,
  `Link` varchar(200) DEFAULT NULL,
  `Category` int(11) NOT NULL,
  `Description` longtext,
  `PubDate` datetime NOT NULL,
  `CountVisits` int(11) NOT NULL,
  `CountPublications` int(11) NOT NULL,
  `CountUpdates` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Link` (`Link`) USING HASH
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `news`
--

LOCK TABLES `news` WRITE;
/*!40000 ALTER TABLE `news` DISABLE KEYS */;
INSERT INTO `news` VALUES (2,'Google offers cash to Europe\'s media','http://www.bbc.com/news/technology-32486019 ',3,'Google has pledged to give €150m ($163m; £107m) to European news publishers and journalism-focused start-ups over the next three years.\nThe funds - which are part of a wider package - will be used to support the organisations\' efforts to earn money from their own online coverage.\nThe Financial Times, the Guardian, Spain\'s El Pais and Germany\'s Die Zeit are among those backing the initiative.\n','2015-04-27 00:00:00',2,87,0),(3,'Apple to return more cash to investors as profits soar',' http://www.bbc.com/news/business-32490926 ',2,'Technology giant Apple sold 61.1 million iPhones in the first three months of 2015, driving profit up 33% from a year earlier.\nThe firm reported a $13.6bn (£8.9bn) profit, with revenue up 27% to $58bn.\nSales in greater China leapt 71% to $16.8bn, outpacing those in the US for the first time, and helping to drive the sharp profit rise.\nApple also said it would ramp up its share-buying programme, returning $200bn to investors, up from $130bn.\n','2015-04-28 00:00:00',1,135,0),(5,'Lenovo and Acer smartphones pack huge batteries',' http://www.bbc.com/news/technology-32479717 ',3,' Lenovo and Acer have both unveiled smartphones with much larger than normal batteries.\nA total of three devices from the two companies contain cells with 4,000 milliamp-hour (mAh) capacities.\nThat is more than a third higher than the components used in Samsung and Apple\'s latest flagship phones.\n ','2015-04-27 00:00:00',0,49,0),(6,'Nepal earthquake: Eight million people affected, UN says',' http://www.bbc.com/news/world-asia-32492232',0,'\n    Eight million people have been affected by the massive earthquake in Nepal - more than a quarter of the country\'s population - the United Nations says.\n    International aid has started arriving but there is still huge need - 1.4 million require food aid, the UN said.\n    The 7.8-magnitude quake hit Nepal on Saturday destroying buildings in Kathmandu and severely affecting rural areas across the region.\n    The death toll has risen to 4,310, with almost 8,000 injured, officials say.\n  ','2015-04-28 00:00:00',0,64,0),(7,'Vatican urges action on climate change',' http://www.bbc.com/news/science-environment-32487874',4,'\n    The Vatican Science Academy will urge Christians to take action on climate change because it threatens the world\'s poor.\n    The Academy is being addressed on the issue by the UN Secretary General Ban Ki-moon.\n    Next month the Pope is due to deliver an Encyclical, an official statement, on the dangers of heating the climate.\n    It may be controversial among Catholic conservatives in the US, many of whom say climate change is entirely natural.\n    But Bishop Marcelo Sanchez Sondoro, who heads the Academy, told BBC News that Christians were obliged to be stewards of the Earth and protect the poor - which meant taking action to safeguard the climate.\n  ','2015-04-28 00:00:00',5,58,0),(8,'Five billion people \'have no access to safe surgery\'',' http://www.bbc.com/news/health-32452249',7,'\n    Two-thirds of the world\'s population have no access to safe and affordable surgery, according to a new study in The Lancet - more than double the number in previous estimates.\n    It means millions of people are dying from treatable conditions such as appendicitis and obstructed labour.\n    Most live in low and middle-income countries.\n    The study suggests that 93% of people in sub-Saharan Africa cannot obtain basic surgical care.\n    Previous estimates have only looked at whether surgery was available.\n  ','2015-04-27 00:00:00',0,23,0),(9,'    Mitochondria editing tried in mice  ',' http://www.bbc.com/news/health-32434347',7,'\n    Researchers have developed a technique to edit out bits of mitochondrial DNA that could otherwise pass on incurable diseases, a study in mice shows.\n    Salk Institute scientists used specifically engineered molecular scissors to snip out mutations in embryos, leaving healthy DNA intact.\n    They hope it could one day be used to prevent human mitochondrial diseases.\n    But experts say though it is a \"technical masterpiece\", it raises ethical and scientific challenges.\n    Mitochondria are tiny powerhouses found inside nearly every cell in the body, generating energy necessary for essential functions.\n  ','2015-04-26 00:00:00',0,31,0),(10,'Pepsi to drop artificial sweetener aspartame',' http://www.bbc.com/news/health-32478203',7,'\n    A controversial artificial sweetener is being removed from Diet Pepsi in the US amid consumer concerns about its safety.\n    Aspartame-free cans of the drink will go on sale from August in America, but not in Britain.\n    Regulators in the UK and the US insist aspartame is still safe to use in soft drinks.\n    PepsiCo says its decision is a commercial one - responding to consumer preferences.\n  ','2015-04-27 00:00:00',0,58,0),(11,'Child malaria vaccine: Final trials bring hope',' http://www.bbc.com/news/health-32437383',7,'\n    Final clinical trials of a malaria vaccine - the first to reach this stage - suggest it could help protect millions of children against malaria.\n    But tests on 16,000 children from seven African countries found that booster doses were of limited use and vaccines in young babies were not effective.\n    After children aged 5-17 months were given three doses of the vaccine, the immunisation was only 46% effective.\n    But experts say getting the vaccine this far is a scientific milestone.\n    Data from the trial published in The Lancet showed that the success rate fell to even lower levels in younger infants.\n  ','2015-04-24 00:00:00',3,156,0);
/*!40000 ALTER TABLE `news` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-04-28 10:54:38
