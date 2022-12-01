CREATE DATABASE  IF NOT EXISTS `credu` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `credu`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: credu
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `dni_cliente` varchar(18) NOT NULL,
  `nombre` varchar(60) NOT NULL,
  `apellido` varchar(80) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `telefono` varchar(13) NOT NULL,
  PRIMARY KEY (`idCliente`,`dni_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devoluciones` (
  `idDevolucion_d` int NOT NULL AUTO_INCREMENT,
  `nombreLibro_d` varchar(60) NOT NULL,
  `clienteDNI` varchar(18) NOT NULL,
  `empleadoID` varchar(18) NOT NULL,
  `empleadoDNI` varchar(18) NOT NULL,
  `fechaPrestamo` datetime NOT NULL,
  `fechaDevolucion_d` datetime NOT NULL,
  PRIMARY KEY (`idDevolucion_d`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devoluciones`
--

LOCK TABLES `devoluciones` WRITE;
/*!40000 ALTER TABLE `devoluciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `devoluciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idEmpleado` int NOT NULL AUTO_INCREMENT,
  `dni_empleado` varchar(18) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `direccion` varchar(150) NOT NULL,
  `telefono` varchar(40) NOT NULL,
  `correo` varchar(60) NOT NULL,
  PRIMARY KEY (`idEmpleado`,`dni_empleado`),
  UNIQUE KEY `Correo_UNIQUE` (`correo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'ARGNLS01072326H200','Luis Octavio','Armenta Gonzalez','Ignacio Comonfort 263','6381093002','ardenglzlo@hotmail.com'),(2,'RTBNLS01072326H159','Juan','Valdez Gomez','Jaime nuno 748','6381581485','JuanNunoglzlo@hotmail.com');
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradas`
--

DROP TABLE IF EXISTS `entradas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entradas` (
  `codigoArticulo_e` varchar(6) NOT NULL,
  `nombreArticulo_e` varchar(100) NOT NULL,
  `cantidad_e` int NOT NULL,
  `descripcion_e` varchar(80) DEFAULT NULL,
  `fecha_e` varchar(25) NOT NULL,
  `tipo_e` varchar(18) NOT NULL,
  PRIMARY KEY (`codigoArticulo_e`,`nombreArticulo_e`,`cantidad_e`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradas`
--

LOCK TABLES `entradas` WRITE;
/*!40000 ALTER TABLE `entradas` DISABLE KEYS */;
INSERT INTO `entradas` VALUES ('1','Besos',15,'Besotes plebes','2022-11-24 19:14:55','Compra'),('2','Lapices',5,'Hola a todos','2022-11-20 20:37:55','Donación'),('4','Caca',10,'Cacquitas','2022-11-24 18:02:30','Donación'),('6','Ela',20,'mplSVmlsdv','2022-12-01 14:06:21','Compra'),('7','gkg',10,'guktgk','2022-12-01 13:17:23','Compra');
/*!40000 ALTER TABLE `entradas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros`
--

DROP TABLE IF EXISTS `libros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libros` (
  `idLibro_l` int NOT NULL AUTO_INCREMENT,
  `nombre_l` varchar(60) NOT NULL,
  `autor_i` varchar(60) DEFAULT NULL,
  `categoria_i` varchar(30) DEFAULT NULL,
  `idioma_i` varchar(45) DEFAULT NULL,
  `edicion_i` varchar(45) DEFAULT NULL,
  `existencias_i` int NOT NULL,
  PRIMARY KEY (`idLibro_l`,`nombre_l`),
  UNIQUE KEY `nombre_l_UNIQUE` (`nombre_l`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
INSERT INTO `libros` VALUES (1,'don quijote','quijote','cuentos','español','Primera',2);
/*!40000 ALTER TABLE `libros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamos`
--

DROP TABLE IF EXISTS `prestamos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prestamos` (
  `idPrestamo_p` int NOT NULL AUTO_INCREMENT,
  `libros_idLibro_l` int NOT NULL,
  `libros_nombre_l` varchar(60) NOT NULL,
  `clientes_idCliente` int NOT NULL,
  `clientes_dni_cliente` varchar(18) NOT NULL,
  `usuarios_id_usuario` varchar(18) NOT NULL,
  `fechaPrestamo_p` datetime NOT NULL,
  PRIMARY KEY (`idPrestamo_p`),
  KEY `fk_prestamos_usuarios1_idx` (`usuarios_id_usuario`),
  KEY `fk_prestamos_libros1_idx` (`libros_idLibro_l`,`libros_nombre_l`),
  KEY `fk_prestamos_clientes1_idx` (`clientes_idCliente`,`clientes_dni_cliente`),
  CONSTRAINT `fk_prestamos_clientes1` FOREIGN KEY (`clientes_idCliente`, `clientes_dni_cliente`) REFERENCES `clientes` (`idCliente`, `dni_cliente`),
  CONSTRAINT `fk_prestamos_libros1` FOREIGN KEY (`libros_idLibro_l`, `libros_nombre_l`) REFERENCES `libros` (`idLibro_l`, `nombre_l`),
  CONSTRAINT `fk_prestamos_usuarios1` FOREIGN KEY (`usuarios_id_usuario`) REFERENCES `usuarios` (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos`
--

LOCK TABLES `prestamos` WRITE;
/*!40000 ALTER TABLE `prestamos` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `codigo_p` varchar(6) NOT NULL,
  `nombreArticulo_p` varchar(100) NOT NULL,
  `existencias_p` int NOT NULL,
  PRIMARY KEY (`codigo_p`,`nombreArticulo_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salidas`
--

DROP TABLE IF EXISTS `salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salidas` (
  `id_salidas` varchar(6) NOT NULL,
  `nombreArticulo_s` varchar(45) NOT NULL,
  `cantidad_s` int NOT NULL,
  `fecha_s` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salidas`
--

LOCK TABLES `salidas` WRITE;
/*!40000 ALTER TABLE `salidas` DISABLE KEYS */;
INSERT INTO `salidas` VALUES ('1','Besos',3,'01/12/2022'),('7','gkg',10,'01/12/2022'),('6','Ela',10,'01/12/2022'),('6','Ela',10,'01/12/2022');
/*!40000 ALTER TABLE `salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `empleados_idEmpleado` int NOT NULL,
  `id_usuario` varchar(18) NOT NULL,
  `empleados_dni_empleado` varchar(18) NOT NULL,
  `contraseña` varchar(10) NOT NULL,
  `id_tipo` varchar(15) NOT NULL,
  `biblioteca` varchar(2) NOT NULL,
  `inventario` varchar(2) NOT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `id_usuario_UNIQUE` (`id_usuario`),
  KEY `fk_usuarios_empleados1_idx` (`empleados_idEmpleado`,`empleados_dni_empleado`),
  CONSTRAINT `fk_usuarios_empleados1` FOREIGN KEY (`empleados_idEmpleado`, `empleados_dni_empleado`) REFERENCES `empleados` (`idEmpleado`, `dni_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Armenta','ARGNLS01072326H200','1234','Administrador','SI','SI'),(2,'JuanVG','RTBNLS01072326H159','1234','Encargado','SI','SI');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-01 14:09:06
