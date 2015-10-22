-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.26-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping structure for table try_entity.meal
DROP TABLE IF EXISTS `meal`;
CREATE TABLE IF NOT EXISTS `meal` (
  `id` int(11) NOT NULL,
  `meal_name` varchar(45) NOT NULL,
  `course_name` varchar(45) DEFAULT NULL,
  `item` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `idmeal_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='			';

-- Dumping data for table try_entity.meal: ~8 rows (approximately)
DELETE FROM `meal`;
/*!40000 ALTER TABLE `meal` DISABLE KEYS */;
INSERT INTO `meal` (`id`, `meal_name`, `course_name`, `item`) VALUES
	(1, 'southern_dinner', 'appetizer', 'pickles'),
	(2, 'southern_dinner', 'salad', 'spinach'),
	(3, 'southern_dinner', 'dessert', 'pie'),
	(4, 'southern_dinner', 'main', 'steak'),
	(5, 'veggie_lunch', 'appetizer', 'carrots'),
	(6, 'veggie_lunch', 'salad', 'fruit'),
	(7, 'veggie_lunch', 'main', 'tofu burrito'),
	(8, 'veggie_lunch', 'dessert', 'strawberries');
/*!40000 ALTER TABLE `meal` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
