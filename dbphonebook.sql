-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2025 at 08:31 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbphonebook`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblphoneno`
--

CREATE TABLE `tblphoneno` (
  `idPhoneNo` int(11) NOT NULL,
  `contactName` varchar(100) NOT NULL,
  `contactNumber` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblphoneno`
--

INSERT INTO `tblphoneno` (`idPhoneNo`, `contactName`, `contactNumber`) VALUES
(1, 'Ahammad', '04-9886200'),
(2, 'Fatimah', '04-1234567'),
(3, 'Muhammad', '04-9998888'),
(4, 'Khairul', '04-5554444');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblphoneno`
--
ALTER TABLE `tblphoneno`
  ADD PRIMARY KEY (`idPhoneNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblphoneno`
--
ALTER TABLE `tblphoneno`
  MODIFY `idPhoneNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
