-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 05, 2018 at 08:50 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_clinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE IF NOT EXISTS `billing` (
  `bill_id` int(11) NOT NULL AUTO_INCREMENT,
  `sched_id` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `datecreated` date NOT NULL,
  `status` int(10) NOT NULL COMMENT '1=paid; 0=unpaid',
  PRIMARY KEY (`bill_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=45 ;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`bill_id`, `sched_id`, `total`, `datecreated`, `status`) VALUES
(1, 1, '4640.00', '2018-09-20', 1),
(2, 2, '2350.00', '2018-09-21', 1),
(3, 4, '1675.00', '2018-09-21', 1),
(4, 9, '3445.00', '2018-10-02', 1),
(5, 8, '4340.00', '2018-10-04', 1),
(6, 7, '1055.00', '2018-10-04', 1),
(7, 6, '3850.00', '2018-10-04', 1),
(8, 3, '2400.00', '2018-10-04', 1),
(9, 5, '25.00', '2018-10-04', 1),
(10, 11, '400.00', '2018-10-04', 0),
(11, 11, '5500.00', '2018-10-04', 1),
(12, 3, '250.00', '2018-10-04', 0),
(13, 13, '0.00', '2018-10-05', 1),
(14, 11, '0.00', '2018-10-05', 0),
(15, 5, '0.00', '2018-10-05', 0),
(16, 11, '0.00', '2018-10-05', 0),
(17, 11, '0.00', '2018-10-05', 0),
(18, 13, '125.00', '2018-10-05', 1),
(19, 13, '0.00', '2018-10-05', 1),
(20, 13, '0.00', '2018-10-05', 1),
(21, 13, '0.00', '2018-10-05', 1),
(22, 13, '0.00', '2018-10-05', 1),
(23, 13, '0.00', '2018-10-05', 1),
(24, 13, '0.00', '2018-10-05', 1),
(25, 14, '200.00', '2018-10-05', 0),
(26, 14, '200.00', '2018-10-05', 0),
(27, 14, '200.00', '2018-10-05', 0),
(28, 14, '600.00', '2018-10-05', 0),
(29, 14, '1850.00', '2018-10-05', 0),
(30, 11, '900.00', '2018-10-05', 0),
(31, 14, '900.00', '2018-10-05', 0),
(32, 11, '900.00', '2018-10-05', 0),
(33, 14, '900.00', '2018-10-05', 0),
(34, 10, '1120.00', '2018-10-05', 0),
(35, 5, '100.00', '2018-10-05', 0),
(36, 14, '200.00', '2018-10-05', 0),
(37, 2, '245.00', '2018-10-05', 0),
(38, 5, '1445.00', '2018-10-05', 0),
(39, 14, '1195.00', '2018-10-05', 0),
(40, 7, '1355.00', '2018-10-05', 0),
(41, 12, '995.00', '2018-10-05', 1),
(42, 2, '1295.00', '2018-10-05', 0),
(43, 14, '900.00', '2018-10-05', 0),
(44, 14, '100.00', '2018-10-05', 0);

-- --------------------------------------------------------

--
-- Table structure for table `dialyzers`
--

CREATE TABLE IF NOT EXISTS `dialyzers` (
  `dialyzer_id` int(11) NOT NULL AUTO_INCREMENT,
  `dialyzer_name` varchar(100) NOT NULL,
  `description` varchar(200) NOT NULL,
  PRIMARY KEY (`dialyzer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `dialyzers`
--

INSERT INTO `dialyzers` (`dialyzer_id`, `dialyzer_name`, `description`) VALUES
(1, 'F8', '1,600.00 '),
(2, 'F80', '2,850.00 '),
(3, '210HR', '1,850.00 \r\n'),
(4, '170L', '900.00 \r\n'),
(5, '190LR', '1,500.00 '),
(6, '190HR', '1,850.00'),
(7, 'F8+', '1,850.00'),
(8, 'F80+', '3,320.00'),
(9, '210HR+', '2,000.00'),
(10, '190LR+', '1,600.00'),
(11, '190HR+', '2,000.00');

-- --------------------------------------------------------

--
-- Table structure for table `dialyzer_used`
--

CREATE TABLE IF NOT EXISTS `dialyzer_used` (
  `dialyzer_used_id` int(11) NOT NULL AUTO_INCREMENT,
  `dialyzer_id` int(11) NOT NULL,
  `bill_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `datecommit` date NOT NULL,
  PRIMARY KEY (`dialyzer_used_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `dialyzer_used`
--

INSERT INTO `dialyzer_used` (`dialyzer_used_id`, `dialyzer_id`, `bill_id`, `amount`, `datecommit`) VALUES
(1, 9, 1, '600.00', '0000-00-00'),
(2, 5, 2, '1000.00', '0000-00-00'),
(3, 6, 3, '1000.00', '2018-09-21'),
(4, 9, 4, '2000.00', '2018-10-02'),
(5, 11, 5, '2000.00', '2018-10-04'),
(6, 10, 6, '900.00', '2018-10-04'),
(7, 6, 7, '1850.00', '2018-10-04'),
(8, 4, 8, '900.00', '2018-10-04'),
(9, 11, 11, '1850.00', '2018-10-04'),
(10, 6, 29, '1850.00', '2018-10-05'),
(11, 4, 30, '900.00', '2018-10-05'),
(12, 4, 31, '900.00', '2018-10-05'),
(13, 4, 32, '900.00', '2018-10-05'),
(14, 4, 33, '900.00', '2018-10-05'),
(15, 4, 34, '900.00', '2018-10-05'),
(16, 4, 38, '900.00', '2018-10-05'),
(17, 4, 39, '900.00', '2018-10-05'),
(18, 4, 40, '900.00', '2018-10-05'),
(19, 4, 41, '900.00', '2018-10-05'),
(20, 4, 42, '900.00', '2018-10-05'),
(21, 4, 43, '900.00', '2018-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `items_delivery`
--

CREATE TABLE IF NOT EXISTS `items_delivery` (
  `delivery_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `item_id` int(10) unsigned NOT NULL,
  `quantity` int(10) unsigned NOT NULL,
  PRIMARY KEY (`delivery_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `item_groups`
--

CREATE TABLE IF NOT EXISTS `item_groups` (
  `ig_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `group_id` int(10) unsigned NOT NULL,
  `item_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ig_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=143 ;

--
-- Dumping data for table `item_groups`
--

INSERT INTO `item_groups` (`ig_id`, `group_id`, `item_id`) VALUES
(2, 1, 1),
(3, 1, 2),
(4, 1, 3),
(5, 1, 4),
(6, 1, 5),
(7, 1, 6),
(8, 1, 7),
(9, 1, 8),
(10, 1, 9),
(11, 1, 10),
(12, 1, 11),
(13, 1, 12),
(14, 1, 13),
(15, 1, 14),
(16, 1, 15),
(17, 1, 16),
(18, 1, 17),
(19, 1, 18),
(20, 1, 19),
(21, 1, 20),
(22, 1, 21),
(23, 1, 22),
(24, 1, 23),
(25, 1, 24),
(26, 1, 25),
(27, 1, 26),
(28, 1, 27),
(29, 1, 28),
(30, 1, 29),
(31, 1, 30),
(32, 1, 31),
(33, 1, 32),
(34, 1, 33),
(35, 1, 34),
(36, 1, 35),
(37, 1, 36),
(38, 1, 37),
(39, 1, 38),
(40, 1, 39),
(41, 1, 40),
(42, 1, 41),
(43, 1, 42),
(44, 1, 43),
(45, 1, 44),
(46, 1, 45),
(47, 1, 46),
(48, 1, 47),
(49, 1, 48),
(50, 1, 49),
(51, 1, 50),
(52, 1, 51),
(53, 1, 52),
(54, 1, 53),
(55, 1, 54),
(56, 1, 55),
(57, 1, 56),
(58, 1, 57),
(59, 1, 58),
(60, 1, 59),
(61, 1, 60),
(62, 1, 61),
(63, 1, 62),
(64, 1, 63),
(65, 1, 64),
(66, 1, 65),
(67, 1, 66),
(68, 1, 67),
(69, 1, 68),
(70, 1, 69),
(71, 1, 70),
(72, 1, 71),
(73, 1, 72),
(74, 1, 73),
(75, 1, 74),
(76, 1, 75),
(77, 1, 76),
(78, 1, 77),
(79, 1, 78),
(80, 1, 79),
(81, 1, 80),
(82, 1, 81),
(83, 1, 82),
(84, 1, 83),
(85, 1, 84),
(86, 1, 85),
(87, 1, 86),
(88, 1, 87),
(89, 1, 88),
(90, 1, 89),
(91, 1, 90),
(92, 1, 91),
(93, 1, 92),
(94, 1, 93),
(95, 1, 94),
(96, 1, 95),
(97, 1, 96),
(98, 1, 97),
(99, 1, 98),
(100, 1, 99),
(101, 1, 100),
(102, 1, 101),
(103, 1, 102),
(104, 1, 103),
(105, 1, 104),
(106, 1, 104),
(107, 1, 106),
(108, 1, 107),
(109, 1, 108),
(110, 1, 109),
(111, 1, 110),
(112, 1, 111),
(113, 1, 112),
(114, 1, 113),
(115, 1, 114),
(116, 1, 115),
(117, 1, 116),
(118, 1, 117),
(119, 1, 118),
(120, 1, 119),
(121, 1, 120),
(122, 1, 121),
(123, 1, 122),
(124, 1, 123),
(125, 1, 124),
(126, 1, 125),
(127, 1, 126),
(128, 1, 127),
(129, 1, 128),
(130, 2, 129),
(131, 2, 130),
(132, 2, 131),
(133, 2, 132),
(134, 2, 133),
(135, 2, 134),
(136, 2, 135),
(137, 2, 136),
(138, 2, 137),
(139, 2, 138),
(140, 2, 139),
(141, 2, 140),
(142, 3, 140);

-- --------------------------------------------------------

--
-- Table structure for table `item_group_names`
--

CREATE TABLE IF NOT EXISTS `item_group_names` (
  `ig_name_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `group_name` varchar(45) NOT NULL,
  `description` varchar(255) NOT NULL,
  PRIMARY KEY (`ig_name_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `item_group_names`
--

INSERT INTO `item_group_names` (`ig_name_id`, `group_name`, `description`) VALUES
(1, 'Meds / Supply', 'Meds / Supplies only'),
(2, 'Epoetin', 'epoetin only'),
(3, 'Icecream Cake!', 'Oh so tasty, come and chase me!');

-- --------------------------------------------------------

--
-- Table structure for table `item_info`
--

CREATE TABLE IF NOT EXISTS `item_info` (
  `item_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `brand` varchar(45) NOT NULL,
  `description` varchar(255) NOT NULL,
  `packaging` varchar(45) NOT NULL,
  `sell_price` decimal(10,2) NOT NULL,
  `original_price` decimal(10,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`item_id`) USING BTREE
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=141 ;

--
-- Dumping data for table `item_info`
--

INSERT INTO `item_info` (`item_id`, `name`, `brand`, `description`, `packaging`, `sell_price`, `original_price`, `quantity`) VALUES
(1, '0K (acid bath)', '-', 'Meds/Supply', 'boxing', '300.00', '300.00', 100),
(2, '5% Dextrose', '', '', 'boxing', '200.00', '200.00', 0),
(3, 'Aborted TX', '', '', 'boxing', '500.00', '500.00', 0),
(4, 'Alcohol pads', '', '', 'boxing', '5.00', '5.00', 0),
(5, 'Ambulance 1', '', '', 'boxing', '1000.00', '1000.00', 0),
(6, 'Ambulance 2', '', '', 'boxing', '2000.00', '2000.00', 0),
(7, 'Amiodarone 150mg', '', '', 'boxing', '300.00', '300.00', 0),
(8, 'Antamine', '', '', 'boxing', '40.00', '40.00', 0),
(9, 'Asepto Syringe', '', '', 'boxing', '150.00', '150.00', 0),
(10, 'Aspirin 80mg', '', '', 'boxing', '5.00', '5.00', 0),
(11, 'Atropine Sulfate', '', '', 'boxing', '30.00', '30.00', 0),
(12, 'AV Fistula', '', '', 'boxing', '20.00', '20.00', 0),
(13, 'BCM Electrodes', '', '', 'boxing', '500.00', '500.00', 0),
(14, 'Benadryl 50mg cap', '', '', 'boxing', '40.00', '40.00', 0),
(15, 'Beta Pad', '', '', 'boxing', '5.00', '5.00', 0),
(16, 'Bloodline set', '', '', 'boxing', '200.00', '200.00', 0),
(17, 'Bricanyl tab', '', '', 'boxing', '20.00', '20.00', 0),
(18, 'BT charge', '', '', 'boxing', '100.00', '100.00', 0),
(19, 'BT Set', '', '', 'boxing', '50.00', '50.00', 0),
(20, 'BT Set+Benadryl', '', '', 'boxing', '90.00', '90.00', 0),
(21, 'Buscopan 10mg tab', '', '', 'boxing', '25.00', '25.00', 0),
(22, 'Buscopan amp', '', '', 'boxing', '135.00', '135.00', 0),
(23, 'Ca Gluconate 100mg/ml', '', '', 'boxing', '445.00', '445.00', 0),
(24, 'Calcium Gloconate', '', '', 'boxing', '445.00', '445.00', 0),
(25, 'Cath hep', '', '', 'boxing', '150.00', '150.00', 0),
(26, 'Clonipres 150mg', '', '', 'boxing', '55.00', '55.00', 0),
(27, 'Clonipres 75mg', '', '', 'boxing', '40.00', '40.00', 0),
(28, 'Combivent Nebule', '', '', 'boxing', '60.00', '60.00', 0),
(29, 'D5 NM', '', '', 'boxing', '200.00', '200.00', 0),
(30, 'Dextrose 50%/50ml', '', '', 'boxing', '80.00', '80.00', 0),
(31, 'Diazepam 10 Tab', '', '', 'boxing', '20.00', '20.00', 0),
(32, 'Diazepam 5 Tab', '', '', 'boxing', '15.00', '15.00', 0),
(33, 'Diazepam Amp', '', '', 'boxing', '300.00', '300.00', 0),
(34, 'Diphenhydramine', '', '', 'boxing', '180.00', '180.00', 0),
(35, 'Dobutamine', '', '', 'boxing', '700.00', '700.00', 0),
(36, 'Dolfenal Mefenamic', '', '', 'boxing', '40.00', '40.00', 0),
(37, 'Dopamine amp', '', '', 'boxing', '250.00', '250.00', 0),
(38, 'Dormicum/Midazolam', '', '', 'boxing', '130.00', '130.00', 0),
(39, 'ECG', '', '', 'boxing', '300.00', '300.00', 0),
(40, 'Epinephrine', '', '', 'boxing', '60.00', '60.00', 0),
(41, 'ET Tube', '', '', 'boxing', '250.00', '250.00', 0),
(42, 'Extra Heparin', '', '', 'boxing', '50.00', '50.00', 0),
(43, 'Extra TX', '', '', 'boxing', '500.00', '500.00', 0),
(44, 'Extra TX HMO', '', '', 'boxing', '800.00', '800.00', 0),
(45, 'Face Mask', '', '', 'boxing', '5.00', '5.00', 0),
(46, 'Ferrofer', '', '', 'boxing', '500.00', '500.00', 0),
(47, 'Fistula Kit', '', '', 'boxing', '75.00', '75.00', 0),
(48, 'Fucidin ointment', '', '', 'boxing', '400.00', '400.00', 0),
(49, 'Furosemide/Lasix', '', '', 'boxing', '85.00', '85.00', 0),
(50, 'G 7.0 ET Tube', '', '', 'boxing', '250.00', '250.00', 0),
(51, 'G 7.5 ET Tube', '', '', 'boxing', '250.00', '250.00', 0),
(52, 'G 8.0 ET Tube', '', '', 'boxing', '250.00', '250.00', 0),
(53, 'G16 catheter', '', '', 'boxing', '85.00', '85.00', 0),
(54, 'G20 catheter', '', '', 'boxing', '85.00', '85.00', 0),
(55, 'G22 catheter', '', '', 'boxing', '85.00', '85.00', 0),
(56, 'G24 catheter', '', '', 'boxing', '85.00', '85.00', 0),
(57, 'gauze 2x2', '', '', 'boxing', '5.00', '5.00', 0),
(58, 'gauze 4x4', '', '', 'boxing', '5.00', '5.00', 0),
(59, 'Gentamicin 80mg/2ml', '', '', 'boxing', '85.00', '85.00', 0),
(60, 'Gloves', '', '', 'boxing', '5.00', '5.00', 0),
(61, 'Hemostan', '', '', 'boxing', '35.00', '35.00', 0),
(62, 'Hemostan Amp', '', '', 'boxing', '300.00', '300.00', 0),
(63, 'Heparin vial', '', '', 'boxing', '250.00', '250.00', 0),
(64, 'Heplock', '', '', 'boxing', '60.00', '60.00', 0),
(65, 'HGT Strips', '', '', 'boxing', '75.00', '75.00', 0),
(66, 'Hydrocort 100mg', '', '', 'boxing', '100.00', '100.00', 0),
(67, 'Hydrocort 250mg', '', '', 'boxing', '180.00', '180.00', 0),
(68, 'IJ Flushing', '', '', 'boxing', '150.00', '150.00', 0),
(69, 'Immodium 2mg cap', '', '', 'boxing', '25.00', '25.00', 0),
(70, 'Inohep 2ml vial', '', '', 'boxing', '1.00', '1.00', 0),
(71, 'Isordil 10mg Tab', '', '', 'boxing', '20.00', '20.00', 0),
(72, 'Isordil 5mg Sub', '', '', 'boxing', '25.00', '25.00', 0),
(73, 'IV Cath G20,22', '', '', 'boxing', '85.00', '85.00', 0),
(74, 'IV Fe Charge', '', '', 'boxing', '100.00', '100.00', 0),
(75, 'Kalimate 5g', '', '', 'boxing', '100.00', '100.00', 0),
(76, 'Ketobest 600mg', '', '', 'boxing', '30.00', '30.00', 0),
(77, 'Lanoxin amp', '', '', 'boxing', '220.00', '220.00', 0),
(78, 'Lanoxin Tab', '', '', 'boxing', '15.00', '15.00', 0),
(79, 'Lidocaine /cc', '', '', 'boxing', '10.00', '10.00', 0),
(80, 'Macroset', '', '', 'boxing', '130.00', '130.00', 0),
(81, 'Mannitol', '', '', 'boxing', '175.00', '175.00', 0),
(82, 'Mefenamic Acid 500mg', '', '', 'boxing', '15.00', '15.00', 0),
(83, 'Micropore', '', '', 'boxing', '45.00', '45.00', 0),
(84, 'Microset', '', '', 'boxing', '130.00', '130.00', 0),
(85, 'misc fee', '', '', 'boxing', '75.00', '75.00', 0),
(86, 'Na Bicarb (8.4%) 10ml', '', '', 'boxing', '75.00', '75.00', 0),
(87, 'Na Bicarb (8.4%) 50ml', '', '', 'boxing', '150.00', '150.00', 0),
(88, 'NaCl (9%) 50ml', '', '', 'boxing', '70.00', '70.00', 0),
(89, 'Neb Kit', '', '', 'boxing', '80.00', '80.00', 0),
(90, 'NGT Tube', '', '', 'boxing', '200.00', '200.00', 0),
(91, 'Nicardipine amp', '', '', 'boxing', '250.00', '250.00', 0),
(92, 'Nifedipine 5mg', '', '', 'boxing', '25.00', '25.00', 0),
(93, 'Nitroglycerin Patch', '', '', 'boxing', '100.00', '100.00', 0),
(94, 'NSS (0.9 %)', '', '', 'boxing', '75.00', '75.00', 0),
(95, 'O2 Cannula', '', '', 'boxing', '35.00', '35.00', 0),
(96, 'O2 Inhalation /30min', '', '', 'boxing', '40.00', '40.00', 0),
(97, 'O2 Mask', '', '', 'boxing', '110.00', '110.00', 0),
(98, 'OR Fee', '', '', 'boxing', '500.00', '500.00', 0),
(99, 'Paracetamol amp', '', '', 'boxing', '70.00', '70.00', 0),
(100, 'Paracetamol Tab', '', '', 'boxing', '10.00', '10.00', 0),
(101, 'Plasil Amp', '', '', '', '60.00', '60.00', 0),
(102, 'Plasil Tab', '', '', '', '15.00', '15.00', 0),
(103, 'Ponstant Mefenamic', '', '', '', '45.00', '45.00', 0),
(104, 'Potassium Chloride 20ml', '', '', '', '70.00', '70.00', 0),
(105, 'Ranitidine Amp', '', '', '', '130.00', '130.00', 0),
(106, 'Ranitidine Tab', '', '', '', '25.00', '25.00', 0),
(107, 'Renvela', '', '', '', '62.00', '62.00', 0),
(108, 'Retic Count', '', '', '', '110.00', '110.00', 0),
(109, 'Ribotril', '', '', '', '20.00', '20.00', 0),
(110, 'Sodium Chloride', '', '', 'boxing', '150.00', '150.00', 0),
(111, 'Solu Set', '', '', 'boxing', '250.00', '250.00', 0),
(112, 'Suction Catheter', '', '', 'boxing', '20.00', '20.00', 0),
(113, 'Suction Tip G16', '', '', 'boxing', '100.00', '100.00', 0),
(114, 'Suture', '', '', 'boxing', '250.00', '250.00', 0),
(115, 'Syringe 10cc', '', '', 'boxing', '10.00', '10.00', 0),
(116, 'Syringe 1cc', '', '', 'boxing', '5.00', '5.00', 0),
(117, 'Syringe 20cc', '', '', 'boxing', '15.00', '15.00', 0),
(118, 'Syringe 3cc', '', '', 'boxing', '5.00', '5.00', 0),
(119, 'Tram cetra', '', '', 'boxing', '65.00', '65.00', 0),
(120, 'Tram dolcet', '', '', 'boxing', '65.00', '65.00', 0),
(121, 'Tramadol amp', '', '', 'boxing', '100.00', '100.00', 0),
(122, 'Underpads', '', '', 'boxing', '5.00', '5.00', 0),
(123, 'vaccine(FLU)', '', '', 'boxing', '650.00', '650.00', 0),
(124, 'vaccine(pneumo)', '', '', 'boxing', '1100.00', '1100.00', 0),
(125, 'Wound dressing', '', '', 'boxing', '200.00', '200.00', 0),
(126, 'Tegaderm', '', '', 'boxing', '100.00', '100.00', 0),
(127, 'Nephrisol D', '', '', 'boxing', '430.00', '430.00', 0),
(128, 'H & H strip', '', '', 'boxing', '100.00', '100.00', 0),
(129, 'Eprex', '', '', '', '950.00', '950.00', 0),
(130, 'Recormon', '', '', '', '1500.00', '1500.00', 0),
(131, 'Renogen', '', '', '', '750.00', '750.00', 0),
(132, 'Eposino', '', '', '', '700.00', '700.00', 0),
(133, 'Hemapo', '', '', '', '800.00', '800.00', 0),
(134, 'NESP darbepoetin alfa', '', '', '', '1850.00', '1850.00', 0),
(135, 'Eprex+', '', '', '', '1000.00', '0.00', 0),
(136, 'Recormon+', '', '', '', '1700.00', '0.00', 0),
(137, 'Renogen+', '', '', '', '925.00', '925.00', 0),
(138, 'Eposino+', '', '', '', '875.00', '875.00', 0),
(139, 'Hemapo+', '', '', '', '950.00', '950.00', 0),
(140, 'NESP darbepoetin alfa+', '', '', '', '2000.00', '2000.00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `item_used`
--

CREATE TABLE IF NOT EXISTS `item_used` (
  `item_used_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) NOT NULL,
  `bill_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `datecommit` date NOT NULL,
  PRIMARY KEY (`item_used_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Dumping data for table `item_used`
--

INSERT INTO `item_used` (`item_used_id`, `item_id`, `bill_id`, `amount`, `quantity`, `datecommit`) VALUES
(1, 134, 1, '1850.00', 1, '0000-00-00'),
(2, 83, 1, '45.00', 2, '0000-00-00'),
(3, 1, 2, '300.00', 1, '0000-00-00'),
(4, 69, 3, '25.00', 1, '2018-09-21'),
(5, 3, 4, '500.00', 1, '2018-10-02'),
(6, 140, 5, '2000.00', 1, '2018-10-04'),
(7, 57, 6, '5.00', 10, '2018-10-04'),
(8, 140, 7, '2000.00', 1, '2018-10-04'),
(9, 32, 8, '15.00', 100, '2018-10-04'),
(10, 4, 9, '5.00', 5, '2018-10-04'),
(11, 2, 10, '200.00', 2, '2018-10-04'),
(12, 2, 10, '200.00', 0, '2018-10-04'),
(13, 2, 11, '200.00', 2, '2018-10-04'),
(14, 3, 11, '500.00', 1, '2018-10-04'),
(15, 2, 12, '200.00', 1, '2018-10-04'),
(16, 4, 12, '5.00', 10, '2018-10-04'),
(17, 21, 18, '25.00', 5, '2018-10-05'),
(18, 18, 25, '100.00', 1, '2018-10-05'),
(19, 2, 26, '200.00', 1, '2018-10-05'),
(20, 2, 27, '200.00', 1, '2018-10-05'),
(21, 2, 28, '200.00', 1, '2018-10-05'),
(22, 2, 28, '200.00', 2, '2018-10-05'),
(23, 4, 34, '5.00', 5, '2018-10-05'),
(24, 2, 38, '200.00', 2, '2018-10-05'),
(25, 2, 39, '200.00', 1, '2018-10-05'),
(26, 2, 40, '200.00', 1, '2018-10-05'),
(27, 2, 42, '200.00', 1, '2018-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `laboratories`
--

CREATE TABLE IF NOT EXISTS `laboratories` (
  `lab_id` int(11) NOT NULL AUTO_INCREMENT,
  `lab_name` varchar(100) NOT NULL,
  `description` varchar(200) NOT NULL,
  PRIMARY KEY (`lab_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=77 ;

--
-- Dumping data for table `laboratories`
--

INSERT INTO `laboratories` (`lab_id`, `lab_name`, `description`) VALUES
(1, 'Lab 1 (CBC;Creatinine;Pre & Post BUN;Ca;K;P;Albumin;Na;BUA;URR & KT/V)', '750.00 \r\n'),
(2, 'Lab 2 (Lab 1; SGPT;Alkaline Phospate;FBS;Lipid Profile)', '1,100.00'),
(3, 'Lab 3 (HbsAg;anti-HBs w/ titer;anti-HCV)', '900.00'),
(4, 'Lab 7 (Iron;Ferritin;TIBC;TSAT)', '1,200.00'),
(5, 'CBC', '120.00'),
(6, 'Creatinine', '90.00'),
(7, 'BUN', '90.00'),
(8, 'Potassium', '135.00'),
(9, 'Albumin', '95.00'),
(10, 'FBS', '90.00'),
(11, 'BUA', '95.00'),
(12, 'SGPT', '90.00'),
(13, 'SGOT', '90.00'),
(14, 'Phosphorus', '135.00'),
(15, 'HbsAg', '165.00'),
(16, 'Anti-HBs', '375.00'),
(17, 'Anti-HCV', '405.00'),
(18, 'Calcium (Ionized)/ Total', '135.00'),
(19, 'Total Cholesterol', '110.00'),
(20, 'HDL', '200.00'),
(21, 'LDL', '200.00'),
(22, 'Triglycerides', '110.00'),
(23, 'Magnesium /Mg', '300.00'),
(24, 'Sodium', '135.00'),
(25, 'Chloride', '135.00'),
(26, 'SGOT / AST', '90.00'),
(27, 'SGPT / ALT', '90.00'),
(28, 'Bilirubin(tb;b1;b2)', '95.00'),
(29, 'GGT', '- \r\n'),
(30, 'Alkaline Phosphatase / ALP', '90.00'),
(31, 'Total Protein', '95.00'),
(32, 'HbA1C /Glycosylated Hgb', '470.00'),
(33, 'TPAG', '200.00'),
(34, 'PSA', '-'),
(35, 'Gram Stain', '-'),
(36, 'AFB x3', '270.00'),
(37, 'Lipid Profile', '300.00'),
(38, 'Na;K;iCal', '- '),
(39, 'ASO', '-'),
(40, 'OGCT', '300.00'),
(41, 'OGIT', '600.00'),
(42, 'CBC w/ Plate Count', '120.00'),
(43, 'Platelet count', '-'),
(44, 'ABO w/ Rh typing', '95.00'),
(45, 'ESR', '120.00'),
(46, 'Bleeding Time', '105.00'),
(47, 'Clotting Time', '105.00'),
(48, 'APTT', '225.00'),
(49, 'Prothrombin Time / PTPA', '340.00'),
(50, 'Peripheral Blood Smear', '210.00'),
(51, 'Routine Urinalysis', '-'),
(52, 'Fecalysis', '-'),
(53, 'Fecalysis w/ Occult Blood', '-'),
(54, 'Pregnancy Test', '135.00'),
(55, 'Iron', '300.00'),
(56, 'Ferritin', '945.00'),
(57, 'Anti-HAV (IgM)', '-'),
(58, 'Anti-Hbe', '-'),
(59, 'Anti- Hbc (Total)', '-'),
(60, 'T3', '270.00'),
(61, 'T4', '270.00'),
(62, 'TSH', '450.00'),
(63, 'FT3', '340.00'),
(64, 'FT4', '340.00'),
(65, 'Bicarbonate', '-'),
(66, 'PTH', '2,160.00'),
(67, 'Tumor Marker', '-'),
(68, 'TIBC', '450.00'),
(69, 'Lab 1 HMO', '800.00'),
(70, 'Lab 2 HMO', '1,200.00'),
(71, 'Lab 3 HMO', '1,000.00'),
(72, 'Lab 7 HMO', '1,440.00'),
(73, 'MP Lab 1 (CBC;Creatinine;Pre & Post BUN;Ca;K;P;Albumin;Na;BUA;URR & KT/V)', '750.00'),
(74, 'MP Lab 2 (Lab 1; SGPT;Alkaline Phospate;FBS;Lipid Profile)', '1,400.00'),
(75, 'MP Lab 3 (HbsAg;anti-HBs w/ titer;anti-HCV)', '900.00'),
(76, 'MP Lab 7 (Iron;Ferritin;TIBC;TSAT)', '2,500.00');

-- --------------------------------------------------------

--
-- Table structure for table `laboratory_used`
--

CREATE TABLE IF NOT EXISTS `laboratory_used` (
  `lab_used_id` int(11) NOT NULL AUTO_INCREMENT,
  `lab_id` int(11) NOT NULL,
  `bill_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `datecommit` date NOT NULL,
  PRIMARY KEY (`lab_used_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `laboratory_used`
--

INSERT INTO `laboratory_used` (`lab_used_id`, `lab_id`, `bill_id`, `amount`, `datecommit`) VALUES
(1, 56, 1, '1000.00', '0000-00-00'),
(2, 38, 1, '1000.00', '0000-00-00'),
(3, 28, 2, '1000.00', '0000-00-00'),
(4, 44, 3, '650.00', '2018-09-21'),
(5, 56, 4, '945.00', '2018-10-02'),
(6, 64, 5, '340.00', '2018-10-04'),
(7, 47, 6, '105.00', '2018-10-04'),
(8, 1, 11, '750.00', '2018-10-04'),
(9, 28, 34, '95.00', '2018-10-05'),
(10, 44, 38, '95.00', '2018-10-05'),
(11, 44, 39, '95.00', '2018-10-05'),
(12, 44, 40, '95.00', '2018-10-05'),
(13, 44, 40, '95.00', '2018-10-05'),
(14, 44, 41, '95.00', '2018-10-05'),
(15, 44, 42, '95.00', '2018-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `mode_of_payment`
--

CREATE TABLE IF NOT EXISTS `mode_of_payment` (
  `mode_id` int(11) NOT NULL AUTO_INCREMENT,
  `mode_of_payment` varchar(100) NOT NULL,
  `description` varchar(200) NOT NULL,
  PRIMARY KEY (`mode_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `mode_of_payment`
--

INSERT INTO `mode_of_payment` (`mode_id`, `mode_of_payment`, `description`) VALUES
(1, 'cash', 'cash'),
(2, 'check', 'check'),
(3, 'credit card', 'credit card'),
(4, 'phic', 'phic'),
(5, 'pcso', 'pcso'),
(6, 'maxicare', 'maxicare'),
(7, 'lacson', 'lacson'),
(8, 'asianlife', 'asianlife'),
(9, 'medocare', 'medocare'),
(10, 'valucare', 'valucare'),
(11, 'flexicare', 'flexicare'),
(12, 'dswd', 'dswd'),
(13, 'philhealth', 'philhealth'),
(14, 'hppi', 'hppi');

-- --------------------------------------------------------

--
-- Table structure for table `other_expenses`
--

CREATE TABLE IF NOT EXISTS `other_expenses` (
  `expense_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(200) NOT NULL,
  `bill_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `datecommit` date NOT NULL,
  PRIMARY KEY (`expense_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `other_expenses`
--

INSERT INTO `other_expenses` (`expense_id`, `description`, `bill_id`, `amount`, `datecommit`) VALUES
(1, 'Extra', 1, '100.00', '0000-00-00'),
(2, 'Travel', 2, '50.00', '0000-00-00'),
(3, 'ambulance', 11, '2000.00', '2018-10-04'),
(4, 'Travel', 34, '100.00', '2018-10-05'),
(5, 'travel', 35, '100.00', '2018-10-05'),
(6, 'travel', 36, '100.00', '2018-10-05'),
(7, 'food', 36, '100.00', '2018-10-05'),
(8, 'food', 37, '45.00', '2018-10-05'),
(9, 'water', 37, '200.00', '2018-10-05'),
(10, 'food', 38, '50.00', '2018-10-05'),
(11, 'food', 40, '65.00', '2018-10-05'),
(12, 'food', 42, '100.00', '2018-10-05'),
(13, 'food', 44, '100.00', '2018-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE IF NOT EXISTS `patient` (
  `patient_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `lastname` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `clinic_abstract` tinyint(1) NOT NULL,
  `hemoglobin_order` tinyint(1) NOT NULL,
  `latest_lab` tinyint(1) NOT NULL,
  `latest_chest_xray` tinyint(1) NOT NULL,
  `hepatitis_profile` tinyint(1) NOT NULL,
  `dialysis_logsheet` tinyint(1) NOT NULL,
  `storage_code` varchar(100) NOT NULL,
  `is_complete` tinyint(1) NOT NULL COMMENT '0=incomplete; 1-complete;',
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`patient_id`, `lastname`, `firstname`, `middlename`, `phone`, `contact`, `clinic_abstract`, `hemoglobin_order`, `latest_lab`, `latest_chest_xray`, `hepatitis_profile`, `dialysis_logsheet`, `storage_code`, `is_complete`) VALUES
(1, 'Agustin', 'Herminia', 'B', '9090-0909099', '113-1212', 0, 0, 1, 1, 0, 1, 'ABSdasdsa', 0),
(2, 'Alvarez', 'Mary Ann', 'G', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(3, 'Banaag', 'Teresita', 'W', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(4, 'Ballesteros', 'Gem', 'P', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(5, 'Barral', 'Rogel', 'H', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(6, 'Cabana', 'Melba', 'T', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(7, 'Capistrano', 'Lumen', 'L', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(8, 'Crisologo', 'Moises', 'E', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(9, 'Dadia', 'Jackielyn', 'K', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(10, 'De Guzman', 'Roderick', 'G', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(11, 'Ebio', 'Shiela', 'G', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(12, 'Fernandez', 'Rebecca', 'H', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(13, 'Gonzales', 'Babilyn', 'Q', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(14, 'Javier', 'Dona', 'L', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(15, 'Marin', 'Christian', 'C', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(16, 'Medico', 'Joanne', 'C', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(17, 'Perez', 'Belen', 'M', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(18, 'Rodriguez', 'Benito', 'N', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(19, 'Santos', 'Emelie', 'I', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(20, 'Soliman', 'Alicia', 'C', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(21, 'Valdez', 'Eric', 'N', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(22, 'Redondo', 'Ena', 'M', '9090-0909099', '113-1212', 1, 0, 1, 0, 1, 0, 'ABCD-1124', 0),
(23, 'Akenzua', 'Fe', 'C', '9090-0909099', '113-1212', 1, 1, 1, 1, 1, 1, 'ABCD-1124', 0),
(24, 'Jeffric', 'Pisuena', 'V', '0990909', '090909090909', 0, 0, 0, 0, 0, 0, '', 0),
(25, 'last', 'first', 'middle', '09090', '111111', 0, 0, 0, 0, 0, 0, '', 0),
(26, 'Prado', 'Felimer', 'V.', '0909090', '787878556', 0, 0, 0, 0, 0, 0, '', 0),
(27, 'parafina', 'edrein', 'ignacio', '', '09asd', 1, 0, 0, 0, 0, 0, '', 0),
(28, 'dela cruz', 'juan', 'ignacio', '', '09asd', 1, 1, 1, 1, 1, 1, '', 0),
(29, 'Ballesteros', 'Paul', 'Oranya', '212121', '143231', 1, 1, 1, 1, 1, 1, 'STORAGE-123', 1);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE IF NOT EXISTS `payment` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `bill_id` int(11) NOT NULL,
  `mode_id` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `discount` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`payment_id`, `bill_id`, `mode_id`, `amount`, `discount`, `total`, `date`) VALUES
(1, 1, 1, '4640.00', '0.00', '4640.00', '0000-00-00'),
(2, 2, 9, '2000.00', '0.00', '2000.00', '2018-09-21'),
(3, 2, 1, '350.00', '0.00', '350.00', '2018-09-21'),
(4, 4, 13, '3445.00', '0.00', '3445.00', '2018-10-02'),
(8, 5, 1, '100.00', '0.00', '100.00', '2018-10-04'),
(9, 5, 1, '100.00', '0.00', '100.00', '2018-10-04'),
(10, 5, 1, '4140.00', '0.00', '4140.00', '2018-10-04'),
(11, 6, 8, '1055.00', '0.00', '1055.00', '2018-10-04'),
(12, 7, 8, '3850.00', '0.00', '3850.00', '2018-10-04'),
(13, 8, 1, '100.00', '0.00', '100.00', '2018-10-04'),
(14, 9, 8, '25.00', '0.00', '25.00', '2018-10-04'),
(15, 11, 1, '1000.00', '0.00', '1000.00', '2018-10-04'),
(16, 11, 1, '1000.00', '0.00', '1000.00', '2018-10-04'),
(17, 11, 1, '3500.00', '0.00', '3500.00', '2018-10-04'),
(18, 24, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(19, 23, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(20, 22, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(21, 21, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(22, 20, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(23, 41, 8, '995.00', '0.00', '995.00', '2018-10-05'),
(24, 13, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(25, 18, 8, '0.00', '0.00', '0.00', '2018-10-05'),
(26, 19, 8, '0.00', '0.00', '0.00', '2018-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `scheduling`
--

CREATE TABLE IF NOT EXISTS `scheduling` (
  `schedule_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `patient_id` int(10) unsigned NOT NULL,
  `date_schedule` date NOT NULL,
  `time_start` time NOT NULL,
  `time_end` time NOT NULL,
  `session_no` varchar(50) NOT NULL,
  `is_attended` tinyint(4) NOT NULL,
  PRIMARY KEY (`schedule_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `scheduling`
--

INSERT INTO `scheduling` (`schedule_id`, `patient_id`, `date_schedule`, `time_start`, `time_end`, `session_no`, `is_attended`) VALUES
(1, 15, '2018-09-14', '08:00:00', '10:00:00', '20180920195941', 0),
(2, 20, '2018-09-21', '08:00:00', '10:00:00', '20180920195956', 0),
(3, 20, '2018-09-22', '08:00:00', '10:00:00', '20180920200003', 0),
(4, 15, '2018-09-23', '08:00:00', '10:00:00', '20180920200010', 0),
(5, 13, '2018-09-24', '08:00:00', '10:00:00', '20180920200019', 0),
(6, 14, '2018-09-25', '08:00:00', '10:00:00', '20180920200025', 0),
(7, 11, '2018-09-26', '08:00:00', '10:00:00', '20180920200032', 0),
(8, 1, '2018-09-13', '06:52:23', '10:52:23', '20180928145255', 0),
(9, 19, '2018-10-02', '12:00:00', '04:00:00', '20181001133904', 0),
(10, 26, '2018-10-04', '10:00:00', '02:00:00', '20181004165014', 0),
(11, 27, '2018-10-05', '08:00:00', '12:00:00', '20181004200231', 1),
(12, 28, '2018-10-06', '08:22:30', '08:22:30', '20181004202512', 1),
(13, 1, '2018-10-06', '08:22:30', '08:22:30', '20181004202619', 1),
(14, 29, '2018-10-08', '08:00:00', '12:00:00', '20181005111104', 0);

-- --------------------------------------------------------

--
-- Table structure for table `summary`
--

CREATE TABLE IF NOT EXISTS `summary` (
  `summary_id` int(11) NOT NULL AUTO_INCREMENT,
  `summary` varchar(200) NOT NULL,
  `quantity` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`summary_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `username`, `password`) VALUES
(1, 'admin1', '5f4dcc3b5aa765d61d8327deb882cf99'),
(2, 'admin2', '5f4dcc3b5aa765d61d8327deb882cf99');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
