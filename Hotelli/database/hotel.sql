-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 04.03.2026 klo 12:34
-- Palvelimen versio: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `customers`
--

CREATE TABLE `customers` (
  `customerid` int(11) NOT NULL,
  `firstname` varchar(25) NOT NULL,
  `lastname` varchar(25) NOT NULL,
  `address` varchar(40) NOT NULL,
  `postcode` varchar(10) NOT NULL,
  `postalarea` varchar(25) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `customers`
--

INSERT INTO `customers` (`customerid`, `firstname`, `lastname`, `address`, `postcode`, `postalarea`, `username`, `password`) VALUES
(2, 'Niko', 'Muukkonen', 'Palopellonkatu 16', '04254', 'Kerava', 'nks1', 'qwerqwerqwer1'),
(3, 'Niko', 'Muukkonen', 'Palopellonkatu 16', '04255', 'Kerava', 'nks1', 'qwerqwerqwer1');

-- --------------------------------------------------------

--
-- Rakenne taululle `reservations`
--

CREATE TABLE `reservations` (
  `id` int(25) NOT NULL,
  `reservationnumber` varchar(25) NOT NULL,
  `customernumber` varchar(25) NOT NULL,
  `roomtype` varchar(25) NOT NULL,
  `roomnumber` varchar(25) NOT NULL,
  `indate` date NOT NULL,
  `outdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `reservations`
--

INSERT INTO `reservations` (`id`, `reservationnumber`, `customernumber`, `roomtype`, `roomnumber`, `indate`, `outdate`) VALUES
(1, '102939', '12', 'Single', '102', '2026-03-05', '2026-03-12'),
(2, '190393', '14', 'Double', '103', '2026-03-05', '2026-03-12');

-- --------------------------------------------------------

--
-- Rakenne taululle `rooms`
--

CREATE TABLE `rooms` (
  `id` int(11) NOT NULL,
  `roomnumber` varchar(25) NOT NULL,
  `roomtype` varchar(25) NOT NULL,
  `phone` varchar(25) NOT NULL,
  `isfree` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `rooms`
--

INSERT INTO `rooms` (`id`, `roomnumber`, `roomtype`, `phone`, `isfree`) VALUES
(1, '102', 'Single', '040123123', 0);

-- --------------------------------------------------------

--
-- Rakenne taululle `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `users`
--

INSERT INTO `users` (`userid`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customerid`);

--
-- Indexes for table `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customerid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `reservations`
--
ALTER TABLE `reservations`
  MODIFY `id` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `rooms`
--
ALTER TABLE `rooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
