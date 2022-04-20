#Creación de la base de datos

CREATE DATABASE `lionsstest` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

#Creación de tabla para almacenar las reservas

CREATE TABLE `tblReserva` (
  `Reserva_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Sala_ID` int(11) NOT NULL,
  `InicioRenta` datetime DEFAULT NULL,
  `FinRenta` datetime DEFAULT NULL,
  `Activa` bit(1) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  PRIMARY KEY (`Reserva_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#Creación de tabla para la lista de salas

CREATE TABLE `tblSalas` (
  `Sala_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Sala` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`Sala_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

#Procedimiento para cancelar reserva de salas

CREATE DEFINER=`liontest`@`%` PROCEDURE `lionsstest`.`RevRenta`()
BEGIN 
	UPDATE tblReserva r SET r.Activa = 0 WHERE r.Activa = 1 AND r.FinRenta < Now();
END;

#Evento programado para ejecutar el procedimiento

CREATE EVENT SchRevRent
ON SCHEDULE EVERY 15 MINUTE
STARTS '2022-04-19 00:00:00.000'
ON COMPLETION PRESERVE
ENABLE
DO CALL RevRenta;


