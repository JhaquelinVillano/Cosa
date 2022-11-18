select * from empleados;
select * from usuarios;
select id_usuario,empleados_dni_empleado,id_tipo,biblioteca,inventario from usuarios;
select id_usuario from usuarios where id_usuario='Armenta';
select contraseña from usuarios where id_usuario='armenta';
select id_tipo from usuarios where id_usuario='armenta';
select  dni_empleado from empleados where dni_empleado='ARGNLS01072326H200';
select  idEmpleado from empleados where dni_empleado='ARGNLS01072326H200';

insert into empleados (idEmpleado,dni_empleado,nombre,apellido,direccion,telefono,correo) values (default,'ARGNLS01072326H200','Luis Octavio','Armenta Gonzalez','Ignacio Comonfort 263','6381093002','armenglzlo@hotmail.com');
insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values (1,'Armenta','ARGNLS01072326H200','1234','Administrador','SI','SI');

insert into empleados (idEmpleado,dni_empleado,nombre,apellido,direccion,telefono,correo) values (default,'RTBNLS01072326H159','Juan','Valdez Gomez','Jaime nuno 748','6381581485','JuanNunoglzlo@hotmail.com');
insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values (2,'JuanVG','RTBNLS01072326H159','1234','Encargado','SI','SI');

UPDATE empleados set dni_empleado='YUINLS01072326H200',nombre='Jose Jose',apellido='Vargas Salomon',direccion='al chile, ni el sabe',telefono='6381147474',correo='Salonsm324@gmail.com' WHERE idEmpleado='3';

UPDATE usuarios SET id_tipo=0 WHERE id_usuario='ArmentaCon';
UPDATE usuarios set empleados_dni_empleado='RTBNLS01072326H159',contraseña='1234',id_tipo='Invitado',biblioteca='NO',inventario='NO' where id_usuario='JuanInvitado';

alter table empleados AUTO_INCREMENT=1;

DELETE FROM usuarios WHERE id_usuario='JuanVG';
DELETE FROM empleados WHERE idEmpleado='3';



select * from libros;

insert into libros (idLibro_l,nombre_l,autor_i,categoria_i,idioma_i,edicion_i,existencias_i) values (default,'don quijote','quijote','cuentos','español','Primera',2);

update libros set nombre_l='Don Quijote de la mancha',autor_i='Quijote',categoria_i='cuentos',idioma_i='español',edicion_i='primera',existencias_i='1' where idLibro_l=1;


alter table devoluciones AUTO_INCREMENT=1;
DELETE FROM prestamos WHERE idPrestamo_p='4';

select * from clientes;
select * from prestamos;

select existencias_i from libros where idLibro_l='1';
SELECT count(*) FROM prestamos where libros_idLibro_l = '1';
select idCliente from clientes where idCliente='2';
select nombre_l from libros where idLibro_l='1';
select dni_cliente from clientes where idCliente="1";

insert into prestamos (idPrestamo_p,libros_idLibro_l,libros_nombre_l,clientes_idCliente,clientes_dni_cliente,usuarios_id_usuario,fechaPrestamo_p) values (default,'1','don quijote','1','GAGNLS01072326G567','Armenta',now());
select * from devoluciones;
select fechaPrestamo_p from prestamos where idPrestamo_p=1;
select empleados_dni_empleado from usuarios where id_usuario='Armenta';
delete from devoluciones where idDevolucion_d=1;
alter table devoluciones AUTO_INCREMENT=1;
insert into devoluciones (idDevolucion_d,libroID,nombreLibro_d,clienteID,clienteDNI,empleadoID,empleadoDNI,fechaPrestamo,fechaDevolucion_d) values (default,1,'algo',1,'ASDSDASDAD',1,'ASDWDADASDA','13-11-2022 15:50:46',now());

select * from prestamos;
SELECT DISTINCT DATE_FORMAT(fechaPrestamo_p,'%Y-%m-%d %H:%i:%S') fechaPrestamo_p FROM prestamos WHERE idPrestamo_p=1;
