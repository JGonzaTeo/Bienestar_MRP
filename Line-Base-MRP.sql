CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.34-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `costosdefabricacion`
--

DROP TABLE IF EXISTS `costosdefabricacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `costosdefabricacion` (
  `pkidcostosdefabricacion` int(11) NOT NULL,
  `pkidprocesoproduccion` int(11) DEFAULT NULL,
  `costototal` double DEFAULT NULL,
  PRIMARY KEY (`pkidcostosdefabricacion`),
  KEY `fk_costosdefabricacion_procesoproduccion1_idx` (`pkidprocesoproduccion`),
  CONSTRAINT `fk_costosdefabricacion_procesoproduccion1` FOREIGN KEY (`pkidprocesoproduccion`) REFERENCES `procesoproduccion` (`pkidprocesoproduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `costosdefabricacion`
--

LOCK TABLES `costosdefabricacion` WRITE;
/*!40000 ALTER TABLE `costosdefabricacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `costosdefabricacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_contable`
--

DROP TABLE IF EXISTS `cuenta_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuenta_contable` (
  `pkid_cuenta` int(11) NOT NULL,
  PRIMARY KEY (`pkid_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_contable`
--

LOCK TABLES `cuenta_contable` WRITE;
/*!40000 ALTER TABLE `cuenta_contable` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_produccion`
--

DROP TABLE IF EXISTS `detalle_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_produccion` (
  `pkidencabezadop` int(11) NOT NULL,
  `pkidformula` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkidencabezadop`),
  KEY `fk_detalle_produccion_formula1_idx` (`pkidformula`),
  CONSTRAINT `fk_detalle_produccion_formula1` FOREIGN KEY (`pkidformula`) REFERENCES `formula` (`pkidformula`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_produccion`
--

LOCK TABLES `detalle_produccion` WRITE;
/*!40000 ALTER TABLE `detalle_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_produccion`
--

DROP TABLE IF EXISTS `encabezado_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_produccion` (
  `pkidencabezadop` int(11) NOT NULL,
  `pkidepedido` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkidencabezadop`),
  KEY `fk_encabezado_produccion_pedido1_idx` (`pkidepedido`),
  CONSTRAINT `fk_encabezado_produccion_detalle_produccion1` FOREIGN KEY (`pkidencabezadop`) REFERENCES `detalle_produccion` (`pkidencabezadop`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_encabezado_produccion_pedido1` FOREIGN KEY (`pkidepedido`) REFERENCES `pedido` (`pkidepedido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_produccion`
--

LOCK TABLES `encabezado_produccion` WRITE;
/*!40000 ALTER TABLE `encabezado_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradas_salidas`
--

DROP TABLE IF EXISTS `entradas_salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entradas_salidas` (
  `pkidentradaysalida` int(11) NOT NULL,
  `pkidemaestroactivos` int(11) DEFAULT NULL,
  `movimiento` tinyint(2) DEFAULT NULL,
  `pkidempleado` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `pkidenbezadop` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidentradaysalida`),
  KEY `fk_entradas_salidas_encabezado_produccion1_idx` (`pkidenbezadop`),
  KEY `fk_entradas_salidas_maestroactivos1_idx` (`pkidemaestroactivos`),
  CONSTRAINT `fk_entradas_salidas_encabezado_produccion1` FOREIGN KEY (`pkidenbezadop`) REFERENCES `encabezado_produccion` (`pkidencabezadop`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_entradas_salidas_maestroactivos1` FOREIGN KEY (`pkidemaestroactivos`) REFERENCES `maestroactivos` (`pkidmaestroactivos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradas_salidas`
--

LOCK TABLES `entradas_salidas` WRITE;
/*!40000 ALTER TABLE `entradas_salidas` DISABLE KEYS */;
/*!40000 ALTER TABLE `entradas_salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estacion`
--

DROP TABLE IF EXISTS `estacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estacion` (
  `pkidestacion` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  `pkidempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidestacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estacion`
--

LOCK TABLES `estacion` WRITE;
/*!40000 ALTER TABLE `estacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `estacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estandardecalidad`
--

DROP TABLE IF EXISTS `estandardecalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estandardecalidad` (
  `pkidestandardecalidad` int(11) NOT NULL,
  `categoria` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidestandardecalidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estandardecalidad`
--

LOCK TABLES `estandardecalidad` WRITE;
/*!40000 ALTER TABLE `estandardecalidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `estandardecalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formula`
--

DROP TABLE IF EXISTS `formula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formula` (
  `pkidformula` int(11) NOT NULL,
  `producto_fabricar` int(11) DEFAULT NULL,
  `producto_mp` double DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkidformula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formula`
--

LOCK TABLES `formula` WRITE;
/*!40000 ALTER TABLE `formula` DISABLE KEYS */;
/*!40000 ALTER TABLE `formula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maestroactivos`
--

DROP TABLE IF EXISTS `maestroactivos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maestroactivos` (
  `pkidmaestroactivos` int(11) NOT NULL,
  `pkidproducto` int(11) DEFAULT NULL,
  `existencia_actual` double DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  `stock_minimo` double DEFAULT NULL,
  `stock_maximo` double DEFAULT NULL,
  PRIMARY KEY (`pkidmaestroactivos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestroactivos`
--

LOCK TABLES `maestroactivos` WRITE;
/*!40000 ALTER TABLE `maestroactivos` DISABLE KEYS */;
/*!40000 ALTER TABLE `maestroactivos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `merma`
--

DROP TABLE IF EXISTS `merma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `merma` (
  `pkidmerma` int(11) NOT NULL AUTO_INCREMENT,
  `producto_merma` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidmerma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `merma`
--

LOCK TABLES `merma` WRITE;
/*!40000 ALTER TABLE `merma` DISABLE KEYS */;
/*!40000 ALTER TABLE `merma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden de produccion`
--

DROP TABLE IF EXISTS `orden de produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orden de produccion` (
  `pkidordenproduccion` int(11) NOT NULL,
  `fecha_realzacion` date DEFAULT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `detalle` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkidordenproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden de produccion`
--

LOCK TABLES `orden de produccion` WRITE;
/*!40000 ALTER TABLE `orden de produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `orden de produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `pkidepedido` int(11) NOT NULL,
  `clasficacion` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  `pkidempleado` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `pkidordenproduccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidepedido`),
  KEY `fk_pedido_Orden de produccion1_idx` (`pkidordenproduccion`),
  CONSTRAINT `fk_pedido_Orden de produccion1` FOREIGN KEY (`pkidordenproduccion`) REFERENCES `orden de produccion` (`pkidordenproduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_detalle`
--

DROP TABLE IF EXISTS `poliza_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_detalle` (
  `cod_linea` int(11) NOT NULL AUTO_INCREMENT,
  `pkid_poliza` int(11) NOT NULL,
  `pkid_cuenta` int(11) DEFAULT NULL,
  `debe` double DEFAULT NULL,
  `haber` double DEFAULT NULL,
  `estadi` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`cod_linea`,`pkid_poliza`),
  KEY `fk_poliza_detalle_cuenta_contable1_idx` (`pkid_cuenta`),
  KEY `fk_poliza_detalle_poliza_encabezado1_idx` (`pkid_poliza`),
  CONSTRAINT `fk_poliza_detalle_cuenta_contable1` FOREIGN KEY (`pkid_cuenta`) REFERENCES `cuenta_contable` (`pkid_cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_poliza_detalle_poliza_encabezado1` FOREIGN KEY (`pkid_poliza`) REFERENCES `poliza_encabezado` (`pkid_poliza`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_detalle`
--

LOCK TABLES `poliza_detalle` WRITE;
/*!40000 ALTER TABLE `poliza_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `poliza_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_encabezado`
--

DROP TABLE IF EXISTS `poliza_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_encabezado` (
  `pkid_poliza` int(11) NOT NULL,
  ` fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkid_poliza`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_encabezado`
--

LOCK TABLES `poliza_encabezado` WRITE;
/*!40000 ALTER TABLE `poliza_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `poliza_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `procesoproduccion`
--

DROP TABLE IF EXISTS `procesoproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `procesoproduccion` (
  `pkidprocesoproduccion` int(11) NOT NULL,
  `pkidencabezadop` int(11) DEFAULT NULL,
  `pkidestacion` int(11) DEFAULT NULL,
  `linea` int(11) NOT NULL,
  PRIMARY KEY (`pkidprocesoproduccion`,`linea`),
  KEY `fk_procesoproduccion_encabezado_produccion1_idx` (`pkidencabezadop`),
  KEY `fk_procesoproduccion_estacion1_idx` (`pkidestacion`),
  CONSTRAINT `fk_procesoproduccion_encabezado_produccion1` FOREIGN KEY (`pkidencabezadop`) REFERENCES `encabezado_produccion` (`pkidencabezadop`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_procesoproduccion_estacion1` FOREIGN KEY (`pkidestacion`) REFERENCES `estacion` (`pkidestacion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procesoproduccion`
--

LOCK TABLES `procesoproduccion` WRITE;
/*!40000 ALTER TABLE `procesoproduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `procesoproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_control_calidad`
--

DROP TABLE IF EXISTS `producto_control_calidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_control_calidad` (
  `pkidproducto_control_calidad` int(11) NOT NULL AUTO_INCREMENT,
  `pkidprocesoproduccion` int(11) DEFAULT NULL,
  `pkidestandardecalidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidproducto_control_calidad`),
  KEY `fk_producto_control_calidad_procesoproduccion1_idx` (`pkidprocesoproduccion`),
  KEY `fk_producto_control_calidad_estandardecalidad1_idx` (`pkidestandardecalidad`),
  CONSTRAINT `fk_producto_control_calidad_estandardecalidad1` FOREIGN KEY (`pkidestandardecalidad`) REFERENCES `estandardecalidad` (`pkidestandardecalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_control_calidad_procesoproduccion1` FOREIGN KEY (`pkidprocesoproduccion`) REFERENCES `procesoproduccion` (`pkidprocesoproduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_control_calidad`
--

LOCK TABLES `producto_control_calidad` WRITE;
/*!40000 ALTER TABLE `producto_control_calidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto_control_calidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-02 22:27:17
