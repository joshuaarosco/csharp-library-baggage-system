/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 5.6.50-log : Database - baggage_system
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`baggage_system` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `baggage_system`;

/*Table structure for table `baggages` */

DROP TABLE IF EXISTS `baggages`;

CREATE TABLE `baggages` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(80) DEFAULT NULL,
  `student_id` varchar(80) DEFAULT NULL,
  `keycard_number` varchar(80) DEFAULT NULL,
  `status` varchar(80) DEFAULT NULL,
  `time_in` datetime DEFAULT NULL,
  `time_out` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `baggages` */

insert  into `baggages`(`id`,`name`,`student_id`,`keycard_number`,`status`,`time_in`,`time_out`) values 
(1,'Joshua Arosco','20230206-0001','001','available','2023-02-06 09:02:57',NULL),
(2,'Jhay Mark Jhon Lopez','19-LN-1780','001','available','2023-02-06 17:25:46','2023-02-06 20:11:41'),
(3,'Joeward Peña','19-LN-2128','002','available','2023-02-06 18:00:32','2023-02-08 13:07:30'),
(4,'Test Visitor 1','20230208-001','001','available','2023-02-08 10:48:59',NULL),
(5,'Test Visitor 2','20230208-002','001','available','2023-02-08 10:51:19',NULL),
(6,'Test Visitor 3','20230208-003','001','available','2023-02-08 11:05:59','2023-02-08 11:09:41'),
(7,'Test Visitor 4','20230208-004','001','available','2023-02-08 11:13:06','2023-02-08 11:15:40'),
(8,'Jhay Mark Jhon Lopez','19-LN-1780','001','available','2023-02-08 23:30:23','2023-02-08 23:31:33'),
(9,'Jhay Mark Jhon Lopez','19-LN-1780','001','occupied','2023-02-08 23:32:32',NULL);

/*Table structure for table `keycards` */

DROP TABLE IF EXISTS `keycards`;

CREATE TABLE `keycards` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `keycard_number` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `keycards` */

insert  into `keycards`(`id`,`keycard_number`) values 
(1,'001'),
(2,'002');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) DEFAULT NULL,
  `name` varchar(80) DEFAULT NULL,
  `student_id` varchar(80) DEFAULT NULL,
  `username` varchar(80) DEFAULT NULL,
  `password` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `users` */

insert  into `users`(`id`,`type`,`name`,`student_id`,`username`,`password`) values 
(1,'admin','admin',NULL,'admin','password'),
(2,'student','Jhay Mark Jhon Lopez','19-LN-1780',NULL,NULL),
(3,'student','Joeward Peña','19-LN-2128',NULL,NULL),
(4,'visitor','Test Visitor 2','20230208-002',NULL,NULL),
(5,'visitor','Test Visitor 3','20230208-003',NULL,NULL),
(6,'visitor','Test Visitor 4','20230208-004',NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
