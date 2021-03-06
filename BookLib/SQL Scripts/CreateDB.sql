-- MySQL Script generated by MySQL Workbench
-- 01/19/16 11:04:11
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema booklib
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `booklib` ;

-- -----------------------------------------------------
-- Schema booklib
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `booklib` DEFAULT CHARACTER SET utf8 ;
USE `booklib` ;

-- -----------------------------------------------------
-- Table `booklib`.`authors`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `booklib`.`authors` ;

CREATE TABLE IF NOT EXISTS `booklib`.`authors` (
  `AuthorID` INT(11) NOT NULL AUTO_INCREMENT,
  `AuthorName` VARCHAR(45) NULL DEFAULT NULL,
  `AuthorSurname` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`AuthorID`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `booklib`.`books`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `booklib`.`books` ;

CREATE TABLE IF NOT EXISTS `booklib`.`books` (
  `BookID` INT(11) NOT NULL AUTO_INCREMENT,
  `BookName` VARCHAR(45) NULL DEFAULT NULL,
  `AuthorID` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`BookID`),
  CONSTRAINT `FB_Author`
    FOREIGN KEY (`AuthorID`)
    REFERENCES `booklib`.`authors` (`AuthorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;

CREATE UNIQUE INDEX `BookName_UNIQUE` ON `booklib`.`books` (`BookName` ASC);

CREATE INDEX `FK_Author_idx` ON `booklib`.`books` (`AuthorID` ASC);


-- -----------------------------------------------------
-- Table `booklib`.`categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `booklib`.`categories` ;

CREATE TABLE IF NOT EXISTS `booklib`.`categories` (
  `CategoryID` INT(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`CategoryID`))
ENGINE = InnoDB
AUTO_INCREMENT = 14
DEFAULT CHARACTER SET = utf8;

CREATE UNIQUE INDEX `CategoryName_UNIQUE` ON `booklib`.`categories` (`CategoryName` ASC);


-- -----------------------------------------------------
-- Table `booklib`.`lib_control`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `booklib`.`lib_control` ;

CREATE TABLE IF NOT EXISTS `booklib`.`lib_control` (
  `Lib_Control_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `New_Book_Dir` VARCHAR(100) NULL DEFAULT NULL,
  `Reviewed_Book_Dir` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Lib_Control_ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
