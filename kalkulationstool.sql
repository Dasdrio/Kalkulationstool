-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 26. Feb 2026 um 14:39
-- Server-Version: 10.4.28-MariaDB
-- PHP-Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kalkulationstool`
--

DELIMITER $$
--
-- Prozeduren
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_data` (IN `p_listeneinkaufspreis` DECIMAL, IN `p_lieferrabatt` DECIMAL, IN `p_zieleinkaufspreis` DECIMAL, IN `p_liefererskonto` DECIMAL, IN `p_bareinkaufspreis` DECIMAL, IN `p_bezugskosten` DECIMAL, IN `p_bezugspreis` DECIMAL, IN `p_handlungskosten` DECIMAL, IN `p_selbstkosten` DECIMAL, IN `p_gewinnzuschlag` DECIMAL, IN `p_barverkaufspreis` DECIMAL, IN `p_kundenskonto_vertreterprovision` DECIMAL, IN `p_zielverkaufspreis` DECIMAL, IN `p_kundenrabatt` DECIMAL, IN `p_nettoverkaufspreis` DECIMAL, IN `p_umsatzsteuer` DECIMAL, IN `p_bruttoverkaufspreis` DECIMAL)   INSERT INTO kalkulation VALUES(
    null,
    p_listeneinkaufspreis,
    p_lieferrabatt,
    p_zieleinkaufspreis,
    p_liefererskonto,
    p_bareinkaufspreis,
    p_bezugskosten,
    p_bezugspreis,
    p_handlungskosten,
    p_selbstkosten,
    p_gewinnzuschlag,
    p_barverkaufspreis,
    p_kundenskonto_vertreterprovision,
    p_zielverkaufspreis,
    p_kundenrabatt,
    p_nettoverkaufspreis,
    p_umsatzsteuer,
    p_bruttoverkaufspreis
)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kalkulation`
--

CREATE TABLE `kalkulation` (
  `id` int(10) UNSIGNED NOT NULL,
  `listeneinkaufspreis` decimal(10,2) NOT NULL,
  `lieferrabatt` decimal(10,2) NOT NULL,
  `zieleinkaufspreis` decimal(10,2) NOT NULL,
  `liefererskonto` decimal(10,2) NOT NULL,
  `bareinkaufspreis` decimal(10,2) NOT NULL,
  `bezugskosten` decimal(10,2) NOT NULL,
  `bezugspreis` decimal(10,2) NOT NULL,
  `handlungskosten` decimal(10,2) NOT NULL,
  `selbstkostenpreis` decimal(10,2) NOT NULL,
  `gewinnzuschlag` decimal(10,2) NOT NULL,
  `barverkaufspreis` decimal(10,2) NOT NULL,
  `kundenskonto_vertreterprovision` decimal(10,2) NOT NULL,
  `zielverkaufspreis` decimal(10,2) NOT NULL,
  `kundenrabatt` decimal(10,2) NOT NULL,
  `nettoverkaufspres` decimal(10,2) NOT NULL,
  `umsatzsteuer` decimal(10,2) NOT NULL,
  `bruttoverkaufspreis` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kalkulation`
--

INSERT INTO `kalkulation` (`id`, `listeneinkaufspreis`, `lieferrabatt`, `zieleinkaufspreis`, `liefererskonto`, `bareinkaufspreis`, `bezugskosten`, `bezugspreis`, `handlungskosten`, `selbstkostenpreis`, `gewinnzuschlag`, `barverkaufspreis`, `kundenskonto_vertreterprovision`, `zielverkaufspreis`, `kundenrabatt`, `nettoverkaufspres`, `umsatzsteuer`, `bruttoverkaufspreis`) VALUES
(2, 100.00, 30.00, 70.00, 2.00, 68.00, 3.00, 71.00, 18.00, 89.00, 11.00, 100.00, 4.00, 104.00, 45.00, 149.00, 28.00, 177.00);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `kalkulation`
--
ALTER TABLE `kalkulation`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `kalkulation`
--
ALTER TABLE `kalkulation`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
