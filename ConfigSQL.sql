-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2017 at 06:39 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hrm_database`
--
CREATE DATABASE IF NOT EXISTS `hrm_database` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hrm_database`;

-- --------------------------------------------------------

--
-- Table structure for table `employee_table`
--

CREATE TABLE `employee_table` (
  `eid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `uid` int(11) NOT NULL,
  `auth` int(2) NOT NULL,
  `aadhar_uid` varchar(20) NOT NULL,
  `aadhar_string` varchar(1000) NOT NULL,
  `skill` int(5) NOT NULL,
  `emp_type` int(3) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `goverment_users`
--

CREATE TABLE `goverment_users` (
  `gid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `aadhar_gid` varchar(20) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `goverment_users`
--

INSERT INTO `goverment_users` (`gid`, `name`, `email`, `password`, `aadhar_gid`, `created`) VALUES
(1, 'Admin', 'admin@admin.com', '21232F297A57A5A743894A0E4A801FC3', '902502551478', '2017-03-21 06:35:48');

-- --------------------------------------------------------

--
-- Table structure for table `contract_users`
--

CREATE TABLE `contract_users` (
  `cid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `aadhar_cid` varchar(20) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supervisour_users`
--

CREATE TABLE `supervisour_users` (
  `su_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `aadhar_su_id` varchar(20) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `site_table`
--

CREATE TABLE `site_table` (
  `sid` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `address` varchar(20) NOT NULL,
  `district` varchar(1000) NOT NULL,
  `state` varchar(20) NOT NULL,
  `type` int(3) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `super_req_table`
--

CREATE TABLE `super_req_table` (
  `rid` int(11) NOT NULL,
  `task_name` varchar(100) NOT NULL,
  `uid` int(11) NOT NULL,
  `date` varchar(20) NOT NULL,
  `skill_1` int(5) NOT NULL,
  `skill_2` int(5) NOT NULL,
  `skill_3` int(5) NOT NULL,
  `skill_4` int(5) NOT NULL,
  `c_response` int(2) NOT NULL,
  `created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_table`
--
ALTER TABLE `employee_table`
  ADD PRIMARY KEY (`eid`);

--
-- Indexes for table `goverment_users`
--
ALTER TABLE `goverment_users`
  ADD PRIMARY KEY (`gid`);

--
-- Indexes for table `goverment_users`
--
ALTER TABLE `contract_users`
  ADD PRIMARY KEY (`cid`);

--
-- Indexes for table `goverment_users`
--
ALTER TABLE `supervisour_users`
  ADD PRIMARY KEY (`su_id`);

--
-- Indexes for table `site_table`
--
ALTER TABLE `site_table`
  ADD PRIMARY KEY (`sid`);

--
-- Indexes for table `super_req_table`
--
ALTER TABLE `super_req_table`
  ADD PRIMARY KEY (`rid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_table`
--
ALTER TABLE `employee_table`
  MODIFY `eid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `goverment_users`
--
ALTER TABLE `goverment_users`
  MODIFY `gid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `contract_users`
--
ALTER TABLE `contract_users`
  MODIFY `cid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `supervisour_users`
--
ALTER TABLE `supervisour_users`
  MODIFY `su_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `site_table`
--
ALTER TABLE `site_table`
  MODIFY `sid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `super_req_table`
--
ALTER TABLE `super_req_table`
  MODIFY `rid` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
