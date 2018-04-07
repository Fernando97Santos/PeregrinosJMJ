CREATE DATABASE `peregrinosjmj`;
USE `peregrinosjmj`;

CREATE TABLE `Usuarios` (

`id_usuario` int NOT NULL AUTO_INCREMENT,

`username` varchar(255) NOT NULL,

`contra` varchar(255) NOT NULL,

`id_peregrino` int NOT NULL,

PRIMARY KEY (`id_usuario`) 

);



CREATE TABLE `Actividades` (

`id_actividad` int NOT NULL AUTO_INCREMENT,

`actividad` varchar(255) NOT NULL,

`fecha` date NOT NULL,

`lugar` varchar(255) NOT NULL,

`ganacia` float NULL,

PRIMARY KEY (`id_actividad`) 

);



CREATE TABLE `Inversion` (

`id_inversion` int(255) NOT NULL AUTO_INCREMENT,

`producto` varchar(255) NOT NULL,

`monto` float NOT NULL,

`id_actividad` int NOT NULL,

PRIMARY KEY (`id_inversion`) 

);



CREATE TABLE `Peregrinos` (

`id_peregrino` int NOT NULL AUTO_INCREMENT,

`nombres` varchar(255) NOT NULL,

`apellidos` varchar(255) NOT NULL,

`edad` int NOT NULL,

`sexo` char(1) NOT NULL,

`correo` varchar(255) NULL,

`tele_casa` char(9) NULL,

`tele_celu` char(9) NULL,

`ministerio` varchar(255) NULL,

`jmj` char(1) NOT NULL,

PRIMARY KEY (`id_peregrino`) 

);



CREATE TABLE `Asistencia` (

`id_asistencia` int NOT NULL AUTO_INCREMENT,

`pre-asis` int NULL,

`asis` int NULL,

`id_actividad` int NOT NULL,

`id_peregrino` int NOT NULL,

PRIMARY KEY (`id_asistencia`) 

);





ALTER TABLE `Inversion` ADD CONSTRAINT `fk_id_actividad` FOREIGN KEY (`id_actividad`) REFERENCES `Actividades` (`id_actividad`);

ALTER TABLE `Usuarios` ADD CONSTRAINT `fk_id_peregrino` FOREIGN KEY (`id_peregrino`) REFERENCES `Peregrinos` (`id_peregrino`);

ALTER TABLE `Asistencia` ADD CONSTRAINT `fk_id_actividad_2` FOREIGN KEY (`id_actividad`) REFERENCES `Actividades` (`id_actividad`);

ALTER TABLE `Asistencia` ADD CONSTRAINT `fk_id_peregrino_2` FOREIGN KEY (`id_peregrino`) REFERENCES `Peregrinos` (`id_peregrino`);



