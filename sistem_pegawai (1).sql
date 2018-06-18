-- Adminer 4.3.1 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `absensi`;
CREATE TABLE `absensi` (
  `NIP` decimal(10,0) NOT NULL,
  `Hari_Masuk` date NOT NULL,
  `JamMasuk` time NOT NULL,
  `JamKeluar` time NOT NULL,
  KEY `NIP` (`NIP`),
  CONSTRAINT `absensi_ibfk_1` FOREIGN KEY (`NIP`) REFERENCES `pegawai` (`NIP`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;


DROP TABLE IF EXISTS `cuti`;
CREATE TABLE `cuti` (
  `NIP` decimal(10,0) NOT NULL,
  `Tanggal_Mulai` date NOT NULL,
  `Tanggal_Selesai` date NOT NULL,
  `Keperluan` text COLLATE ascii_bin NOT NULL,
  KEY `NIP` (`NIP`),
  CONSTRAINT `cuti_ibfk_1` FOREIGN KEY (`NIP`) REFERENCES `pegawai` (`NIP`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;


DROP TABLE IF EXISTS `divisi`;
CREATE TABLE `divisi` (
  `KodeDiv` varchar(20) COLLATE ascii_bin NOT NULL,
  `NamaDiv` varchar(50) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`KodeDiv`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `divisi` (`KodeDiv`, `NamaDiv`) VALUES
('D0001',	'Divisi Pemasaran'),
('D0002',	'Divisi Personalia'),
('D0003',	'Divisi Umum'),
('D0004',	'Divisi Keuangan');

DROP TABLE IF EXISTS `jabatan`;
CREATE TABLE `jabatan` (
  `KodeJabat` varchar(20) COLLATE ascii_bin NOT NULL,
  `NamaJabat` varchar(50) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`KodeJabat`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `jabatan` (`KodeJabat`, `NamaJabat`) VALUES
('J0001',	'Direksi'),
('J0002',	'Direktur Utama'),
('J0003',	'Direktur Keuangan'),
('J0004',	'Direktur Personalia'),
('J0005',	'Direktur'),
('J0006',	'Manager'),
('J0007',	'Manager Personalia'),
('J0008',	'Manager Pemasaran'),
('J0009',	'Manager Keuangan');

DROP TABLE IF EXISTS `pegawai`;
CREATE TABLE `pegawai` (
  `NIP` decimal(10,0) NOT NULL,
  `NamaDepan` varchar(100) COLLATE ascii_bin NOT NULL,
  `NamaBelakang` varchar(100) COLLATE ascii_bin NOT NULL,
  `JenisKelamin` enum('Laki-Laki','Perempuan') COLLATE ascii_bin NOT NULL,
  `TempatLahir` varchar(100) COLLATE ascii_bin NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Alamat` varchar(500) COLLATE ascii_bin NOT NULL,
  `Status_alamat` enum('Kontrak','Indekos','Milik Sendiri','Milik Orangtua') COLLATE ascii_bin NOT NULL,
  `Agama` enum('Islam','Kristen Protestan','Katolik','Buddha','Hindu','Konghucu') COLLATE ascii_bin NOT NULL,
  `NoTelp` decimal(10,0) NOT NULL,
  `Pendidikan` varchar(100) COLLATE ascii_bin NOT NULL,
  `GolDarah` enum('A','B','O','AB') COLLATE ascii_bin DEFAULT NULL,
  `NoKTP` decimal(10,0) DEFAULT NULL,
  `SIM` enum('A','B','C') COLLATE ascii_bin DEFAULT NULL,
  `NoSIM` decimal(10,0) DEFAULT NULL,
  `No_NPWP` decimal(10,0) DEFAULT NULL,
  `KodeDiv` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `KodeJabat` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `TglMasuk` date DEFAULT NULL,
  `NoRek` decimal(10,0) DEFAULT NULL,
  `NamaBank` enum('BCA','BRI','BNI','Mandiri') COLLATE ascii_bin DEFAULT NULL,
  `CabangBank` varchar(50) COLLATE ascii_bin DEFAULT NULL,
  PRIMARY KEY (`NIP`),
  KEY `KodeJabat` (`KodeJabat`),
  KEY `KodeDiv` (`KodeDiv`),
  CONSTRAINT `pegawai_ibfk_1` FOREIGN KEY (`KodeJabat`) REFERENCES `jabatan` (`KodeJabat`),
  CONSTRAINT `pegawai_ibfk_2` FOREIGN KEY (`KodeDiv`) REFERENCES `divisi` (`KodeDiv`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;


DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `username` varchar(20) COLLATE ascii_bin NOT NULL,
  `password` varchar(20) COLLATE ascii_bin NOT NULL,
  `level` varchar(50) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `user` (`username`, `password`, `level`) VALUES
('admin',	'admin123',	'admin'),
('pegawai',	'pegawai123',	'pegawai');

-- 2018-06-05 10:58:50
