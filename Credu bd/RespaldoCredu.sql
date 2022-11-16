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
  PRIMARY KEY (`idCliente`,`dni_cliente`),
  UNIQUE KEY `idCliente_UNIQUE` (`idCliente`),
  UNIQUE KEY `dni_cliente_UNIQUE` (`dni_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'GHJNLS01072326T567','Andres','Inzunza Salomon','nose','6381474711'),(3,'GHJNLS01072326T890','Fernando','Rodriguez','nose','6381041526');
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
  `libroID` int NOT NULL,
  `nombreLibro_d` varchar(60) NOT NULL,
  `clienteID` int NOT NULL,
  `clienteDNI` varchar(18) NOT NULL,
  `empleadoID` int NOT NULL,
  `empleadoDNI` varchar(18) NOT NULL,
  `fechaPrestamo` datetime NOT NULL,
  `fechaDevolucion_d` datetime NOT NULL,
  PRIMARY KEY (`idDevolucion_d`),
  UNIQUE KEY `idDevolucion_d_UNIQUE` (`idDevolucion_d`)
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
  UNIQUE KEY `dni_empleado_UNIQUE` (`dni_empleado`),
  UNIQUE KEY `correo_UNIQUE` (`correo`),
  UNIQUE KEY `telefono_UNIQUE` (`telefono`),
  UNIQUE KEY `idEmpleado_UNIQUE` (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'ARGNLS01072326H200','Luis Octavio','Armenta Gonzalez','Ignacio Comonfort 263','6381093002','armenglzlo@hotmail.com');
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
  `fecha_e` datetime NOT NULL,
  `empleadoID` varchar(18) NOT NULL,
  `empleadoDNI` varchar(18) NOT NULL,
  PRIMARY KEY (`codigoArticulo_e`,`nombreArticulo_e`,`cantidad_e`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradas`
--

LOCK TABLES `entradas` WRITE;
/*!40000 ALTER TABLE `entradas` DISABLE KEYS */;
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
  UNIQUE KEY `nombre_l_UNIQUE` (`nombre_l`),
  UNIQUE KEY `idLibro_l_UNIQUE` (`idLibro_l`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
INSERT INTO `libros` VALUES (1,'Luna de Plutón','Dross Rotzank','Arte','Español','Primera',2),(2,'El libro Rojo','James Brown','Arte','Español','Primera',1);
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
  UNIQUE KEY `idPrestamo_p_UNIQUE` (`idPrestamo_p`),
  KEY `fk_prestamos_usuarios1_idx` (`usuarios_id_usuario`),
  KEY `fk_prestamos_libros1_idx` (`libros_idLibro_l`,`libros_nombre_l`),
  KEY `fk_prestamos_clientes1_idx` (`clientes_idCliente`,`clientes_dni_cliente`),
  CONSTRAINT `fk_prestamos_clientes1` FOREIGN KEY (`clientes_idCliente`, `clientes_dni_cliente`) REFERENCES `clientes` (`idCliente`, `dni_cliente`),
  CONSTRAINT `fk_prestamos_libros1` FOREIGN KEY (`libros_idLibro_l`, `libros_nombre_l`) REFERENCES `libros` (`idLibro_l`, `nombre_l`),
  CONSTRAINT `fk_prestamos_usuarios1` FOREIGN KEY (`usuarios_id_usuario`) REFERENCES `usuarios` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos`
--

LOCK TABLES `prestamos` WRITE;
/*!40000 ALTER TABLE `prestamos` DISABLE KEYS */;
INSERT INTO `prestamos` VALUES (1,1,'Luna de Plutón',1,'GHJNLS01072326T567','Armenta','2022-11-13 18:10:27');
/*!40000 ALTER TABLE `prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `entradas_codigoArticulo_e` varchar(6) NOT NULL,
  `entradas_nombreArticulo_e` varchar(100) NOT NULL,
  `entradas_cantidad_e` int NOT NULL,
  `existencias_p` int NOT NULL,
  `salidas_cantidad_s` int NOT NULL,
  KEY `fk_productos_salidas1_idx` (`salidas_cantidad_s`),
  KEY `fk_productos_entradas1_idx` (`entradas_codigoArticulo_e`,`entradas_nombreArticulo_e`,`entradas_cantidad_e`),
  CONSTRAINT `fk_productos_entradas1` FOREIGN KEY (`entradas_codigoArticulo_e`, `entradas_nombreArticulo_e`, `entradas_cantidad_e`) REFERENCES `entradas` (`codigoArticulo_e`, `nombreArticulo_e`, `cantidad_e`),
  CONSTRAINT `fk_productos_salidas1` FOREIGN KEY (`salidas_cantidad_s`) REFERENCES `salidas` (`cantidad_s`)
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
  `cantidad_s` int NOT NULL,
  `fecha_s` datetime NOT NULL,
  `entradas_codigoArticulo_e` varchar(6) NOT NULL,
  `entradas_nombreArticulo_e` varchar(100) NOT NULL,
  `entradas_cantidad_e` int NOT NULL,
  `descripcion_s` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cantidad_s`),
  KEY `fk_salidas_entradas1_idx` (`entradas_codigoArticulo_e`,`entradas_nombreArticulo_e`,`entradas_cantidad_e`),
  CONSTRAINT `fk_salidas_entradas1` FOREIGN KEY (`entradas_codigoArticulo_e`, `entradas_nombreArticulo_e`, `entradas_cantidad_e`) REFERENCES `entradas` (`codigoArticulo_e`, `nombreArticulo_e`, `cantidad_e`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salidas`
--

LOCK TABLES `salidas` WRITE;
/*!40000 ALTER TABLE `salidas` DISABLE KEYS */;
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
INSERT INTO `usuarios` VALUES (1,'Armenta','ARGNLS01072326H200','1234','Administrador','SI','SI');
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

-- Dump completed on 2022-11-13 18:11:11
