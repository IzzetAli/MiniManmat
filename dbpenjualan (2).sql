-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Des 2022 pada 02.27
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpenjualan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `Kode_Admin` varchar(6) NOT NULL,
  `Nama_Admin` varchar(50) NOT NULL,
  `Password_Admin` varchar(30) NOT NULL,
  `Level_Admin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_admin`
--

INSERT INTO `tbl_admin` (`Kode_Admin`, `Nama_Admin`, `Password_Admin`, `Level_Admin`) VALUES
('ADM001', 'ADMIN', 'ADMIN', 'ADMIN'),
('ADM002', 'IZET', 'USER', 'USER'),
('ADM003', 'madi', 'kontol', 'ADMIN'),
('ADM004', 'made', 'Masukkan', 'USER');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `Kode_Barang` varchar(6) NOT NULL,
  `Nama_Barang` varchar(50) NOT NULL,
  `Harga_Barang` int(11) NOT NULL,
  `Jumlah_Barang` int(11) NOT NULL,
  `Satuan_Barang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`Kode_Barang`, `Nama_Barang`, `Harga_Barang`, `Jumlah_Barang`, `Satuan_Barang`) VALUES
('BRG001', 'gunting', 15000, 27, 'PCS'),
('BRG002', 'SABUN', 6000, 82, 'PCS'),
('BRG003', 'PANCI', 35000, 59, 'PCS'),
('BRG004', 'baju', 100000, 100, 'PCS'),
('BRG005', 'KOPI', 50000, 40, 'PCS');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailjual`
--

CREATE TABLE `tbl_detailjual` (
  `No_Jual` varchar(10) NOT NULL,
  `Kode_Barang` varchar(6) NOT NULL,
  `Nama_Barang` varchar(50) NOT NULL,
  `Harga_Jual` int(11) NOT NULL,
  `Jumlah_Jual` int(11) NOT NULL,
  `Sub_Total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_detailjual`
--

INSERT INTO `tbl_detailjual` (`No_Jual`, `Kode_Barang`, `Nama_Barang`, `Harga_Jual`, `Jumlah_Jual`, `Sub_Total`) VALUES
('J221205001', 'BRG001', 'gunting', 15000, 4, 60000),
('J221205001', 'BRG003', 'PANCI', 35000, 2, 70000),
('J221205002', 'BRG002', 'SABUN', 6000, 5, 30000),
('J221205002', 'BRG003', 'PANCI', 35000, 1, 35000),
('J221205003', 'BRG003', 'PANCI', 35000, 4, 140000),
('J221205004', 'BRG001', 'gunting', 15000, 1, 15000),
('J221205005', 'BRG001', 'gunting', 15000, 1, 15000),
('J221205006', 'BRG003', 'PANCI', 35000, 1, 35000),
('J221205007', 'BRG002', 'SABUN', 6000, 22, 132000),
('J221205008', 'BRG001', 'gunting', 15000, 2, 30000),
('J221205009', 'BRG001', 'gunting', 15000, 4, 60000),
('J221205009', 'BRG002', 'SABUN', 6000, 6, 36000),
('J221205009', 'BRG003', 'PANCI', 35000, 3, 105000),
('J221205010', 'BRG002', 'SABUN', 6000, 3, 18000),
('J221205011', 'BRG003', 'PANCI', 35000, 1, 35000),
('J221205012', 'BRG002', 'SABUN', 6000, 2, 12000),
('J221205013', 'BRG001', 'gunting', 15000, 3, 45000),
('J221205014', 'BRG003', 'PANCI', 35000, 4, 140000),
('J221207015', 'BRG001', 'gunting', 15000, 5, 75000),
('J221207016', 'BRG001', 'gunting', 15000, 5, 75000),
('J221207017', 'BRG001', 'gunting', 15000, 2, 30000),
('J221207018', 'BRG001', 'gunting', 15000, 5, 75000),
('J221213019', 'BRG001', 'gunting', 15000, 4, 60000),
('J221215020', 'BRG001', 'gunting', 15000, 5, 75000),
('J221215021', 'BRG001', 'gunting', 15000, 4, 60000),
('J221215021', 'BRG003', 'PANCI', 35000, 12, 420000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `No_Jual` varchar(10) NOT NULL,
  `Tgl_Jual` date NOT NULL,
  `Jam_Jual` varchar(10) NOT NULL,
  `Item_Jual` int(11) NOT NULL,
  `Total_Jual` int(11) NOT NULL,
  `Dibayar` int(11) NOT NULL,
  `Kembali` int(11) NOT NULL,
  `Kode_Pelanggan` varchar(6) NOT NULL,
  `Kode_Admin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jual`
--

INSERT INTO `tbl_jual` (`No_Jual`, `Tgl_Jual`, `Jam_Jual`, `Item_Jual`, `Total_Jual`, `Dibayar`, `Kembali`, `Kode_Pelanggan`, `Kode_Admin`) VALUES
('J221205001', '2022-12-05', '2022-12-05', 6, 0, 150000, 20000, 'PLG002', 'ADM001'),
('J221205002', '2022-12-05', '2022-12-05', 6, 0, 100000, 35000, 'PLG001', 'ADM001'),
('J221205003', '2022-12-05', '2022-12-05', 4, 0, 400000, 260000, 'PLG001', ''),
('J221205004', '2022-12-05', '2022-12-05', 1, 0, 20000, 5000, 'PLG001', ''),
('J221205005', '2022-12-05', '2022-12-05', 1, 0, 16000, 1000, 'PLG001', 'ADM001'),
('J221205006', '2022-12-05', '2022-12-05', 1, 0, 36000, 1000, 'PLG001', 'ADM001'),
('J221205007', '2022-12-05', '2022-12-05', 22, 0, 135000, 3000, 'PLG001', 'ADM001'),
('J221205008', '2022-12-05', '2022-12-05', 2, 0, 30000, 0, 'PLG002', 'ADM001'),
('J221205009', '2022-12-05', '2022-12-05', 13, 0, 250000, 49000, 'PLG001', 'ADM001'),
('J221205010', '2022-12-05', '2022-12-05', 3, 0, 20000, 2000, 'PLG002', 'ADM001'),
('J221205011', '2022-12-05', '2022-12-05', 1, 0, 40000, 5000, 'PLG001', ''),
('J221205012', '2022-12-05', '2022-12-05', 2, 0, 15000, 3000, 'PLG001', 'ADM001'),
('J221205013', '2022-12-05', '17.34.22', 3, 0, 50000, 5000, 'PLG001', ''),
('J221205014', '2022-12-05', '17.35.03', 4, 0, 150000, 10000, 'PLG002', 'ADM001'),
('J221207015', '2022-12-07', '10.15.44', 5, 0, 75000, 0, 'PLG001', 'ADM001'),
('J221207016', '2022-12-07', '15.34.24', 5, 75000, 75000, 0, 'PLG001', 'ADM001'),
('J221207017', '2022-12-07', '15.49.21', 2, 30000, 30000, 0, 'PLG002', 'ADM001'),
('J221207018', '2022-12-07', '15.59.15', 5, 75000, 75000, 0, 'PLG001', 'ADM001'),
('J221213019', '2022-12-13', '18.11.58', 4, 60000, 60000, 0, 'PLG001', ''),
('J221215020', '2022-12-15', '12.34.32', 5, 75000, 80000, 5000, 'PLG001', 'ADM001'),
('J221215021', '2022-12-15', '18.17.20', 16, 480000, 500000, 20000, 'PLG001', 'ADM001');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `Kode_Pelanggan` varchar(6) NOT NULL,
  `Nama_Pelanggan` varchar(50) NOT NULL,
  `Alamat_Pelanggan` varchar(100) NOT NULL,
  `Telpon_Pelanggan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`Kode_Pelanggan`, `Nama_Pelanggan`, `Alamat_Pelanggan`, `Telpon_Pelanggan`) VALUES
('PLG001', 'IZET', 'GERUNG', '089765432112'),
('PLG002', 'NASRULOH', 'JOTANG', '0852654657');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`Kode_Admin`);

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`Kode_Barang`);

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`No_Jual`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`Kode_Pelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
