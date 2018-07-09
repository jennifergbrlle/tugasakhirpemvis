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
  `JamKeluar` time DEFAULT NULL,
  KEY `NIP` (`NIP`),
  CONSTRAINT `absensi_ibfk_2` FOREIGN KEY (`NIP`) REFERENCES `pegawai` (`NIP`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `absensi` (`NIP`, `Hari_Masuk`, `JamMasuk`, `JamKeluar`) VALUES
(102,	'2018-06-20',	'12:49:59',	'22:09:39'),
(1,	'2018-06-21',	'22:58:22',	'23:01:15'),
(102,	'2018-06-21',	'22:58:40',	'23:02:49'),
(1597,	'2018-06-24',	'23:30:05',	NULL);

DROP TABLE IF EXISTS `cuti`;
CREATE TABLE `cuti` (
  `NIP` decimal(10,0) NOT NULL,
  `Tanggal_Mulai` date NOT NULL,
  `Tanggal_Selesai` date NOT NULL,
  `Keperluan` text COLLATE ascii_bin NOT NULL,
  `Status` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  KEY `NIP` (`NIP`),
  CONSTRAINT `cuti_ibfk_2` FOREIGN KEY (`NIP`) REFERENCES `pegawai` (`NIP`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `cuti` (`NIP`, `Tanggal_Mulai`, `Tanggal_Selesai`, `Keperluan`, `Status`) VALUES
(102,	'2018-06-21',	'2018-06-28',	'asd',	NULL),
(1,	'2018-06-23',	'2018-06-25',	'adea',	'disetujui');

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

DROP VIEW IF EXISTS `employeeinfo`;
CREATE TABLE `employeeinfo` (`NIP` decimal(10,0), `NamaPegawai` varchar(101), `Jeniskelamin` enum('Laki-Laki','Perempuan'), `TempatTglLahir` varchar(112), `Agama` enum('Islam','Kristen Protestan','Katolik','Buddha','Hindu','Konghucu'), `Pendidikan` enum('SD','SMP','SMA/SMK','D3','S1','S2','S3'), `Alamat` varchar(150), `Status_alamat` enum('Kontrak','Indekos','Milik Sendiri','Milik Orangtua'), `NoTelp` varchar(15), `GolDarah` enum('A','B','O','AB'), `NamaDiv` varchar(50), `NamaJabat` varchar(50), `TglMasuk` varchar(10), `NoKTP` varchar(15), `NoSIM` varchar(15), `No_NPWP` varchar(15), `NoRek` varchar(15), `NamaRek` varchar(50), `NamaBank` enum('BCA','BRI','BNI','Mandiri'), `CabangBank` varchar(50), `JatahCuti` int(10), `flag` int(2));


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
  `NamaDepan` varchar(50) COLLATE ascii_bin NOT NULL,
  `NamaBelakang` varchar(50) COLLATE ascii_bin NOT NULL,
  `JenisKelamin` enum('Laki-Laki','Perempuan') COLLATE ascii_bin NOT NULL,
  `TempatLahir` varchar(100) COLLATE ascii_bin NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Alamat` varchar(150) COLLATE ascii_bin NOT NULL,
  `Status_alamat` enum('Kontrak','Indekos','Milik Sendiri','Milik Orangtua') COLLATE ascii_bin NOT NULL,
  `Agama` enum('Islam','Kristen Protestan','Katolik','Buddha','Hindu','Konghucu') COLLATE ascii_bin NOT NULL,
  `NoTelp` varchar(15) COLLATE ascii_bin NOT NULL,
  `Pendidikan` enum('SD','SMP','SMA/SMK','D3','S1','S2','S3') COLLATE ascii_bin NOT NULL,
  `GolDarah` enum('A','B','O','AB') COLLATE ascii_bin NOT NULL,
  `NoKTP` varchar(15) COLLATE ascii_bin NOT NULL,
  `NoSIM` varchar(15) COLLATE ascii_bin NOT NULL,
  `No_NPWP` varchar(15) COLLATE ascii_bin NOT NULL,
  `KodeDiv` varchar(20) COLLATE ascii_bin NOT NULL,
  `KodeJabat` varchar(20) COLLATE ascii_bin NOT NULL,
  `TglMasuk` date NOT NULL,
  `NoRek` varchar(15) COLLATE ascii_bin NOT NULL,
  `NamaRek` varchar(50) COLLATE ascii_bin NOT NULL,
  `NamaBank` enum('BCA','BRI','BNI','Mandiri') COLLATE ascii_bin NOT NULL,
  `CabangBank` varchar(50) COLLATE ascii_bin NOT NULL,
  `JatahCuti` int(10) NOT NULL DEFAULT '12',
  `Flag` int(2) NOT NULL DEFAULT '1',
  PRIMARY KEY (`NIP`),
  KEY `KodeJabat` (`KodeJabat`),
  KEY `KodeDiv` (`KodeDiv`),
  CONSTRAINT `pegawai_ibfk_1` FOREIGN KEY (`KodeJabat`) REFERENCES `jabatan` (`KodeJabat`),
  CONSTRAINT `pegawai_ibfk_2` FOREIGN KEY (`KodeDiv`) REFERENCES `divisi` (`KodeDiv`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `pegawai` (`NIP`, `NamaDepan`, `NamaBelakang`, `JenisKelamin`, `TempatLahir`, `TanggalLahir`, `Alamat`, `Status_alamat`, `Agama`, `NoTelp`, `Pendidikan`, `GolDarah`, `NoKTP`, `NoSIM`, `No_NPWP`, `KodeDiv`, `KodeJabat`, `TglMasuk`, `NoRek`, `NamaRek`, `NamaBank`, `CabangBank`, `JatahCuti`, `Flag`) VALUES
(1,	'Andi',	'Wijaya',	'Laki-Laki',	'Tangerang',	'1978-09-08',	'Jl kenanga',	'Milik Sendiri',	'Islam',	'81273638',	'SD',	'A',	'237971904',	'24910',	'24567',	'D0001',	'J0002',	'2018-06-23',	'123456',	'Andi',	'BCA',	'Tangerang',	0,	1),
(102,	'Anisa',	'D',	'Perempuan',	'Jakarta',	'1985-09-12',	'Jl Madagaskar raya no 12 Kec adase Kota Tangerang',	'Milik Sendiri',	'Kristen Protestan',	'123456',	'SD',	'B',	'567890',	'2345678',	'234568',	'D0002',	'J0002',	'2017-09-09',	'4567890',	'anisa',	'BNI',	'Jakarta',	0,	1),
(1573,	'Jennifer',	'gabrielle',	'Perempuan',	'Tangerang',	'1997-07-02',	'Grand Duta',	'Milik Orangtua',	'Katolik',	'08118450875',	'S1',	'B',	'2345678923456',	'12345678900987',	'34567898765424',	'D0004',	'J0005',	'2017-06-07',	'45677789987567',	'Jenni',	'BCA',	'Tangerang',	12,	1),
(1597,	'Edho',	'Fernando',	'Laki-Laki',	'DKI Jakarta',	'1994-11-02',	'Duri Kosambi',	'Milik Orangtua',	'Kristen Protestan',	'08988886575',	'S1',	'B',	'23456798765433',	'45627820965351',	'25461354645341',	'D0002',	'J0005',	'2018-06-03',	'56783029864793',	'Edho',	'BCA',	'Jakarta',	12,	0),
(1937,	'Angelia',	'Riana',	'Perempuan',	'Tangerang',	'1997-11-12',	'Cimone Permai',	'Milik Orangtua',	'Buddha',	'08129373922',	'S1',	'A',	'4761948618946',	'2461824682846',	'8461898748347',	'D0002',	'J0008',	'2018-06-03',	'8461987487482',	'Angelia',	'BCA',	'Cimone',	12,	0);

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `username` decimal(10,0) NOT NULL,
  `password` varchar(20) COLLATE ascii_bin NOT NULL,
  `level` varchar(50) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `user` (`username`, `password`, `level`) VALUES
(1,	'pegawai01',	'pegawai'),
(102,	'admin01',	'admin'),
(1226,	'Gabrielle1226',	'pegawai'),
(1573,	'gabrielle1573',	'pegawai'),
(1597,	'Fernando1597',	'pegawai'),
(1937,	'Riana1937',	'pegawai');

DROP TABLE IF EXISTS `employeeinfo`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `employeeinfo` AS select `pegawai`.`NIP` AS `NIP`,concat(`pegawai`.`NamaDepan`,' ',`pegawai`.`NamaBelakang`) AS `NamaPegawai`,`pegawai`.`JenisKelamin` AS `Jeniskelamin`,concat(`pegawai`.`TempatLahir`,', ',convert(date_format(`pegawai`.`TanggalLahir`,'%e %m %Y') using ascii)) AS `TempatTglLahir`,`pegawai`.`Agama` AS `Agama`,`pegawai`.`Pendidikan` AS `Pendidikan`,`pegawai`.`Alamat` AS `Alamat`,`pegawai`.`Status_alamat` AS `Status_alamat`,`pegawai`.`NoTelp` AS `NoTelp`,`pegawai`.`GolDarah` AS `GolDarah`,`divisi`.`NamaDiv` AS `NamaDiv`,`jabatan`.`NamaJabat` AS `NamaJabat`,date_format(`pegawai`.`TglMasuk`,'%e %m %Y') AS `TglMasuk`,`pegawai`.`NoKTP` AS `NoKTP`,`pegawai`.`NoSIM` AS `NoSIM`,`pegawai`.`No_NPWP` AS `No_NPWP`,`pegawai`.`NoRek` AS `NoRek`,`pegawai`.`NamaRek` AS `NamaRek`,`pegawai`.`NamaBank` AS `NamaBank`,`pegawai`.`CabangBank` AS `CabangBank`,`pegawai`.`JatahCuti` AS `JatahCuti`,`pegawai`.`Flag` AS `flag` from ((`pegawai` join `divisi`) join `jabatan`) where ((`pegawai`.`KodeDiv` = `divisi`.`KodeDiv`) and (`pegawai`.`KodeJabat` = `jabatan`.`KodeJabat`));

-- 2018-07-09 08:50:09
