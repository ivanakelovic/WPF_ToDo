-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 26, 2015 at 10:37 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ispit`
--
CREATE DATABASE IF NOT EXISTS `ispit` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `ispit`;
-- --------------------------------------------------------

--
-- Table structure for table `obaveze`
--

CREATE TABLE IF NOT EXISTS `obaveze` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(32) NOT NULL,
  `Opis` varchar(128) NOT NULL,
  `Zavrsena` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `obaveze`
--

INSERT INTO `obaveze` (`ID`, `Naziv`, `Opis`, `Zavrsena`) VALUES
(1, 'Kupiti namjernice', 'Hljeb, mlijeko, šećer...', 0),
(2, 'Podići knjigu', 'Kopirnica', 0),
(3, 'Prijaviti ispite', 'TMP i Baze', 1),
(4, 'Film', 'RTRS 22:00', 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
