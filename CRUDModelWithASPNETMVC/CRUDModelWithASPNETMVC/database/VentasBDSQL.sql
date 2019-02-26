USE master;


IF EXISTS ( SELECT  name
            FROM    master.dbo.sysdatabases
            WHERE   name = N'VentasBD' )
    DROP DATABASE VentasBD;

CREATE DATABASE VentasBD;
GO

USE VentasBD;
GO

CREATE TABLE DetalleClientes
    (
      IdCliente INT NOT NULL
                    PRIMARY KEY
                    IDENTITY ,
      Nombre VARCHAR(50) NOT NULL ,
      Direccion VARCHAR(80) NOT NULL ,
      Ciudad VARCHAR(50) NOT NULL ,
      CodigoPIN CHAR(5) UNIQUE ,
      Pais VARCHAR(70) NOT NULL
    );

CREATE TABLE Empleado
    (
      IdEmpleado INT NOT NULL
                     PRIMARY KEY
                     IDENTITY ,
      Nombre VARCHAR(50) NOT NULL ,
      Departamento VARCHAR(40) NOT NULL ,
      Telefono VARCHAR(30) NOT NULL
    );

INSERT  dbo.DetalleClientes
        ( Nombre ,
          Direccion ,
          Ciudad ,
          CodigoPIN ,
          Pais
        )
VALUES  ( 'Thomas Hardy' , -- Nombre - varchar(50)
          '89 Chiaroscuro Rd.' , -- Direccion - varchar(80)
          'Portland' , -- Ciudad - varchar(50)
          '97219' , -- CodigoPIN - char(5)
          'USA'  -- Pais - varchar(70)
        );

INSERT  dbo.DetalleClientes
        ( Nombre ,
          Direccion ,
          Ciudad ,
          CodigoPIN ,
          Pais
        )
VALUES  ( 'Maria Anders' , -- Nombre - varchar(50)
          'Obere Str. 57' , -- Direccion - varchar(80)
          'Berlin' , -- Ciudad - varchar(50)
          '12209' , -- CodigoPIN - char(5)
          'Germany'  -- Pais - varchar(70)
        );

INSERT  dbo.DetalleClientes
        ( Nombre ,
          Direccion ,
          Ciudad ,
          CodigoPIN ,
          Pais
		 )
VALUES  ( 'Fran Wilson' , -- Nombre - varchar(50)
          'C/ Araquil, 67' , -- Direccion - varchar(80)
          'Madrid' , -- Ciudad - varchar(50)
          '28023' , -- CodigoPIN - char(5)
          'Spain'  -- Pais - varchar(70)
		 );

INSERT  dbo.DetalleClientes
        ( Nombre ,
          Direccion ,
          Ciudad ,
          CodigoPIN ,
          Pais
				
        )
VALUES  ( 'Dominique Perrier' , -- Nombre - varchar(50)
          '25, rue Lauriston' , -- Direccion - varchar(80)
          'Paris' , -- Ciudad - varchar(50)
          '75016' , -- CodigoPIN - char(5)
          'France'  -- Pais - varchar(70)
				
        );

INSERT  dbo.DetalleClientes
        ( Nombre ,
          Direccion ,
          Ciudad ,
          CodigoPIN ,
          Pais
						
        )
VALUES  ( 'Martin Blank' , -- Nombre - varchar(50)
          'Via Monte Bianco 34' , -- Direccion - varchar(80)
          'Turin' , -- Ciudad - varchar(50)
          '10100' , -- CodigoPIN - char(5)
          'Italy'  -- Pais - varchar(70)
						
        );
INSERT  dbo.Empleado
VALUES  ( 'John Doe', 'Administration', '(171) 555-2222' );

INSERT  dbo.Empleado
VALUES  ( 'Peter Parker', 'Customer Service', '(313) 555-5735' );

INSERT  dbo.Empleado
VALUES  ( 'Fran Wilson', 'Human Resources', '(503) 555-9931' );




SELECT  *
FROM    dbo.DetalleClientes;

SELECT  *
FROM    dbo.Empleado;