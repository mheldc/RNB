/*
SQLyog Ultimate v10.00 Beta1
MySQL - 5.7.18-log : Database - careserve
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`careserve` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `careserve`;

/*Table structure for table `ca_booking` */

DROP TABLE IF EXISTS `ca_booking`;

CREATE TABLE `ca_booking` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bksrctypeid` int(11) NOT NULL DEFAULT '0',
  `rsvid` bigint(20) NOT NULL DEFAULT '0',
  `guestid` bigint(20) NOT NULL DEFAULT '0',
  `rmtypeid` bigint(20) NOT NULL DEFAULT '0',
  `roomid` bigint(20) NOT NULL DEFAULT '0',
  `rmrate` double(10,2) NOT NULL DEFAULT '0.00',
  `guesta` int(11) NOT NULL DEFAULT '0',
  `guestc` int(11) NOT NULL DEFAULT '0',
  `guestc2` int(11) NOT NULL DEFAULT '0',
  `isovernight` bit(1) NOT NULL DEFAULT b'0',
  `bkstat` bit(1) NOT NULL DEFAULT b'1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`rsvid`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `ca_booking` */

insert  into `ca_booking`(`id`,`bksrctypeid`,`rsvid`,`guestid`,`rmtypeid`,`roomid`,`rmrate`,`guesta`,`guestc`,`guestc2`,`isovernight`,`bkstat`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,0,0,1,1,1,500.00,11,0,0,'\0','\0',1,'2017-05-28 12:44:06',1,'2017-06-11 18:03:45'),(2,0,0,2,2,15,500.00,11,0,0,'\0','\0',1,'2017-05-28 12:51:40',1,'2017-06-11 18:03:49'),(3,0,0,2,1,2,500.00,2,0,0,'\0','\0',1,'2017-05-31 16:29:02',1,'2017-06-11 18:03:55'),(4,0,0,1,2,16,500.00,3,2,0,'','',1,'2017-06-11 18:01:58',1,'2017-09-09 15:38:48'),(5,0,0,2,1,1,500.00,2,2,0,'\0','',1,'2017-06-12 06:59:41',0,'2017-06-12 06:59:41'),(6,0,0,3,1,4,500.00,2,0,0,'','\0',1,'2017-09-06 20:02:13',1,'2017-09-07 02:38:13'),(7,0,0,4,1,2,500.00,2,0,0,'','\0',1,'2017-09-07 02:22:05',1,'2017-09-07 02:38:20'),(8,0,0,5,2,15,500.00,7,2,1,'\0','',1,'2017-09-10 11:27:36',1,'2017-09-11 18:38:28'),(9,0,0,6,1,2,500.00,3,0,0,'','',1,'2017-09-11 21:16:48',0,'2017-09-11 21:16:48'),(10,0,0,6,1,3,500.00,5,0,0,'','',1,'2017-09-11 23:06:22',0,'2017-09-11 23:06:22'),(11,0,0,7,3,17,1000.00,5,3,5,'\0','',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05');

/*Table structure for table `ca_booking_guest` */

DROP TABLE IF EXISTS `ca_booking_guest`;

CREATE TABLE `ca_booking_guest` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `bcid` varchar(20) NOT NULL DEFAULT '''0000000000''',
  `gname` varchar(50) DEFAULT NULL,
  `gclass` int(11) NOT NULL DEFAULT '1',
  `timein` time DEFAULT NULL,
  `entryflag` bit(1) NOT NULL DEFAULT b'0',
  `exitflag` bit(1) NOT NULL DEFAULT b'0',
  `expdate` datetime DEFAULT NULL,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id`,`bkid`,`bcid`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;

/*Data for the table `ca_booking_guest` */

insert  into `ca_booking_guest`(`id`,`bkid`,`bcid`,`gname`,`gclass`,`timein`,`entryflag`,`exitflag`,`expdate`,`createdbyid`,`datecreated`) values (1,3,'0000001',NULL,1,'16:29:34','','\0','2017-06-09 05:00:00',1,'2017-05-31 16:29:34'),(2,3,'0000002',NULL,1,'06:48:51','\0','','2017-06-09 05:00:00',1,'2017-06-02 06:48:51'),(3,4,'0000003',NULL,1,'18:08:17','','\0','2017-06-12 05:00:00',1,'2017-06-12 05:00:00'),(4,4,'0000004',NULL,1,'18:08:18','','\0','2017-06-12 05:00:00',1,'2017-06-12 05:00:00'),(5,5,'0000005',NULL,1,'07:10:15','\0','\0','2017-06-12 17:00:00',1,'2017-06-12 07:10:15'),(6,5,'0000006',NULL,1,'07:25:25','\0','\0','2017-06-12 17:00:00',1,'2017-06-12 07:25:25'),(7,5,'0000007',NULL,1,'07:25:25','\0','\0','2017-06-12 17:00:00',1,'2017-06-12 07:25:25'),(8,5,'0000008',NULL,1,'07:20:48','\0','\0','2017-06-13 17:00:00',1,'2017-06-13 07:20:48'),(9,4,'0987654321',NULL,1,'05:19:55','\0','\0','2017-07-20 05:00:00',1,'2017-07-19 05:19:55'),(10,4,'12121212121',NULL,1,'05:19:55','\0','\0','2017-07-20 05:00:00',1,'2017-07-19 05:19:55'),(11,4,'4545454545454',NULL,1,'05:19:55','\0','\0','2017-07-20 05:00:00',1,'2017-07-19 05:19:55'),(12,8,'0000009',NULL,1,'11:30:26','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:26'),(13,8,'0000010',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(14,8,'0000011',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(15,8,'0000012',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(16,8,'0000013',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(17,8,'0000014',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(18,8,'0000015',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(19,8,'0000016',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(20,8,'0000017',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(21,8,'0000018',NULL,1,'11:30:27','\0','\0','2017-09-10 17:00:00',1,'2017-09-10 11:30:27'),(22,9,'9999999',NULL,1,'12:44:36','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:44:36'),(23,9,'8888888',NULL,1,'12:44:36','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:44:36'),(24,9,'7777777',NULL,1,'12:44:37','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:44:37'),(25,10,'9000000',NULL,1,'12:48:48','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:48:48'),(26,10,'8000000',NULL,1,'12:48:48','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:48:48'),(27,10,'7000000',NULL,1,'12:48:48','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:48:48'),(28,10,'90000007',NULL,1,'12:48:48','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:48:48'),(29,10,'9000007',NULL,1,'12:48:48','\0','\0','2017-09-24 05:00:00',1,'2017-09-23 12:48:48'),(30,11,'7000001',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(31,11,'7000002',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(32,11,'7000003',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(33,11,'7000004',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(34,11,'7000005',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(35,11,'7000006',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(36,11,'7000007',NULL,1,'12:50:59','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:50:59'),(37,11,'7000008',NULL,1,'12:51:00','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:00'),(38,11,'7000009',NULL,1,'12:51:00','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:00'),(39,11,'7000010',NULL,1,'12:51:00','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:00'),(40,11,'7000011',NULL,1,'12:51:00','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:00'),(41,11,'7000012',NULL,1,'12:51:00','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:00'),(42,11,'7000013',NULL,1,'12:51:23','\0','\0','2017-09-23 17:00:00',1,'2017-09-23 12:51:23');

/*Table structure for table `ca_booking_items` */

DROP TABLE IF EXISTS `ca_booking_items`;

CREATE TABLE `ca_booking_items` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `itemtype` int(11) NOT NULL DEFAULT '0',
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `itemdesc` varchar(150) NOT NULL DEFAULT 'Item-0',
  `itemqty` int(11) NOT NULL DEFAULT '1',
  `itemamt` decimal(10,2) NOT NULL DEFAULT '0.00',
  `ispaid` bit(1) NOT NULL DEFAULT b'0',
  `isprinted` bit(1) NOT NULL DEFAULT b'0',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;

/*Data for the table `ca_booking_items` */

insert  into `ca_booking_items`(`id`,`bkid`,`itemtype`,`itemid`,`itemdesc`,`itemqty`,`itemamt`,`ispaid`,`isprinted`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,1,1,0,'Umbrella 01',1,'500.00','','\0',1,'2017-05-28 12:44:06',0,'2017-05-28 12:44:06'),(2,1,2,0,'Entrance Fee (Adult)',11,'2200.00','','\0',1,'2017-05-28 12:44:06',0,'2017-05-28 12:44:06'),(3,2,1,0,'Umbrella 02',1,'500.00','','\0',1,'2017-05-28 12:51:40',0,'2017-05-28 12:51:40'),(4,2,2,0,'Entrance Fee (Adult)',8,'1600.00','','\0',1,'2017-05-28 12:51:40',0,'2017-05-28 12:51:40'),(5,2,2,0,'Entrance Fee (Adult)',3,'600.00','','\0',1,'2017-05-28 12:56:46',0,'2017-05-28 12:56:46'),(6,2,1,0,'Transfer Accommodation : Umbrella 02 to Gazebo 1 Balance to pay : 1,000.00',1,'1000.00','','\0',1,'2017-05-28 12:57:54',0,'2017-05-28 12:57:54'),(7,3,1,0,'Umbrella 02',1,'500.00','','\0',1,'2017-05-31 16:29:02',0,'2017-05-31 16:29:02'),(8,3,2,0,'Entrance Fee (Adult)',1,'200.00','','\0',1,'2017-05-31 16:29:02',0,'2017-05-31 16:29:02'),(9,3,2,0,'Entrance Fee (Adult)',1,'200.00','','\0',1,'2017-06-02 06:45:00',0,'2017-06-02 06:45:00'),(10,4,1,0,'Umbrella 03',1,'500.00','','\0',1,'2017-06-11 18:01:58',0,'2017-06-11 18:01:58'),(11,4,2,0,'Entrance Fee (Adult)',1,'250.00','','\0',1,'2017-06-11 18:01:58',0,'2017-06-11 18:01:58'),(12,4,2,0,'Entrance Fee (Adult)',1,'250.00','','\0',1,'2017-06-11 18:07:54',0,'2017-06-11 18:07:54'),(13,5,1,0,'Umbrella 01',1,'500.00','','\0',1,'2017-06-12 06:59:41',0,'2017-06-12 06:59:41'),(14,5,2,0,'Entrance Fee (Adult)',1,'200.00','','\0',1,'2017-06-12 06:59:41',0,'2017-06-12 06:59:41'),(15,5,2,0,'Entrance Fee (Adult)',1,'200.00','','\0',1,'2017-06-12 07:10:39',0,'2017-06-12 07:10:39'),(16,5,2,0,'Entrance Fee (Senior Citizen / PWD)',1,'100.00','','\0',1,'2017-06-12 07:10:39',0,'2017-06-12 07:10:39'),(17,5,2,0,'Entrance Fee (Senior Citizen / PWD)',1,'100.00','','\0',1,'2017-06-13 07:19:49',0,'2017-06-13 07:19:49'),(18,4,2,0,'Entrance Fee (Adult)',1,'200.00','','\0',1,'2017-07-19 05:19:02',0,'2017-07-19 05:19:02'),(19,4,2,0,'Entrance Fee (Senior Citizen / PWD)',2,'200.00','','\0',1,'2017-07-19 05:19:02',0,'2017-07-19 05:19:02'),(20,6,1,0,'Umbrella 04',1,'500.00','','\0',1,'2017-09-06 20:02:13',0,'2017-09-06 20:02:13'),(21,6,2,0,'Entrance Fee (Adult)',2,'500.00','','\0',1,'2017-09-06 20:02:13',0,'2017-09-06 20:02:13'),(22,7,1,0,'Umbrella 02',1,'500.00','','\0',1,'2017-09-07 02:22:05',0,'2017-09-07 02:22:05'),(23,7,2,0,'Entrance Fee (Adult)',2,'500.00','','\0',1,'2017-09-07 02:22:05',0,'2017-09-07 02:22:05'),(24,4,1,0,'Transfer Accommodation : Umbrella 03 to Gazebo 2 Balance to pay : 1,000.00',1,'1000.00','','\0',1,'2017-09-09 15:29:35',0,'2017-09-09 15:29:35'),(28,4,1,0,'Transfer Accommodation : Gazebo 1 to Gazebo 2 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-09 15:38:48',0,'2017-09-09 15:38:48'),(29,8,1,0,'Umbrella 02',1,'500.00','','\0',1,'2017-09-10 11:27:36',0,'2017-09-10 11:27:36'),(30,8,2,0,'Entrance Fee (Adult)',3,'600.00','','\0',1,'2017-09-10 11:27:36',0,'2017-09-10 11:27:36'),(31,8,2,0,'Entrance Fee (Senior Citizen / PWD)',2,'200.00','','\0',1,'2017-09-10 11:27:36',0,'2017-09-10 11:27:36'),(32,8,2,0,'Entrance Fee (Children below 4ft)',1,'100.00','','\0',1,'2017-09-10 11:27:36',0,'2017-09-10 11:27:36'),(33,8,1,0,'Transfer Accommodation : Umbrella 02 to Umbrella 14 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-10 11:28:35',0,'2017-09-10 11:28:35'),(34,8,2,0,'Entrance Fee (Adult)',4,'800.00','','\0',1,'2017-09-10 11:29:20',0,'2017-09-10 11:29:20'),(35,8,1,0,'Transfer Accommodation : Umbrella 14 to Umbrella 06 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-11 18:33:07',0,'2017-09-11 18:33:07'),(36,8,1,0,'Transfer Accommodation : Umbrella 06 to Umbrella 10 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-11 18:33:58',0,'2017-09-11 18:33:58'),(37,8,1,0,'Transfer Accommodation : Umbrella 10 to Umbrella 12 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-11 18:35:17',0,'2017-09-11 18:35:17'),(38,8,1,0,'Transfer Accommodation : Umbrella 12 to Umbrella 02 Balance to pay : 0.00',1,'0.00','','\0',1,'2017-09-11 18:36:14',0,'2017-09-11 18:36:14'),(39,8,1,0,'Transfer Accommodation : Umbrella 02 to Gazebo 1 Balance to pay : 1,000.00',1,'1000.00','','\0',1,'2017-09-11 18:38:28',0,'2017-09-11 18:38:28'),(40,8,3,9,'Videoke unit + Song book',1,'1200.00','','\0',1,'2017-09-11 18:40:50',0,'2017-09-11 18:40:50'),(41,9,1,0,'Umbrella 02',1,'500.00','','\0',1,'2017-09-11 21:16:48',0,'2017-09-11 21:16:48'),(42,9,2,0,'Entrance Fee (Adult)',3,'750.00','','\0',1,'2017-09-11 21:16:48',0,'2017-09-11 21:16:48'),(43,10,1,0,'Umbrella 03',1,'500.00','','\0',1,'2017-09-11 23:06:22',0,'2017-09-11 23:06:22'),(44,10,2,0,'Entrance Fee (Adult)',5,'1250.00','','\0',1,'2017-09-11 23:06:22',0,'2017-09-11 23:06:22'),(45,11,1,0,'Gazebo 3',1,'1000.00','','\0',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05'),(46,11,2,0,'Entrance Fee (Adult)',5,'1000.00','','\0',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05'),(47,11,2,0,'Entrance Fee (Senior Citizen / PWD)',3,'300.00','','\0',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05'),(48,11,2,0,'Entrance Fee (Children below 4ft)',5,'500.00','','\0',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05');

/*Table structure for table `ca_booking_transfers` */

DROP TABLE IF EXISTS `ca_booking_transfers`;

CREATE TABLE `ca_booking_transfers` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bid` bigint(20) NOT NULL DEFAULT '0',
  `frmtypeid` bigint(20) NOT NULL DEFAULT '0',
  `frmid` bigint(20) NOT NULL DEFAULT '0',
  `frmrate` double(10,2) NOT NULL DEFAULT '0.00',
  `newrmtypeid` bigint(20) NOT NULL DEFAULT '0',
  `newrmid` bigint(20) NOT NULL DEFAULT '0',
  `rmrate` double(10,2) NOT NULL DEFAULT '0.00',
  `remarks` text,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`bid`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

/*Data for the table `ca_booking_transfers` */

insert  into `ca_booking_transfers`(`id`,`bid`,`frmtypeid`,`frmid`,`frmrate`,`newrmtypeid`,`newrmid`,`rmrate`,`remarks`,`createdbyid`,`datecreated`) values (1,2,1,2,500.00,2,15,1500.00,'Expecting additional guest which current accommodation cannot cater anymore.',1,'2017-05-28 12:57:53'),(2,4,1,3,500.00,2,16,1500.00,'masikip',1,'2017-09-09 15:29:35'),(3,4,2,16,1500.00,2,15,1500.00,'changed',1,'2017-09-09 15:30:06'),(4,4,2,15,1500.00,2,16,1500.00,'masikip',1,'2017-09-09 15:32:35'),(5,4,2,16,1500.00,2,15,1500.00,'masikip',1,'2017-09-09 15:34:15'),(6,4,2,15,1500.00,2,16,1500.00,'masikip',1,'2017-09-09 15:38:48'),(7,8,1,2,500.00,1,14,500.00,'malapit sa pool',1,'2017-09-10 11:28:35'),(11,8,1,12,500.00,1,2,500.00,'Balik nalang ulit',1,'2017-09-11 18:36:14'),(12,8,1,2,500.00,2,15,1500.00,'Additional guests are coming.',1,'2017-09-11 18:38:28');

/*Table structure for table `ca_company_profile` */

DROP TABLE IF EXISTS `ca_company_profile`;

CREATE TABLE `ca_company_profile` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `coname` varchar(100) DEFAULT NULL,
  `coaddr` varchar(200) DEFAULT NULL,
  `conumb` varchar(100) DEFAULT NULL,
  `cotin` varchar(20) DEFAULT NULL,
  `coprops` text,
  `cologo` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `ca_company_profile` */

insert  into `ca_company_profile`(`id`,`coname`,`coaddr`,`conumb`,`cotin`,`coprops`,`cologo`) values (1,'Costa Abril Resort','#49 Dau Street, Barangay San Jose; 1860 Montalban, Rizal','1234567890','0987654321','Mr.Daryl Villa-Abrille','‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0§\0\0€ðh\0\0\0sRGB\0®Îé\0\0\0gAMA\0\0±üa\0\0\0	pHYs\0\0Ã\0\0ÃÇo¨d\0\0•·IDATx^í½€UÅÙ>ž~‰ù41\ZT(lñ³$jbbÉ§‰XE¤\nJS@zUºôÞ{ï½—eiËöÞîÞ~ïóž÷Ü»,‚°ÀBöÝ{Î™3å·Í;sæÌùJ\0œŸH„õ\nñÄ„‹Ü½ôë÷î¼áç}Þó+ÑÉÃI!¡Š,<cé^ÈŸ‚Ù³æÀç |B8!áPÉ‰‘«Ÿa%cáBç„ÿÇƒã\"¡6øCA„Ãa>€!—NÄ@Àîy‚’é§©ã…G‡0ÇEBÜ%¨~÷_áf­žäd‰”ƒ‚Áê]|9Å#Œ…¯Ôez\"sð3‡;)‰H›ÇDBí\n‡Th˜|!ç’?†>ù¸Å¶ºôj\"†;9ƒ>oeqÇ‡\0¾¯ÿAäüH86%|nçè–ÿïSÈÛƒñåïFÖ°)Ä#„¥õZÚí–¿¿¾;ˆh¾5›\rùã²†£à˜H„ýù‘3Ëk…‹~ò?DõüæŠI bk6FÚªÍ”¾‡}ÙN\0?fÛ±ÙñcdJIÁê\n;ñip‰:nAõoE(/×iå1ò\rc\Z4Šœ†c\" Ô\r[æÌEŽZ‘-Ov&j\\]ý¯¸¡œŒ©OŒÇˆ†M#g‡á˜H„²³\"g‡Ác‚ÊJÈÓ€¤Õôó4Lõ•”Œç3\"Äˆ0ãsêÇ<;¶`ºs\"\'Ç‡ÙÃ~@ìso[…õËßŠ|V6³W/ç¦?ŒÁM›¢Úo.Y8‚>­Ž„ZˆhÈq@‚¹õéê&´¾°Ù¹¤ž.XÉš…óÐ·é§ð’¢’SZåœÇDÂÈÊ‚Í¶(ü¨zÑ˜xõí¨rÑåØÛi\0ÂÞÚÞ|f¼ÛÀZüåÛ5±¾kÖ4–Lï××4ëXplJB4ù2Ù‘ë¢àëð]GÓ˜<G\Z.¢è”I_|Fãë\\Ž‹„ó©àáŸ°u‘¨ŸBÀ{0þ„y\Z‰(X#‚è÷Ÿ7©ÇnMQØ¶a\r|©‰Çæä1àä(\n*ÙtÓŒÝ»0¯g?¬þa,]À[üã-“ÏŸ?‰3\0ç‰óh¿ y¤gâàÈiHèÜûF¥9‘E¢Òò¾lÂÉÂÉ! J=´ê¾˜ã‚ßBúâUì?<rAN?€„^>ã1“Ÿ+‘¾¤Hr|´‹€ªLß¹SýŽõq\n²˜R:©£YE\"¦TñÇ9¾ C:[Ž‹@Æö@j¦|Z ®=	Ñ·ÌpÏ^Às‡êÅe÷?üÇ#–çxàesB‚ÈÕ‘plÜtPYÅâ9Óíò›rw\ZE²ºaÝŒ<Äâ…„kÞ2ú.»þ)8NÿtXSˆã	Áð×Þ@`ón2H‰äxÜ>øó2ìž êæ‰	´Ž?òº½V+ruŽA–ZÄô›ü),Xk×9k×cæ¿^bëØóÐ+v/#1	¾a“íþOAÈ÷ã>åÇh”t½LŽx¿3çÎG“üJ€‚)_\"ŒÜŒ4¤~ÐÂIü:F§vlŽNHÝ#¯º™³æÓ›ÎfÅ4KA·Åç¤&#½ÞW\'4??®þˆW*´(D=œ ¬O=DRC´p@6æ	ù(éò”ˆÁ‰¤Ê²4ÖêvîÀ“ÿcM8†Hç…«ÞeŽ,È_6að0½NžC=ÚQÊ_MùôK»^}ê|hçEá äæ—œùëÖ¡Å—;%*5[?öé×‘]ç3kyØ›iîÛ¢\nw“~¤´h§„Ô‡\nGÃ1) 6L¹&Ëû1\ZÉSç3Å–­¼‚,^tkÔÐävã/!÷P¼¥“/™Ï†tùûc†lÈì&\nì]¹Jäê0ØtËR{d¦5ÖËå¶ÒÖw’\ZØxÑŽ‹€Kð°ˆPàdúµÃ”ž=8 ‰ uøi\"m¿>lY±$Âûcƒ:±­ës¯\"D3ùÓU;pRDAr.ÉUàóaóäI˜Ó­7â7nçÙ…ˆ¿p25Gàg!p&àœ#PàÌÁÄA?^¯M^£·uOªMãG¥Ž½í‡÷¢E3œQ\"ç`V‚`JÛÂ~„Þ\\ˆAË¯á‰:võ,êgC\"&fŸ•]í»\"kÖ,#ãO8 §ÅH„0‰éñpØfû,ÎNœ‹S›¦U$‚MG½XûÙW$Ü\'§NNj‘ÈÞ±Ë\Z-¶Ÿf[°2¹\0š†\\ôn:uù6*;öœÏOÃ©Áïƒ;>ž½qã\r[w²hõKám{1òŽ‡S‘c)D?\rÎ_D?é=‡`ç³µúö\'ØñaK|ôÀ¿È^¢žŸEOŽjrŠ\"/Õ¹Òù›Õéx“üÇ‚ŸEá—³|Od¼Bx¥ì5ðÛ Ý©pbå·Ùç<Àc\\­++ü!:oEf9ÑòÒr†¸¨¬Ì¸xl¿ë)ää‘?ÞØÐ§—Ù—“…“\"‚p—¨ÄÅÙµAØ‹Ö< $Ýª»ÿjÊÊù¯Iéÿ~Î‘¥çõóåþ¨3ƒ—_gã=Çú7Ü/%A‰Ç”­ˆ\\æøùBí€ùF¬ß•OuÑxêÄpÒ’6i¶#\nE@sÌAÙ«:Ò	{zQGVNEñDz1ˆi˜Ó q4¬·™yÝcš@À¹6ì^»H\ZyB8I\"¨ûÒñ§KT#á¢÷U0í+g¬\"Hž3ÇŽù£Æ“8$\Z‰÷z…\nôƒýMÎ‹(¡ìldg¤²†0¾C52ŠžÈI[¶:ru|89upûá\"Ó\ZÇÇ.{»€kê\Z‚õØ·y‡ÅeM›o)f>X™Ää@–úZãÚ±ê‘ê$ŠŒ­BA®Mˆ™ï·ŠPTW§N\rÉæÐz\r\"WÇ‡“—4§÷°õ­zJÊt\Z¯±}ÁåÍEÆ€Ñ˜ÿÂ[xãæ›i¹IHªÐËW\\A eö\\Ì=!43“5Æî§ÞÄ–\'ª¢YÙ›MeN$·k·:?\'M„¥¤¨ÿdÌLÆéT!°fZ\\w+öÜþ/‡e0ÒÕª/¾®T	}Z´2ýgg¢êååiEy¥ˆ˜ht÷½èòàCèyÛ=$˜QŸß|&TüRW¯Ãê>#P›½LRƒ/Ðèš?¡òE¿Anø0Ž³Æ6fœN’R\ZšžßE®Vn²£wÊ\"v§ar7W£önÚüäva¹²R×®!\rxÜ4K…PÀƒ…#§ñ´hÉî61«Ö:ÄbÞ”&ÎdÀd–»yá|¢,û¹ñpr6A9ùõ«›¶·i¬ŸžÕëí˜¹h)2×m„‹åí­òž[ó+\"ÌGF\nrsáZ´\n±K–:.!o¤j÷ÅÔžõë+%¾ýÃ56Y ½Ojv˜BuÀk´5\Zœ$œ¤$á•ö`Æ§Ÿ8˜³€\r˜-à9g+j”—’«¹@Ù[õ\ZA‰²Ò0ˆ8Jæ‰ä#hÑï\'4¬ÁHPõav¿ûYFèŠu8sL\'?›QP?¯\'ªIän~:(5ŠbÁ÷Ì+r³ÒÑ÷ñ*F\\[Îp\nœ2ŽAO¦4ÿŠG˜”œ\"^G€$@³Ä^±—\\ž1t ÖMšÈ\nžZŠ•?µžFlXÃO0ìÓ&Ø²|2éméiÄ Ò´¨D[•ìAB~66­^†1_µÁ÷ïÔFZÌ!¦/jÎ,È9gfMe‹£¶M ØŸDÅ\"#?bµ<APÚÅ+ÙÆ8ÿgÎ,Î(%¡”„R\"Î8wÆ1n6ã #GÐ¯i>-:Ý®é:žéÊ1„ö¹°“3g”BÛpdëCl¢;›·#nêÄ÷ƒ„o;âP÷NØ7x$Î˜_Nd%«MÖrFç)„xÆÊ5È_´š~±×œM³I:ô¬!¬iëþœ`ÏåWç†{ñjloÝÖž?˜tœ!(6\"ØbOh4È^¼þ¼2ßï¸²§	!y†l¨ù>ë( Öøy†b¢L±!D´2æ® ÿ´ZAO’+ÛíÓIF±,Ž7v2Mi§;1]§MÅ;}ÃºÇæÿS£\ZTSØãÇ†¦-9,§jy‚ÜîÈýŸ§L³ÜA¼)ÉTg»rˆpÀ©›\'Ò	Ÿ¾ý;‘)C*Sr\nðóˆ ‚GŽÁœ\\êf@#XG,y4ûæ\r8öAÆMžø/1ÎåMƒ_Ý!ñUhBh\'CÈc„âX!§\0bÂøz8¨”ÑÕT>úEý|I`#ÙZ|/£Ç~}óV<ûë_Ñ²kÀãÃöæ1ñÎû±ì÷Q@äBô{½n|xI„òò±þ±7Ù´#¶Vy+ž¨\n9¨^pÚ£ÕNO”HðI/×„[DæÿÏ!çÏ\"‚1ÜMëìóØÓÖoû“ú<óIƒèù¯Êð)£…Ø¾C‘—šH„‚hðÐ¿8|)iHaÞ£â$ÈUWÉ2Zßý—S”ƒ0³äL}·!\Z±P\'\'GU`Gv€j¤Êß¼‡?ê×ÊByÈÜ½×8UÍj·ü‰†+€>nTë#±¤ËîX;\Z¢Œ^ûI;“¢.o¼jñ§šÿôÄ\n·“‡“—r4c‘\'ûôHþÀ[õ#ÎÙãgGÎŒ\r*ßP‘âN;àÍÃ”r7;·	þŽ$ü^¬jÜþýYHúÀy¹êô €\ZJ3P\'	\'EMm…µŠÛDÀõÖ£w±2\ZHz&Vô\Z@ÉÐ@//óÀA·}£§:ç„Àæ‘³ <›7¡  Ç8HÍÂÆeK­ÈBqú¹@ItŸÞ/¼áè›¬ò	à¤ˆ Õà¹Ûc·(h¾oVùÒc(¼bQ@ÃøÝåáY´¡¸$¼ø›Ë©£2h-6lGµÿÉ©)øM×8ˆËU0dÍ®‡<èúªŽQñ©`H†‘®×:‹ñ©´VµË‰ÚèN‚­5Ò‘­(ú\\Y£G1D]¢ºv|zv¡$FþG$ˆçZ¯ OT×–ñ“…d$æøpRDðnnlÜTL¡Äñ(¥Ó¤…õEÝ<Pç3l{ðe„]ùŸ¹j%ú]wþå)úš¼§q|í#€ruyC‹h£…ž\"©ö/¾Jé:q9\'E„Ý#‡ž˜/¤†8ÞºM¯¼nyQøöÆ›ÃžåùK.“À3Jb›“2±~Å\nä2ÍÈkïÕ-kzçZï0§\'	\Z¶Ïž9Õœ¸œ“\"Bö²ÅÆ­Ÿ¢©D^k˜j_YÈ÷`zßžÐV<Y˜³šªÀ¡ñžiT0s…ÝW§:®ÂßŠï^§®ÅÐgØÃ^â$Ê9)\"×®2ä~Š6oDqßÖo²¶mÄ÷7ü…x0Ž™šU¬ˆ¼¼l|yYy64÷¤YLÆàêÕÈ0&`÷;á†%¡{ÝwybcÑŸ®ô§€8\'ä°m:œRgM?¡$Hú÷´íí\\Ðú¥ÍY	Wf:›F£ŠwZoÒé†{¬÷„i&¤ëé:ÃÏÏ\'V|Èˆ û½j×s„˜ç?ï©b AÜ¹e­CÈÀIaY‹Ïìø“4õÑ°Ò3ä¼ãKìŸýõ¯ÍQ\\þ·\'1ñ…·X\0#‰\\VWç=µô“ß^NA£Û®‰!ŒÑnEJƒæ¤3«€S‚¦ŒB\\Nœÿ¤ˆà™¿‚E‰7Ç§ª—ŠDÝy÷$lœºQ=Ò·½\0„Óø4ìåÐSFË£F2è£nU Õ¥Ú¬RéH;”F’a6—ñRA-úR•*­ˆKÚ…ðÕóUŒ\'‚“³	úQÍ?Uà1î)JaÓ[\rñM¹Û0êíºæ\'hî©ù]÷âË×h00Ad‡v4ˆæíú‚˜Zç#þ°>ÖV¸‘géÜ‡ã«ò7cá5w#›%·¹êOèrÃ]ø²ü-h~Õ-Ø¾t	3; V\\°”ÄPð\'à¤ˆàgw³«kÿŸ&ÂO@³2uoo¾¿°Œ•Óf’ÓZì@öòÕ7¢Í‘¦€oýªO„\Zµýý¥L«ñ\n}	IÕªUvOÏ9õ×¦FM»Ž‚¹iÕ|ÕgNŠæËù3¡SæW^L¢üÎÃ³UŽ©Ú4x8Í]N§?z(Ã+Übª¡*>¹>Cô·>þ2IåEb­OííÃqÏÕ4-‘º(]«7«;	èè	w7j³ªˆz8I\"håHKš}ŸOúzâ¾·(´){¶×icï¥»ë(	È8\rî~ùÿðn-+=Ï+›}°ÿ¥•ëš:d‘\ZhjÙ’GF\Za4ÿÏs:1ÐÌ6’g¼¯bM¿~\ZN’¬2Ó“’„¼“(¸(´-OÊëÃ<Í/ ,Ÿ>SL³é5q+‡¥·ºöäÐÀ.üã4LÇû’ŒþöˆIOBÝOmNuÁƒZµÔG\'ŸxJE\Z¤¤§ ˜›j÷ONŠ*PÜ2?\\¯öº3h\'OÆ!uàù_ÿÊ±âÙyøªq#Æ—¿¿\n;*EÄ8=µÊVp$B†ÌUÀiE¤´èŒç.½´P\r»ßú -Óõ“ü’¨ÛH4„wþþ1Éãó`~ç^Z4ˆáÂR81Þ\0=þ“¬H+Ô”Ôº?u‡$Bô)›âeÃÂì7dôÅ4R?ÌxC^*	Ëâ}¯Ê¡W(2h1ynÀa¯Ô1/Uð3hð3‰@ÌmjEêàÎwŸóêã‰@oH±=:\Zc%êFI”£–†:¢†Áq˜‘øÃ³‡ÑæÆ:„…]{93ÖÌcë¥¬°“ƒŸG„\" b€FrÌÚ(Ð0#–Q#wFRdó”ûq£¾\'T6JÆ©Ö|ÊD°\Z|þvŒŸˆœØm†˜Ãæ3ar<.a/:>ÿ\ZíƒŒ;èœ*œ:Ž‚@Ðƒï5ÂÁ}1¼\Z§b!	í†aJÚ¡ø}hýBe^ÐßˆÕOŠBÐ$!äÁÁY1¢Qsäå¤1ÒéCl	ÞÏ\0{´	¾ì,ŒéÝc\Z7æudº…Å	Š“Ç\0ÙúýËV ã+¯`Ñ°AØ`?Ý/{\rªÌÆ™¤h£½úÏàñ{q(ñ\0Ž…ÞußÅÊŽßX\"§ß°¶;œQ\"cã–5B6ÛÙ¥¦áÀŠåX:tˆ½h½¸ï÷ØIéÉßŸÀ„N?aVùœ^àÌÁ%‚qYM`ÃÄAç—Áº9ñ–ç‘(\'µÓU\Z¡,§nŒvÿÌÁ™•„óJ‰@(%B)”\nB)”\nB)œ·‚Pè<ÉñæèJÑIšÃ÷œÛ\ZÉÉQu–ÖÊsSJy`Î»®ECÑ2¬h9pÚÖKkBšÜÖÂ87ÐêòBù”_Ógšõ±	óÎ_‹ é9rJOµ‚¶I0e<xR‘·eâ†FÌcµv\r\\q±f$ ìÍ\'§ÝÌ«ýÖ´wÑçUØ˜ÞÍd¹a~³]ðÅnGþ¦µØÚí[lhù¶6m…ô•kÎNgê€­âÑKð>\r´dQBa3oç”PApžÍØ8Š\'a?ÎÛ20@ËHGú¢Å80o<É©¦Ü‡át üG‡(WäÜ“‡”)3°ë½ÆHøa8ÂZ‡ÒcÕÜÚ\0Û`³‘j•,’ÆÖÀ’%SH8Bëá\\j&Ò§Ì‡/áùM-Õ€<à˜âBþ“¶UÕ9É¨øª\rZ£]ƒ=þó¸±¥s/loó\rûZ$/­öÎÁ#$øœÂY„BvéDÄˆœ{LõI¾ô<šÝuðçjg|Šq\"°¥‹hsÐ¯ì†Ý9ç`ÝN\"èØL‘pd¡yCc¹^þ\nàÀÐØôMo\n„‹qL£-ø}ô¢¹&ýmó™†³oØ:‡Dúéè|åf!k…6¯ÒÒMg‡YÝ7\Z(™Qä\0¿óÞ·–Àã‡;”‡œmk±¾NCš7ú\"Œ¶æêGçQÞÏÙ€sÒ5¨Ú@ïàòe{Èx=S¡¹/´îFH¸ °Md.¹-ç2Ì>Â­sZ‹C“¦`w¿´yRKvÚË8OÎ¬ °-…m×æKÏ€;æ\0Ï}¶\'Ÿ¶„Ñxó¿#–ZYÐÍ´²\n¶G>Ab2<»bÙ	ç#ä1=ÑÊ<’°áaØßþx´†Î|2Þùec¹”Ö6â`ðÈzy‰GvÝzn¦4]ÉÈWfgöþì„ÃŸ•Š)o¼Çê9ªñÒÅT;ˆ„‡b‡3*…“)A20=f7ãHY6*_Ú“ï¸ùhVñ>´ª\\[7­GP»Ó‡ÔCR<6ïBã{ÂŠÑc_€<&¦¿ß\0³ÊßŒUÞ¢ÀÈy”ùäO~R‡OÂû7Ü]kVÁð œ›‡Q­¾À°î_cæ ïÓòk¼wñÅX4|&÷é‡‘ÚcbßþöÇFì ò§ÌÂ·îDZÜaÊFœ	²¬:áÂ¶åæ&cÔëuÌB¸$ÌBè4Öü¯ Ã–:h}QÐçCÚê\rÔ,²Íl?[C\rO2-+=ë¤µÖG2\nx=d:T®FÞ©ÐŽy´‡µ¶P	X}Ý½èÞàcG‹½.äÖj…5#ô\Z‚Êw´ûhîÞk_Íˆ¦Q¡ÌS-“oÃvt¨ô\nÜ{÷bDÙÛàÉÊ¢›}:w@¼bv®ÃöþÍâ9V¯­Š	Š]$ÌJ­¾;‘³–ZN‰É½\'Èë:Ã?omLµåÌGAhÃtºî>ž8÷Œav<ÛvÇ«×è©¯\0\nÈä—•Åär3a\"‘øq¹þ]1?˜\0»£œT4ºæ‹ós–,Çëîb[~\\ÎY6VÝAŽ7Ã^z“_•dAjšbeõ¬ÔE+yá0Pà NæÉ¾¿yc~@˜cjm&!ñ‘UÐ™rx—®Â°\n·!?+›>c8ä²;÷¤ðHêØƒ·4FRiLðœ$>,øÛs¨^¶#„Ð¶]hrÙ5vny(„Nñ™Ø÷Qk¼qÑÿ‡ÎånÁ×·ý­o¸m~_Ï_ôK«Ó/?‚Âe‚seÃñœ	6WÈÕz#w?}%â\"ÜmSÆbX¨T|Á˜¶G¤Ï“›Zz·<mØ$Ì/=¶ÎFhÄÀÔj)óÛžläÂ»ÿ…ÎeÄ´ì3wŒ—°„‚¸ç.BUú	6“óÇ¼š09B~?66k‡I]zòêHlØŠ/®ªhç&&€Ä}Ýk¦Lcµšýc)”H/ïéÐ®xäÔ¹ê:;W&	ëÙô MTÑi¤l\rEîAZ[d>ñ×tNÅj\nèñçoÚAŒiÌ4-lÄ>4Bp¾ÝÀö‹ñ^ÅQ\\»Ë®Ã›¿¹í?~Ÿ÷4%@ ?õîºƒæü÷h_þT½¬<Ú<Y…>AKaù$„<~û_ï!¨~ñU˜¤á—¨cªÎSÌRñ¸}Æ<þë‹äÞÁ-ˆÕú¢î?$^Î2C#®¸Í[”Jxæ×—`ÓV:²ªÓÊ4q8;`´Ý¤”\n…|¯‘Í>#žzëƒø>Åê#„Ü.¸÷$EÑHäq@¯BIÃmƒNi;ýÍ\'è½Œ(¨/²Ö8;—†`ŽL~¬©Ù›F2>Œx„ó¡ØdŒŠ#­¤ÍAÅÂû!˜xÈ&±x^Ö/+dÕ2„‚^úássè‰+éMJANÌ^Ö-süãúÏ&èå‚ìÔChõ|eâ\'AˆÜ8\r(FA#yÊ½N¿]ÈŸ\'Ut&Qî›Bá\r;jw†À×P™}¸Þ¾*ê¿™@ñ/oÄt4¸áV‹s\'&bå÷¡áýÿ´WH¤/ú •÷û±¨sM\Z,/’7lÀ”ÛïAËKËÀïqt_–#˜™†*ü\r™©f¬$ö®\Z\rñMõ×MXÏ¢=86Ð\n\n×eßö‚?;þ$¨|b(F!Lq®™NG_N=É€~¤ÑÒþ\rÚ\"5e?â{\rGç²·°3öG@îÌÅhtÓ–W»åföüŸ¿^ƒiCÁ‘	õŒ™†W¯£ CAÕfæ çMw##9Ùâô»Pn.ÆT¸9GÙ$fzÏ¨	¾­ý®µï´ß\\?]jÀ¦ë0¯6È?}U|>‚Ïßê6ig\nË¾Vüù ÂÛÂ_ë.|ÓbôWm¬Ï¦GnŸ¡ø´‚†ybæá\ZR§ÏÄü[ÿa{½YîOèxópíÙÏQ‡^þP—ÃÜcg£öµÚÇ…H®ÛŠÖÿx¾¼l§»Q5-”Ÿƒq×ý¹™é…‚ÀRë·@÷:Î¾ôgkÚ÷¸„ƒöbäúhH	ò´í™wùb¢\'†)Bg§!ù\rŽ0¶¬CËr×ã•ß^ŠF®G½[ïC“»ïGû«+¢ÖÿÞÍ:\"Ã9V”GiýŸì<W‚”–Ž¡ånCÂ¾ÝF&½	”7y\Zê—¿Î›±p9Æ—»‡V¬‡7à|>ÐOA˜Tñ!ä¤§ØµÄRƒ×„_¢óûu¶	äTPÕF•wVAN2û÷nÇ°\Z•B¬NŠµkˆ>ÜÑd]ÓÃ=)¯æÛq±ø¢¬£ù6¶¤ÚjÏ\rY	ÙæŠ÷£Ù?5«¨šÜSæ¡ÓÿþM‰`W±/ÝpËc^öëú “{âÔ*{1L§0ìraþï@»¿ý“£çóØ¡ÜLLºéad§9‚ ‹ 6¥}Ú}ß©Í²=,N«œö¬ÄlCQ§ål\0S½«ÏÁÒ¯»SÐ\r‹Ó‚bu÷~ó-DŠD·-UOuXSÀ¨îýphG,y~œM3h\n>¨F Âƒ?ŒÄgÏ=‡¯6Gn|&±pœD±R_áÑr¶U#Fã³7Þ±qºi»Žw{Aè³(úY™höB¤g¤Ûˆ&¤wÁ´ýªÖÁgÏ¿ˆ†Ï¾€<‰çÿògË£.K[Ô›ý³ÇJHI%H&tŒ0WE÷Y&EÉ®uÓ:A5PixnÖ‹Ánj¹œ¬ãÑ@ºÊKšÒòK„ò’­ÜÓ…bä»®‡Fž ž*~jº†Žæ8ÿ?ûšÑ{Á¬<x—¬ƒ{Ô¤/àè%+ôÑò”Òôhýn$Ÿ„´žƒ±¿NSt­úNaYöpŒ\\wûè6Î^‚¹M¿°§¡Zœ*ÎùØ½Øð6Ëÿ‚¥Èi×\r;?iŽ„±‰-Žº*ál–„‚¸=¹cf!oìLä¬[C²¸‰# áÄx–¯†kú|¸®FÖÆMÈ_¿ù[¶Â¿j#â‡ŽGæ¶X§›<\nTÅÞ›Ñþ5mÓ¨QÔ1UågAñùšÃÉ˜7•DÓ£]™pçÞÏeSóL£~Šdˆà[¸õ/¿Jw¶têŽÁW^}«Ö‘ÇŒozâm,™;Ä«äŠÈbÈ2PðèðîèÜ½ê;ßò•VkæZÎ¦}^x÷>´ûçˆ[ã|\'XQ!é;·Ñß¨ˆîÿ~„µþ‹þcôÿ¢ÏœÁñâ;þŠW.ºØòZFÆFaÚƒÏ¢K­È:,ÂÝ*$..·]´Iˆ¶¬0ØÝÓ‚b´D˜ý§›‡mÛ³‰îb1Y\'®5ÐòŠí\\ÓÃ!w:ýé/ÈJd_OF7Š{é=¬œ>Íˆ§}ÀŒÔQMP¯ù¦]y/}6Ë(ÕÕ¤sHÐ¶îDÃ\n·R:=#f–+3\rsoÿ;VO_\0g(ÖU³7Óç»¬(ä.]§w¹ÝëlÇXZ\Zý%7iƒ6o¹Œ@÷,5ÿuæ¡Õ\Zþé§ðçpTC¼¤|Î¢ØÓƒbt‰+‘\nÑhJi{ûnlid¹¸©Î™ÿÊ\rhreç|æJ´±}EBðŠi4ê—yo4D½‹/Â7W\\×/ú%¶.^E†T&ï4­\Z³_—¹sÊ_•½»ÚÊ!1-ë³NèðêëÆ9­?vCÛ^«…ãhC6ñ‹¸ÚŸ¢ßg-€ä,FMÅX:vú<’?%0e#­Y[4ª¬·Ý£Ô;¥f§ahƒÌÈ¥ 2‚Ò¥¹uK§Åë#h.œÿÚÆ*@Þ²\rÈZËá™½\'À$Ç _qAÁšuh[özçÂçÃ<ŽÆÕ¨MÐ6#Nõ‚Cÿ©ŽÕS§ðL/©8Ä˜³\'¡u…m˜7øúÛqpÍ&Óø[ãƒKmVyÎC.¹—r÷èšØVïáæuŠBjÝ¦è¡}bh^Òç/¡pUD^R‚Ý3›Akà²v5}º’b	ÃºÍËÑåñ—AA:ŠUŒ‚`8[#ê¦9Œ¡vÌªý!Þ,viŒ<Cà[¹ÿx‹k÷ùñs}Ÿýþ:ÛGWk!T»ëã¶Ø4I‚ 6”Eº½ä	™*õò|ÿ~,¤Gþå›µ‘+ñã&ÜñO¸âZ¸¶ï  øè7°}¤å›ñl™«àËÉ³\'˜ýæÔýêÖ±$¶£I³Ëßž¹ˆ™M[jú­: þƒD®C+Ã:v@ÒÒ5¬‘\'!uª(V(VAøD¬@@Ã7.æ~ÐÂÀqŸGdekxïôši{É¼	È±ˆeKÙÌ<šõ„l¿`}ˆqÑ”É˜=jæö€Qº OÛ/œ´\"®7€Þï„@Fû^‘Ý)GAnn|l™3Ýë¿‡ï×Ç²I“Ø†sFSØ‹&OÆ–¥+Å>\n…SäÿÂñtVÙ¿û…“ÕÄšñ3°fÞ|Þ—Æ“D4÷³FŽÄÀzt\\õqYŽ„Ãk*8£‚ &K£$úö40#	ãê|on&òHˆb{1Eu·X¤išŠVÐ=Î›‹ºÐ$­‚%äAÞŒ²ÛmqB}þKdM°”@Ai²x*OÝÃ@Yœª¬<›ØŠà¦[¯ëhy:ääåaü€>U­ÓÑÅ%ÎÖgôcù‹Î¬E8&h(Eð1øƒ±oÆ4xÜnj,cI	½C(Â*Øè^Ô9-?l8²O†ÊJ¨»äÿêu+Ñù…°~‡™\'%‰$;+pöæU¼5b#5Æwççbbåš88w6òÜyôâ#3lL¤¾Ô´é\0WD¼õ0M£‡e«W¡Çam¾¼ëŒE¢´1ú.TAƒ%\nÒvGó9ÔÒ„ÿm:µ #h)¦}Ù©qû˜B7\"’¨Ä S§‚nØÍs\ra*‘ vûBHNOÀÒ¡?àëg_EÌ|ÍÀÒÝ¤/âSßÉÉ—pÚÃÄ\n‡gÎA×ðÓ †ÛºE-Ò³\n†ºu«QËÖÌCzv2-=stìDT‹ÎÁŽDBËâõŽ„7Û•…•+—bx›¯Ðó±—°kÖtK&Ü•FÏ1ä{–(q‚ –Ú“\nrX4•Fù©1úÂ¸ß–¨1øÜØ2l:¿Tß×i€Å\'!&v\'rsrH\\Y›³òmb÷ìÁüyó0ºm+t©þ&†½[ÙÛ¶ó®lÛBœõå{7CˆYp„ÅB	(\'	¢#Z¼ª/.…ô©©\0Í¬\'qkVcaÏüjM|÷Ö»dP\rü¬FuûÓ†ôÃâñ?`Ý¬IØºp¶._‚í+–ÚqÓâ…X;w–Mˆé?Æ¨¾=Ñï›vèý^]xƒeT®ŽÉ7Çòá#‘—O^k¬¡áÇ>J.-ÙÙîÛ‹Î[Aˆ*—ýr*¥ƒ\nÖWèD\\á}]j({bÎ§âd9tnŒ<Bzôkcyår‚¥ç™§úx\"wF¦]×\'Ð1z~žÁùkJ¡X¡TJÁ TJÁ TJÁ TJÁ TJÁ TJÁ TJÁ TJÁà<çõáÛ\nÎt_dNÐÒD§ÿ¢º§£sy”×ŽNÎè¹ÊˆNRêŽ“1z/Ñ‚í‡±Î‚ƒó\nÎ[A8LwþÉ,2ZSÈ…ÌÑ	oi¡‘©)f=É´‰fíé¤éd&pV 9iœ×ù#lf>íƒ¨åíÚa{§Úá³ÊgBMEGëV~­frÖ0Ÿ_p^\n‚ctŒýybšL¶„Ä8µ‰w^>üûã‘¶j%ÎœƒãfàÐà‰Hè=‰Ý:!¾s{ÄÛ{~‹}ßÇþá£±âx¤-›or<‚ž\"•H($ZbB,diX¯=š4(çœŸÁx¢CZy¬çúz}Å…°7ùö#cêlì1û&LFþ¾x÷#äÊ ˜OOµþ8ºëÒ‘Q¯e1dÜ~„Q°c2gNÃªÏ?Ç¦f­6r\"\n¶mC0P`%ø´yhÈc;»˜U)A—OÎS‹À Z»½pïÙ‡”YsíKß–]Ô~m-¥7•µª!Àtdƒ­†’ÁóD&ßöK’¦Û\r\'ØbZ-§2¯õ®£–•)­ Ò}Zo\\2úÃªq ß\0øöî³{êb”ì|ƒ’\'äInFX¼1•/A$³š·s\'Í&ó·ï´E°–¸Ø@•*¢Ç(}ïð¹76‰_tÄ–ÆŸ¿\r&Zˆ§E¹>Ê›äQBb¿R]f/Pâ¡ðíeŠši¯tÑIóï§N[‚¼Ø$\"\r°i§ÖD	|î@Ûk¯&ûò»•@j.v~Ñ–¡=šÈ8…A‹ßeÔ9™E+„Ÿ€ˆµ¶uÌ?òÖnCþâU4Ëzo™Œ×²5¦AEKY‹s	Â™r)VÈ°Î·ÜÜ[0÷í·z\rÓQÌ½ênx*“P*Ç[¯èu#ÕVdoÝMÇK,Ø’´(ãï’;*B±ç„‹¤Gá¢ÑÃ0×ýtL3Ó1ý½O‘¹r)cóíÅ¡^Rà¬\n‚\Znž0Dig¯­ûÈÙ¸9»ö0R£qjMÈ6Ëq1è`eXâœkNÂÆ ‚’œÓ¨phó‹»áO<ˆ…u>‹N®¹–\Z˜Ã™ÐÑùåÏYkâY„£A;‚hçOÏBê†tHÛµ5J<KvA€uZc*@òâÙX×¨%­_ÒeõØlÛwÁé7Øl[¶³g·kˆ0Õi¦.¤5È]½‰ÇùÚ¯HÔ$½XjÉ#yÎ{é£€gò4è¥Dž4¬jÑ\n®+h(&$‡º=%µs£ÔÙs\"\ZX…tþòs¼’NÀ[š¡c\Z)B¡2œ-Jœ°îƒšo]/ôÚc˜Ãá‚U+°´Á§ŒÌ¥“éC¶Z¯vÛÐâìÀ9É¬ûà:pÐ4@Sèž5Ûp8èpÁ€5?4ýš Ö‹/^¶Ý6àrçbâ«Õôè3NÃ/‹ÀV¨íÖ~‚úÈ°ß„uè7¹iÔ5˜ÅtCíX\"Í±þ”?zæ£m×§}¥t?¤ZÑ¼j;ùJcó\rÌ¨i^}ãÁ«~–Râ”5Ùc\rñDZUmÏ“Äéò«ed’^×b­úÏ0¨\r>4oƒ¼m;i$óà£…tÉaŽLˆ‹8g\0Î¸E(¤£ID	+Ø¸½d\0{@6ÔÑ\rÂ)ifëMh§{Pzí=`;¢å¹àßþ¸xc~¾L&	be›tñL>¦~òóàK Ð(ò+¡F	§oÈQ PÀà÷P8å—(î‡Ø‡{­^%7âŸ%Ëý!/âFMÀÞÉÓ‰>Å_Œ¢C ^g\0ÎB× ‚ªcô!~íz;’)Ai-Èa8azÜz/Vý0Þ´V“ÄÔP~>|c`êUñÃŸîÅú;Áªþ‰ì\rÛà¦eÑv8â—lˆ—œÄÀžZ¡ÖMw HíÞ3r<Rš|\r¼‚ÄZM‘Ö¸\rvVª…Íµ\Zá`ƒÏÑò÷—’h/¤êûb~Ú°1H^¿ÑÆù\">1?k K~AaHœ<{\'M&óƒp/¡#I(Ž]VgT„»ýú}HÞ¶•\rÑ0)DK‚‡\r¬ß•|7Ë_‘={ 7;›÷eÙØv÷†&üù©Iì7]Ø»v)†Ýp\'z•)_Z*M»óÇžBn‹AÿWAŸú\"ßEá¢6£GŒhÿ%Fßë¾ÿSo»kÖÀ¬ïbÔ×0´ÍWðäåRhHn\nC(ÛO×øèÁ‡\ro?2v9+`5™á\">b®:9›7±Î$˜G¾h_|Pü‚P„nBYLÊÛ¹ao#d\rØ©ñêÍ¨G-_<n¬™<%VW¡Ž\"òÀ;iš=ò4	 ÷ãyŸ£-Yó°Ï…‰×Þ¦½ÏLº6&%c\\õÚHÜ³Ç¾Ö®Qêçåè¾ò3+ö<ý6fäxíŒÖs\róÈq74ïÜ˜ñru¼ðë_!;žÂ§tÖ¥œP×`‚Çÿ<aìñaæg­Ø¾DÊfTdz­Ø¡øÈGCôÔK\"zb²ïÏ6ÇPšníÙ‡†·Ý‰œƒ‡Ì¡;xé‹C×{þiŸ\nÙÊ §<#-†¾ï¨o	lÇ•ãñùµý¾QÊKŒ?\ZRÞk†ÙßOý\"X™$õ»\nÎôªõàÎÈÂ¬½ˆ®O<ç¤Óº„sáüŒÑh‚tÐÃ*ëfÏ\0» ˆ	f	DæôLÙ!oœ½ØñeÌ2ˆ\ZN×‡Œ,ôš\rÂH?ïÞt»Å[ŸhL“Èù£qLMÁŒ@>ýíœÜ\"ÖÞðW¬h¯X°.JÁ±ô8¥ÞÁ)ž—„šï°|ù‹—aLÙë9Î§;3t?iÐv}©Ù0úÕ·ˆ(ý&ø@±\n‚Ã,’Uˆ9¼K]»Ž&š»á˜bÿ¾}hSá.2‹ÖâˆBéM»¡ÏÙ{îÂ²£!”“‡ñ>‡<zøò9ôÄoÄÕ0©\\Eüð·2ŽF5‚”÷›aÖ€…‚ nH]ƒÌmBï°aÒë+a7>[]k½cCÑs\nt\r“V-ÃÆßÑ)>–ˆŸ>« ’Ù8îOÞ´›$¹žÓS.´•½ºÏÂ¥¨þ»K”\nqá(—þZSú¢µ3±ÆŸÂT:aåº0øžÇáÍÍ°.ÇÇ:Dž˜¹S1òªòøüªëxõc¦~Ð3ûö)bøC)õå¦â`:Ž©©ð$Ò	M¢%Ø´^r©“ðœ‚žTM¿“:µ…\'>!_¼Pl‚`=)µÞ{ÜpÜoñQÑ5i”1f:\Zýö÷FÞ\0‡x6}ÄþÙœDÆi~ýPÕ÷Ðü‘GŒaÁËNËÀƒY—øDÔ+w=GvM—Zšðmß‰þWÜˆ”˜=ºsd½ßc»wµô…Ž­WæìhwÅõ¨sñ¥è{Ó=ö ÆW”Ã—–ÁœX.+hoâ¨úÏ\"8ô¡8Ù	{ÐO»²‰‘A•æŒ-OŠM¤êÄÎ”«xòc\'K¼kí\nÌ.3²iÖÉEGß%òâ²V±ªNCtº²¬“‰ÖÅŒ!oËYÒ¬bhÁ\nT«è|ÑMY­îH1àp°ß_ÿ…tuGAî{-0ðËÖ…‚ 7ÌÊ’z‘ºyÜ™iðiqk„ÛKŸ­ê—\\nn‚6ç&\nFü³	ÚïYøj‚L[ö®<™q±Î$˜Ý/(¾®ÄÓÆQ¡\0‡~±ñF¸£A¦^3ƒ+¯ýzýé.ÛøšÆÀ\Z#Áp|(3Ÿ·zÖTø_,ë×™d˜fÓ´2É¾1MG±û/àÐæÍ¼f&–³É“Ðs´÷ }°óXsÕk®b:CÆ];Qí²rÆdû¼.R±šÒ&´Oý$Ð×ÑTµŠTº³	šP²Jôé€¬ô4ô~ñu\n§5ÂÅS±	‚¬·•´‚Ö@¦þXªCŸ@£AÇý½Ê\\Šy¼Û_ûþëÜ¶‡ÆÏf\Z}8Üyõš`Íÿ¶wšÂ{p/üÉIÀª­øþ?¯£O½†&öQ+iµ˜”zž1ðr™«‘sLk™X¥>}åUëÂÌ\"|Ø×¼#z4l`Þ¸ÖHPEX\rUõ2Ëü[ÿêúD êQ–b!ûÏ\0©=A›zëO]è’N=ÎÎb,-(‘Š$9-(6A |Ò²{½|5‘%ÊÇÄÎcoèCº¼]u~{1\Zÿör´ýÃøó/…™JQ1µgÔýí¥ètù5hX¾\"^º¢6Mšc}¶Nj¦©]¹[ñæ]÷ÂŸŸcÃÒ×Ì¬Ge¢þåWà\'Ÿ12ò¹\\¨ú»rpçgˆ¤,Ž)Åg)[ÄÿØ5e!ÞzøŸ¦Šè*E	¢%ž šb¾Yó•ÂØƒ	4aŒ¦ÖÙB±Ó‚âóÈ?=Ú°‡Fõ$ð’ÆiZ·Pä#ë»õ\n™²+èI£Ý¶†jå˜G×1üÝ·}ù¯»*9z®ìf!XŸja/´á¢ºƒH\Z9¨%7Ì-u{¤êè ¤;çT³Ç“‡.Ï<g×öªÐ)F!€ø…KH=’Ò(h?Ç3i[Ü)çŒÁÞ]ˆ4JÛÚžÌ“¼ì›:ÏÒkÞÀ4ã(§e!xè\0‚y©dž=²b‘ò”œy´\n*´w/YLãóR°è_xxÔøÌþ™\'+™1ûuiy\r%¿îm»ö²gŽÉ¹­€^Ú«/»X=ƒù1-NŠOˆ\\Òü¥$º‘ˆ¯R¥ƒš!b[à¹Y?j›Bæº1¾rMcH@óJ\\( ¾ÑÓ0¸ìÿbPÅ{±ù/ÿÁŽÁÃÍNÄp„Ý–oüT.w\'¦Þù(vÝý,æÕjHÐ[QÑ*)\n“æ¢õ?Ø}8Å\ZN„Ìªô&ÓÒ«¯9—@DeÍv­]ƒå½û‘êÔNŠO¼^x7n\'cÉZRÏy.xb°/Â3µõƒ²Št¸âp;kfÜó(†wjï˜ÂH|Q˜÷“ˆYµ’÷BØÚ±+ºÿ¡<òSh´¨EÔ+À‚;ÿ…Ô;áÉÍÁÒæ-±#‚®ÕÞ Õ±o¹BØÛ¦#>ð«B#\Zuö£×Õ7ñ‚©(™ÅAøSuOa$P8T}Ã¡w1@±	Bþþ]¤eÐœ:©,\'Ûf¯–{ôfPËß¬‹õßõGýK.%_œWGÃÊGžAì’Åä•œ</&Þõ/ÄnßÀüdžY„\0–<ø$’vÇ²wùüØRíT¾ÒyxåL^q­¿A³GsÈËkÊ<qÑ£çŽ¨žKQÐ:é]ÚT~1wúø› doÚ\0¸]šÿ!ZÅ@(aLÜ—ŒÚ·ë;Ð~,¯ð(æöê}Ìò×<ö\ZÖD>RŽ|7jý®<Bn\ZQz—fEèÃÌ{ä9$²ÿgÁ‡´~£ðê­·ÃmÕ4“%¶í‚æ>aìŽòÜOAà¨EpÎ~“Í—~uk[”ƒèéA±	Bæ„©ôÇ8à¢éŒ¸i§‘™Dú~2?¹ëP¬™9——AÄ6ë‚ÖJÊdDÍ(ä}Ô‰“gÂ{\0±MÚcÕÂiö©  Gzh£ï5­xô¤ï8ÀQkÈÉAßWÆþ5ëE[¦pl~JÇîhõØSi#<÷\'BÏòê\Zx©Ä§ÑºÓgÄ£ã¨&ì¬D	Bú÷#‰ 4P²éëO”SyÜ©ÙøúîL(Äø +ûßøGrü‰\"‚öê»hpÉÅhvÝÝhyiÌnö¹Írj†SšNG\0«þï$ïÙƒPJ2ö÷ˆ	m¿æRËæT‚¼„0R¿îV?ãàoH”0A`ýQA˜Øò3;+Q‚Ñk(\\òÔ%ScO5ôÅ81Ú?g	&<þ\Z‡FÖâ•ïÙë>x¹¬ž.2­Æ•¬Hu­¸ÿilY¿˜}=-ÇôyX|Í?0¿[7³*$ù	‹ÿý}„$ÎZŒAWÝoNŠù!ögŽFÚ7=ñyA.þøCè}µ>%¨Êä=(½\r6•ê,Ë1Ô7ás}eV˜ž>Å\'ÝQÜÖ5ˆX…Dú™`Ÿõ‘ÈÓ¹ÛÞô<ù«ÿAË*Þ…÷ï¸mïüšü®í·%ë<Õ´ùá°{ÉRÓnØ‹˜ê£ö2§Ï?–·ô‰°=†]X\0Sïø7ºÝrÑeoTÒ²PZýûiÚµšS.¼“gÎÄ“	–8] ¥=[àTk0ªEV.KvúPl‚5t4ñco,ª°?×pðTÀÞ3ÐÇÝPã÷å8ý›¾Èr·™7=€ÆüâfÕø±à±W°iÕrSØ Þeè>ï?ôOÝtGAXþTeÄm¢UáØÛG-_[á/˜ÛæÞò;³ŸÆ®á³£œE_\\ú\\MAàµÚ\'áˆÈ%q:³³Î4Jƒ\Z6ä±„Í#d,_¸òŒ@š8Uô\nDÜ°Y]cH›6³èX½ÐBÿ?àFî¸)pEE„rC Vì¾v®ZhÚNMÃ\'º©ûöR*È&³~¬}úÄlÜD\"+ýnÄtéƒaWÝ×Cö2‰féRiš<ü/‡µú!>î¸8L¹÷1–å%n´z!âAn¨[±fÓìÞÉ‚UÉ6õ|ç]ži¼súPl‚³m	oÚ\"¦²œ2[þ’åhþÇ\nð»\nÈD	‚ã,Šðfq×ûŠ[Qïåç(¼ï	#ëéêQéyì¨ù)^+[[&OµÑß> Í4>/F”¿\r»W¬µ·¡l?$Z‰ï®¿÷þæWV¦žc¬x·\ZÞÿàaA`Èß¾‰¼ˆ7ýIµ?ÆbZŸÁïÔ·šµ:Ë‚ w.ò²³ÑêÙxeƒãÓ†b}¶.Ô3[\nš>% \'äMËÁ[O=oLÐ‚ÕA „¯›¶BnJ¦	ŽÖ\n´ÿO%4«ú&ÖÏÐ47eƒ?Ê)ë”ÃÈÑAëgŸÃÎë\'³¥ù\nJ:…wÑðIb1¢åèÒ¸©	EˆÖ%ò\"{ÃntzáU4|ñE4{â9|ðàÃèò5?]Fâg»¤(;Ë5‘àÑÁâ\"Â\"×Gõ²û±™NFFc%”·¡ç#ŽH1RgÖ-3íÚ½ƒ«¿Í¤z§Å&ròvµúš\r#blXd6àgƒŸW%Ed[,rØ³ýË3Ômž:šÈæ³!¡è¨@3ªïS#S^¯X ö0»gA\n/«rIh/@ïC)˜L§ÜòPÔ©:gg•®GAùyP¼,˜©ë·@¬/á}fÓF@š$s6 9E1™âô¤Uy­¬¢ÀÕ½hælúÓ—°®A’óM\"•o\r:U9Õ£^5LÌ°I£cXÝ×[NEïvìƒküäOž‰Ü­›Éí}(¿‚ÀÒµ`z<sW\"½ïd÷ˆ}Ô,#º=ý³%di©XüÖ‡»œüÁtF)Äk÷^ä\Z…´_aËç_!˜Dí\r —÷‰–‡ß“‡à¢uÈ;™3\"~Ð„K¯æq¶Å wÖxf-AÎªµÈÙ²®uÛáÞ°	sW`I‡îN:•wèéã½¥•šÊò(ÇHós¡ø„ðî:H{‰GÌÔàSe‹f-z~(Z‚½íûº/:Ýð4++üéŸÅá^þÁCËÈ!û6Ì{¬\Z:>õZW~	_U­ŽÜ¸j•„	HàÀÆÍøá…7ñÜ\rí±µ†šVár¦ÎG£oE÷—_Ç÷uj£OÙk0·|El§vŠÑÖliõþÝØõvs4½áVt){bþT	#þïiacøtºñïxïw×à“+*`Ùsobá“¯àÓ?ÞŒ&ånEƒKËãÿ.úCúh5Pñ™™)h÷ï§ìÚSLþI±	‚¹,v5ûœ\ZFä¢³?”KWó¤Çmf¤x¶=ÿ&&~7ÀŽì,Lüãíx¯¼†Ÿ1UNÎúM¨si»VŠ2Ùêj´$;÷à£[ÿ‚l-Š×&r.Ct,eqêÞû7»§Jµ4BðÃóUÐ¿Ì¥(°­ô†\'ö¾üCÖ£N%Œ”i‹(07aÙ¬i.aãdÖ™ÿ!4¼äb»>„ ÿÔ:WáaÌ^0s[Íž†øÉ™Ö½Ó„bô(éA6õíG¼ÜR®³\nû_©‡	ß³kGéºŽB¥_ýÒh¤nA„t¯Û††‘WåìzÞsæ;ÈâŸùEglY¸Ò–Ê‰¼êrØÛÓ¾\rÛðžÖ.j›“X÷¥JÄ²ëîFó_2ßD¹Ý’Ðñªkè°$9«Ì¶ýá×ÐäÍ7?„éLDtLM@=Ý<Ž:ð‚éõyÐïÃ4&ÂN‚b€âë\ZÂ¨…/öêWñàwÒ°ûÍ†˜Òw°­6’_á\Z=	Õï¾\'BHÍRÖìFãË¯²ôZ¦êp[œs˜»ïþ—0»ý×æŒ9æˆ¤¦pK£:ôÃÈ6_°lËd ù	Ms‹ñq\rš¡ú%‘÷1å›JDv*sù?ã¹·°ÃF+š—…‚à£ t/w›å=\ZdQLºø¯š7¬^‰ïÞ®CáÔ\\†ƒúaŒNŠOÔ9HˆøÆæŸ;¹Óg¼ù1&õû-àÎEë;þÎáeš1BC,õÝÙ›waîÏÃ·ç\nÈS9Ô$Ó4W¡•L“^¨†©å*`Ñ;¹MˆÐj†·\0Kž|±ë×›8\Z$(IßAýß93¡ÚœÃw í¯¾ÎYÚdg¹>o”½Î8s*\'*^\nÂ·em´nB]„ªõ¸r1¨I3¸3RÙ.‘Œÿ1F?ŠOˆ•« šêÅÖ‹Á“…ýo6ÀøAýè¤%#©ßl›<ÙÙHÃ«±€#¹ì\Z6Þ÷8ê_r9Z•)‡ç/¾’8’!¼$×Ca/F¾[SÊ]‹·ÞN!È3/ßŸ’„q·?d·­v#u#R&LBÍß]m—b‘÷`\"¾¼ºË uZ°ƒyþ\ZÉT‡ƒ^Ö5¤%Ò\"è¡ÖÁÌ?µ^VjåÌ©Qç‹¨‹b^-ý·Æ&Ÿù1³G\rØÜÀá[[ç2^æKãð3»kÖÇ´žýìÛ\nS¯¾ëÇŒE®Ì¸_ãl8ämÜ…Æ¿û}$‡aìüŠ˜Lk\"ÈGâŠMXuíMxóÁ»\rqÂALºåa¸só˜”©ä‡HÈÄ$ã«î	3ðÒo®Á´üP2Ú”+oÃÑƒ½ ëå—5VuÉÍ³\"¤8N×ÐçÚcw\ršýM“Å£kõÚ@A¶Ã¡ »uV$8ñÊ6ç¨\0ªÕ¥°²/ŽjCû3q5>ÂÄ>½HX?b»‡1eo PdQ“¨J FÓ\"4½T/¶Š¿Œ•š\'Çƒ ŽDÛç¥]±ç“/ðüï/3F#/[ÿüfdŒÓ¨HÖÏqBAÁÏê7m_­nõé_áóòôÜ,€£©i7=Œ^÷þBà0OÊ¡É7GÑÿz=Ý<¨>ÒrbÇŽˆ¹ô”X?£E ‚jÿmÁ˜pn66·îB¡–&E&wÎ$Ôn„IÝºSÅá¹7Ý‡N·“¸t`µV0ä‡kÃn4Œ8‹š’ Ø2êƒ©¹šÿPW gÏûÝdÔ¸ÿA{*©)ê­z-n¼ÞÚg\r¡ÐD›NNG“;ïG~bªÓF–í>”„oË]cÝ“òè	æòkþÛÆMDÈ-Z˜r!%ÁV_+iQ°	5Ö1sêXŒ{·>óÐS½g\0ŠÑ\"84²¶HhI_ž?¬ÛŒÝÃ‡Ñ»Öig2Þi‚AÚ1Ã>?|c1ýÚû1²ÙçÐJ¥<:‹ÃÈ0˜v„WÓÌ\ZWÈp“Ð9ùð.Y‰Ê—^\r_~ùÚ\03kñZL¿º\"f¾^›é(TL/\'‡Ò1£asty¿»Ä¨¡–³˜Lgñ\ZŽ6Y.…MÆgY½¦è|ù•ðä›\0Ê5AH>„á·Þ‚›ã<Ö¯ZŒNÿ÷\"ÏØEP*lx| øAàA«&šPh(ráÀÔÙÈ·€7Ø›JãhÞlª%£ÇõwcØ_Ðl“XržXÇä·>Æ¿üð»É6Z†xâ1¶\\EªpÒ^{ýn¼³:tE>­…¶ÀÍ\Z=\r“j6Àke¯FvF’1IopM1sÛwÃñÙ¥Wafù;X»b?ï„ú7Ýï>â¸ž©ŒG\n<ÏÞ²ÏþúW»üÎì¦nR\Zë^r>|ýuŠ…kQ	ËÍ‹;„×/ºnm&F¡T…êMnÝŒOŸ§¸©D²Xº\'gç@±Z„®1½—~ÂÊ¾=‘³s»5JC5¶8­Üòñ“³y½1T¼°—Z¼alœ¿œ+õãý¤„}X0nfŠ©ºa`§¯±uÙR§¿&¡—\ZŽÕ&R¡}ìQÌµ+4s:ii‚Y¹˜Ðùk´»:~hÛ¹™iô6t÷Hpef`þXv~M:+à¿¶\\>s>M\0mh@\\µRÛÏ2Žš¯+×NÚ}û÷£sº(ˆOc;«nBÛOñÃóÅH#?¥_äXÙìdïßjƒŒvÅØ(ŸÌ;…N³kí5Hû,I0L™ÔGè&ù ÕP6çH±}\ZÙË£×¸fÓTT4¼¨<Ö½ÖPPÃS+ó(È¥ðë-$}gBu¨rM@y(\0¶Ù¨I_dE2-§v~q©`âµ9~†¿S©zaHN‚ÒFºcTU,pÆAô´‰11(”ù_´Cúú\rì;¥uŠ°Ž¨p©T]žD‚Œ¼iƒó˜	DgÆ8KÕ\'3‘Íç›mÐ=qÁÉnq*CofGtõHP”ð±6f²2íG÷¢øêèœbÍÆ5Pù-älÛJþKŠäácïŠÎ  áÈ{šyótîwcCŸ¾Ø1j¼ú6C1H¤y\nù\'F«Ñ#4¶£9fº`µÂK×–žÚ(!‘•NAL1°²#qü±Gå*\\G$>rSÔ:\'j9’…Ê\"»£?‰’¬äªÓñåOÛ’?=j6÷šÿÊ§²l¨*Bž8³>Â@a³Ø¸ŒM[0¦n=ä¥§ÒäÊ,‹æj¤æå\"ãóHÚÄL	G¤G°™}Mddecêw}0ð­w\"wºççìÀYi=ÖÕZÂü<Œ¬^Íaßë²åaÆÿ¨à“h6º¸@Í`›Qç¥N¼¬Ý²\n½kÕAÌˆÉl/€þ”,ŽÉÿ+R	þ›®«‘ròb§ÍÂ¼w\Z\"+á &g[}í\Zæ¤ÙÎù×~6´%—“RÓ0ú‡aèõDesS˜Àñ$\0¢Ï…-j˜þXPûm\ZW.ºVy;fŒG ;ÍISä0çúò±dÖty»VvîkíóÐ±©$65J¢³\rgU¢ßq?À4^Ú/ù¿pz¼ö&b,BnAŽÅaô£4<FË±‹¨PS(‚œN\rµŽ&>‚šCÏmkVbt£ÏÐ¯Î‡ì³˜‚ã9£jƒÍFó3D²ž8Ë>ÂI€ÆØ$HÌ‚…èõÌ«Ø0k6òs³HIÙ\rgª¶Ðl2è\\?—`¦\\ÂH>ÊÔs&‹äuAAV/›Íš£cšðe¦ò…_Jç\\€C‰™È°V„x¥QÄ¯ÛˆžO¾ˆ1z`×¡ð{9¥_ad˜Ö˜ ŒçÈOucÚ›Q¸iÿéƒ‡öbÚØ‘èóZ\rŒ|÷C„ô»€3B@[\0cù=JžE ÊkôÀNÁá°´‡#\ndg`F“¶èþ|5Ì4‡bw ÀÍT2­^‰ƒÇZATÜàìçÔ¥BÕ¨½’3öïÃöÿC\Z6E×ÿ<‡=³f²\r>{mOY”+ŠÓE–(q‚`«‰¨U¢š\\›&\"Õ¾ˆ?AIÑæVš}†¾Ukbz·ÞX³zR’“áñè!ðÙ!¯„!++7lÀÄÁß£ÏûuðuåW°²ç\0¢h¶iØÉIØÊe¡fAÖàœÛ±# äY„ãÀìå…sFö¾X,êÚýë¼‹^µkc|»¯°fædÄlßŒ¤”d¸\n8 el/¾*‡ò2¨/—#\'-µÀHóY¥áa:²dœž8êÍj—¯\0IéIØ½sVÎçP·jò	¾~¹\nÆ4l„ƒ—±_ƒÁë(«täUÉ„óFŽ\0Q–A^‚vDói	¼^2Â‹‚ôd¬53>mƒ^/VCÏ7k¢Ç{õ0âë¶Û·æŠ•SÇaóüéØºd¶-_Š+–bóÒÅØ°`VÎ˜‚yãFaÒàÜµú~ÞÝß¬ŽÁ´>ƒ^©…Ýúb×²%6Ü•…ôRû}I‘tÜôü|àüQp^\n‚ˆm´–µå‰=7P¤T›ÝŠº—ÈSŽH\"†¼|<ˆø°cæL¬=\n|‡¹=úbv×^XÐ³–?&ÍÀk‘¾s/‚É™ô^U†ÃbÕik‡eæ‹LŽEG¿V=C© œ%£ÁÂ !d„íŽ\'¦@®(â4ìtºÇÁsœ<=rB(ì¬V²}’L²tt0“U£ìÉ0#Ô½X™Œ>ßá¼î\ZækÞAlg®èÊ‘ƒHÂˆ°èZÊ=×ÿwŠ\'½@7U£,N´|G¬Æ\"eX1çœŸ‚P\nÅ¥‚P\n¥‚P\n¥‚P\n¥‚P\n¥‚P\n¥P\n…PjJ¡J¡J\rB)”B)B©A(…R(…B(5¥P\n¥P¥¡J¡\n¡Ô œMÐ¢%-tŠ®c²g}Óáàlèlæ¡ýÇt¶pÎYø¤¥VŠuVJ9k­´-—Þ³²×k=I,ydY–…èµnøã|\rK‹òXšôr¡®CZÃíÄ3W$h\r–Ö€9ió\0Ë#¶,W!ÀJœµà*[8+]tUŸÞNá9ãtOø¨=Ñ¢ƒ®¯5gZ	¦wÞ´é±vã²ö•ÂƒRƒpArYÚhzp„2è†‚–ÞFÏ£‰#\n¢äN>þjÉ¬i6Ï-ðœñ2/z=ÔYR©%Ü\n>¦?ƒÞ\0*(\0\\ù@n—Íc“ÉÀ£®]yÐ·íÓøQ<¬rNÌñL†KFL[ÉÊT9<•E«…£Xè½#Éjø\nS½õ«ÏãhÛ9½¤÷•^i£†L«•Ö)µÎ”\Z„³	lJ¸‚zsëIécoUmèxê©#ª¤í‹CT`_B®3“¿/Ik×\"qÁb¤Lž…Œ‘S>x<ÒGêÈiHš<ñ³æ#qÞ\"¤,]†ôÕ«¹i²¶oDvÌ6äîß…ü±ðìƒ{ÿ!¸0ŒwŽû¢ f/\nvÆÀµeòÖ-CÖŠ…H]8I3§!~Âxìûa$öþ{ûD\\‡ÎÈü¼\r2Ûv@rž88p Lô%Kàß³ÔD„ril|¹l‡£òa¶)¤]ëä)PÇyÊû$Þ_ÕæeåPðRFA·µi™ü&^–Â‚Rƒp!º[ŽI¸zwí°ï£¨[¯íF(+ÞƒqðnÜŽ¼E+6{!â¦ÍAüìH_¶Y6ÂZ*u+A{ñ\0\rE(¬o\rº©Cí.#Âr‚EµÌ‚ÎeŽˆ—Ð\":öžÎQ!\Zo/qEÐ·w’#qê¯¥Ç…¯•è­?½…ì|’3ØŸßú]È˜½q£Çak·¾ØÐ¦bÚ÷EB·!È39ë·!”’Nc ·s‰SÍ¢Ï¾ž˜OäX¢áh.ƒ¼¡R8cPjN$ŸÒ’hÐµÅñÂ´J*	zCN›èfå kÏ>X²1³ç#~Þbd®\\OìAÒµFÔ¹ŽäÓøÙÎ™\'(¬K!…Q¼E¡HÍ…Ait´Ò-­Ê.\"uECaNëÆu_óš[0ídœ®™–Iµ¹ó¹S»úsmF\Z¤jË#0+¢¹ÛÏVÞ™?Þ{hð–\"¾ÿ@loÕk>i…Ÿ~…”¡“á_³ÈÔ–(^–æ5s§6\nt±µäTt_ñÂÜIiƒB´I:FÊ)…ÃPjN$7Ñ 9RˆªkT¾|ìñµ? /äô•ê-CùùÈß½	sèrOœ‡Ü…«»{‚Tzö¢2æ%DöÎ‘™.ý—‚K^þ:Ÿæ•‡“Kã™ˆ¤…±ûÛï°ºêÇXùþ²LF n“Ð£ºI|ÂnÒÓGƒe_•cv’TÆ³Ðs1£å˜¸È@ÌÎKáH(5\'\0é§Ä3ÚãXï§Þ_=v^±½d•ŸcîôÙ‹‘1sÜb(Ì/³WÕ§~\nø«¾Òé‡a47<ríÌÌëÉÀ¯EÐh@_ØQo/…5ÿ\"è%]h*\"^ˆQÎ›ÜÄŠµõšcs&ˆé1ž=1$d.óº8ÔWÂRX¨y/,WNŽ˜)FþË/¥¥á$@ûekß{kÛh¯¤t¤­ÙˆÄEìý×oE03“÷Ø[ÙD™¦5\nv€i|Ä§•L+˜0ê\'\Zµÿ­@:˜A´ áÉ‘A]¿)·ì0“DÉ¥Ç’ºà?´qCG`mO±¥A[$-^Ér´‡³¾ãF  ‡Ã=Â4º—ÂPjN|ì¥’‘º~=â—.Eþ®Ýôf5¡G¿!Hµ§ð²£¾;B*yv$Õ„Nyr‰õë¤ŠŠs©TF¡(uŒ*úQÐHÁPï^ø§k»B¾€­«ðÑp8S¢HKFê˜±XR¯Ö5oŠ‚uë\r+)2.hƒ•\'.AÑˆ\"AcK‰ÿyCêCä	xàÙ»i—#{ÃN„2ôØ‰å×R£Ù\rŽ¸(…’\0Î¤¨£ôÆ\Z\ZÏî=ØümWL©]FGøPœãÕÑåðó¾Ÿü•!·G¡!}µÉäÙ—à#^ŠÚõÕÊ”Ð¨¸€xÿ_å!ˆoG}RWÌG€ÁëFÁþCHY´™·#äqQÿµØ†œ×dýòfõõ8õdÊDa¥P2@¼Ð b\r´\r¦—C=—Ï_ˆž]0Á„}ˆ2sß®Ýß‡@NÜpÑÐã¯éÒÙWvU†¿hP\\äp¡ÍD\\ØA¼ŠðKŒR±õYg›°çóTö`\\ñºj5ò¶ïB8ÏÅ{Ñž@BÅxP1Qy 	±£­Ã.J¡D€1K¼Ó ÂYù¨)Í‡éáÙ7hÉA)¿-úJIDBïXùR-Äõ†pó\r•@d(X@¹ÉgúˆVl¡ D¤äBbý…o\"`N¾zz\Z¤¥ qý:¤oÞ	äé—öjP\0ä\"2md0«\"\n‹‰^F”BI±Hºk\'ö8G†À95eVïOQÐ<±‡7òL¹‘”€Íºat\ZH^<Ÿ7sé-äÒ³ð —ÆAßô·2ÍET7£“.ƒ \rÒk	…½dÃ³Ïƒ¤;¿qYY}>ìŒÈ[õ Jn½	sÙK:’$çßdÉÊtŠ´ x;ÉšÉ‹.,ž\'V`$w¤÷’¢º-¿’ð ÉGÅ)et®x§<›3§s«SF¨,[q(vê·ÊT E]G‚ÒW«Kq‘JU¿ž8Óùl?ïùu´»‘Ì%¢h\Zª‡/ô§>ÝÖ\'PÁÅ_£›êçQô°YÇòV®ÁÄšu°üË¯á‹c\ZÊ‹~‚Æ úgz=&Uy6Áù_8«Ò)ÿ<ó× ££l>tB&Øs}}©%3é+6 /&–ãBïC@ëLs™ØºIƒ&Žä)ÈÔ;d­ŸBcß‰Ž”¯g¶ÛQ=Øò±½à<ä¢XPÐüT(-\"ÎW<&-…StrRB#E·‚(ƒºe†FÊlqŒ žz/\Z.	±žÉÓqü`¦Ñ¬º³`ÙyÌé¼fäáf¶ŒI«õu|{ä¦ŠT¶íó²µ,;ÈzÂ†—uœtÕˆõ…=,­€Ç€S‡„ž7œƒ®.H 3BÞøS±¹ï÷˜Pý=$Ì]Ès°¤—IÙ\n‰ÀÑ Ã/™ã_„¥F›ó‰>ÐÌéÕ[¯I…LÏ@ÒÚõÈ³ÙdŠ¹=&$iá}d\\ó¨·Õs…@ˆj›‡Ð²åˆiÒÝîz+·PÑôAûHÑXý9+\rÈr)ËÁ4—oƒ{ètä¶ëÌFíPã|ýCø¸=ÒFLG >…ŠyX•$,\nv¡ÂÍ—å]ÔSÉˆx¥õ	ðÍ\\„©/ÖÄ¨÷›\ZùTT}!°`ß¸7lGÁüUÈ=Ycg gÊ<dÏ\\ˆŒÅK‰ÿrä/Z÷ÜU(X´YËÖ ½^ÎòÕHž8k»~E}Á›a€BZ1q„›ŒŠZš<s.t\ZJ¯*—x±Õ¦\0N:9=Ê\"ìÏw¡4c©mn\ZEÍ\' +É“¦cÂÛõ°süÞÌ&¡(Ìµ	fÐ#AEÉ[PcòsÀbÄ\r’\\/ìÐj²³qhÓ&d:àÄÙX€#D¦É#sÌ(ÕyÄD`á\Z¤vŽ¹UÞÁ§7Ü‚Çû[TºûÌ3ÎÑõÈTfõéZm ‡0àÊCÁÆm8øýhô~ä%|xû½hþ¯ÇÐ¾òóèPëU4}ñ)´ùó^¶\"V^ûL,w=ú,RÖo%Š>*µ¾þéILpäbR|h¬B.ŠÐŽ}pŸyï|„úå¯Ã›7ßŒOß¨†ô”$\n^ÊÆw¯ÖB§›ïC‹r7¢ú%¿GõËË Q¹\nøáOc÷óµY¯	üí1t»ö6´¼ö4¾îV4ºîv4,[õ.¾Oÿê¨ñ÷‡›šlFÑ«­ôèž’I3-“g×NŽÂ¸6íèD±n]Þ6¡gRá~!‚5Q?²Œ\ZSR~‚z‘,3	qcÆcÔ[u¿|)	@<É£¡Îa\Z%mŒ¹Öœ?:o\r‚\\Hd³êd–Ç…ø­›‘N!F~™œŒôf’aãÝÞPz&«7!®ÏPtÿg%¼|Ey´«ý.¶­Z\rŸK¾¸gÖÞÍŸ\0¥^Ï¢å´kÈÚµiÇ£)•ñ›ªo\"3iŸ“A0ÈÓ¶®E—y9Ø7|&Ý~¦”»	Mwæ}Û•wˆ¯ö\ZP6Eß{‘õÃx´âY4ü÷3Ø½|U¤¡ÄƒÆ-@áúi”hEäæGžˆÿB«¶bæMÅ«ýó†‰Ääµ°^Ñ…çêýícµ7&™úbã‹o¢éï¯Æ3—\\†‘ßvs²E‚ÑÞèáZ¥þÀxá­Ÿta7‚\\úŽîôlèÜã«¿o¬–MÀ+EÓK†HÛóéIDÉ4¢Þ±BÑ]£kéH8à…k[\\+7!œë\"Ó4 FPá4Fæ(}¸€Ê¾nvuè‚êW_‡&•_ÇÝ{¬<&éŽ–m»ä\\¿+áË°¥þç¨VþflY¶ÂÒ=|˜b—ºü±ÉH*™Ðð§æbåëïcÁoÀ;_Œ5ú>4AÞAØ\\uö0®$õþMï¾óºô2¡òr(!ex©I™¤í§!°s’ê4A‹K¯Âìï¿³8Í\rXNÕÉ?›&Œ ˜ÊhMTÊ+ðsŒNOGvÏhzÓýØ0~2VtíŽ¶W\\‡Æ—VÀš!c,_>3zDi*Âˆ\r\n<ÑËl)b1ãýFXÒü 7ƒD¦I6ièg;Y¦|‰‡’o\"‘3Ú+Iµ¹†æñÉÈ\\¶¾´tê‡štc\"õ Ò\"­*3V¤çÃ5{º>[uþz¿}::hO4‘èTtøÕÝc€‡\n»r-6~Öüñf¬9Þ¢íKÿšx3`QvÐVb6‰§ò5? œöìÅþJobð•QõŽ»àa¯¬ÑHÈK—3¾Qäÿµ:F•¿ãë¿Ï<¹ì­ÝÄ‹™•Ÿi¥´¯Ap÷^¤¼×­.½šá{‹;Ò èŒA¥Á:Œ>MEv.òÆÏE“›þ‚½œ¼ðæcëo±þºûÑ¹ìX>a³2‡&\"þ[MyCÈ*ÈBÌ¼©õÜkHž3ŸÑæOš\r7\ZŸ\'$*ñAb+¢ú)±²¶Z¯ÒÇöÝ.d®\\‡‚1T©\rûpIµÆ{d€ò8y)¶yðMš1ÏTC{@^R\"ï8O\"ž}!üØ ðšnb81é½F¢çŸÁgOT‚/O;ÿDpcêg‚ê•Dƒ®u+˜…CM¾Ää;CµënA~bŠÝP›rX’\'.‹^­‡Qe+bÂ÷W^©o×FæöÌMGžc|{½7RÏOA`×\Z„fƒp,Áyâ üõ…Ö‹ç~›=/X¸\Z½|«W·ïé;(Þ9©8Ôð,¿ö^|vÍuØ¸pŽÓVYªÿR¸˜#HÙô„]H>´37Åü¦­áKI±ù\"7\rúùB¡=‡PT±ÌýV¯ï	Á—áÂ¡%«àÏÉ 0RIì5dSI2‡¿T0=ž“mÇÜ6\"µqÔ¾ôrÌ3R±,‡\nÂž[ONšú+˜½™µ¿D‡rw`ÈŸGo8È±f§Ç=\nt¿Hñz!*¹sŒüçsx¥Âp%Ê01¯/€|â¯½‚TRA\\æÙí˜fÄUe1¹\\E|[áv,Òø½ÀEZH\Zü;cúã!Ìì××âŽ6ªK»•™>ût—Æ`ËhÞ\rî{Á”$Þ4BÙcÎ0}àpN.üC&`óóµP·ì5Ø·m“C‚ÿZEõÁÚY‘‰ÍC‡¢ßo!~Õ*Êˆh[DJ0”8ƒ ²IÀÔsÛP™r¿}ö´ Ï$¬ZÇÞRä—4+D29rK·šìÑKJêÚx/ÒÄ¾øj]z)ÍwÆîp)çÎó{)F¡©WYá¡S¥Èž8U?A÷ò·¡GýúT$zL¤ñ·^w†Þ½§\'aHG3G.­QTV.ÇåƒÑåö¿ã­»ï¥«é±9•åUAj´FBLï±yÜñ»0÷µ71‡õö,SõÿvüÚüô ç”þ~s4û}yLéÝËâ4rZQmA¬9Œ€y;7#8|\nv¿ô†Òhzç}¬nÔ\n±-;áP‡þÈè>é#§ ¦]g¬}¢\nšþîÔºóvä$\'8¥²±ö\"ÑQó1ÎS«Ó©ø‚Ç„KêØÒHÓ5TÈÊMÆŽe³Ð£Æ›X3t8ï“\0”_1!B\'Šií¡¤†…<?×P\"\r‚ôBÂ+:­ø£E2ž	H\\º‚Ã…¼HÊŸ/TBŸÂñþÞ¿=‹î¸S:´5çsØAƒ¡yç±Ô^y\ZJ0	)K\0˜8ìª^³n»ŸÞ|²¶ÇCÔ^MjÊ(ˆ¹†”ÕPRzáÛ°…\nöÒ%e°~Ò¥´¶*\nˆ”H™Í—W-DNö7í€¾þ‚—.+ƒí+WòÆOChË.dÓ 4½¼~èôµÉ2£ ÊX¸µO7(’©‡ðýôºç||ÛÝøäŸÿBã‡F«§ŸÄç¯¿Š¶µk ÇGbx«V˜Èò¦7joËÞ‚/¹Ÿ>û·-fÒ:…¬é&zÈK³¶©- ˆã’\Z#d„¤l»KïAä§#cí\nz·õêÇ4>g¾I\'‰”V¦DËåÍX¡Î-”È!ƒ‘…ÓÐV[sË†z÷% cÑZÒT“l\'é‚y™Sk\n2°¡Jul¬ð¿øšFaFÏ.ÌM;®:ÈG•&Y‘Œ³A³=w–‰‘i,ÇïALÏ¾XqÓýtá+ ÇãÃ››eïfRÅ`ËO¼u°ŠªG;&<€}£:]ø>\r?Qj&s„H•Ë“ÐÊByŠ–lhî^qÈÍ†Ìt´ºånÔ¼÷~ø]\'žÕh£Ö÷Z U™ëÑ¯eËH$«cq…Á^éÍIƒkê,t¹çŸèôZ\rkˆ­¾daiÈˆHr‚ˆ«—×ao\0)]‡bÕµÆ×—]‰¯kÕf:-¥’ad«Ç¡Cau È 8íekÕXÉæ¼´¥žßëEâÆÍ]«>æš§¦U¡LI\'Òê¨¬\"Ó¹†’gDj©ŸÖ@KŒƒtÅ]	qÈšÏ^±€ãYj±†\'C<	¤”U†éXÿnŒ)[³Ê_ñ×Þ†\rõ›#oÉ& K\Z)S‰u”!ˆ ¢£m\rN•w¹°÷ë>˜Tî6–q;ú_w\'ö~?’\Z\"Õ‘ó¯ÏÔ\Z,í¬TÀãAŽÃ¬Æ¬Z\rPé7—bºfíÕ>j––F‡#Ï§Âì!49™O…*`9Ú•	Iô„6îÃžîñÊåQÿ_OÁ•šqRm÷¯ÛÏ{Ÿá««nFëš5ÉccŽôhn2Óš»cž®‚zwÜ‡œôt§áj	èb&/1“abrôö_0Ä¾-œ‡í:`ÓuàóKËcØG4tzªBoH–-*èr¡åZ_¸À†Šfj¢ÈJ\"ëRÆ]4sù½8´i-†¼TË2Zè=Š(O8º%K†Í,‘‚Ö‡Ëí’š…Ò31kÂúMî´èxRt#à/ \0‡¡\r¾}T>oF2Æµøï]u9Ú_vÆ–½‹®¹îù7ö?]\r™¯~ˆüêM1åî\'ñÞeå1ãÛ.Ì€›Áí!FšuOMÁ¨Zïàãß^ŒŽ—]Š™Wß€·<€ý/ÖBRÓ/ß©\'ö~ÕóÞ¨Fþ„§þç2ômÚ¾‚<Pa4+oË˜é½øÌèÑ0°×ææ#oæ|xûÃ¶¦íÐê®ñèÿ»Mž¯„¬xgñS@ÞËI´?J>þº;ðÎÿü?|øì³ÊÀðÿ°A ôf»°±Q{t½î.Ta;v¯Yby™ÌL›³›²&h#‘xu†¹¤‰\'\\A,~§%šüöüù—¿À€ÞÝœò#8:‰ºLÃj šÇ£ü)uÇc`{-8m÷¸s±mÕrtyáMì™:Ÿq\ZRÉTê35J¯Àès%Ò è=MªiF;mêl¸â\Z­$“´Ž«¥óŸ	š°ÝpT\0!@%O=p\0›fÏAï–­Ð¼êh^¹*šU~\rÍ_¯†ÆÕÞÄ¬#”ÓÒë×9#È*ñ?;!\rK\'ÍÄµßÇ¯¾ÖÌÿó\rïÑûvì…/‹½=yÔ’ê“PŠíK–¡s­w±xÄ(ä&iKvF²åT/íŒÌÙzÅ‹<:©ŒrL(Úäçd#nËfìÛ¾‡öì¥mtnèž£°*‡¢èóbñØÉX0f¼•+?\'úú·Ìˆ0dX§ðQøó}Ö¾’cð–ŸØËž‘˜\nMÕiÂ®Ô*ä¿DGÑ0=7\r‹FD§g*Á»?ÞXHé°µ,aMšwÎ-”È!ƒÜgíûŸ½~#òié®v*t9ÄµD§2šH¨<zÙ3»i|T¾ÂFöŒÓ\n4Õªõ\r6É§¼‘ …±ü!zZû¯gÍ¦ .ªT^.|A¯½c_À\ZsëSe>Ç¤ý$X¯Ì?MlÊUwV¹	;Çð`ÓVR!‰‘‰’~\"Šl÷<ì«è…h\rÓ\Záà¬½‚k´R ‡ÞCP[ˆ1£•«rxOsz f‹½Ì\"è \n™Ir R¹_“1züëæ KOAX®<=+“Á™rýïµ[ä	“ñ±›1áã&×º­ñZè¼¤–—(‘‚ËŸš‰}3çÂ—žLjjðÀhQ–‚*åpFi?¢ÞÀÎuiBÍU ³\rÏp8K!D³IÌ…›Ô6ì¡ÒnÚ‹Ù\rZ\"~)\r™ž,Ø¬%ƒO\Z¦GB% ž=ûá›¶ÞÎÃ°ç±õ±¯qkd·øIÝ†Ã½y7µjÍ¡†ÞmÐJÈ ÍA°µAVŒÏ‰ÝƒÜóQÐá;$Vk‚„ÚM‘úáÈù¨#’¿ê‹äéÎÐžÊO—VÆ‘Ù\r%ˆo^BËÖbu“èVý=d$‘Ög$sR™!	feÀ?{1æÕm„¡Ÿ~æÌ¡ðFˆøé5íÿfpöí¤q$=7MŸŽV•^@âr-}§á,A´)AR@Îü•È–RÉ/Öl-Ï¤x’>ç1á•ëT@eÊY“B¯ 4¦#Qe)tp‚Flÿ„ÇÏÁÌÞÂû·Ý¤½»FžÂÞ?\nìÍA‚8jcÆ¬ØZ³zÝùŒÿ ¦÷èñ›bð£ÏbÖ­aíGÇ?Þ‚•ÃF)³-½ÖkËòb\n82Óé/@&‡;j|ˆ7ß‰Þ¯¼†.ïÖDË§ŸB››îÄÄkîÁ–Ä„r·£ëCO\"yÓaB×•y‰†ÄSôCiÈè>óx	­ÿþ/d¥¦]GÑ‰ºÚg™X·ç@R>ë„Ñw>‚oª¾Î8&Š|§Qeþ¸õÿE@úhœD`ßžû°1ÆÔoH\"ºÇÁ$o”ú”H!@!Œ9žƒ	&TúÈ§TRåÌX£x©K—¢A×GÅñ×©MºË§7ç‰­L’›Íš½cf¯XôÄ+èuÃm¨vÑ/ðîÝw!qÛVå¤cžctÑ÷\'¬þçO˜}\ZM*Þ‚m+–Y•RN}èÞìªû1•½/]~lßJJéˆhvÂYué³w<èè™ˆå÷<‰j×T@RÌ^Ã](kŽ@B¸oÐL¹ñ~ô)So\\s5öïØL\\tÏ1‚š—02d¥cÿW_cx…ûÐâá##3Õ¨oVÒ’+îû±¯æ\'è]þt®Uƒ1\Z~Q	˜N4úïŸÃ2T¼ÌÎÎÆâÁÃÐî™JÈf§!F‡¥ç\ZJ¤‡µkgLrs©DÚÛQ\nÓ˜s XÆªhÕ<jÈbLØ;Û.Kùn¸©È-oý&të‚Pz\n&TªŠWÞŠN=†¬„8\'ëI ž1{Vþß‹h}ãŸ°c•ó6¥ÙVÐ£¾™Ë0âÏOâ…«+ ™=™Sd)T¦Ô <c¦`á?ŸÁ«®GBÌ>S`-ÄÒãNùÁÌ¤uìq7Ý‹®¼\n´ÄVÀìªKk(¤ç¡ìÄÙ£¯ýš?úrh¬ÛÂ`Áù‡çÐAz·z”»	]Þ©­ÒÌ¨ÈÓp|<¥ú/+à·!™(àxåŠ¥ø¶z5ÄþÁ’Dfvìü\\BÉ3è¼…‹©\r.‘Æñ	á³ß³+Z¬Lõ+XÅÄI‹N4QÒ«ÏóÖ¡÷}•ð-]@MÀ‘ùkwbëýo`êÕ÷ õ_@n\\¬2ªƒ¢sE!wÖ\"ì©Rîz[–/¶êÔc#ßƒðšíè_©\n*ßzvi_Hyz`+.åE8“€ú^¤wô,zä%¼Uáf¤ì:`x‹–¦˜AÂ±‡°»]oÔ¸ô\nôúèÞcYBÏÒ(Ëaž rb»o1öú¿ã³=‰­[`²co|’ÞkŠåoÂ·ï¾ËÆëS^Ùñßl·&ªyæÐ!„íÛ6chÃ˜Ü¸…“BÃ«@Ÿ’g(Ì™?Œƒkå2’ÎcO¹L†y°yêàÙ7NWd ¢y´ôþÛ0ãÕÚøJïJËrzDiÀµl%vþû-Œºö>´yº\\ÙÚu€Ùèâ;½¹´êHH=îFŸãÐ3ocì_þ…Íµ›#¯ïd7ëŽ÷>‰]C0Ç¤Ž¶RËc=^–£’$RÚ4^\nßè9XõÈ+xÿÚ[¾sŸ¡ì\r{òæ!¼}7æÕo…7®¸3úõ\'B¤)¨IN%´\nlF~R;öÀ¸ëþ–=ƒÜãxVÂ!¤Öož4ÝëÔSv»gï8XyVø!:Zs¢3u¤Ã¾½1Û¼)F7ÐªUÅ8†â\\C‰3a¯éý†#¸vµ-ƒÕ#;M è€M`Ñ (êì‰–ÌÄÞÑ±MŠg½òöƒÈ2=y\n	Ö*6ªG4eêcóŠÙ‚.ÃðÍ5w£uÕ7é9jVY\r8¶AÈš<Ûþñ<¾-#7þ3û÷EÿÖ­ÐâùðáÕ×¡ß71ÜŽ15ëÛ÷$CTò Þ¦³þÄS\nè0+©‚j×UDü~½wáCæØpwøÓž«qM[Ò»ÑöâÊ¯|DÝŒ-Oìe-§?¹h¾îñ×?ˆÏ§AÈL7±-5?Œ¸zðK6E$.n?&µj‰Þk`×Žàœ{ú”<ƒàö#³û`V-£¬Oi˜”q©£ÍNÑÂJÏéd\nØ£³nñÕ&Ù•ú“÷ÃõÃH$Ôl¶enÁW—]…©×ÝŽíO¿†¥o½‹Ù~„¥u\ZbÙSÕ0ç¶ÐéåPù¢_càçí\r÷0=!íÊ¬²0*[EgÍ˜å=ƒæ×ßˆ­+	\ZFÍ£0Ó§Œ™¥·=Š^e®¤ÿ(<ù™vÏ¼%–‘ñáš<‹žx\\}=R7ï±ÞÉK÷Å›cB¹[Ñ¡ly,îÕ‹EjÓVÒSë”Ý¤-é«õ*Lv+T‡´ozbRÅ‡ð9=„œôTÝ-4â„ø¡º}‡â‘ñ^kô.ºÕÓB¤a²àÂË!ž¥–Ïåø]*ˆ ÃÙcêÙµË\"\"‘6ÆÜ±­>Ç÷>fÛÕÕ÷Î9”¼!ƒ/€Œ¾C‘³`.ÕÐ^\r2á4rƒ y¦èªÖì¦‹¸P±M˜Šþ<‰/Ÿ|“¿‚EcÆ`íÌi8°f-òwDAl*\nÒráÊÍ79+¶AŸ+*â½K.Å¨ž­\\y?Ö_¨qÖ 0²g.ÀÊG_A«îÀŽ¥Ë-^zä¦vj±²Ø«w‚á·þoÝþ\'ÄïÙ¥Œ¦s*Bk8&kÒ4¬xòEÔ)_q\"‚z+SKhÛtÆÒë°MX†Tyþìùb6ÜáÐ•\'%åfšA˜Hƒ`si)ŽîêÇdÜQiõ~îÄD$~ø¾ýãø¶žã!¨ywJc?\nj¯ŽœuZrTâ€­ä1Êê˜]1¼IüÐ 	#dˆKFëKà¤bYÓg!yÒDJ‰‹ÂäRD4r’xÅ·\náÄ zõ1íl}gA.‚3—cÚ“oá“‡Ÿ„+?Ï˜,Å–½bXÏÊ 1~.]ow€cþÌÄÖük+ÜŠÆ—–ÁŠQc˜’ÀŒÊkžÝÿü©s±á‘×ÑìÆ;°qUäÝhÏ°UÓ¡lÿü[¼ú›+ÐÕ^&¢\nkð¯ìªX\'–x&Ñ“x²2j–«€·\Z^>º­a¯,Z2¦/Äœ;þ…E¼íÊ_‡ØY³\riMRð˜¯ÚôžEn’;vÇä›FóGŸ@vZ²j(46dÐ9µÞ—ˆŒ÷Ûbàµ÷ Om\Z\Z&ÅkQ’v™Vd57¤v+«¢¢Â\n4¶ÎÊMG¦6­^‚~ï½‡ñŸ¶b„³Uñç\ZJžA ¤­]:;»#ó:*&¦Á³k†ƒ”.\'¾9s°ê­÷Q£ìõˆÝ¼Í˜èìžLŒ´}yÀq…õ}Ðâ4sJMÅòÇ_Á¸r÷âÕKÊ`ÍÌYV¾\\~å/˜<ÞÛ`N¥×ppáºá‰Ç$\0ëwâàðqh}ÿÃx†eá¨qÌ £ÛmuP™©¥ÚÆÂè©ØôxÔ(W;×¯·zäè\rÒ°¾QA¤¤bás¯cT¹;ññoË¡gýiÙ1²›íuËCÈÏER‡n˜|ÓÃhüÀ?‘™’h´/jd‡D#×Xd6í€ýoÔ·­ßr´ô|ëNÄì‚gÏNäoÞÌµ›¿÷ åqf*ôCÚ)\\°àðXm\rx=X0}:U­†¸qSILé ©>÷P\r%-«Z~Ž¼5ëxíLGÉoAÍÂJèÏ¦‹¥G{~l6õËß‚ÿæ·˜øÝ÷B•÷Û~´}·[ÂRç¦@OÌ~4¹ãÜñË_ Î«Uà¢¯‘´%ò°î‹Îè]æ24ýí¯ñì¯ª]ŽÚ—ßˆºÿ{†~õÒökˆ ×§Õ“Óè„ôÄB´Q/#º°VŸ+[´Ç;ÿóüßo.Â–ÅKmŽ!‹•Øœ…b2{\ZâuczÓ¶xêWÿƒnº;×ir”î;½Yš“ƒ.?Êýoüù$§%9^hB|5{?xš±hz–¹/ÿ>¼äøà’‹Ñþ²1øÆ¿á‡›îÇg¿/‡\'õ|óÊ[#expVF8ïzžUA4 Ñ_tÃcDsÑX÷­6jx¢r/¯ÊJcZ\rIÔveÕ}5Ýáœ`\\4ØA±š9:<7ãÜVyÑ9€a+¯±†ÇÞ\'_ô–«ÊKIIÆ´^½ÐöÙç·o/ï²å¤õ‰J9Pò&ù§•3ûAr¯Œ +ÙŠõê‰ä–Û›aü³Ú„4à¥Øê_)âpS-È`}\ZÞC…<)û®‰%_éñÉpeå:’&	Ö¿”JèsÀçÉ§NÓÇ ²;ùÔd¦w1Ýª+”Tå¥`2òèUêßM\r!µH+}ŽN¯‘ŒŠ¨	DûÎélßyðy\Z—€ ›âªò¬):aYôÈBzuZ@÷½ôÐè=èkVÙR	9q²MbY—Ê\nqXâ÷äÂãËƒ‹m)på³½ÙÈJJAbü!$¥§±8–\'üe]T-«DhaUGÛf¸DºÍ [\"Å’w¡&)¯\\Ý×A?Êoc8^ˆ>ŒTzU§ôjè%¥ àäS:/,\'‚‹á)ÍŠd\Zë—,#Ã	@<ÑÛª¢×Ê+Ð»F]Lù´Éc¹ZÅIxŽ¡D\Z)¿ÿ`64þ\nyÛvñZ* 8ü’}¶‹³²Þj”#é›¶XŠR¥^Ô‚”&’ö§@y´‹±õ¾,Ç¶h7©;º4Ác™Á •+$^;$Qºåîë}I…4šÖŠ0’HÈÕwiS–¤ëLhXSàFØCÌKE8.®õ›‘¸a‡	n¸¨ÙZµÕQ\0õŸN¯¦Ñ’^I·o=zóàON„{ß>†5Q±L‘™Hû;Ø›ªÂ‘ù\r\'áÉ`Ii4PyÙ%Å!th/BÙé,Ó¦1\"µ‹¡amSˆtCJnïH0h\r…êc¹zéK›ÂzI+Íì˜Â ,V˜’‰>j‡>¯•ŸÚD6DùRÇã4œ!R!\Zì‰êÛm\r£\'NF&UŽ‚ŠSzÒâ1cÐ@|J¯+sã&Æ2àÖÐs%oÈ`)o „Ôq³±ãÓ6ŒË!³ÉÞ’ Ÿ3Ò©â¢A²•…€’J(Š†¢Å	|R\'Ï‡·÷hl®Tkî»©†½•jb×ÞÆ¦Ê5‘ðÃÙãý^¸¨dÙTxõ~‡•GbÌûà>FÍ»çhLxêeüð—bØ¢ÿÿ@Ç2×£úoô¾ÅÓÇ[>Ÿæ:¢eHƒ©a\Z¡P{ùÝ»œµ1u›£ÙïÊ É_ÿ•Yß<ôEz?3nÔ5ÔMê“yú@¬?>Ek×s6Vÿ\0Sî{ãnºÓÖßóvÜõ6\\/–¿Xq³ç³Zçƒ¼¹T>mn#¾G	&\'¾ 3îÉsì;ë_®‡¼€íÿz;›_¬¥•ßÆîÎýàÓ›‰››íÒ9A6Î½d+\nºFrëÞÌ[[žyûž¬…ÔW>DNÃ¯üi;ì®û)6½ò¶Ty{ÞnŒÄwZ ³^Ä¼ô>z^{\'ª_|bæ-\"B4<\ZðÁãƒ‘EÆƒÞÓÚ%³Ñ«Ú[˜Û­—ÝQ®mh#ëòÓÅœ(‘srgåZ…²]Xÿy+$gÄÊážÜËÝ;ëÄ‹TYT©%û:*îTÑQ¾h¹:ºæ/Å¶—ßFË²0¥e[dÇÄbíü¹˜Ð­+úÿçYŒ¨pæV¸×Ö=LÐ*·|ÍAhî”¡BTŽÌfÞšØñh-4»´VŒÁ!A‚ùùxÜ’pÌ®oø§¥Ìêmù¯rÔWZŸMobýìêÒŸÞr7êßû0uüûöîO¯6»å=8n°ˆ¡ƒ<hSà\\Þßy™£§¡÷cÏá­+bL·.ÈŠ·×­…«”Ä’†¡Ï_ÿ†áW]‹Ñlw»k*bÇÔ©T­T•§¢B#?ž]»qèùFèZîNôùà=díÜŒýóç`FR½.F_¶_ÿg¸¢,Ú=ú$\rH†ñJdw¯XŽñÚcvç®˜Öû;Lûa8æN…õÇ`O¿!rçCøø’ËÑò¡bõÔñX:y\"æƒéìÕ\'öí±½{ah÷nHÚ»—RFÕˆ“\0Í7ïŠÝZ¢û•JÉ$ßèyŠt²4\\‘žS(CG(Md8¾\n\'Ä`9?o³Ü+ºjfnE@¥¼ð ´pžË\\qCú[œÎ”ŽÊ—»«7Àô«o°IÇ#F[\ZÓaÒÇ\Zi+6nÆögßÄ‡—^ŽÓœ]žå8©,ƒå“pvœ`DÄÂ’à™0ß<øºÔªO¦8ÇÓR1å·né4ÐAß¿Ô£YC35Aöô«×@µ›nÆŽåÎ.ÑV‡Á<\n†è°)}ýVLýç˜Sþhü‡‹1oÈ@§CËFà–Î»/^ûíÊ”ÃÀMi»œ6ë½Xõ×ª(¡m¬­ðWT½è\"´hY¡ºx[mT›5´’,)Nx“ã±õíú4¶åñUÍZ–ç„ ŒÊÏ£äÖæ#dÄlhÇŠ¬ç!))–üìƒožª‚ÌÕÛ­%¶ØŒ÷(Õ<ŠðçJ¤‡“¬š½¦õÕc5OÌ.¬zµ6	{HÈh¿u`\"¸V¯Ç®j\rðÙ×crç3j¦.f%%öTÞ)³°àáJxü×ÿƒ•3gë.Q)Xšù.4vbÛ‹µP÷ò2Xù–¤Ri~Ü1¸aqÖ·sŒìœûGNDfµ†øìš[°kíFS¢ÇîÎ\\\0H¢9\\(çÃÒÇc4ÓÃ²sò7a6ú=ö,Þÿû}È‹×‹UE<\n¤ šW1E•F±`ß¦­ØúÈóTö:Ô¼þfÄoÓ,<=	@ž£Ç%\"®f#t,{\r†6mA4+œˆœŠQ<Û7aë\rPå¢Kè]ug$IÈ{RX¡\"ó\"*6¼NK@jÓ¯Ð¥\\E´©UÓòœ¨DbÍ3ˆL‰©‰˜=ô;|óäsØ>co1y)6g—Gó¬Î5”@ƒ ¢ê)¾3ó*#+K^°k¶¾ú6{®ÆÌ’@¼3ÞU›°·ú\'øìÊ1¹{HB‰ Ãš?ÁÁlnÑU.+ƒÁí:8Š`“]“‰Î\\‹À½v²Þú]®¿k¦Lv\"Z}xwçÓpÌ£	Kº­¶Œ)v‹‰×ü+8fxýmXß¯?¼yú~&ë‘ÿK¦eJ°mâRJíGþ‚eØV»j°—]<Æñ^ì…«NE!êDÁ¼o>â¿éŽu÷?z—”ÃòqŽ!³íÝe‰˜Å{0ñµ>E\Zï›·t<¢­ÉB{“éAÖ€ñhXîf4~©\n<z#U…è‡A-t>ãw¤Að¦$ ¥ÙWø¶ÜMøü­·”ã„ |ÎUÚ`Î¤cÉ	ñ˜=l:¿ø\ZÖÑÚ?‡i2 ³­&1ˆˆ•ç\ZJ¦‡ –©÷ ÅÔgÙ—‘àBÖÆµXôæpïÖ“Ù^\n{˜\0‚+7á {æO¯¼¿Ó›lÇÜZ.íÛ¶³ê~Œ\Z7ÜŒôAQê¥¼ë!4úÌuÛPðÑWØ÷rmüðÏbáKu‘òn+¨ñ	ßö0šÝð7ì¡’hš³-:Ò@=Œñø‘´j-ºÿß£øöò+9D¹ž¡\"Æýó)ÄÎžO0‡ÑB\'Ö%%`}¡ì¸{Æ´¿=vOU‚/+ÛAD\nË´\'âÝ:f<v¾ø6ÞûÝ5˜7j’ÝÓK\\ÎÌÛ| 	ï|Š¶W_‡þ-ZšòiÉ;r2»°½Ó@ÔºæLèHÏ€·4”1eÓp¥Æ\nŸ£\r‚=yrã6èZö&4×ŽO\'Êç¡XH¤›ç‹\r!1væ÷ï‡oª¼Žµ#&ðVˆ^\n+š \'MŒfü1#\\B\\Þ’gD%2N2N\'‘çTZZùZäÙ¾sjÔFîzº±úöÇj\ZVèQž’‹¬N˜«°ó<kÖcÏÛ¢ùU0i€óMÆìm±ØÿAG¬}¦&z?ûÇ9¢0\\>	–} Ñúnþ©åŽPænÜ}ÿ©aŸ€kûd%ô|¯º½óÚ×«Öõj£í‡p0F.¹sšP3þz²ç¢ðjÖÀ“r»ö@¿¿>‚±t§ç—¿ß\\[k\'·:£®¸Ÿ½avý6Uñoh÷Z5¡nˆh„óòïa~èìîX„êw#}Âdl¨Z¯ÿî*,ž2Ý¹O>Ë¤¨ïÁ$$½Ó_^]¡{X*er\Zvõ\r¼ö>Üö RöÄZ¯ë—7#‡ˆi4¿ R¬Ê‹†X…ÖSe§& ­y{ô¼æ6|òÜŠ<9!e9*Víð°½›6­Çèo;£Ã³Ï#f\ZÛ j˜F^¯ŽÆ ¦×<‚í7©GÃŠ?ÇP\"=“H)¸ˆÆS\r4—î–CèËC€‚·ðÝ&ˆ9†Þ®Ü/Í7D½1½1˜L²¢Î3È_·ûiÚ^u=&÷îcqò~\\kvaÚbTÙ\nèr÷ßµc¯¹½¶+4&É¬fÛMÞ™Ï³nöWªŽ&¿»«¦N±²D%·ýi‚–J¨ÀõãŽçÅ ú‘–öÌ=Àšd(hÝk¶aÕýOÚjÊ§¯ø-önÝæðIU§%!áƒfXtÏS¨wÓíØ¼|™Åk×+3ÐæR3hÂÍVIEƒ0äoV2Ü#¦`ä#•QëÖ»a»M9íRá‘AÈ¨ý)>/_½>mâxHTøPbU®ŽqånEûknÄö©Ó-›÷Ôíb­-äLqÙgaY2Ã£yÍÛ¢ßuÿ‹æÏ<«È“ƒn*&%7KçÍÂðº0¸úÈ;Àò‹¬³(áPB\r‚†êíL ˜Eu“‹¹¢|Æûµ¨„DÞÓw$–5üþä8Ê»ù®Z‰Ç\"$ì:žoàY½q5?B›r7brÏžç×<À1tj\n–Wzk*Ü^W”Ã†!Z>MsÉ†JæÕ#Ê(:ÊFþÖíØVùmÔ¿ìr,™5ÍD’Î*ÿx_ŠÎ°EèTäÔ9a„”YÍ.½*“×‚~£0òžGQé²Ë¼]ÉÒ©NÒ÷±·â#èUæ\Zt©[ƒ=4ÇïDNe8yŽû®©ÂÎ¥˜ðsÀ³n–}ØÕþPK‡Žb¬óY9ë<…Úk3±^3´-\rz}ò‰ívmHØ`ÜÍ:bÍµ·bÄUå1¡ÁÇðjõ$o«\"Õ¥i	‡Œß‘å6mƒïn¸MŸ¦\'v2 ²˜_mÛ·3õEßÿTÆš¾ðäÛ<‚æYÎY,qÁ¡¯œ¹ˆË¯qS2® Æ“ÎçÅ¼pïÞƒyÕ?Â¾^ÊKá-ö}ì²9¦–‚œoàY³I5?Á×åoÂÈnújA4Ð6îxõ6›6ÇÂ?ÞŽWÜˆA¯Ô„7>Õ¤\\&µ¢\\cwÝ>¤Viˆvô6ÖNŒ<v¤ç¥àèujéA@Þ•ÖàÊµŽ¬üèá¢yL/zzµ	KvÂwbY&xþ7e0c¸ói}eópì¯ô¡¼\\lz«!_s7†_u†=ý2òwïUI,Ãoo:ê[Ì£&é«wÆ¨L7\\Ë×cTø÷o/Çœï‡¿µBR,w°r~Ý‘Z·)º•½=>`/Ì4Æky	4`\"×F`Jù;0£ü­øæ®û¹c—Éž\\É<Øöw¬@4ˆ\ZJ\"RZ´ÃÀŠAã?	}Nðh8Ö|UfNV,œ‡¡õ£ÿoÀ»‹¥{È¹T§MÜF—p(±sâ½’õzŽyaçÒ™ÌâO€ž\'qsç`lw‘¨ÇkZÙ¨‹	Ï3ð-X…Ï¼…OÊ\\aÚYœ„]J¡FÛ· é\r%žˆ‘åÿ‚Ö¿/O×ýJÌ\ZÍñ¼ßC}¦˜Gä/kÕZäVûÛ~óßú\0{»\rAöàQðL‡¼1Ócf~Þ	ûçÓµ\'½<!8 #½¥‰ì—“Þ³‹W!ŽwÈ^ÆS¿û-š¼ö\Z2“SŒAÁ|\n½—¢çàbohöÄÀ¶Þßá;ºíC®¼Ãh<P	‡:õoÕ&éòRÒá9py¶ mìdŒ®ò&*_r	ZU®‚ìøx\Z)âÁ¶JÁjñÒÁ»\'±ÏÖB£?”AÛwj’~«×†L#‡Š¶ÙvbÜ¡o™+Pù¢ÿ‡!}ºÑE}\ZXõ1ŽA`¹ÉñØR»º—»ï=ð0òó]Îc€Œ‚ÇMã¼~-FõøŸ?]	ÛGsX¦w=X¶>ïoË½åÚÏ\"K8”À!ÃÉ3^v¬µ=U×#?{‡ÇÄ\Zµ‘·n‚¾›|±+\nxéSh.sÊm•‚™¬•0F­;¯—)‡¿ÿ¿_¢oËÖ¶NÓœÉBû1!#aÓTùß¿£Î/ qï{×ÂÇ.I/bI+6ŽƒW/¹Ïÿú\"<ý›_á¥K.Fß•AÃËÊ¡ö¥Wáñß\\„{~ùKŒïü­J6Ã«¡¾õ€</4i‹:enÄå+¢SõšØ:w>|®ÜB\Zâ#…²çÔf¨a—q+6áû÷šàÝ\n·¢îÅ¿A³ß]ŽÖ—•G«+®GË¯ÆËW\\–¯VÅŠ™Sá÷_‹BüæxîšŠøë//BÓ*Õr;¦ÀM$l@\\4Ë¯áŽ7#u/ßý\0âÖo—Ë€iÆŸ­vÖy³ïªßúÜûË_áûB¾íý õ\"5Ldå©‡†yûÎ­˜9°?:?_Ú}‹`&q§1°á˜ÔéÄ’/å-arv<8o\r‚¨.…ÖB01Jž²Ã^d†Ýðsè°©MÌzÿdÅn£aÈ&³Üä9#Æˆc‘ü:-Q`3^’ fÉØ|¸ƒ;okSÕºñZo«´Øˆ\0¯óØûéc-^ºï^\Z½*^æÑù5•Ioªc¼­\'à½ —ÞFA>ë°)z¦%]Crƒé?hè¢²#ør:‰Rý=\nøìSyòðtG+øl_I½lžèŽVhÜuþS ão_ÇŽÒˆÈú‰¿³®€…D&£å)éq‹¤¡á]¶Ï¾žÄxûL»<–¡AƒÌ‰†¨öÔJ´‘‹EÐì¿¼=ÑQ‹Ý6ÅŠÅœqcÐ¯z=¨ZÙ	‡œ:ÕóÐË’\'¯@%(ðŽ…óÎ[ƒ vJ,4kFA\'&Æ>23å ô1ÆP÷nKÂMfë;„¶…¹zZ‡÷%Ô”¨çbøE%*‚ªäUmW\rÌª97mâtÉ<Ñ²¤vƒ:7Cê\\28Àî1¨lÛ®GGôò\\kë÷D*Då)\rƒÒ*ŸEéGåñ†’ª§ÿuâ•UçŠÓ£MC]í´F+ÑOƒ’DÍ‹ý°á%…v|(UÊ Ã¦2	¦ãÎÖïÔcû9yœT%ˆà-ü$_Òõ<\Z”m»·`ê˜Áø¾æ»RéudmÙÉä¬—uéÛŒVT¤l‡y<¢ô)¬£„Ãyj°Á\"+¾Ë¨/3SÅ$$Îpåau›o1áµÚØ³xr²“#ã<	|	ƒ¨@^«M\n:èhit¡˜DÓDƒ¥‘í(‹õÆr•M¡$õR\n¥“ÔŠp,\\†F«ým?\n…å¹VrD?™\n§\rnªÜ¨6ZBFJÃ¤Ä¬K¸èO¸>Ês\"ˆVZ\'ðGeØ\r†è©îE!š6rÏhY4\nu™\'Yi©X»d.Fuùß¼ø\ZÆ½÷)¼è°aòTœWá<Ñªý9”Q8_à¼5fèÏI ¢ò¦hH.Ä7¯5)i[“ËÞûó7e&¾Z³;vkó6û2‘z1Yz¹­êéŒ}*K³ïš›`¡Žèþ‹ôÅ‘t‘c1€SºÔKBçŒ‰Õ+^õ¹H}:DÛ®sA4.jOÔË©vƒAíM¢‚lçVƒzVy­zÇ„‡ëˆ¡ T:±Ê˜—ttÔàp:U+P2á¥¯å×O$DOOJ£ü*\'Zžå“vj—îYýJADm\Z==mÐ¹²Jf„³ËïF½%ãF¡_ízèøŸ*Ø5u6cú3fÀŠ«ŸÂò£m—iŒ¤ˆ&>àüC8)p”Ë™:r¥e£\Z+RS±°Gwôxñ¬íÝÙ{wÁ]MÃ ÔŽ0ŽT¡&øÑ x\'Dd¡J\nˆ!²d¸X$>jºR2 6\Zsm“ª-;—Ï}ñ°pÖtŒüª=¾ú÷³˜Þ¦)ÉNZ[\ZNC(8Y¹Qþ_HpÁõWN@Á ó<Tf=¯wVÍÉDøáŠ;ˆÅŸµÇÈJ¯aå þ8xp+\n<¹æ9È\"Hÿ­·ó%\r²\n<WTÑ7KáÜƒÃ“¨1gÏ\"A<”ap‘÷Àâ¹30ò›öè^éEŒ¯U60=\0=u”½‘©§>µ£”Š2nëÇN.¸°\r‚	9v4ã¢×ºE› UtÚG¾DöÚ\r˜óaŒ}¥&Ö~ÿöíY´¼òmA6ìÐ:	[a‘ŒwÆ¯¥P@|q¼BuzpÈ#y”ŸŸ½Û¶bñ¤ÉÚöt~ó]xçCìž1‹Cs¹).^òXÃŠÃ¢cbT$ò]pÄÅù´AÒª§°¡‚±R1Nç á„êµZÏ¯ÇazŽoOžyß‡ŒmÛ0³åèWõuÌnóöÏžœýûPŸgÛrÙ,4ƒY•RƒP¢@\\örÜŸšÍË—bæÀïÑï“Ñ¡jUŒoÑ‰úN~.è…ßãÏ«…Y4	‘ùUóLá\"Päô‚€|Èpºa·”=/±sæcØ¡û«Õ0åóÖˆ;1;áÍÍ²¹‡¨ ÙØÕK‘ä¿²FÝT\r[¢aXgÚ‰A‰\nÃ…&b?Ø~3ß\" èÇk{	‚C<^ê¡ˆw\Zp}R]n¼\\x{„ÌxŸ×¤¤Tl\\»óF\rÂà–MÑî…Êø¾zl5áz!½\"îƒ‹A]Â1á¿˜¥á$@g«\0é	øBRi\n’Ç+ÖbÐÇ-Ðê©—Ð»ÁÇX2avo]‹¤ôƒÈödRä\"Ó’zÊAïC›bÈ˜¼‘}+N÷Ž#¢ÿ \ZÈPŠ$¢…#k»w­ž´ùÕlf§¾\0ÒÓÒ±{ûV,5zwEÿßG»ÇžÀwU«có˜ÉgÛÖªä›—CB¹¡Ç„¬AFFîÀ3±¥á$ÀžZF”Wç( Îs÷ˆ\ZSàòöïÁâžýðÝ«µðíÓU0ìã&˜?t6¯X‚C{w\"-\'Y¡{±F‹}ì»¦aW,[Ïèm‘ËÑvEÛvÄöi[ dn\0ƒè!…%\\ž\\$$Ä¦\r«0gú8ŒèÑÞÿ\0]ý^ªŽ9»!mó*ºV£+aÑWœa*[ü]Y¾ŠŒ¬a³óR8J\rÂ	€âd‰zfm.?#ô€B.¬	\Z…LÏ§m©Š¾9Àñ(ô²f¨<¶e×Œ¹Ó¼5¼Tƒþ]“>l‚Ù}ûbõŠØ³±©UŸ^Ó\rÊ*8PTY.8Â\0Ø/É\"??))	Ø³w–¯žƒ™ÓFa\\Ïo1¼Act{æ|û\\U|Wÿl7¹»w“ÆùÌ)µ§ë¯ØŠÞZÆMC”ÑvŒMVŸ~,ð\'Š@)B©A8) 8ÉØ¿0&Úñ0PÈu‹AêìÌ0ÎîÊ¡µmòwðÀu0§ÍÃ’Ž=1à­ºhý\\t¬Qý5Æ´n=°lìhlX<[·­Å¾„$f\'\"³ ?A.J¡`\" Sáx¬`ud¾Eƒƒé‘qJW˜W!’?z­c!ÁCÐkê9Á¤º2Ÿ²1»7cãòEX9u\r‚©;aHƒFø¦òëøê…WÐõ­Ú˜öU\'l3¹Ûv#˜“Ã’„i§ÍwåU©lÖá„0\nÇ°˜ÂHÊ¢ \\ÙH‹ˆ†R8\ZJ\rÂÙÉ 4(r°urö!\n;{9h3Ð¼läˆÅž…‹±ù»ìè€J¯£÷S¯¢Ç‹¯£O:ðÙgÞ£+&ˆ™cGbéìiX»t¶®_‰Ø›°/v;âö\"+5	ùY4\",Ó“ŸAžmÚ`=/ƒ<?½\Z½l\r>]³×õyô¸-OÞZ›¬º³“‘›ôÄýH:ƒý»·`÷æ5Ø¸j1ÏŠY“Ç`òƒ0¶wwŒïø5F5nŽÕë ß‹o¢÷³UÑõùªþÁ\'XÖ»¶Ïžìý».È Aôi;yW$’zzˆ§Ñ…@¥z|Æ¡Ô œe0y.\"ØzûÎK×BûçëHODo\nz5“NuÐ<…£ê#é.ëÝýœƒ{‘±mbfÌÀ¬.Ý0¢ÉgZ¯!FÖªAUkRùª ÃÏ¢ý“•ÐåÙ—Ð÷•jøFM{»6†×¬ƒAïÔEßwßCß: oÝÐ¯n}ô«÷¡û0®Ï»ïcà;õ0¬:=——_C÷ÿ<Î,ëëÇŸ²óï_}#j²,æÒ°1¦~ó\r¶NŸ‚ô˜mÈ<‹œÔC4:šØcmKÀÕ\Zíòdó\'ìÑénØKHÅ£^¿ÖD®Z¬Ee¥áìA©A8‹ Á–3k2­EDõ]q–†G›cd8ìžËÖ‚MÄ1Paìý…H\n\'•3Õ©3\'NÇhˆ¦Ó¹@Ç¢ŠæBÑ¼GÖis61Èè¢Eé–LB4D‡&\nÑ8%-Šá±j?ò¢ŠJ\rÂÙ„\"Ò®ƒ³šN\"—™l}œ-r’)0•4IJ SM8©£ô\n…L[8i§£Å1Å‚ÏŸÂ²-(>Àûš55KäÜW%Õ¥ì®‹‚®#Isþ:Áy—ÄLÛsD³XÅ)¢Ð4èf‘‚Š†#OKáA©A(…R(…B(5¥P\n¥P¥¡J¡\n¡Ô ”B)”B!”\Z„R(…Rˆ\0ðÿÍ\Z¦ï:\0\0\0\0IEND®B`‚');

/*Table structure for table `ca_guest_info` */

DROP TABLE IF EXISTS `ca_guest_info`;

CREATE TABLE `ca_guest_info` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `salutation` int(11) NOT NULL DEFAULT '0',
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `address` text,
  `email` varchar(100) DEFAULT NULL,
  `landline` varchar(25) DEFAULT NULL,
  `fax` varchar(25) DEFAULT NULL,
  `mobile` varchar(50) DEFAULT NULL,
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `ca_guest_info` */

insert  into `ca_guest_info`(`id`,`salutation`,`lastname`,`firstname`,`middlename`,`address`,`email`,`landline`,`fax`,`mobile`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,0,'Villa-Abrille','Daryll','A','Rodriguez Rizal','hvill@gmail.com','0000000',NULL,'00000000000','2017-05-22 19:35:40',1,'2017-05-22 19:35:40',0),(2,0,'Dela Cruz','Romel','S','Marikina City','','026248754',NULL,'09276010064','2017-05-28 04:47:31',1,'2017-05-28 04:47:31',0),(3,0,'Luna','Juan','D','Makati City','samples@samples.com','0000000',NULL,'0000000000','2017-09-06 20:02:13',1,'2017-09-06 20:02:13',0),(4,0,'Rizal','Jose','Protacio','Calamba, Laguna','sample@sample.com','0000000',NULL,'00000000000','2017-09-07 02:22:05',1,'2017-09-07 02:22:05',0),(5,0,'Luna','Juan','Daquila','xxx','jdl@sampleemail.com','0000000',NULL,'00000000000','2017-09-10 11:27:36',1,'2017-09-10 11:27:36',0),(6,1,'Arellano','Glaiza','Endriga','M.Cruz Street, Sta.Elena, Marikina','sample@sample.com','0000000',NULL,'00000000000','2017-09-11 21:16:48',1,'2017-09-11 21:16:48',0),(7,0,'Quezon','Manuel','Luis','Quezon City','mlq@philippines.gov','0000000',NULL,'00000000000','2017-09-12 10:17:05',1,'2017-09-12 10:17:05',0);

/*Table structure for table `ca_guest_rates` */

DROP TABLE IF EXISTS `ca_guest_rates`;

CREATE TABLE `ca_guest_rates` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `gtype` varchar(25) NOT NULL DEFAULT 'xxx',
  `dayrate` double(10,2) NOT NULL DEFAULT '0.00',
  `dfrom` time DEFAULT NULL,
  `dto` time DEFAULT NULL,
  `nightrate` double(10,2) NOT NULL DEFAULT '0.00',
  `nfrom` time DEFAULT NULL,
  `nto` time DEFAULT NULL,
  `daynightrate` double(10,2) NOT NULL DEFAULT '0.00',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `ca_guest_rates` */

insert  into `ca_guest_rates`(`id`,`gtype`,`dayrate`,`dfrom`,`dto`,`nightrate`,`nfrom`,`nto`,`daynightrate`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,'Adult',200.00,'05:00:01','17:00:00',250.00,'17:00:01','05:00:00',0.00,0,'2017-02-16 20:59:25',1,'2017-05-19 13:20:43'),(2,'Children 4ft and above',100.00,'05:00:01','17:00:00',100.00,'17:00:01','05:00:00',0.00,0,'2017-02-16 20:59:25',1,'2017-05-19 13:20:43'),(3,'Children below 4ft',100.00,'05:00:01','17:00:00',50.00,'17:00:01','05:00:00',0.00,0,'2017-02-16 20:59:25',1,'2017-05-19 13:20:44');

/*Table structure for table `ca_inv_audit` */

DROP TABLE IF EXISTS `ca_inv_audit`;

CREATE TABLE `ca_inv_audit` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `begcount` bigint(20) NOT NULL DEFAULT '1',
  `endcount` bigint(20) NOT NULL DEFAULT '1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`itemid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_inv_audit` */

/*Table structure for table `ca_invaudit` */

DROP TABLE IF EXISTS `ca_invaudit`;

CREATE TABLE `ca_invaudit` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `qty` int(11) NOT NULL DEFAULT '1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`itemid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_invaudit` */

/*Table structure for table `ca_invitems` */

DROP TABLE IF EXISTS `ca_invitems`;

CREATE TABLE `ca_invitems` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `typeid` bigint(20) NOT NULL DEFAULT '0',
  `itemcode` varchar(25) NOT NULL DEFAULT 'xxx',
  `itemdesc` varchar(150) NOT NULL DEFAULT 'Not Specified',
  `price` double(10,2) NOT NULL DEFAULT '0.00',
  `withdeposit` bit(1) NOT NULL DEFAULT b'0',
  `depositamt` double(10,2) NOT NULL DEFAULT '0.00',
  `itemstat` bit(1) NOT NULL DEFAULT b'1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `modifieddate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`typeid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `ca_invitems` */

insert  into `ca_invitems`(`id`,`typeid`,`itemcode`,`itemdesc`,`price`,`withdeposit`,`depositamt`,`itemstat`,`createdbyid`,`datecreated`,`modifiedbyid`,`modifieddate`) values (1,1,'CO-01','Charcoal 500g pack',25.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(2,2,'NC-Towel 01','Bath Towel',0.00,'\0',0.00,'',0,'2017-02-28 20:18:31',1,'2017-05-06 23:48:37'),(3,1,'CO-03','Royal softdrinks 1.5L',55.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(4,1,'CO-04','Sprite softdrinks 1.5L',55.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(5,1,'CO-05','Piatos Sourcream 300g',45.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(6,1,'CO-06','Piatos Cheese 300g',45.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(7,2,'NC-01','Barbecue Grill small',500.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(8,2,'NC-02','Barbecue Grill large',550.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(9,2,'NC-03','Videoke unit + Song book',1200.00,'\0',0.00,'',0,'2017-02-28 20:18:31',0,'2017-02-28 20:18:31'),(10,2,'NC-Towel-02','Bath Towel',0.00,'\0',0.00,'\0',1,'2017-05-06 23:48:15',1,'2017-05-06 23:58:20');

/*Table structure for table `ca_invitems_in` */

DROP TABLE IF EXISTS `ca_invitems_in`;

CREATE TABLE `ca_invitems_in` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `itype` int(11) NOT NULL DEFAULT '0',
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `qtyin` bigint(20) NOT NULL DEFAULT '0',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `ca_invitems_in` */

/*Table structure for table `ca_invitems_out` */

DROP TABLE IF EXISTS `ca_invitems_out`;

CREATE TABLE `ca_invitems_out` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `itype` int(11) NOT NULL DEFAULT '0',
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `iqty` int(11) NOT NULL DEFAULT '1',
  `iprice` double(10,2) NOT NULL DEFAULT '0.00',
  `isubtotal` double(10,2) NOT NULL DEFAULT '0.00',
  `istatus` bit(1) NOT NULL DEFAULT b'1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodfied` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`bkid`,`itype`,`itemid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `ca_invitems_out` */

insert  into `ca_invitems_out`(`id`,`bkid`,`itype`,`itemid`,`iqty`,`iprice`,`isubtotal`,`istatus`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodfied`) values (1,8,2,9,1,1200.00,1200.00,'',1,'2017-09-11 18:40:50',0,'2017-09-11 18:40:50');

/*Table structure for table `ca_invtypes` */

DROP TABLE IF EXISTS `ca_invtypes`;

CREATE TABLE `ca_invtypes` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `typedesc` varchar(100) DEFAULT NULL,
  `typestat` bit(1) NOT NULL DEFAULT b'1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `ca_invtypes` */

insert  into `ca_invtypes`(`id`,`typedesc`,`typestat`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,'Consumable','',0,'2017-02-28 20:11:02',0,'2017-02-28 20:11:02'),(2,'Non-Consumable','',0,'2017-02-28 20:11:02',0,'2017-02-28 20:11:02'),(3,'Bathroom Utilities ','\0',1,'2017-05-07 01:21:38',0,'2017-05-07 01:21:38');

/*Table structure for table `ca_itemsforrefund` */

DROP TABLE IF EXISTS `ca_itemsforrefund`;

CREATE TABLE `ca_itemsforrefund` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `typeid` bigint(20) NOT NULL DEFAULT '0',
  `itemtypeid` bigint(20) NOT NULL DEFAULT '0',
  `itemname` varchar(200) DEFAULT NULL,
  `refundamt` decimal(10,2) DEFAULT NULL,
  `isrefunded` bit(1) NOT NULL DEFAULT b'0',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodifed` datetime DEFAULT NULL,
  PRIMARY KEY (`id`,`bkid`,`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_itemsforrefund` */

/*Table structure for table `ca_occular_requests` */

DROP TABLE IF EXISTS `ca_occular_requests`;

CREATE TABLE `ca_occular_requests` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `occdate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `lastname` varchar(50) NOT NULL DEFAULT 'Doe',
  `firstname` varchar(50) NOT NULL DEFAULT 'John',
  `middlename` varchar(50) DEFAULT NULL,
  `address` text,
  `contactnos` varchar(100) NOT NULL DEFAULT '0000000',
  `email` varchar(100) NOT NULL DEFAULT 'N/A',
  `estguestcnt` int(11) NOT NULL DEFAULT '1',
  `visitflag` bit(1) NOT NULL DEFAULT b'0',
  `cancelflag` bit(1) NOT NULL DEFAULT b'0',
  `remarks` text,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `ca_occular_requests` */

insert  into `ca_occular_requests`(`id`,`occdate`,`lastname`,`firstname`,`middlename`,`address`,`contactnos`,`email`,`estguestcnt`,`visitflag`,`cancelflag`,`remarks`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,'2017-03-31 09:00:00','Dela Cruz','Romel',NULL,'Marikina City','1234567890 / 1234567','',5,'','\0','This request have been completed and closed automatically.',1,'2017-03-26 22:47:12',1,'2017-03-26 22:58:55'),(2,'2017-03-26 23:00:00','Dela Rosa','Ronald',NULL,'Davao','123123123','isumbongmokaybato@pnp.ph',3,'\0','','This request has been cancelled.',1,'2017-03-26 23:01:42',1,'2017-03-26 23:04:42'),(3,'2017-03-31 10:00:00','Dela Cruz','Juana',NULL,'Quezon City','12345678980/122334','',2,'','\0','This request have been completed and closed automatically.',1,'2017-03-30 12:32:20',1,'2017-03-30 12:32:40');

/*Table structure for table `ca_pass_logs` */

DROP TABLE IF EXISTS `ca_pass_logs`;

CREATE TABLE `ca_pass_logs` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `bcid` varchar(25) NOT NULL DEFAULT '0000000',
  `logtype` int(11) NOT NULL DEFAULT '0',
  `logdatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;

/*Data for the table `ca_pass_logs` */

insert  into `ca_pass_logs`(`id`,`bkid`,`bcid`,`logtype`,`logdatetime`) values (1,3,'0000001',0,'2017-06-08 20:15:26'),(2,3,'0000002',1,'2017-06-08 20:18:30'),(3,4,'0000004',0,'2017-06-11 18:13:44'),(4,4,'0000003',0,'2017-06-11 18:16:48'),(5,0,'0000001',0,'2017-09-11 09:52:15'),(6,0,'0000001',0,'2017-09-11 09:52:15'),(7,0,'0000001',0,'2017-09-11 09:52:16'),(8,0,'0000001',0,'2017-09-11 09:52:17'),(9,0,'0000001',0,'2017-09-11 09:52:18'),(10,0,'0000001',0,'2017-09-11 09:52:19'),(11,0,'0000001',0,'2017-09-11 09:52:20'),(12,0,'0000001',0,'2017-09-11 09:52:21'),(13,0,'0000001',0,'2017-09-11 09:52:22'),(14,0,'0000001',0,'2017-09-11 09:52:23'),(15,0,'0000001',0,'2017-09-11 09:52:24'),(16,0,'0000001',0,'2017-09-11 09:52:25'),(17,0,'0000001',0,'2017-09-11 10:00:35'),(18,0,'0000001',0,'2017-09-11 10:00:36'),(19,0,'0000001',0,'2017-09-11 10:00:37'),(20,0,'0000001',0,'2017-09-11 10:00:38'),(21,0,'0000001',0,'2017-09-11 10:00:39'),(22,0,'0000001',0,'2017-09-11 10:00:40'),(23,0,'0000001',0,'2017-09-11 10:00:41'),(24,0,'0000001',0,'2017-09-11 10:00:42'),(25,0,'0000001',0,'2017-09-11 10:00:43'),(26,0,'0000001',0,'2017-09-11 10:07:12'),(27,0,'0000001',0,'2017-09-11 10:07:12'),(28,0,'0000001',0,'2017-09-11 10:07:13'),(29,0,'0000001',0,'2017-09-11 10:07:14'),(30,0,'0000001',0,'2017-09-11 10:07:15'),(31,0,'0000001',0,'2017-09-11 10:07:16'),(32,0,'0000001',0,'2017-09-11 10:07:17'),(33,0,'0000001',0,'2017-09-11 10:07:18'),(34,0,'0000001',0,'2017-09-11 10:07:19'),(35,0,'0000001',0,'2017-09-11 10:07:20'),(36,0,'0000001',0,'2017-09-11 10:08:49'),(37,0,'0000001',0,'2017-09-11 10:08:50'),(38,0,'0000001',0,'2017-09-11 10:08:50'),(39,0,'0000001',0,'2017-09-11 10:08:52'),(40,0,'0000001',0,'2017-09-11 10:08:52'),(41,0,'0000001',0,'2017-09-11 10:08:54'),(42,0,'0000001',0,'2017-09-11 10:08:55'),(43,0,'0000001',0,'2017-09-11 10:08:56'),(44,0,'0000001',0,'2017-09-11 10:09:17'),(45,0,'0000001',0,'2017-09-11 10:09:30'),(46,0,'0000001',0,'2017-09-11 10:10:34'),(47,0,'0000001',0,'2017-09-11 10:13:51'),(48,0,'0000001',0,'2017-09-11 10:16:00'),(49,0,'0000001',0,'2017-09-11 10:17:35'),(50,0,'0000001',0,'2017-09-11 10:18:25'),(51,0,'0000001',0,'2017-09-11 10:52:13'),(52,0,'0000001',0,'2017-09-11 10:57:48'),(53,0,'0000001',1,'2017-09-11 11:00:18'),(54,0,'0000001',1,'2017-09-11 11:02:10'),(55,0,'0000001',1,'2017-09-11 11:03:59'),(56,0,'0000001',0,'2017-09-11 11:05:21'),(57,0,'0000001',0,'2017-09-11 12:39:29'),(58,0,'0000001',0,'2017-09-11 12:41:54'),(59,0,'0000001',0,'2017-09-11 12:44:46'),(60,0,'0000001',0,'2017-09-11 12:46:25'),(61,0,'0000001',0,'2017-09-11 12:49:33'),(62,0,'0000001',0,'2017-09-11 12:50:26'),(63,0,'0000001',0,'2017-09-11 12:54:26'),(64,0,'0000001',0,'2017-09-11 12:56:17'),(65,0,'0000001',0,'2017-09-11 13:00:44'),(66,0,'0000001',0,'2017-09-11 13:00:51'),(67,0,'0000001',0,'2017-09-11 18:12:42');

/*Table structure for table `ca_portsettings` */

DROP TABLE IF EXISTS `ca_portsettings`;

CREATE TABLE `ca_portsettings` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `portid` bigint(20) NOT NULL DEFAULT '-1',
  `portname` varchar(50) NOT NULL DEFAULT '',
  `baudid` bigint(20) NOT NULL DEFAULT '0',
  `baudnm` varchar(10) NOT NULL DEFAULT '0',
  `databitid` bigint(20) NOT NULL DEFAULT '0',
  `databitnm` varchar(50) NOT NULL DEFAULT '',
  `stopbitid` bigint(20) NOT NULL DEFAULT '0',
  `stopbitnm` varchar(50) NOT NULL DEFAULT '',
  `parityid` bigint(20) NOT NULL DEFAULT '0',
  `paritynm` varchar(50) NOT NULL DEFAULT '',
  `handshakeid` bigint(20) NOT NULL DEFAULT '0',
  `handshakenm` varchar(50) NOT NULL DEFAULT '',
  `txdelay` bigint(20) NOT NULL DEFAULT '0',
  `txdelaynm` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `ca_portsettings` */

insert  into `ca_portsettings`(`id`,`portid`,`portname`,`baudid`,`baudnm`,`databitid`,`databitnm`,`stopbitid`,`stopbitnm`,`parityid`,`paritynm`,`handshakeid`,`handshakenm`,`txdelay`,`txdelaynm`) values (1,0,'COM1',6,'19200',1,'8 bits',0,'1',1,'Even',1,'XOnXOff',0,'1 second');

/*Table structure for table `ca_queue_served` */

DROP TABLE IF EXISTS `ca_queue_served`;

CREATE TABLE `ca_queue_served` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bid` bigint(20) NOT NULL DEFAULT '0',
  `guestid` bigint(20) NOT NULL DEFAULT '0',
  `message` text,
  `isserved` bit(1) NOT NULL DEFAULT b'0',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`bid`,`guestid`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

/*Data for the table `ca_queue_served` */

insert  into `ca_queue_served`(`id`,`bid`,`guestid`,`message`,`isserved`,`createdbyid`,`datecreated`,`modifiedbyid`,`datemodified`) values (1,1,12,'Prepare : SR-01:Standard Room 01','\0',0,'2017-03-07 21:39:09',0,'2017-03-07 21:39:09'),(2,1,12,'Transfer : From Standard Room 01 to FR-01:Family Room 07','\0',0,'2017-03-07 22:02:44',0,'2017-03-07 22:02:44'),(3,2,8,'Prepare : UM-01:Umbrella 1','\0',0,'2017-03-08 00:27:42',0,'2017-03-08 00:27:42'),(4,3,4,'Prepare : UM-02:Umbrella 2','\0',0,'2017-03-26 10:53:24',0,'2017-03-26 10:53:24'),(5,4,13,'Prepare : GA-03:Gazebo 3','\0',0,'2017-03-26 10:56:01',0,'2017-03-26 10:56:01'),(6,5,9,'Prepare : UM-03:Umbrella 3','\0',1,'2017-03-26 17:34:45',0,'2017-03-26 17:34:45'),(7,4,1,'Guest Sir/Ma\'am Villa-Abrille, Daryll is requesting for 1 Entrance Fee (Adult)','\0',1,'2017-07-19 05:19:02',0,'2017-07-19 05:19:02'),(8,4,1,'Guest Sir/Ma\'am Villa-Abrille, Daryll is requesting for 2 Entrance Fee (Senior Citizen / PWD)','\0',1,'2017-07-19 05:19:02',0,'2017-07-19 05:19:02'),(9,6,3,'Prepare : Umbrella 04 for guest Sir/Ma\'am Luna, Juan','\0',1,'2017-09-06 20:02:13',0,'2017-09-06 20:02:13'),(10,7,4,'Prepare : Umbrella 02 for guest Sir/Ma\'am Rizal, Jose','\0',1,'2017-09-07 02:22:05',0,'2017-09-07 02:22:05'),(11,4,1,'Guest Sir/Ma\'am Villa-Abrille, Daryll is requesting for 1 Transfer Accommodation : Umbrella 03 to Gazebo 2 Balance to pay : 1,000.00','\0',1,'2017-09-09 15:29:35',0,'2017-09-09 15:29:35'),(12,4,1,'Guest Sir/Ma\'am Villa-Abrille, Daryll is requesting for 1 Transfer Accommodation : Gazebo 1 to Gazebo 2 Balance to pay : 0.00','\0',1,'2017-09-09 15:38:48',0,'2017-09-09 15:38:48'),(13,8,5,'Prepare : Umbrella 02 for guest Sir/Ma\'am Luna, Juan','\0',1,'2017-09-10 11:27:36',0,'2017-09-10 11:27:36'),(14,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 02 to Umbrella 14 Balance to pay : 0.00','\0',1,'2017-09-10 11:28:35',0,'2017-09-10 11:28:35'),(15,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 4 Entrance Fee (Adult)','\0',1,'2017-09-10 11:29:20',0,'2017-09-10 11:29:20'),(16,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 14 to Umbrella 06 Balance to pay : 0.00','\0',1,'2017-09-11 18:33:07',0,'2017-09-11 18:33:07'),(17,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 06 to Umbrella 10 Balance to pay : 0.00','\0',1,'2017-09-11 18:33:58',0,'2017-09-11 18:33:58'),(18,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 10 to Umbrella 12 Balance to pay : 0.00','\0',1,'2017-09-11 18:35:17',0,'2017-09-11 18:35:17'),(19,8,5,'Prepare Umbrella 02 for guest Juan Luna','\0',1,'2017-09-11 18:36:14',0,'2017-09-11 18:36:14'),(20,8,5,'Guest JuanLuna is requesting for a room transfer check Umbrella 12 after guest vacates.','\0',1,'2017-09-11 18:36:14',0,'2017-09-11 18:36:14'),(21,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 12 to Umbrella 02 Balance to pay : 0.00','\0',1,'2017-09-11 18:36:14',0,'2017-09-11 18:36:14'),(22,8,5,'Prepare Gazebo 1 for guest Juan Luna','\0',1,'2017-09-11 18:38:28',0,'2017-09-11 18:38:28'),(23,8,5,'Guest JuanLuna is requesting for a room transfer from Umbrella 02 to Gazebo 1 check room after guest vacates.','\0',1,'2017-09-11 18:38:28',0,'2017-09-11 18:38:28'),(24,8,5,'Guest Sir/Ma\'am Luna, Juan is requesting for 1 Transfer Accommodation : Umbrella 02 to Gazebo 1 Balance to pay : 1,000.00','\0',1,'2017-09-11 18:38:28',0,'2017-09-11 18:38:28'),(25,9,6,'Prepare : Umbrella 02 for guest Sir/Ma\'am Arellano, Glaiza','\0',1,'2017-09-11 21:16:48',0,'2017-09-11 21:16:48'),(26,10,6,'Prepare : Umbrella 03 for guest Sir/Ma\'am Arellano, Glaiza','\0',1,'2017-09-11 23:06:22',0,'2017-09-11 23:06:22'),(27,11,7,'Prepare : Gazebo 3 for guest Sir/Ma\'am Quezon, Manuel','\0',1,'2017-09-12 10:17:05',0,'2017-09-12 10:17:05');

/*Table structure for table `ca_reqitems` */

DROP TABLE IF EXISTS `ca_reqitems`;

CREATE TABLE `ca_reqitems` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `itemtype` int(11) NOT NULL DEFAULT '0',
  `itemid` bigint(20) NOT NULL DEFAULT '0',
  `itemdesc` varchar(150) NOT NULL DEFAULT 'xxx',
  `itemqty` int(11) NOT NULL DEFAULT '0',
  `itemamt` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`,`bkid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_reqitems` */

/*Table structure for table `ca_reservation` */

DROP TABLE IF EXISTS `ca_reservation`;

CREATE TABLE `ca_reservation` (
  `id` bigint(20) NOT NULL DEFAULT '0',
  `rsvno` varchar(20) NOT NULL DEFAULT '''0000-00-000000''',
  `guestid` bigint(20) NOT NULL DEFAULT '0',
  `rmtypeid` bigint(20) NOT NULL DEFAULT '0',
  `roomid` bigint(20) NOT NULL DEFAULT '0',
  `rsdate` date NOT NULL,
  `isovernight` bit(1) NOT NULL DEFAULT b'0',
  `estguestcnt` int(11) NOT NULL DEFAULT '1',
  `ispaid` bit(1) NOT NULL DEFAULT b'0',
  `rsvstatus` int(11) NOT NULL DEFAULT '0',
  `remarks` text,
  `downpayment` double(10,2) NOT NULL DEFAULT '0.00',
  `balance` double(10,2) NOT NULL DEFAULT '0.00',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_reservation` */

/*Table structure for table `ca_reservesetting` */

DROP TABLE IF EXISTS `ca_reservesetting`;

CREATE TABLE `ca_reservesetting` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `allowmindp` bit(1) NOT NULL DEFAULT b'1',
  `dpratetype` int(11) NOT NULL DEFAULT '0',
  `dpvalue` decimal(10,2) NOT NULL DEFAULT '0.00',
  `allowresperiod` bit(1) NOT NULL DEFAULT b'1',
  `maxreservedays` int(11) NOT NULL DEFAULT '5',
  `sendresmail` bit(1) NOT NULL DEFAULT b'1',
  `recstatus` bit(1) NOT NULL DEFAULT b'1',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ca_reservesetting` */

/*Table structure for table `ca_room_rates` */

DROP TABLE IF EXISTS `ca_room_rates`;

CREATE TABLE `ca_room_rates` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `rmtypeid` bigint(20) NOT NULL DEFAULT '0',
  `regular` decimal(10,2) NOT NULL DEFAULT '0.00',
  `regtimein` time DEFAULT NULL,
  `regtimeout` time DEFAULT NULL,
  `overnight` decimal(10,2) NOT NULL DEFAULT '0.00',
  `ovntimein` time DEFAULT NULL,
  `ovntimeout` time DEFAULT NULL,
  `daynight` decimal(10,2) NOT NULL DEFAULT '0.00',
  `daynightin` time DEFAULT NULL,
  `daynightout` time DEFAULT NULL,
  `extension` decimal(10,2) NOT NULL DEFAULT '0.00',
  `extratebase` int(11) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`,`rmtypeid`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

/*Data for the table `ca_room_rates` */

insert  into `ca_room_rates`(`id`,`rmtypeid`,`regular`,`regtimein`,`regtimeout`,`overnight`,`ovntimein`,`ovntimeout`,`daynight`,`daynightin`,`daynightout`,`extension`,`extratebase`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,1,'500.00','05:00:01','17:00:00','500.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 18:58:28',1,'2017-05-22 18:58:28',0),(2,2,'1500.00','05:00:01','17:00:00','1500.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 18:59:50',1,'2017-05-22 18:59:50',0),(3,3,'1000.00','05:00:01','17:00:00','1000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:00:54',1,'2017-05-22 19:00:54',0),(4,4,'2000.00','05:00:01','17:00:00','2000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:01:57',1,'2017-05-22 19:01:57',0),(5,5,'1000.00','05:00:01','17:00:00','1000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:02:46',1,'2017-05-22 19:02:46',0),(6,6,'1300.00','05:00:01','17:00:00','1300.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:03:43',1,'2017-05-22 19:03:43',0),(7,7,'1000.00','05:00:01','17:00:00','1000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:06:53',1,'2017-05-22 19:06:53',0),(8,8,'1300.00','05:00:01','17:00:00','1300.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:07:27',1,'2017-05-22 19:07:27',0),(9,9,'1500.00','05:00:01','17:00:00','2000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:08:40',1,'2017-05-22 19:08:40',0),(10,10,'3500.00','05:00:01','17:00:00','3500.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:12:07',1,'2017-05-22 19:12:07',0),(11,11,'3000.00','05:00:01','17:00:00','3500.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:13:09',1,'2017-05-22 19:13:09',0),(12,12,'3600.00','05:00:01','17:00:00','3600.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:13:55',1,'2017-05-22 19:13:55',0),(13,14,'4000.00','05:00:01','17:00:00','4000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:15:15',1,'2017-05-22 19:15:15',0),(14,15,'15000.00','05:00:01','17:00:00','15000.00','17:00:01','05:00:00','0.00','05:00:01','05:00:00','0.00',0,'2017-05-22 19:16:02',1,'2017-05-22 19:16:02',0);

/*Table structure for table `ca_rooms` */

DROP TABLE IF EXISTS `ca_rooms`;

CREATE TABLE `ca_rooms` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `typeid` bigint(20) NOT NULL DEFAULT '0',
  `roomcode` varchar(25) NOT NULL,
  `roomdesc` varchar(100) NOT NULL,
  `capacity` int(11) NOT NULL DEFAULT '1',
  `recstatus` bit(1) NOT NULL DEFAULT b'1',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

/*Data for the table `ca_rooms` */

insert  into `ca_rooms`(`id`,`typeid`,`roomcode`,`roomdesc`,`capacity`,`recstatus`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,1,'UM-01','Umbrella 01',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(2,1,'UM-02','Umbrella 02',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(3,1,'UM-03','Umbrella 03',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(4,1,'UM-04','Umbrella 04',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(5,1,'UM-05','Umbrella 05',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(6,1,'UM-06','Umbrella 06',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(7,1,'UM-07','Umbrella 07',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(8,1,'UM-08','Umbrella 08',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(9,1,'UM-09','Umbrella 09',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(10,1,'UM-10','Umbrella 10',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(11,1,'UM-11','Umbrella 11',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(12,1,'UM-12','Umbrella 12',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(13,1,'UM-13','Umbrella 13',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(14,1,'UM-14','Umbrella 14',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(15,2,'GA-01','Gazebo 1',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(16,2,'GA-02','Gazebo 2',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(17,3,'GA-03','Gazebo 3',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(18,3,'GA-04','Gazebo 4',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(19,3,'GA-05','Gazebo 5',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(20,3,'GA-06','Gazebo 6',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(21,4,'B-G','Big Gazebo',40,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(22,5,'A-01','Cabana A1',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(23,5,'A-02','Cabana A2',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(24,5,'A-03','Cabana A3',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(25,5,'A-04','Cabana A4',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(26,5,'A-05','Cabana A5',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(27,5,'A-06','Cabana A6',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(28,5,'A-07','Cabana A7',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(29,5,'A-08','Cabana A8',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(30,5,'A-09','Cabana A9',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(31,5,'A-11','Cabana A11',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(32,5,'A-12','Cabana A12',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(33,5,'A-13','Cabana A13',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(34,5,'A-14','Cabana A14',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(35,5,'A-15','Cabana A15',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(36,6,'A-10','Cabana A10',25,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(37,6,'A-16','Cabana A16',25,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(38,7,'B-01','Cabana A1',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(39,7,'B-02','Cabana A2',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(40,7,'B-03','Cabana A3',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(41,7,'B-04','Cabana A4',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(42,7,'B-05','Cabana A5',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(43,7,'B-06','Cabana A6',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(44,7,'B-07','Cabana A7',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(45,7,'B-08','Cabana A8',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(46,7,'B-09','Cabana A9',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(47,7,'B-11','Cabana A11',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(48,7,'B-12','Cabana A12',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(49,7,'B-13','Cabana A13',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(50,7,'B-14','Cabana A14',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(51,7,'B-15','Cabana A15',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(52,8,'B-10','Cabana A10',25,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(53,8,'B-16','Cabana A16',25,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(54,9,'Casa-01','Casa 01',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(55,9,'Casa-02','Casa 02',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(56,9,'Casa-03','Casa 03',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(57,9,'Casa-04','Casa 04',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(58,9,'Casa-05','Casa 05',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(59,9,'Casa-06','Casa 06',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(60,9,'Casa-07','Casa 07',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(61,9,'Casa-08','Casa 08',6,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(62,10,'FAM RM-02','Family Room 02',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(63,10,'FAM RM-09','Family Room 09',20,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(64,11,'VI-01','Villa 01',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(65,11,'VI-02','Villa 02',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(66,11,'VI-03','Villa 03',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(67,11,'VI-04','Villa 04',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(68,11,'VI-06','Villa 06',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(69,12,'VI-05','Villa 05 (Open)',10,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(70,13,'COR-01','Conference Room 01',50,'','2017-02-12 02:24:49',0,'2017-05-22 18:54:50',1),(71,14,'FH-01','Function Hall 01',50,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1),(72,15,'PV-01','Pavillion 01',50,'','2017-02-12 02:24:49',0,'2017-05-13 20:04:50',1);

/*Table structure for table `ca_roomtype` */

DROP TABLE IF EXISTS `ca_roomtype`;

CREATE TABLE `ca_roomtype` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `typedesc` varchar(50) DEFAULT NULL,
  `allowdp` bit(1) NOT NULL DEFAULT b'0',
  `dptype` int(1) NOT NULL DEFAULT '0',
  `dpvalue` double NOT NULL DEFAULT '0',
  `recstatus` bit(1) NOT NULL DEFAULT b'1',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Data for the table `ca_roomtype` */

insert  into `ca_roomtype`(`id`,`typedesc`,`allowdp`,`dptype`,`dpvalue`,`recstatus`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,'Umbrella (1-14)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-14 01:22:26',1),(2,'Gazebo (1-2)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:17:58',1),(3,'Gazebo (3-6)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-14 01:23:07',1),(4,'Big Gazebo','\0',0,0,'','2017-05-14 01:26:10',1,'2017-05-14 01:26:10',0),(5,'Cabana (A1-A9, A11-A15)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-14 01:24:17',1),(6,'Cabana (A10, A16)','\0',0,0,'','2017-05-14 01:21:33',1,'2017-05-18 18:33:46',1),(7,'Cabana (B1-B9, B11-B15)','\0',0,0,'','2017-05-18 18:32:29',1,'2017-05-18 18:33:37',1),(8,'Cabana (B10, B16)','\0',0,0,'','2017-05-18 18:33:01',1,'2017-05-18 18:33:01',0),(9,'Casa (1-8)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-17 17:19:12',1),(10,'Family Rooms','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:17:15',1),(11,'Villa (1-6)','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:16:54',1),(12,'Villa 5','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:17:05',1),(13,'Conference Rooms','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:16:42',1),(14,'Function Hall','\0',0,0,'','2017-02-12 02:24:49',0,'2017-05-02 23:16:42',1),(15,'Pavillion','\0',0,0,'','2017-02-12 12:39:53',0,'2017-05-02 23:16:32',1);

/*Table structure for table `ca_serving_board` */

DROP TABLE IF EXISTS `ca_serving_board`;

CREATE TABLE `ca_serving_board` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bkid` bigint(20) NOT NULL DEFAULT '0',
  `served` bit(1) NOT NULL DEFAULT b'0',
  `inqueue` bit(1) NOT NULL DEFAULT b'0',
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`bkid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `ca_serving_board` */

insert  into `ca_serving_board`(`id`,`bkid`,`served`,`inqueue`,`createdbyid`,`datecreated`) values (1,10,'','',1,'2017-09-11 23:06:22'),(2,11,'','',1,'2017-09-12 10:17:05');

/*Table structure for table `ca_user_roles` */

DROP TABLE IF EXISTS `ca_user_roles`;

CREATE TABLE `ca_user_roles` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `roledesc` varchar(150) NOT NULL DEFAULT 'Default Role',
  `allowlogin` bit(1) DEFAULT b'1',
  `allowbilling` bit(1) DEFAULT b'1',
  `allowreserve` bit(1) DEFAULT b'1',
  `allowinventory` bit(1) DEFAULT b'1',
  `allowcashier` bit(1) DEFAULT b'1',
  `allowsettings` bit(1) DEFAULT b'1',
  `rolestat` bit(1) NOT NULL DEFAULT b'1',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `ca_user_roles` */

insert  into `ca_user_roles`(`id`,`roledesc`,`allowlogin`,`allowbilling`,`allowreserve`,`allowinventory`,`allowcashier`,`allowsettings`,`rolestat`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,'CA-Administrator','','','','','','','','2017-02-06 02:53:17',0,'2017-02-06 02:53:17',0),(2,'Receptionists - I','','','','','\0','\0','','0000-00-00 00:00:00',20170430192843,'2017-04-30 19:45:30',1),(3,'Cashiers','','','','','\0','\0','','0000-00-00 00:00:00',20170430193700,'2017-04-30 19:37:00',0),(4,'Resort Staff','','\0','\0','','\0','\0','\0','0000-00-00 00:00:00',20170430193929,'2017-04-30 19:39:29',0),(5,'Resort Staff - I','','\0','\0','','','\0','','0000-00-00 00:00:00',20170501021455,'2017-05-01 02:15:18',1),(6,'Maintenance','','\0','\0','','\0','\0','','2017-09-09 15:40:55',1,'2017-09-09 15:40:55',0);

/*Table structure for table `ca_users` */

DROP TABLE IF EXISTS `ca_users`;

CREATE TABLE `ca_users` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `barcodeid` varchar(25) NOT NULL DEFAULT '0',
  `loginid` varchar(25) NOT NULL,
  `loginpw` text NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `roleid` bigint(20) NOT NULL DEFAULT '0',
  `recstatus` bit(1) NOT NULL DEFAULT b'1',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `createdbyid` bigint(20) NOT NULL DEFAULT '0',
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifiedbyid` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`,`firstname`,`lastname`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `ca_users` */

insert  into `ca_users`(`id`,`barcodeid`,`loginid`,`loginpw`,`lastname`,`firstname`,`middlename`,`roleid`,`recstatus`,`datecreated`,`createdbyid`,`datemodified`,`modifiedbyid`) values (1,'9999999999','ca-admin','ccc1c1812d2258fb841a8e78ff7899a0','Admin','Admininstrator','',1,'','2017-02-06 02:55:36',0,'2017-02-06 02:55:36',0),(2,'8888888888','cashier1','136989baac262ea3f560297aab280c8d','Dela Cruz','Romel','Sena',3,'','0000-00-00 00:00:00',20170501165259,'2017-05-01 17:16:40',1),(3,'7777777777','cashier02','d8d152c285fd4af7bb4cc0dd53c4cc4e','Arellano','Glaiza','E',3,'','0000-00-00 00:00:00',20170614124635,'2017-06-14 12:46:35',0),(4,'6666666666','cashier-daryll','d8d152c285fd4af7bb4cc0dd53c4cc4e','Villa-Abrille','Daryll','A',3,'','0000-00-00 00:00:00',20170618122304,'2017-06-18 12:23:04',0),(5,'0000001','Deluna1','84ef6e969f089d0fd36f2f168888d2e7','De Luna','Michelle','Deogracias',6,'','0000-00-00 00:00:00',20170909154201,'2017-09-09 15:42:27',1);

/*Table structure for table `ci_sessions` */

DROP TABLE IF EXISTS `ci_sessions`;

CREATE TABLE `ci_sessions` (
  `id` varchar(40) NOT NULL,
  `ip_address` varchar(45) NOT NULL,
  `timestamp` int(10) unsigned NOT NULL DEFAULT '0',
  `data` blob NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ci_sessions_timestamp` (`timestamp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ci_sessions` */

insert  into `ci_sessions`(`id`,`ip_address`,`timestamp`,`data`) values ('0d7bdllnjla0prfqv25kk87kk4o4fpks','::1',1490494914,'__ci_last_regenerate|i:1490494602;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('0hqo1j4vlr8i2ip82gcnv3ums7g9boej','::1',1490329736,'__ci_last_regenerate|i:1490329698;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('0ogftae9iqhv68mauqjtgm3hrutf8vl5','::1',1490540682,'__ci_last_regenerate|i:1490540321;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('0qtokdud85fid0d6hn6qgl5sjdbp5t64','::1',1490277622,'__ci_last_regenerate|i:1490276639;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('0vobvrqti8e5e1mq38bqcro7ksepu65s','::1',1491106634,'__ci_last_regenerate|i:1491106423;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('1a53vld5hf87h0kh3o7e8gsnp53mkh1d','::1',1490291755,'__ci_last_regenerate|i:1490291457;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('1qst5l9298n0t3fb1cg3s3nakua290e1','::1',1490857941,'__ci_last_regenerate|i:1490857938;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('22g59p7gthtf0hqv0sa22qd4m810pvej','::1',1490330013,'__ci_last_regenerate|i:1490330011;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('2dh6sqd1p97cmh7b0ivumshfam005uas','::1',1491128770,'__ci_last_regenerate|i:1491128759;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('2ek5n5ukncqtrrcd4mkec88ldvdd8e4d','::1',1490328733,'__ci_last_regenerate|i:1490328569;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('2nup6170i9b1jkmuur9cc3c4921jc66c','::1',1490496358,'__ci_last_regenerate|i:1490495844;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('3odateol0pg1gktf35hcek9ol6ktjbv4','::1',1492786087,'__ci_last_regenerate|i:1492786026;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('44ba1nuqh69hbpv13iqdqvb2m1vqs9df','::1',1490345047,'__ci_last_regenerate|i:1490345045;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4dcu4rbigul62gjq6s50k1tqsumn6jg5','::1',1490342478,'__ci_last_regenerate|i:1490342476;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4edphl2o1lkorof3im4upgp7mdsmdarf','::1',1490336390,'__ci_last_regenerate|i:1490336388;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4ntu5bvebifum2hpl494jft0dho40o9p','::1',1490525828,'__ci_last_regenerate|i:1490524765;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4q0kba9vg0o6eophrdaohjdr9f5ui79p','::1',1491100111,'__ci_last_regenerate|i:1491100092;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4rj0j8dclstokrqvsoqr52gbpjlds6jt','::1',1493035631,'__ci_last_regenerate|i:1493035621;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('4rnkfbmhli9u677ppku1jahub8lf1rsq','::1',1490496965,'__ci_last_regenerate|i:1490496765;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('59kh34q8d5ci85b7tct6h4tdgqnpirmq','192.168.254.101',1492689894,'__ci_last_regenerate|i:1492689894;'),('5d54m4uhvba3ojtl9bn3oeqaido8r02p','::1',1490331984,'__ci_last_regenerate|i:1490331708;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('5e5g2kbcnmfft5eom73beo6mr7ak48bh','::1',1490535535,'__ci_last_regenerate|i:1490535531;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('5gntvbhe32rs01e2s93f19otn0vpduo1','::1',1491804257,'__ci_last_regenerate|i:1491804234;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('5mi0ao57mrj9la907u8nklj2pn648dab','::1',1490257687,'__ci_last_regenerate|i:1490257405;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('62jbtpsf5im09ft71vrqf1t55plpfrg9','::1',1490374569,'__ci_last_regenerate|i:1490374568;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('667lnber02o253eiq9lc8e5so7ko73uf','192.168.254.101',1490494718,'__ci_last_regenerate|i:1490494718;'),('6eljjl15a7bq4rujoum1pvepv82hjl45','::1',1490343710,'__ci_last_regenerate|i:1490343437;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('6huk945odje5h0eic3baoh7hujpkvl34','::1',1490848361,'__ci_last_regenerate|i:1490848275;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('6j1d66p9k1l44q700ksgn9o03biklk4t','::1',1490348620,'__ci_last_regenerate|i:1490348618;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('728fbbo86lbv62ac18cm8lohs7b0a9p7','::1',1490342025,'__ci_last_regenerate|i:1490341922;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('7ia4kbhb01bg7ujmtfufe7efuv8v1ko6','::1',1493164590,'__ci_last_regenerate|i:1493164579;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('80fn70b614t584k53ulef52dful9r4t0','::1',1490278266,'__ci_last_regenerate|i:1490277965;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('8ikqrgvkgbik0tekfrc8f853q9ioqa5q','::1',1490520886,'__ci_last_regenerate|i:1490520859;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('8sd1utmblm0m998j7rm12k2lr66cngs2','::1',1490496373,'__ci_last_regenerate|i:1490496358;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('8uahd2q5rl7v1m5ouqh936emlfibmaba','::1',1493893446,'__ci_last_regenerate|i:1493893446;'),('9a0am71vepbsalvno48dei573pnto5t9','::1',1490507585,'__ci_last_regenerate|i:1490507362;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('9nsci5ihgoh7noeiq9suabphtad4luu7','::1',1490260092,'__ci_last_regenerate|i:1490260024;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('9o3cpjmdkegqiqb9ce74f1g2518fdv5i','::1',1490336832,'__ci_last_regenerate|i:1490336712;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('9vk7nldrevjbsutffaiq1eadj8bo534a','::1',1490858515,'__ci_last_regenerate|i:1490858328;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('a1ur23m02ejkc0em6t8qre92i357jq52','::1',1490540162,'__ci_last_regenerate|i:1490539995;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ac202vi3vs4hbbd676rpovebo1mmrm2l','::1',1490326493,'__ci_last_regenerate|i:1490326492;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('aigm641mg55mv3e875v6eqnkd2e15vgu','::1',1490524404,'__ci_last_regenerate|i:1490524402;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('akddg1e499382spj44qa1tnh101bvpc0','::1',1490327785,'__ci_last_regenerate|i:1490327548;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('bemu87vrq8eo5qulkf83r33rcdru396s','::1',1490258003,'__ci_last_regenerate|i:1490257709;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('bilkh2u24kla7cdqapu7rs3car8pvak9','::1',1490343403,'__ci_last_regenerate|i:1490343106;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('dbcb0b6fghg68aecnpj3nk44bmlvrfj9','::1',1490333029,'__ci_last_regenerate|i:1490332758;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('denrrjquhui61eeniacs3r3tv3k51mn0','::1',1490359600,'__ci_last_regenerate|i:1490359578;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('dfaivkusimsa23v153e2kc8v8omkbcq5','::1',1490361772,'__ci_last_regenerate|i:1490361662;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('dhunmjf1jl528ta6df8eudecfqeo2ech','::1',1490344884,'__ci_last_regenerate|i:1490344652;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('eoak6jgaq8f6kek6j0moi5125sae9a1l','::1',1490396810,'__ci_last_regenerate|i:1490396805;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('esth8rgg1b00o9vr5te911392q0l32ed','::1',1490332073,'__ci_last_regenerate|i:1490332011;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('f4t0pr2gmv2762460sfvbud75jepvn96','::1',1490535509,'__ci_last_regenerate|i:1490535213;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('fh4jiuv06aiqghio4cb2fql00ikau5u2','::1',1490539137,'__ci_last_regenerate|i:1490538873;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('fqvfh36qfebb9pt8dnl020h75ult3akl','::1',1490362434,'__ci_last_regenerate|i:1490362295;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('gfrgv2sbo4qtqu5g8cc8s729pn2cvveg','192.168.254.101',1492684924,'__ci_last_regenerate|i:1492684923;'),('grd599tndesee63nbniollb5g9ku7t1s','::1',1490540722,'__ci_last_regenerate|i:1490540719;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('i6hhmt5h05otlp2a9f112ef5slq5qt3a','::1',1490501562,'__ci_last_regenerate|i:1490501342;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ibnts4sh4rqltgrke1qkhrhasovlqs1v','::1',1490257251,'__ci_last_regenerate|i:1490257054;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ignssgfq22u8tl4ks58n10f4fiq1mno4','::1',1490851534,'__ci_last_regenerate|i:1490851287;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('imlqs5470on6edf93842og06vqg0j8n2','192.168.254.102',1490495560,'__ci_last_regenerate|i:1490495560;'),('iocoq7kuduc55h5ivu5vedh1osj3i6ol','::1',1490327236,'__ci_last_regenerate|i:1490326997;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('is5qlfotk1s6h6uv4lm67li00rcpnvrg','::1',1490328536,'__ci_last_regenerate|i:1490328234;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('j5rmdh6oqgtr8r109nrtlo7rm2p6mn53','::1',1493286609,'__ci_last_regenerate|i:1493286607;'),('jbe2ikauu3llecu0ih9lr186os2ht4ig','::1',1490361294,'__ci_last_regenerate|i:1490360992;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('jfu091fu81sk8c2a7s7udpmccqaunvn8','::1',1490851729,'__ci_last_regenerate|i:1490851726;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('jpftkdpdijegul5f7uqdfuugkdgb6b8s','::1',1490524389,'__ci_last_regenerate|i:1490521317;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('js5mj1r2okqfq8l4v7mas5u3dsbkffb7','::1',1490258170,'__ci_last_regenerate|i:1490258041;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('k21d4v6ebv66836n1rfecs9p7pi5hqks','::1',1490395045,'__ci_last_regenerate|i:1490394926;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('k24a9pb96dvftch8vba829puih8849ga','::1',1493893448,'__ci_last_regenerate|i:1493893446;'),('k9vhgusb924m9f8o1i1c24iokjvo3tie','::1',1491110463,'__ci_last_regenerate|i:1491110439;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('kbdja1n15t0edfo9fpf7gps67cbvanfo','::1',1490372576,'__ci_last_regenerate|i:1490372561;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('kjn9pq04dghooae3lvkn2ss5jbmjo3t1','::1',1490326364,'__ci_last_regenerate|i:1490326065;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ku71v3f4m0r8sin3unggb5etuk36slk5','::1',1490333637,'__ci_last_regenerate|i:1490333529;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('l13j08apl33f979cn29he7sq5gd1mho3','::1',1490277932,'__ci_last_regenerate|i:1490277626;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('l3nrbbop7u5lb39uih27e2fkurd32aau','::1',1491716599,'__ci_last_regenerate|i:1491716598;'),('llut5c1d4qhbiknlu6b0hkk0v6o9kgot','::1',1490360679,'__ci_last_regenerate|i:1490360674;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('lndnktipi4mt10ksrv2s61sb4tii22n5','::1',1493356311,'udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}__ci_last_regenerate|i:1493356310;'),('lo1ler4c80cf8b0fai02o25cg4ttet05','::1',1490349543,'__ci_last_regenerate|i:1490349477;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('lviel8uht8nl7f900m7ao7t32e5lb28p','::1',1490362649,'__ci_last_regenerate|i:1490362628;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('m35ub4fio4a345hfdnfr061e8p9fiqrq','::1',1490375678,'__ci_last_regenerate|i:1490375676;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('n2g4mlk6c0b5os6k5f461dd9ju5palhi','::1',1490347110,'__ci_last_regenerate|i:1490347042;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('n3u41hu0re9ognmd9jkhei6nr9ae2lmm','::1',1490328082,'__ci_last_regenerate|i:1490327884;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('o132kffq6aoq24asia5jf4me895ggvd9','::1',1493286607,'__ci_last_regenerate|i:1493286606;'),('o6vnp7fmomk9c5p0eghfutdi9c9c7fr6','::1',1490502775,'__ci_last_regenerate|i:1490502505;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('omoqbr9shst2s5mvltdft84fb42v3e8d','::1',1490520502,'__ci_last_regenerate|i:1490517419;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('opn0pvduoj92pe13qqknj0s5lmq31m1i','::1',1490330819,'__ci_last_regenerate|i:1490330534;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('oqf7sl742vn5lpp4o1hbgmglhu18gb5k','::1',1490516811,'__ci_last_regenerate|i:1490516498;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('p0h89cv2sqtm7oodc6fkdii3kefl47lq','::1',1490276634,'__ci_last_regenerate|i:1490276324;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('p8vrjquj0k3al5ufea40f7porsk81jjd','::1',1494220516,'__ci_last_regenerate|i:1494220513;'),('pdo2lk1a2r16a3c50lj9aqqdqh34cr66','::1',1490325399,'__ci_last_regenerate|i:1490325282;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('r0c3a3p5ao5km1ifc3g6pqv7klnjur3i','::1',1490959405,'__ci_last_regenerate|i:1490959395;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('r1efhbeaclor3lktej1vlr8jni4v8lkf','::1',1491106004,'__ci_last_regenerate|i:1491105950;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('rekqu6n6qne2ava8j29h609pjb326n63','::1',1490394841,'__ci_last_regenerate|i:1490394609;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('rfq6b6d0c0hmgbh7v7acg7bc993sk2h8','::1',1490337148,'__ci_last_regenerate|i:1490337146;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('rhq9b5rtte5e9bb2dvoeinlpi1clj8d9','::1',1490361642,'__ci_last_regenerate|i:1490361346;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('s3q1v2p8b402gn3d1pftioubl8j4pmc9','::1',1490341822,'__ci_last_regenerate|i:1490341574;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('soa7p5k5do74rnp5u3ehjseahkjvms16','::1',1493356310,'udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}__ci_last_regenerate|i:1493356310;'),('spdmrmtj1p92j9dtqstcosudqlif2ai8','::1',1490343989,'__ci_last_regenerate|i:1490343904;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('tbo9vqfa6vfldjouhi4n93fp8pkgu8fu','::1',1490333405,'__ci_last_regenerate|i:1490333118;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('tcnp2gu0h8tldqj8k1f0lh6bckpniej4','::1',1490278535,'__ci_last_regenerate|i:1490278309;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('tjk6ieqs0blog99briln5hshuprdo2dc','::1',1490329095,'__ci_last_regenerate|i:1490328950;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('u6qed277cr5297ch6058m3ak9qto90k7','::1',1490344535,'__ci_last_regenerate|i:1490344285;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ue5kc3t1qnl5ge70lsq1fsvbq0694b5p','::1',1490337672,'__ci_last_regenerate|i:1490337596;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('ugpuqjmcn818gqhsi6een9rkt96bq79m','::1',1490539936,'__ci_last_regenerate|i:1490539592;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('uu9gd3ti3ljpvtf13q2e80k6bjui5ll7','::1',1490539463,'__ci_last_regenerate|i:1490539236;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('vj1cq9a0g7dgbotsgoj49fp44q2s5gn9','::1',1490333979,'__ci_last_regenerate|i:1490333950;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('vl17tr1dcojhvhbj6fjm5vo0iu803bj4','::1',1490346811,'__ci_last_regenerate|i:1490346688;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}'),('vpu5jisovvf06kkpkn71tj8goc6p8fer','::1',1490494915,'__ci_last_regenerate|i:1490494914;udata|a:1:{i:0;a:10:{s:3:\"uid\";s:1:\"1\";s:3:\"lid\";s:8:\"ca-admin\";s:5:\"lname\";s:5:\"Admin\";s:5:\"fname\";s:14:\"Admininstrator\";s:10:\"allowlogin\";s:1:\"1\";s:12:\"allowbilling\";s:1:\"1\";s:12:\"allowreserve\";s:1:\"1\";s:14:\"allowinventory\";s:1:\"1\";s:12:\"allowcashier\";s:1:\"1\";s:13:\"allowsettings\";s:1:\"1\";}}');

/* Procedure structure for procedure `sp_bookingsummary` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_bookingsummary` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_bookingsummary`(
	df date,
	dt date
)
begin
	select 	a.id as bkid, a.`createdbyid`, concat(e.`firstname`, ' ', e.`lastname`) as cashier,
			c.`typedesc` as acctype, d.`roomdesc` as acc,
			concat(g.`firstname`, ' ', g.`lastname`) as guest,
			case a.`isovernight` when true then 'Night Time' else 'Day Time' end as actime,
			case when a.`bkstat` = true then 'Active' else 'Checked Out' end as bstat,
			ifnull(sum(b.`itemqty`), 0) as qtysold, ifnull(sum(b.`itemamt`),0) as totalitemsales, 
			ifnull(sum(b1.`itemqty`), 0) as qtyguests, ifnull(sum(b1.`itemamt`),0) as totalsalesinguests,
			ifnull(sum(b2.`itemqty`), 0) as qtyacc, ifnull(sum(b2.`itemamt`),0) as totalsalesinacc,
			ifnull(sum(f.`refundamt`), 0) as refund
	from 			`ca_booking` 		as a
		left  join 	`ca_booking_items`	as b on a.`id` = b.`bkid` and b.`itemtype` in (3)
		left  join 	`ca_booking_items`	as b1 on a.`id` = b1.`bkid` and b1.`itemtype` in (2)
		left  join  `ca_booking_items`  as b2 on a.`id` = b2.`bkid` and b2.`itemtype` in (1)
		inner join	`ca_roomtype`		as c on a.`rmtypeid` = c.`id`
		inner join 	`ca_rooms`			as d on a.`roomid` = d.`id`
		inner join 	`ca_users`			as e on a.`createdbyid` = e.`id`
		left  join 	`ca_itemsforrefund` as f on a.`id` = f.`bkid`
		inner join 	`ca_guest_info`		as g on a.`guestid` = g.`id`
	where a.`bkstat` = false
	  and a.`datecreated` between df and dt
	group by a.`id`, a.`roomid`;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_checkout` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_checkout` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_checkout`(
	bid bigint,
	cid bigint
)
begin
	update `ca_booking` 
	set `bkstat` = false, `modifiedbyid` = cid, `datemodified` = now()
	where `id` = bid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_companyprofile` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_companyprofile` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_companyprofile`(
	c1 varchar(100),
	c2 varchar(200),
	c3 varchar(100),
	c4 varchar(20),
	c5 text,
	c6 blob
)
begin
	declare cocnt int;
	
	set cocnt = (select count(`id`) from `ca_company_profile`);
	
	if cocnt = 0 then
		insert into `ca_company_profile` 
			(`coname`, `coaddr`, `conumb`, `cotin`, `coprops`, `cologo`)
		values
			(c1, c2, c3, c4, c5, c6);
	else
		update `ca_company_profile` 
		set `coname` = c1, `coaddr` = c2, `conumb` = c3, `cotin` = c4, `coprops` = c5, `cologo` = c6
		where `id` = 1;
	end if;
		
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getaccommodationfortransfer` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getaccommodationfortransfer` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getaccommodationfortransfer`(
	rtid bigint,
	rid bigint,
	isovn bit
)
begin
	select 	a.`id` as rid,
			a.`roomdesc`,
			case isovn when true then b.`overnight` when false then b.`regular` else 0 end as roomrate
	from 			`ca_rooms` 		as a
		inner join 	`ca_room_rates` as b on a.`typeid` = b.`rmtypeid`
	where a.`id` not in ( select `roomid` from `ca_booking` where `rmtypeid` = rtid and `bkstat` = true )
	  and a.`typeid` = rtid
	  and a.`id` = rid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getaccommodationinfo` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getaccommodationinfo` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getaccommodationinfo`(rid bigint)
begin
	select 	c.`regtimein`, c.`regtimeout`, c.`ovntimein`, c.`ovntimeout`,
			case when curtime() >= c.`regtimein` and curtime() <= c.`regtimeout` then 0
				 when curtime() >= c.`ovntimein` or curtime() <= c.`ovntimeout` then 1
				 else 2
			end as ratebasis,
			case when curtime() >= c.`regtimein` and curtime() <= c.`regtimeout` then c.`regular`
				 when curtime() >= c.`ovntimein` or curtime() <= c.`ovntimeout` then c.`overnight`
				 else `extension`
			end as rate,
			a.`capacity`,
			case when curtime() >= c.`regtimein` and curtime() <= c.`regtimeout` then '1900-01-01 08:00:00'
				 when curtime() >= c.`ovntimein` or curtime() <= c.`ovntimeout` then '1900-01-01 19:00:00'
				 else curtime()
			end as timefrom,
			case when curtime() >= c.`regtimein` and curtime() <= c.`regtimeout` then '1900-01-01 17:00:00'
				 when curtime() >= c.`ovntimein` or curtime() <= c.`ovntimeout` then '1900-01-01 05:00:00'
				 else curtime()
			end as timeto
			/*
			case when curtime() between c.`regtimein` and c.`regtimeout` then concat('1900-01-01 ', c.`regtimein`)
				 when curtime() between c.`ovntimein` and c.`ovntimeout` then concat('1900-01-01 ' ,c.`ovntimein`)
				 else curtime()
			end as timefrom,
			case when curtime() between c.`regtimein` and c.`regtimeout` then concat('1900-01-01 ', c.`regtimeout`)
				 when curtime() between c.`ovntimein` and c.`ovntimeout` then concat('1900-01-01 ',c.`ovntimeout`)
				 else curtime()
			end as timeto
			*/
	from 			`ca_rooms` 		as a
		inner join 	`ca_roomtype` 	as b on a.`typeid` = b.`id`
		inner join 	`ca_room_rates`	as c on b.`id` = c.`rmtypeid`
	where b.`recstatus` = true
	  and a.`id` = rid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getaccommodations` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getaccommodations` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getaccommodations`(rtid bigint)
begin
	select 0 as rid, '- Select Accommodation -' as rdesc
	union all
	select `id` as rid, `roomdesc` as rdesc
	from 			`ca_rooms`
	where `recstatus` = true
	  and `id` not in (select `roomid` from `ca_booking` where `rmtypeid` = rtid and `bkstat` = true)
	  and `typeid` = rtid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getaccommodationtypes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getaccommodationtypes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getaccommodationtypes`()
begin
	select 0 as rtid, '- Select Accommodation Type -' as rtdesc
	union all
	select `id` as rtid, `typedesc` as rtdesc
	from `ca_roomtype`
	where `recstatus` = true;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getactivebookings` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getactivebookings` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getactivebookings`(sp text)
begin
	if length(sp) = 0 then
		/*
		select 	a.`id` as bkid,
				concat(b.`lastname`, ", ", b.`firstname`, case length(trim(both from b.`middlename`)) when 0 then "" else concat(" ", substring(b.`middlename`,1,1),".") end )  as guestname,
				c.`roomdesc` as room,
				f.qty,
				f.bcqty,
				case when count(e.`ispaid`) > 0 then true else false end as unpaid,
				case a.`isovernight` when true then 
					case when curtime() > d.`ovntimeout` then true else false end
				else
					case when curtime() > d.`regtimeout` then true else false end
				end as timeout,
				case 
					when f.`bcqty` < (a.`guesta` + a.`guestc` + a.`guestc2`)
						then (a.`guesta` + a.`guestc` + a.`guestc2`) - f.`bcqty`
					else f.`bcqty` - (a.`guesta` + a.`guestc` + a.`guestc2`)
				end as bctoissue
				
		from 			`ca_booking` 			as a
			inner join 	`ca_guest_info`   	as b on a.`guestid` = b.`id`
			inner join 	`ca_rooms`			as c on a.`roomid` = c.`id`
			inner join  `ca_room_rates`		as d on c.`typeid` = d.`rmtypeid`
			left  join  `ca_booking_items`	as e on a.`id` = e.`bkid` and e.`ispaid` = false
			inner join  (select cbi.`bkid`, sum(cbi.`itemqty`) as qty, ifnull(cbg.qty, 0) as bcqty
						from 			`ca_booking_items` as cbi
							left join	(select bkid, count(bkid) as qty from `ca_booking_guest` group by bkid) as cbg on cbi.`bkid` = cbg.`bkid`
						where cbi.`itemtype` = 2 
						  and cbi.`ispaid` = true
						group by cbi.`bkid`) as f on a.`id` = f.`bkid`
		where a.`bkstat` = true
		group by a.`id`, e.`ispaid`;
		*/
		select 	a.`id` as bkid,
				concat(b.`lastname`, ", ", b.`firstname`, case length(trim(both from b.`middlename`)) when 0 then "" else concat(" ", substring(b.`middlename`,1,1),".") end )  as guestname,
				c.`roomdesc` as room,
				(a.`guesta` + a.`guestc` + a.`guestc2`) as qty,
				ifnull(f.bcqty, 0) as bcqty,
				case when count(e.`ispaid`) > 0 then true else false end as unpaid,
				case a.`isovernight` when true then 
					case when curtime() > d.`ovntimeout` then true else false end
				else
					case when curtime() > d.`regtimeout` then true else false end
				end as timeout,
				ifnull(case 
					when f.`bcqty` < (a.`guesta` + a.`guestc` + a.`guestc2`)
						then (a.`guesta` + a.`guestc` + a.`guestc2`) - f.`bcqty`
					else f.`bcqty` - (a.`guesta` + a.`guestc` + a.`guestc2`)
				end, 0) as bctoissue,
				ifnull(g.`served`, 0) as served,
				ifnull(g.`inqueue`, 0) as inqueue
		from 			`ca_booking` 			as a
			inner join 	`ca_guest_info`   	as b on a.`guestid` = b.`id`
			inner join 	`ca_rooms`			as c on a.`roomid` = c.`id`
			inner join  `ca_room_rates`		as d on c.`typeid` = d.`rmtypeid`
			left  join  `ca_booking_items`	as e on a.`id` = e.`bkid` and e.`ispaid` = false
			left join  (select cbi.`bkid`, sum(cbi.`itemqty`) as qty, ifnull(cbg.qty, 0) as bcqty
						from 			`ca_booking_items` as cbi
							left join	(select bkid, count(bkid) as qty from `ca_booking_guest` group by bkid) as cbg on cbi.`bkid` = cbg.`bkid`
						where cbi.`itemtype` = 2 
						  and cbi.`ispaid` = true
						group by cbi.`bkid`) as f on a.`id` = f.`bkid`
			left join 	`ca_serving_board` as g on a.`id` = g.`bkid`
		where a.`bkstat` = true
		group by a.`id`, e.`ispaid`;
	else
		select 	a.`id` as bkid,
				concat(b.`lastname`, ", ", b.`firstname`, case length(trim(both from b.`middlename`)) when 0 then "" else concat(" ", substring(b.`middlename`,1,1),".") end )  as guestname,
				c.`roomdesc` as room,
				(a.`guesta` + a.`guestc` + a.`guestc2`) as qty,
				ifnull(f.bcqty, 0) as bcqty,
				case when count(e.`ispaid`) > 0 then true else false end as unpaid,
				case a.`isovernight` when true then 
					case when curtime() > d.`ovntimeout` then true else false end
				else
					case when curtime() > d.`regtimeout` then true else false end
				end as timeout,
				ifnull(case 
					when f.`bcqty` < (a.`guesta` + a.`guestc` + a.`guestc2`)
						then (a.`guesta` + a.`guestc` + a.`guestc2`) - f.`bcqty`
					else f.`bcqty` - (a.`guesta` + a.`guestc` + a.`guestc2`)
				end, 0) as bctoissue,
				ifnull(g.`served`, 0) as served,
				ifnull(g.`inqueue`, 0) as inqueue
		from 			`ca_booking` 			as a
			inner join 	`ca_guest_info`   	as b on a.`guestid` = b.`id`
			inner join 	`ca_rooms`			as c on a.`roomid` = c.`id`
			inner join  `ca_room_rates`		as d on c.`typeid` = d.`rmtypeid`
			left  join  `ca_booking_items`	as e on a.`id` = e.`bkid` and e.`ispaid` = false
			left  join  (select cbi.`bkid`, sum(cbi.`itemqty`) as qty, ifnull(cbg.qty, 0) as bcqty
						 from 			`ca_booking_items` as cbi
							 left join	(select bkid, count(bkid) as qty from `ca_booking_guest` group by bkid) as cbg on cbi.`bkid` = cbg.`bkid`
						 where cbi.`itemtype` = 2 
						   and cbi.`ispaid` = true
						 group by cbi.`bkid`) as f on a.`id` = f.`bkid`
			left join 	`ca_serving_board` as g on a.`id` = g.`bkid`
		where a.`bkstat` = true
		  and (b.`lastname` like concat('%', sp, '%')
		   or  b.`firstname` like concat('%', sp, '%')
		   or  c.`roomdesc` like concat('%', sp, '%'))
		group by a.`id`, e.`ispaid`;	
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getbclogs` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getbclogs` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getbclogs`(bc varchar(25))
begin
	
	declare empcnt int;
	declare guestcnt int;
	
	set empcnt = (select count(`id`) from `ca_users` where `barcodeid` = bc);
	set guestcnt = (select count(`id`) from `ca_booking_guest` where `bcid` = bc and now() < `expdate`);
	
	if empcnt > 0 then
		select 0 as bkid, false as entryflag, false as exitflag, '2100-12-31 00:00:00' as expdate;
	else
		select `bkid`, `entryflag`, `exitflag`, `expdate` 
		from `ca_booking_guest` 
		where `bcid` = bc
		  and now() < `expdate`;	
	end if;
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getbookinginfo` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getbookinginfo` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getbookinginfo`(
	bid bigint
)
begin
	select 	a.id as bkid,
			a.`rmtypeid` as rtid,
			a.`roomid` as rid,
			concat(b.`lastname`, ', ', b.`firstname`) as guestname,
			c.`roomdesc` as room,
			case a.`isovernight` 
				when true then 'Night Rate'
				when false then 'Daytime Rate'
				else '--'
			end as ratebase,
			case a.`isovernight`
				when true then d.`overnight`
				when false then d.`regular`
				else 0
			end as roomrate,
			a.`isovernight`,
			(a.`guesta` + a.`guestc` + `guestc2`) as gcount
	from 			`ca_booking` 	as a
		inner join	`ca_guest_info` as b on a.`guestid` = b.`id`
		inner join 	`ca_rooms`		as c on a.`roomid` = c.`id`
		inner join	`ca_room_rates` as d on a.`rmtypeid` = d.`rmtypeid`
	where a.`id` = bid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getcompanyprofile` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getcompanyprofile` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getcompanyprofile`()
begin
	select `id`, `coname`, `coaddr`, `conumb`, `cotin`, `coprops`, `cologo`
	from `ca_company_profile`
	where `id` = 1;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getentryfee` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getentryfee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getentryfee`()
begin
	SELECT	`id` AS rateid,
		`gtype` AS guesttype,
		CASE WHEN CURTIME() <= dto AND CURTIME() >= dfrom THEN 'Daytime Rate'
		     WHEN CURTIME() <= nto OR CURTIME() >= nfrom THEN 'Night Time Rate'
			 ELSE 'Floating Rate'
		END AS appliedrate,
		CASE WHEN CURTIME() <= dto AND CURTIME() >= dfrom THEN `dayrate`
		     WHEN CURTIME() <= nto OR CURTIME() >= nfrom THEN `nightrate`
		     ELSE 0
		END AS rate
	FROM `ca_guest_rates`;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getinventoryreport` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getinventoryreport` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getinventoryreport`(
	pstart datetime,
	pend datetime
)
begin
	
	select 	a.`id` as bkid,
			d.`id` as uid,
			concat(d.`loginid`, ' : ', d.`lastname`, ', ', d.`firstname`) as uname,
			c.`typeid` as itid,
			e.`typedesc` as itdesc,
			c.`id` as iid,
			c.`itemdesc` as idesc,
			b.`iqty` as qty,
			b.`iprice` as ip, 
			b.`isubtotal` as ist
	from 			`ca_booking` 		as a
		inner join 	`ca_invitems_out` 	as b on a.`id` = b.`bkid`
		inner join 	`ca_invitems` 		as c on b.`itemid` = c.`id`
		inner join 	`ca_users`			as d on a.`createdbyid` = d.`id`
		inner join 	`ca_invtypes`		as e on c.`typeid` = e.`id`
	where a.`bkstat`= false
	  and a.`datecreated` between pstart and pend;
		
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getiteminfo` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getiteminfo` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getiteminfo`(
	iid bigint
)
begin
	select `id`, `typeid`, `itemcode`, `itemdesc`, `price`, `withdeposit`, `depositamt`, `itemstat`
	from `ca_invitems`
	where `id` = iid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getitems` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getitems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getitems`(
	itype bigint
)
begin
	select 0 as id, '- Select an Item -' as itemdesc
	union all
	select `id`, `itemdesc`
	from `ca_invitems`
	where `itemstat` = true
	  and `typeid` = itype;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getitemsforpayment` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getitemsforpayment` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getitemsforpayment`(
	bid bigint
)
begin
	select `id`, `bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`
	from `ca_booking_items`
	where `bkid` = bid
	  and `ispaid` = false;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getitemtypes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getitemtypes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getitemtypes`()
begin
	select 0 as id, '- Select an Item Type -' as typedesc
	union all
	select `id`, `typedesc` from `ca_invtypes` where `typestat` = true;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getnextguestonqueue` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getnextguestonqueue` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getnextguestonqueue`()
begin
	select	a.`bkid`, upper(concat(case c.`salutation` 
								when 0 then 'Mr. '
								when 1 then 'Ms. '
								when 2 then 'Mrs. '
								else 'Mr. '
							 end, c.`firstname`, ' ', c.`lastname`)) as guestname 
	from 			`ca_serving_board` 	as a
		inner join 	`ca_booking` 		as b on a.`bkid` = b.`id`
		inner join 	`ca_guest_info` 	as c on b.`guestid` = c.`id`
	where a.`served` = false
	  and a.`inqueue` = true
	order by a.`datecreated` asc
	limit 1;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getportsetting` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getportsetting` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getportsetting`()
begin
	select 	`portid`, `portname`, `baudid`, `baudnm`, `databitid`, `databitnm`,
			`stopbitid`, `stopbitnm`, `parityid`, `paritynm`, `handshakeid`, `handshakenm`,
			`txdelay`, `txdelaynm`
	from `ca_portsettings`
	where `id` = 1;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getregisteredguests` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getregisteredguests` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getregisteredguests`(gid bigint, searchparam varchar(100))
begin
	if searchparam = '' then
		if gid = 0 then
			select 	`id`, concat(`lastname`, ', ', `firstname`) as guestname,
					`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `mobile`
			from `ca_guest_info`
			order by `lastname`, `firstname` asc;		
		else
			select 	`id`, concat(`lastname`, ', ', `firstname`) as guestname,
					`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `mobile`
			from `ca_guest_info`
			where `id` = gid;
		end if;		
	else
		select 	`id`, concat(`lastname`, ', ', `firstname`) as guestname,
			`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `mobile`
		from `ca_guest_info`
		where (`lastname` like concat('%', searchparam,'%')
		   or `firstname` like concat('%', searchparam,'%'))
		order by concat(`lastname`, ', ', `firstname`) asc;
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getreservations` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getreservations` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getreservations`(
	restype int,
	sparam text
)
begin
	select	a.`id` as rsid,
		concat((case d.`salutation` 
					when 0 then 'Mr. '
					when 1 then 'Ms. '
					when 2 then 'Mrs. '
					else ''
				end), 
				d.`firstname`, ' ', d.`lastname`) as guestname,
		c.`roomdesc` as actype,
		date_format(a.`rsdate`, '%Y/%m/%d') as resdate,
		case when a.`balance` > 0 then false else true end as ispaid,
		case a.`rsvstatus`
			when 0 then 'Active/Pending'
			when 1 then 'Cancelled'
			when 2 then 'Booked'
			else 'Unknown'
		end as rstatus,
		a.`downpayment`,
		a.`balance`,
		a.`remarks`,
		a.`isovernight`,
		a.`estguestcnt`,
		concat(e.`firstname`, ' ', e.`lastname`) as personnel		
	from 			`ca_reservation`	as a
		inner join	`ca_roomtype`		as b on a.`rmtypeid` = b.`id`
		inner join 	`ca_rooms`			as c on a.`roomid` = c.`id`
		inner join 	`ca_guest_info`		as d on a.`guestid` = d.`id`
		inner join 	`ca_users`			as e on a.`createdbyid` = e.`id`
	where a.`rsvstatus` = restype
	  and (d.`lastname` like concat('%', sparam, '%')
	   or  d.`firstname` like concat('%', sparam, '%')
	   or  c.`roomdesc` like concat('%', sparam, '%'))
	order by a.`rsdate` desc;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getunpaidguest` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getunpaidguest` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getunpaidguest`(
	bid bigint
)
begin
	select ifnull(Sum(`itemqty`), 0) as itemqty 
	from ca_booking_items 
	where itemtype = 2 
	  and ispaid = 0
	  and `bkid` = bid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getunservedqueues` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getunservedqueues` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getunservedqueues`(stype bit)
begin
	select	a.`id` as svcid,
			concat(case c.`salutation` 
						when 0 then 'Mr. '
						when 1 then 'Mrs. '
						when 2 then 'Ms. '
						else 'Mr. '
					end, c.`firstname`, ' ', c.`lastname`) as guestname,
			a.`message`,
			a.`isserved`,
			ifnull(case when a.`datecreated` = a.`datemodified` then null else a.`datemodified` end, '') as svcdt,
			ifnull(concat(d.`firstname`, ' ', d.`lastname`), 'Open') as servedby,
			time_to_sec(timediff(a.`datecreated`, a.`datemodified`))/ 60 as svcduration
	from 			`ca_queue_served` 	as a
		inner join 	`ca_booking` 	  	as b on a.`bid` = b.`id`
		inner join 	`ca_guest_info`		as c on a.`guestid` = c.`id`
		left join 	`ca_users`			as d on a.`modifiedbyid` = d.`id`
	where a.`isserved` = stype;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_getuserroles` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_getuserroles` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getuserroles`()
begin
	select 0 as id, '- Select a User Role -' as roledesc
	union all
	select `id`, `roledesc` from `ca_user_roles` where `rolestat` = true;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_inventoryreport` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_inventoryreport` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inventoryreport`(
	df date,
	dt date
)
begin
	select 	a.id as bkid, c.`itemdesc`,
			ifnull(sum(b.`itemqty`), 0) as qtysold, ifnull(sum(b.`itemamt`),0) as totalitemsales
	from 			`ca_booking` 		as a
		inner join 	`ca_booking_items`	as b on a.`id` = b.`bkid`
		inner join 	`ca_invitems` 		as c on b.`itemid` = c.`id`
	where a.`bkstat` = false
	  and a.`datecreated` between df and dt
	group by b.`itemid`;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_logpass` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_logpass` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_logpass`(bc varchar(25), logtype bit, utype int )
begin
	if logtype = false then
		if utype = 0 then
			insert into `ca_pass_logs`
				(`bkid`, `bcid`, `logtype`, `logdatetime`)
			values
				(0, bc, logtype, now());		
		else
			update `ca_booking_guest` set `entryflag` = true where `bcid` = bc;
			
			insert into `ca_pass_logs`
				(`bkid`, `bcid`, `logtype`, `logdatetime`)
			select `bkid`, `bcid`, 0, now()
			from `ca_booking_guest`
			where `bcid` = bc;
		end if;
		
	elseif logtype = true then
		if utype = 0 then
			insert into `ca_pass_logs`
				(`bkid`, `bcid`, `logtype`, `logdatetime`)
			values
				(0, bc, logtype, now());
		else
			update `ca_booking_guest` set `exitflag` = true where `bcid` = bc;
			
			insert into `ca_pass_logs`
				(`bkid`, `bcid`, `logtype`, `logdatetime`)
			select `bkid`, `bcid`, 1, now()
			from `ca_booking_guest`
			where `bcid` = bc;		
		end if; 
	else
		select 'Nothing to do here.';
	end if;
	
		
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_registerbooking` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_registerbooking` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_registerbooking`(
	bktype int,
	rsid bigint,
	gid bigint,
	rtid bigint,
	rid bigint,
	rrate double(10,2),
	ga int,
	gc int,
	gc0 int,
	isovn bit,
	g0 int,
	g1 varchar(50),
	g2 varchar(50),
	g3 varchar(50),
	g4 text,
	g5 varchar(100),
	g6 varchar(25),
	g7 varchar(50),
	cid bigint
)
begin
	declare newgid bigint;
	declare bid bigint;
	
	-- Guest Information
	if gid = 0 then
		insert into `ca_guest_info`
			(`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `mobile`, `datecreated`, `createdbyid`)
		values
			(g0, g1, g2, g3, g4, g5, g6, g7, now(), cid);
		set newgid = (select distinct last_insert_id() from `ca_guest_info`);
	else
		set newgid = gid;
	end if;
	
	-- Booking
	insert into `ca_booking`
		(`bksrctypeid`, `rsvid`, `guestid`, `rmtypeid`, `roomid`, `rmrate`, `guesta`, `guestc`, `guestc2`, `isovernight`, `bkstat`, `createdbyid`, `datecreated`)
	values
		(bktype, rsid, newgid, rtid, rid, rrate, ga, gc, gc0, isovn, true, cid, now());
	
	set bid = (select distinct last_insert_id() from `ca_booking`);
	
	-- Queue Serve
	insert into `ca_queue_served` 
		(`bid`, `guestid`, `message`, `isserved`, `createdbyid`, `datecreated`)
	select 	bid, newgid, concat('Prepare : ', c.`roomdesc`, ' for guest Sir/Ma\'am ', concat(`lastname`, ', ',`firstname`)) as msg,
			false, cid, now()
	from 			`ca_booking` 	as a
		inner join	`ca_guest_info` as b on a.`guestid` = b.`id`
		inner join 	`ca_rooms`		as c on a.`roomid` = c.`id`
	where a.`id` = bid;
	
	-- Serving Board
	insert into ca_serving_board
		(`bkid`, `served`, `createdbyid`, `datecreated`)
	values
		(bid, false, cid, now());
	
	-- Accommodation
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
		select 	bid, 1, a.`roomdesc`, 1, 
				case isovn 
					when true then `overnight`
					when false then `regular`
					else 0
				end,
				false,
				cid,
				now()
		from 			`ca_rooms` 		as a
			inner join 	`ca_room_rates` as b on a.`typeid` = `rmtypeid`
		where a.`id` = rid
		  and a.`typeid` = rtid;
		
	-- Guests
	
	if ga > 0 then
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
		select 	bid, 2, 'Entrance Fee (Adult)', ga, 
				case isovn 
					when true then `nightrate` * ga
					when false then `dayrate` * ga
					else 0
				end,
				false,
				cid,
				now()
		from `ca_guest_rates`
		where id = 1;
	end if;
	
	if gc > 0 then
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
		select 	bid, 2, 'Entrance Fee (Senior Citizen / PWD)', gc, 
				case isovn 
					when true then `nightrate` * gc
					when false then `dayrate` * gc
					else 0
				end,
				false,
				cid,
				now()
		from `ca_guest_rates`
		where id = 2;
	end if;
	
	if gc0 > 0 then
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
		select 	bid, 2, 'Entrance Fee (Children below 4ft)', gc0, 
				case isovn 
					when true then `nightrate` * gc0
					when false then `dayrate` * gc0
					else 0
				end,
				false,
				cid,
				now()
		from `ca_guest_rates`
		where id = 3;
	end if;	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_registerresortpasses` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_registerresortpasses` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_registerresortpasses`(
	bid bigint,
	bcw varchar(20),
	cid bigint
)
begin
	declare passexists int;
	declare isovn bit;
	
	set passexists = (select count(`id`) from `ca_booking_guest` where `bcid` = bcw);
	set isovn = (select `isovernight` from `ca_booking` where `id` = bid);
	
	if passexists = 0 then
		insert into `ca_booking_guest` 
			(`bkid`, `bcid`, `timein`, `entryflag`, `exitflag`, `expdate`,`createdbyid`, `datecreated`)
		values
			(bid, 
			 bcw, 
			 date_format(now(),'%H:%i:%s'), 
			 false, 
			 false, 
			 case isovn 
				when 0 then concat(date_format(now(), '%Y-%m-%d'), ' 17:00:00')
				when 1 then 
					case when curtime() > '05:00:00' then concat(date_format(date_add(now(), interval 1 day),'%Y-%m-%d'),' 05:00:00')
					     when curtime() >= '00:00:00' then concat(date_format(now(), '%Y-%m-%d'), ' 05:00:00')
						 else concat(date_format(date_add(now(), interval 1 day),'%Y-%m-%d'),' 05:00:00')
					end
				else now()
			 end, 
			 cid, 
			 now());
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_reportperaccommodation` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_reportperaccommodation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_reportperaccommodation`(
	df date,
	dt date
)
begin
	select 	a.id as bkid, c.`typedesc` as acctype, d.`roomdesc` as acc,
			ifnull(sum(b.`itemqty`), 0) as qtysold, ifnull(sum(b.`itemamt`),0) as totalitemsales, 
			ifnull(sum(b1.`itemqty`), 0) as qtyguests, ifnull(sum(b1.`itemamt`),0) as totalsalesinguests
	from 			`ca_booking` 		as a
		left  join 	`ca_booking_items`	as b on a.`id` = b.`bkid` and b.`itemtype` in (3)
		left  join 	`ca_booking_items`	as b1 on a.`id` = b1.`bkid` and b1.`itemtype` in (2)
		inner join	`ca_roomtype`		as c on a.`rmtypeid` = c.`id`
		inner join 	`ca_rooms`			as d on a.`roomid` = d.`id`
	where a.`bkstat` = false
	  and a.`datecreated` between df and dt
	group by a.`rmtypeid`, a.`roomid`;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_reportpercashier` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_reportpercashier` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_reportpercashier`(
	df date,
	dt date
)
begin
	select 	a.id as bkid, a.`createdbyid`, concat(e.`firstname`, ' ', e.`lastname`) as cashier,
			c.`typedesc` as acctype, d.`roomdesc` as acc,
			ifnull(sum(b.`itemqty`), 0) as qtysold, ifnull(sum(b.`itemamt`),0) as totalitemsales, 
			ifnull(sum(b1.`itemqty`), 0) as qtyguests, ifnull(sum(b1.`itemamt`),0) as totalsalesinguests,
			ifnull(sum(b2.`itemqty`), 0) as qtyacc, ifnull(sum(b2.`itemamt`),0) as totalsalesinacc
	from 			`ca_booking` 		as a
		left  join 	`ca_booking_items`	as b on a.`id` = b.`bkid` and b.`itemtype` in (3)
		left  join 	`ca_booking_items`	as b1 on a.`id` = b1.`bkid` and b1.`itemtype` in (2)
		left  join  `ca_booking_items`  as b2 on a.`id` = b2.`bkid` and b2.`itemtype` in (1)
		inner join	`ca_roomtype`		as c on a.`rmtypeid` = c.`id`
		inner join 	`ca_rooms`			as d on a.`roomid` = d.`id`
		inner join 	`ca_users`			as e on a.`createdbyid` = e.`id`
	where a.`bkstat` = false
	  and a.`datecreated` between df and dt
	group by a.`createdbyid`, a.`roomid`;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_saveportsetting` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_saveportsetting` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveportsetting`(
	p1 bigint,
	p2 varchar(50),
	p3 bigint,
	p4 varchar(10),
	
	p5 bigint,
	p6 varchar(50),
	p7 bigint,
	p8 varchar(50),
	
	p9 bigint,
	p10 varchar(50),
	p11 bigint,
	p12 varchar(50),
	
	p13 bigint,
	p14 varchar(50)
)
begin
	
	declare setcnt int;
	
	set setcnt = (select count(`id`) sid from `ca_portsettings`);
	
	if setcnt > 0 then
		update `ca_portsettings`
		set `portid` = p1, 
			`portname` = p2,
			`baudid` = p3,
			`baudnm` = p4,
			`databitid` = p5,
			`databitnm` = p6,
			`stopbitid` = p7,
			`stopbitnm` = p8,
			`parityid` = p9,
			`paritynm` = p10,
			`handshakeid` = p11,
			`handshakenm` = p12,
			`txdelay` = p13,
			`txdelaynm` = p14
		where `id` = 1;
	else
		insert into `ca_portsettings`
			(`portid`, `portname`, `baudid`, `baudnm`, `databitid`, `databitnm`, `stopbitid`, `stopbitnm`, `parityid`, `paritynm`, `handshakeid`, `handshakenm`, `txdelay`, `txdelaynm`)
		values
			(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_settlepayment` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_settlepayment` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_settlepayment`(
	bid bigint
)
begin
	update `ca_booking_items`
	set `ispaid` = true
	where `bkid` = bid
	  and `ispaid` = false;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranaccommodationrates` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranaccommodationrates` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranaccommodationrates`(
	rtype int,
	rtid bigint,
	r1 decimal(10,2),
	r2 time,
	r3 time,
	r4 decimal(10,2),
	r5 time,
	r6 time,
	r7 decimal(10,2),
	r8 time,
	r9 time,
	r10 decimal(10,2),
	r11 int,
	cid bigint
)
begin
	declare rec_exist int;
	
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) 
						 from `ca_room_rates`
						 where `rmtypeid` = rtid
						 );	
	
		if rec_exist = 0 then
			insert into `ca_room_rates`
				(`rmtypeid`, `regular`, `regtimein`, `regtimeout`, `overnight`, `ovntimein`, `ovntimeout`,
				 `daynight`, `daynightin`, `daynightout`, `extension`, `extratebase`,
				 `datecreated`, `createdbyid`)
			values
				(rtid, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, now(), cid);
		else
			update `ca_room_rates`
			set	`regular` = r1 , `regtimein` = r2, `regtimeout` = r3, 
				`overnight` = r4, `ovntimein` = r5, `ovntimeout` = r6,
				`daynight` = r7, `daynightin` = r8, `daynightout` = r9, 
				`extension` = r10, `extratebase` = r11,
				`datemodified` = now(), `modifiedbyid` = cid
			where `rmtypeid` = rtid;
		end if;
	
	elseif rtype = 1 then	-- Update
		select 'Nothing to do here.';
	
	elseif rtype = 2 then	-- Delete
		select 'Nothing to do here.';
				
	elseif rtype = 3 then	-- Load Information
		select 	`id`, `rmtypeid`, `regular`, `regtimein`, `regtimeout`,
				`overnight`, `ovntimein`, `ovntimeout`,
				`daynight`, `daynightin`, `daynightout`,
				`extension`, `extratebase`		
		from `ca_room_rates`
		where `rmtypeid` = rtid;
	
	elseif rtype = 4 then	-- Load List
		select 	`id`, `rmtypeid`, `regular`, `regtimein`, `regtimeout`,
				`overnight`, `ovntimein`, `ovntimeout`,
				`daynight`, `daynightin`, `daynightout`,
				`extension`, `extratebase`		
		from `ca_room_rates`;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranaccommodations` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranaccommodations` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranaccommodations`(
	rtype int,
	rid bigint,
	rtid bigint,
	rcode varchar(25),
	rdesc varchar(100),
	cap int,
	cid bigint
)
begin
	declare rec_exist int;
	
	set rec_exist = (select count(`id`) 
					 from `ca_rooms` 
					 where (`roomcode` = rcode or `roomdesc` = rdesc)
					 );
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) 
						 from `ca_rooms` 
						 where `recstatus` = true
						   and (`roomcode` = rcode or `roomdesc` = rdesc)
						 );
		if rec_exist = 0 then
			insert into `ca_rooms` 
				(`typeid`, `roomcode`, `roomdesc`, `capacity`, `recstatus`, `datecreated`, `createdbyid`)
			values
				(rtid, rcode, rdesc, cap, true, now(), cid);
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) 
						 from `ca_rooms` 
						 where `recstatus` = true
						   and (`roomcode` = rcode or `roomdesc` = rdesc)
						   and `id` != rid	
						 );
		if rec_exist = 0 then
			update `ca_rooms`
			set	`typeid` = rtid, `roomcode` = rcode, `roomdesc` = rdesc, `capacity` = cap, `datemodified` = now(), `modifiedbyid` = cid
			where `id` = rid;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_rooms` set `recstatus` = false where `id` = rid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `typeid`, `roomcode`, `roomdesc`, `capacity`
		from `ca_rooms`
		where `id` = rid;
	
	elseif rtype = 4 then	-- Load List
		if rtid > 0 then
			select `id`, `typeid`, `roomcode`, `roomdesc`, `capacity`
			from `ca_rooms`
			where `recstatus` = true
			  and `typeid` = rtid
			order by `id`, `roomdesc` asc;			
		else
			select `id`, `typeid`, `roomcode`, `roomdesc`, `capacity`
			from `ca_rooms`
			where `recstatus` = true
			order by `id`, `roomdesc` asc;		
		end if;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranaccommodationtransfer` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranaccommodationtransfer` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranaccommodationtransfer`(
	bkid bigint,
	frtid bigint,
	frid bigint,
	frate double(10,2),
	nrtid bigint,
	nrid bigint,
	nrate double(10,2),
	trem text,
	cid bigint
)
begin
	
	declare oldrm varchar(100);
	declare newrm varchar(100);
	
	set oldrm = (select `roomdesc` from `ca_rooms` where `id` = frid);
	set newrm = (select `roomdesc` from `ca_rooms` where `id` = nrid);
	
	insert into `ca_booking_transfers`
		(`bid`, `frmtypeid`, `frmid`, `frmrate`, `newrmtypeid`, `newrmid`, `rmrate`, `remarks`, `createdbyid`, `datecreated`)
	values
		(bkid, frtid, frid, frate, nrtid, nrid, nrate, trem, cid, now());
	
	-- Notify crew to check new room before transfer.	
	insert into `ca_queue_served`
		(`bid`, `guestid`, `message`, `isserved`, `createdbyid`, `datecreated`)
	select a.`id`, `guestid`, concat('Prepare ', newrm, ' for guest ', concat(b.`firstname`, ' ', b.`lastname` )), false, cid, now() 
	from `ca_booking` 				as a
		inner join `ca_guest_info` 	as b on a.`guestid` = b.`id`
	where a.`id` = bkid;
	
	-- Notify crew to check old room before transfer.	
	insert into `ca_queue_served`
		(`bid`, `guestid`, `message`, `isserved`, `createdbyid`, `datecreated`)
	select a.`id`, `guestid`, concat('Guest ', concat(b.`firstname`, ' ', b.`lastname`), ' is requesting for a room transfer from ', oldrm, ' to ', newrm, ' check room after guest vacates.'), false, cid, now() 
	from `ca_booking` 				as a
		inner join `ca_guest_info` 	as b on a.`guestid` = b.`id`
	where a.`id` = bkid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranaccommodationtypes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranaccommodationtypes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranaccommodationtypes`(
	rtype int,
	atid bigint,
	atdesc varchar(50),
	act1 bit,
	act2 int(1),
	act3 double,
	cid bigint
)
begin
	declare rec_exist int;
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) from `ca_roomtype` where `typedesc` = atdesc and `recstatus` = true);
		if rec_exist = 0 then
			insert into `ca_roomtype` 
				(`typedesc`, `allowdp`, `dptype`, `dpvalue`, `recstatus`, `datecreated`, `createdbyid`)
			values
				(atdesc, act1, act2, act3, true, now(), cid);
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) from `ca_roomtype` where `typedesc` = atdesc and `recstatus` = true and `id` != atid);
		if rec_exist = 0 then
			update `ca_roomtype`
			set	`typedesc` = atdesc, `allowdp` = act1, `dptype` = act2, `dpvalue` = act3, `datemodified` = now(), `modifiedbyid` = cid
			where `id` = atid;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_roomtype` set `recstatus` = false where `id` = atid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `typedesc`, `allowdp`, `dptype`, `dpvalue`
		from `ca_roomtype`
		where `id` = atid;
	
	elseif rtype = 4 then	-- Load List
		select 	`id`, `typedesc`, 
				case `allowdp` when true then 'Yes' else 'No' end as allowdp,  
				case `dptype`
					when 0 then 'Not defined'
					when 1 then 'Percentage' 
					when 2 then 'Fixed Amount'
					else 'Not Defined' 
				end as dptype,
				`dpvalue` 
		from `ca_roomtype`
		where `recstatus` = true;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranbookingitems` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranbookingitems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranbookingitems`(
	bid bigint,
	typeid int,
	itype int,
	idesc varchar(150),
	iqty int,
	iamt decimal(10,2),
	cid bigint
)
begin
	
	if itype = 1 and iamt = 0 then
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
		values
			(bid, itype, idesc, iqty, iamt, true, cid, now());
			
		-- Queue Serve
		insert into `ca_queue_served` 
			(`bid`, `guestid`, `message`, `isserved`, `createdbyid`, `datecreated`)
		select 	bid, a.`guestid`, concat('Guest Sir/Ma\'am ', concat(b.`lastname`, ', ',b.`firstname`), ' is requesting for ', iqty, ' ', idesc) as msg,
				false, cid, now()
		from 			`ca_booking` 	as a
			inner join	`ca_guest_info` as b on a.`guestid` = b.`id`
			inner join 	`ca_rooms`		as c on a.`roomid` = c.`id`
		where a.`id` = bid;
			
	else
		insert into `ca_booking_items`
			(`bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`, `createdbyid`, `datecreated`)
		values
			(bid, itype, idesc, iqty, iamt, cid, now());
			
		-- Queue Serve
		insert into `ca_queue_served` 
			(`bid`, `guestid`, `message`, `isserved`, `createdbyid`, `datecreated`)
		select 	bid, a.`guestid`, concat('Guest Sir/Ma\'am ', concat(b.`lastname`, ', ',b.`firstname`), ' is requesting for ', iqty, ' ', idesc) as msg,
				false, cid, now()
		from 			`ca_booking` 	as a
			inner join	`ca_guest_info` as b on a.`guestid` = b.`id`
			inner join 	`ca_rooms`		as c on a.`roomid` = c.`id`
		where a.`id` = bid;	
	end if;
	
	if itype = 2 and typeid = 1 then
		update `ca_booking` set `guesta` = `guesta` + iqty where `id` = bid;
	elseif itype = 2 and typeid = 2 then
		update `ca_booking` set `guestc` = `guestc` + iqty where `id` = bid;
	elseif itype = 2 and typeid = 3 then
		update `ca_booking` set `guestc2` = `guestc2` + iqty where `id` = bid;
	else 
		select 'Nothing to do here.'; 
	end if;
		
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranguestinformation` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranguestinformation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranguestinformation`(
	rtype int,
	sparam text,
	gid bigint,
	sid int,
	n1 varchar(50),
	n2 varchar(50),
	n3 varchar(50),
	i1 text,
	i2 varchar(100),
	i3 varchar(25),
	i4 varchar(25),
	i5 varchar(50),
	cid bigint
)
begin
	declare rec_exist int;
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) from `ca_guest_info` where `lastname` = n1 and `firstname` = n2);
		if rec_exist = 0 then
			insert into `ca_guest_info`
				(`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `fax`, `mobile`, `datecreated`, `createdbyid`)
			values
				(sid, n1, n2, n3, i1, i2, i3, i4, i5, now(), cid);
			
			select last_insert_id() from `ca_guest_info`;
		else
			select `id` from `ca_guest_info` where `lastname` = n1 and `firstname` = n2;
		end if;
	
	elseif rtype = 1 then 	-- Update
		set rec_exist = (select count(`id`) from `ca_guest_info` where `lastname` = n1 and `firstname` = n2 and `id` != gid);
		if rec_exist = 0 then
			update `ca_guest_info`
			set `salutation` = sid, `lastname` = n1, `firstname` = n2, `middlename` = n3,
				`address` = i1, `email` = i2, `landline` = i3, `fax` = i4, `mobile` = i5,
				`datemodified` = now(), `modifiedbyid` = cid
			where `id` = gid;
		end if;
	
	elseif rtype = 2 then 	-- Delete
		delete from `ca_guest_info` where `id` = gid;
	
	elseif rtype = 3 then	-- Load Information
		select	`id`, `salutation`, `lastname`, `firstname`, `middlename`, `address`, 
				`email`, `landline`, `fax`, `mobile`
		from `ca_guest_info`
		where `id` = gid;
	
	elseif rtype = 4 then 	-- Load List
		select `id`, concat(case `salutation` when 1 then 'Mr. ' when 2 then 'Ms. ' when 3 then 'Mrs. ' else 'Mr. ' end, `firstname`, ' ', `lastname`) as gname
		from `ca_guest_info`;
	
	elseif rtype = 5 then 	-- Search 
		select `id`, concat(case `salutation` when 1 then 'Mr. ' when 2 then 'Ms. ' when 3 then 'Mrs. ' else 'Mr. ' end, `firstname`, ' ', `lastname`) as gname
		from `ca_guest_info`
		where (`lastname` like concat('%', sparam, '%') or `firstname` like concat('%', sparam, '%'));
	
	else 
		select 'Nothing to do here.';
	end if; 
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranguestrates` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranguestrates` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranguestrates`(
	rtype int,
	dr0 double(10,2),
	df0 time,
	dt0 time,
	nr0 double(10,2),
	nf0 time,
	nt0 time,
	dr1 double(10,2),
	df1 time,
	dt1 time,
	nr1 double(10,2),
	nf1 time,
	nt1 time,
	dr2 double(10,2),
	df2 time,
	dt2 time,
	nr2 double(10,2),
	nf2 time,
	nt2 time,
	dn0	double(10,2),
	dn1	double(10,2),
	dn2	double(10,2),
	cid bigint
)
begin
	declare a_exists int;
	declare b_exists int;
	declare c_exists int;
	
	if rtype = 0 then
		set a_exists = (select count(`id`) from `ca_guest_rates` where id = 1);
		if a_exists > 0 then
			update `ca_guest_rates`
			set `dayrate` = dr0, `dfrom` = df0, `dto` = dt0, `nightrate` = nr0, `nfrom` = nf0, `nto` = nt0, `daynightrate` = dn0,
				`modifiedbyid` = cid, `datemodified` = now()
			where `id` = 1;
		else	
			insert into `ca_guest_rates`
				(`gtype`, `dayrate`, `dfrom`, `dto`, `nightrate`, `nfrom`, `nto`, `daynightrate`, `createdbyid`, `datecreated`)
			values
				('Adult', dr0, df0, dt0, nr0, nf0, nt0, dn0, cid, now());
		end if;
		
		set b_exists = (select count(`id`) from `ca_guest_rates` where id = 2);
		if b_exists > 0 then
			update `ca_guest_rates`
			set `dayrate` = dr1, `dfrom` = df1, `dto` = dt1, `nightrate` = nr1, `nfrom` = nf1, `nto` = nt1, `daynightrate` = dn1,
				`modifiedbyid` = cid, `datemodified` = now()
			where `id` = 2;
		else	
			insert into `ca_guest_rates`
				(`gtype`, `dayrate`, `dfrom`, `dto`, `nightrate`, `nfrom`, `nto`, `daynightrate`, `createdbyid`, `datecreated`)
			values
				('Children 4ft and above', dr1, df1, dt1, nr1, nf1, nt1, dn1, cid, now());
		end if;
		
		set c_exists = (select count(`id`) from `ca_guest_rates` where id = 3);
		if c_exists > 0 then
			update `ca_guest_rates`
			set `dayrate` = dr2, `dfrom` = df2, `dto` = dt2, `nightrate` = nr2, `nfrom` = nf2, `nto` = nt2, `daynightrate` = dn2,
				`modifiedbyid` = cid, `datemodified` = now()
			where `id` = 3;
		else	
			insert into `ca_guest_rates`
				(`gtype`, `dayrate`, `dfrom`, `dto`, `nightrate`, `nfrom`, `nto`, `daynightrate`, `createdbyid`, `datecreated`)
			values
				('Children below 4ft', dr2, df2, dt2, nr2, nf2, nt2, dn2, cid, now());
		end if;
	else
		select `id`, `gtype`, `dayrate`, `dfrom`, `dto`, `nightrate`, `nfrom`, `nto`, `daynightrate`
		from `ca_guest_rates`;
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_traninvitems` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_traninvitems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_traninvitems`(
	rtype int,
	iid bigint,
	itid bigint,
	icode varchar(25),
	idesc varchar(150),
	iprice double(10,2),
	wdepo bit,
	depoamt double(10,2),
	sparam varchar(100),
	cid bigint
)
begin
	declare rec_exist int;
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) from `ca_invitems` where (`itemcode` = icode  or `itemdesc` = idesc));
		if rec_exist = 0 then
			insert into `ca_invitems` 
				(`typeid`, `itemcode`, `itemdesc`, `price`, `withdeposit`, `depositamt`, `itemstat`, `createdbyid`, `datecreated`)
			values
				(itid, icode, idesc, iprice, wdepo, depoamt, true, cid, now());
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) from `ca_invitems` where `id` != iid and `itemcode` = icode );
		if rec_exist = 0 then
			update `ca_invitems` 
			set `typeid` = itid, `itemcode` = icode, `itemdesc` = idesc, `price` = iprice, 
				`withdeposit` = wdepo, `depositamt` = depoamt, `modifiedbyid` = cid, `modifieddate` = now() 
			where `id` = iid;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_invitems` set `itemstat` = false where `id` = iid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `typeid`, `itemcode`, `itemdesc`, `price`, `withdeposit`, `depositamt` 
		from `ca_invitems` where `id` = iid;
	
	elseif rtype = 4 then	-- Load List
		select `id`, `typeid`, `itemcode`, `itemdesc`, `price`, `withdeposit`, `depositamt` 
		from `ca_invitems`
		where `itemstat` = true;
		
	elseif rtype = 5 then	-- Search
		select `id`, `typeid`, `itemcode`, `itemdesc`, `price`, `withdeposit`, `depositamt`
		from `ca_invitems`
		where `itemstat` = true
		  and (`itemcode` like concat('%', sparam, '%') or `itemdesc` like concat('%', sparam, '%'));
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_traninvitemsin` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_traninvitemsin` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_traninvitemsin`(
	rtype int,
	rid bigint,
	itid int,
	iid bigint,
	qin bigint,
	cid bigint
)
begin
	
	if rtype = 0 then 			-- Add
		insert into `ca_invitems_in`
			(`itype`, `itemid`, `qtyin`, `createdbyid`, `datecreated`)
		values
			(itid, iid, qin, cid, now());
			
	elseif rtype = 1 then 		-- Update
		update `ca_invitems_in` 
		set `qtyin` = qin
		where `id` = rid;
		
	elseif rtype = 2 then 		-- Delete
		delete from `ca_invitems_in` where `id` = rid;
	
	elseif rtype = 3 then		-- Load Information
		select 'Nothing to do here.';
		
	elseif rtype = 4 then 		-- Load List
		select 'Nothing to do here.';
		
	elseif rtype = 5 then		-- Search 
		select 'Nothing to do here.';
		
	else
		select 'Nothing to do here.';
		
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_traninvitemsout` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_traninvitemsout` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_traninvitemsout`(
	bid bigint,
	itid int,
	iid bigint,
	iq int,
	ip int,
	ist int,
	istat bit,
	cid bigint
)
begin 
	insert into `ca_invitems_out`
		(`bkid`, `itype`, `itemid`, `iqty`, `iprice`, `isubtotal`, `istatus`, `createdbyid`, `datecreated`)
	values
		(bid, itid, iid, iq, ip, ist, istat, cid, now());
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_traninvtypes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_traninvtypes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_traninvtypes`(
	rtype int,
	itid bigint,
	itdesc varchar(100),
	sparam varchar(100),
	cid bigint
)
begin
	declare rec_exist int;
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) from `ca_invtypes` where `typedesc` = itdesc);
		if rec_exist = 0 then
			insert into `ca_invtypes` 
				(`typedesc`, `typestat`, `createdbyid`, `datecreated`)
			values
				(itdesc, true, cid, now());
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) from `ca_invtypes` where `id` != itid and `typedesc` = itdesc);
		if rec_exist = 0 then
			update `ca_invtypes` set `typedesc` = itdesc where `id` = itid;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_invtypes` set `typestat` = false where `id` = itid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `typedesc`, `typestat` from `ca_invtypes` where `id` = itid;
	
	elseif rtype = 4 then	-- Load List
		select `id`, `typedesc`, `typestat` from `ca_invtypes` where `typestat` = true;
	
	elseif rtype = 5 then 	-- Search
		select `id`, `typedesc` from `ca_invtypes` where `typestat` = true and `typedesc` like concat('%', sparam, '%');
		
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranrefunditems` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranrefunditems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranrefunditems`(
	rtype int,
	bid bigint,
	tid bigint,
	itid bigint,
	itname varchar(200),
	refamt decimal(10,2),
	cid bigint
)
begin
	if rtype = 0 then		-- Add refund item
		insert into `ca_itemsforrefund`
			(`bkid`, `typeid`, `itemtypeid`, `itemname`, `refundamt`, `isrefunded`, `createdbyid`, `datecreated`)
		values
			(bid, tid, itid, itname, refamt, false, cid, now());
			
	elseif rtype = 1 then 	-- Items Refunded
		update `ca_itemsforrefund` 
		set `isrefunded` = true, `modifiedbyid` = cid, `datemodifed` = now()
		where `bkid` = bid
		  and `isrefunded` = false;
		  
	elseif rtype = 2 then 	-- Remove Items for Refund
		select 'Nothing to do here.';
		
	elseif rtype = 3 then	-- Retrieve Item Info
		select 'Nothing to do here.';
	
	elseif rtype = 4 then 	-- Retrieve Items for refund
		select `id`, `itemname`, `refundamt`
		from `ca_itemsforrefund`
		where `isrefunded` = false
		  and `bkid` = bid;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranreqitems` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranreqitems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranreqitems`(
	rtype int,
	bid bigint,
	itype int,
	iid	bigint,
	idesc varchar(150),
	iqty int,
	iamt decimal(10,2)
)
begin
	
	declare iexists int;
	if rtype = 0 then		-- Add
		set iexists = (select count(`id`) from `ca_reqitems` where `bkid` = bid and `itemid` = iid);
		
		if iexists = 0 then
			insert into `ca_reqitems`
				(`bkid`, `itemtype`, `itemid`, `itemdesc`, `itemqty`, `itemamt`)
			values
				(bid, itype, iid, idesc, iqty, iamt);
		else 
			update `ca_reqitems`
			set `itemqty` = `itemqty` + iqty, `itemamt` = `itemamt` + iamt
			where `bkid` = bid and `itemid` = iid;
		end if;
	elseif rtype = 1 then	-- Edit
		select 'Nothing to do here.';
	
	elseif rtype = 2 then	-- Delete
		delete from `ca_reqitems` where `bkid` = bid and `itemid` = iid;
	
	elseif rtype = 3 then	-- Load Info
		select 'Nothing to do here.';
	
	elseif rtype = 4 then	-- Load List
		select `id`, `bkid`, `itemtype`, `itemdesc`, `itemqty`, `itemamt`
		from `ca_reqitems`
		where `bkid` = bid;
	
	elseif rtype = 5 then	-- Search List
		select 'Nothing to do here.';
	
	elseif rtype = 6 then	-- Delete Cache
		delete from `ca_reqitems` where `bkid` = bid;
		
	else
		select 'Nothing to do here.';
		
	end if;
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranreservation` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranreservation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranreservation`(
	rtype int,
	resid bigint,
	gid bigint,
	rtid bigint,
	rmid bigint,
	rdate date,
	ison bit,
	egcnt int,
	paid bit,
	dp double,
	bal double,
	rmk text,
	g0 int,
	g1 varchar(50),
	g2 varchar(50),
	g3 varchar(50),
	g4 text,
	g5 varchar(100),
	g6 varchar(25),
	g7 varchar(50),
	cid bigint,
	sparam text
)
begin
	
	declare recexist int;
	declare newgid bigint;
	declare rid bigint;
	
	if rtype = 0 then 		-- Add
		-- Guest Information
		if gid = 0 then
			insert into `ca_guest_info`
				(`salutation`, `lastname`, `firstname`, `middlename`, `address`, `email`, `landline`, `mobile`, `datecreated`, `createdbyid`)
			values
				(g0, g1, g2, g3, g4, g5, g6, g7, now(), cid);
			set newgid = (select distinct last_insert_id() from `ca_guest_info`);
		else
			set newgid = gid;
		end if;
	
		-- Reservation
		insert into `ca_reservation`
			(`guestid`, `rmtypeid`, `roomid`, `rsdate`, `isovernight`, `estguestcnt`, `ispaid`, `rsvstatus`, `downpayment`, `balance`, `remarks`)
		values
			(newgid, rtid, rmid, rdate, ison, egcnt, paid, dp, bal, rmk);
			
		set rid = (select distinct last_insert_id() from `ca_reservation`);
		
		update `ca_reservation` 
		set `rsvno` = concat(date_format(now(), '%Y-%m-'), lpad(`id`, 6, '0'))
		where `id` = rid; 
				
	elseif rtype = 1 then 	-- Update
		select 'Nothing to do here.';
	elseif rtype = 2 then 	-- Delete
		select 'Nothing to do here.';
	elseif rtype = 3 then 	-- Show Info
		select 'Nothing to do here.';
	elseif rtype = 4 then 	-- Show List
		select 'Nothing to do here.';
	else
		select 'Nothing to do here.';
	end if;
	
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_transferritobi` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_transferritobi` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_transferritobi`( bid bigint, cid bigint)
begin
	insert into `ca_booking_items`
		(`bkid`, `itemtype`, `itemid`, `itemdesc`, `itemqty`, `itemamt`, `ispaid`, `createdbyid`, `datecreated`)
	select bid, 3, `itemid`, `itemdesc`, `itemqty`, `itemamt`, false, cid, now()
	from `ca_reqitems`
	where `bkid` = bid;
	
	insert into `ca_invitems_out`
		(`bkid`, `itype`, `itemid`, `iqty`, `iprice`, `isubtotal`, `istatus`, `createdbyid`, `datecreated`)
	select a.`bkid`, a.`itemtype`, a.`itemid`, a.`itemqty`, b.`price`, a.`itemamt`, true, cid, now()
		from 			`ca_reqitems` as a
			inner join 	`ca_invitems` as b on a.`itemid` = b.`id`
	where a.`bkid` = bid;
	
	delete from `ca_reqitems` where `bkid` = bid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranuserroles` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranuserroles` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranuserroles`(
	rtype int,
	rid bigint,
	rdesc varchar(150),
	a1 bit,
	a2 bit,
	a3 bit,
	a4 bit,
	a5 bit,
	a6 bit,
	cid bigint
)
begin
	declare rec_exist int;
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) from `ca_user_roles` where `roledesc` = rdesc and `rolestat` = true);
		if rec_exist = 0 then
			insert into `ca_user_roles`
				(`roledesc`, `allowlogin`, `allowbilling`, `allowreserve`, `allowinventory`, `allowcashier`, `allowsettings`, `rolestat`, `datecreated`, `createdbyid`)
			values
				(rdesc, a1, a2, a3, a4, a5, a6, true, now(), cid);
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) from `ca_user_roles` where `roledesc` = rdesc and `rolestat` = true and `id` != rid);
		if rec_exist = 0 then
			update `ca_user_roles`
			set `roledesc` = rdesc, `allowlogin` = a1, `allowbilling` = a2, `allowreserve` = a3, `allowinventory` = a4, `allowcashier` = a5, `allowsettings` = a6,
				`datemodified` = now(), `modifiedbyid` = cid
			where `id` = rid;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_user_roles` set `rolestat` = false where `id` = rid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `roledesc`, `allowlogin`, `allowbilling`, `allowreserve`, `allowinventory`, `allowcashier`, `allowsettings`
		from `ca_user_roles` 
		where `id` = rid;
	
	elseif rtype = 4 then	-- Load List
		select `id`, `roledesc`, `allowlogin`, `allowbilling`, `allowreserve`, `allowinventory`, `allowcashier`, `allowsettings`
		from `ca_user_roles` 
		where `rolestat` = true;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tranusers` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tranusers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tranusers`(
	rtype int,
	uid bigint,
	bcid varchar(25),
	lid varchar(25),
	lpw text,
	lname varchar(50),
	fname varchar(50),
	mname varchar(50),
	rid bigint,
	cid bigint
)
begin
	declare rec_exist int;
	
	if rtype = 0 then		-- Add
		set rec_exist = (select count(`id`) 
				 from `ca_users` 
				 where `recstatus` = true
				   and (`barcodeid` = bcid or `loginid` = lid)
				 );
		if rec_exist = 0 then
			insert into `ca_users` 
				(`barcodeid`, `loginid`, `loginpw`, `lastname`, `firstname`, `middlename`, `roleid`, `recstatus`, `datecreated`, `createdbyid`)
			values
				(bcid, lid, md5(lpw), lname, fname, mname, rid, true, now(), cid);
		end if;
	
	elseif rtype = 1 then	-- Update
		set rec_exist = (select count(`id`) 
						 from `ca_users` 
						 where `recstatus` = true
						   and `barcodeid` = bcid 
						   and `loginid` = lid
						   and `id` != uid
						 );
		if rec_exist = 0 then
			if length(lpw) > 0 then
				update `ca_users`
				set	`loginid` = lid, `barcodeid` = bcid, `loginpw` = lpw, `lastname` = lname, `firstname` = fname, `middlename` = mname, 
					`roleid` = rid, `datemodified` = now(), `modifiedbyid` = cid
				where `id` = uid;
			else
				update `ca_users`
				set	`loginid` = lid, `barcodeid` = bcid, `lastname` = lname, `firstname` = fname, `middlename` = mname, 
					`roleid` = rid, `datemodified` = now(), `modifiedbyid` = cid
				where `id` = uid;	
			end if;
		end if;
	
	elseif rtype = 2 then	-- Delete
		update `ca_users` set `recstatus` = false where `id` = uid;
				
	elseif rtype = 3 then	-- Load Information
		select `id`, `barcodeid`, `loginid`, `loginpw`, `lastname`, `firstname`, `middlename`, `roleid`
		from `ca_users` 
		where `id` = uid;
	
	elseif rtype = 4 then	-- Load List
		select `id`, concat(`lastname`, ', ', `firstname`) as guestname, `barcodeid`, `loginid`, `loginpw`, `lastname`, `firstname`, `middlename`, `roleid`
		from `ca_users` 
		where `recstatus` = true;
	else
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_updatebookingaccommodation` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_updatebookingaccommodation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatebookingaccommodation`(
	bid bigint,
	rtid bigint,
	rid bigint,
	cid bigint
)
begin
	update `ca_booking` 
	set `rmtypeid` = rtid, `roomid` = rid, `modifiedbyid` = cid, `datemodified` = now()
	where `id` = bid;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_updatequeueboard` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_updatequeueboard` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatequeueboard`(bid bigint, u int)
begin
	if u = 0 then 		-- Put on Queue
		update `ca_serving_board` set `inqueue` = true where `bkid` = bid;
	elseif u = 1 then 	-- Served
		update `ca_serving_board` set `inqueue` = true, `served` = true where `bkid` = bid;
	else 
		select 'Nothing to do here.';
	end if;
end */$$
DELIMITER ;

/* Procedure structure for procedure `sp_validatecredentials` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_validatecredentials` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_validatecredentials`(lid varchar(25), lpw text)
BEGIN
		declare recordcount int;
		
		set recordcount = (select count(id) from `ca_users` where `loginid` = lid and `loginpw` = md5(lpw));
		
		if recordcount > 0 then
			select	a.`id` as uid, a.`loginid` as lid, a.`lastname` as lname, a.`firstname` as fname,
					b.`id` as rid, b.`roledesc`,
					b.`allowlogin`, b.`allowbilling`, b.`allowreserve`, b.`allowinventory`, b.`allowcashier`, b.`allowsettings`,
					a.`recstatus`
			from 			`ca_users` 		as a
				inner join	`ca_user_roles`	as b on a.`roleid` = b.`id` and b.`rolestat` = true
			where a.`loginid` = lid
			  and a.`loginpw` = md5(lpw);
		end if;
		
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
