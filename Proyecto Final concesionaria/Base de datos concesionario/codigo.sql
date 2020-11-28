-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema ConcesionarioDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ConcesionarioDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ConcesionarioDB` DEFAULT CHARACTER SET utf8 ;
USE `ConcesionarioDB` ;

-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Sucuarsal_principal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Sucuarsal_principal` (
  `idSucuarsal` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Telefono` INT NOT NULL,
  `Correo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idSucuarsal`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Empleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Empleados` (
  `idEmpleados` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellidos` VARCHAR(45) NOT NULL,
  `Fecha de ingreso` DATE NOT NULL,
  `telefono` INT NOT NULL,
  `Empleadoscol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idEmpleados`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Clientes` (
  `idClientes` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `Telefono` VARCHAR(45) NOT NULL,
  `Correo` VARCHAR(45) NULL,
  `Edad` INT NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Sexo` VARCHAR(45) NOT NULL,
  `FechaNacimiento` DATE NOT NULL,
  `RFC` VARCHAR(45) NOT NULL,
  `ReferenciaUno` VARCHAR(45) NOT NULL,
  `ReferenciaDos` VARCHAR(45) NOT NULL,
  `ReferenciaTres` VARCHAR(45) NOT NULL,
  `NumRefUno` INT NOT NULL,
  `NumRedDos` INT NOT NULL,
  `NumRefTres` INT NOT NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Automoviles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Automoviles` (
  `idAutomoviles` INT NOT NULL,
  `Marca` VARCHAR(45) NOT NULL,
  `Modelo` VARCHAR(45) NOT NULL,
  `Color` VARCHAR(45) NOT NULL,
  `Año` VARCHAR(45) NOT NULL,
  `FechaAdquisicion` VARCHAR(45) NOT NULL,
  `Precio` INT NOT NULL,
  `Sucursal` INT NOT NULL,
  PRIMARY KEY (`idAutomoviles`),
  INDEX `Sucursal_idx` (`Sucursal` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Autopartes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Autopartes` (
  `idAutopartes` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Modelo` VARCHAR(45) NOT NULL,
  `Cantidad` INT NOT NULL,
  `Sucursal` INT NOT NULL,
  PRIMARY KEY (`idAutopartes`),
  INDEX `Sucursal_idx` (`Sucursal` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Sucursal_Secundaria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Sucursal_Secundaria` (
  `idSucursal_Secundaria` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Telefono` INT NOT NULL,
  `Correo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idSucursal_Secundaria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`TraspasoSaS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`TraspasoSaS` (
  `idTraspasoSaS` INT NOT NULL,
  `SucurdalEntrega` INT NOT NULL,
  `SucursalRecbe` INT NOT NULL,
  `TipoTraspaso` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTraspasoSaS`),
  INDEX `SucursalR_idx` (`SucursalRecbe` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Compra-venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Compra-venta` (
  `idCompra-venta` INT NOT NULL,
  `Cliente` INT NOT NULL,
  `Fecha` DATE NOT NULL,
  `TipoFinanciamiento` VARCHAR(45) NOT NULL,
  `Total` DOUBLE NOT NULL,
  PRIMARY KEY (`idCompra-venta`),
  INDEX `Cliente_idx` (`Cliente` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Detalle_Compra_Venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Detalle_Compra_Venta` (
  `idDetalle_Compra_Venta` INT NOT NULL,
  `Automovil` INT NOT NULL,
  `Cantidad` INT NOT NULL,
  `precio` VARCHAR(45) NOT NULL,
  `IdCompraventa` INT NOT NULL,
  `Accesorios` INT NOT NULL,
  PRIMARY KEY (`idDetalle_Compra_Venta`),
  INDEX `Compreventa_idx` (`IdCompraventa` ASC) VISIBLE,
  INDEX `Automovil_idx` (`Automovil` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ConcesionarioDB`.`Detalle_Traspaso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ConcesionarioDB`.`Detalle_Traspaso` (
  `idDetalle_Traspaso` INT NOT NULL,
  `IdTraspasoSAS` INT NOT NULL,
  `Autoparte` INT NOT NULL,
  `Cantidad` INT NOT NULL,
  `Automovil` INT NOT NULL,
  PRIMARY KEY (`idDetalle_Traspaso`),
  INDEX `Traspaso_idx` (`IdTraspasoSAS` ASC) VISIBLE,
  INDEX `Autoparte_idx` (`Autoparte` ASC) VISIBLE,
  INDEX `Automovil_idx` (`Automovil` ASC) VISIBLE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
