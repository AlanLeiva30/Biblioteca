--Creacion de la base de datos
CREATE DATABASE BibliotecaFrom;
GO
USE BibliotecaFrom
go
CREATE TABLE Libro (
    id_libro INT IDENTITY(1,1) PRIMARY KEY,
    tituloLibro VARCHAR(100) NOT NULL,
    autor VARCHAR(50) NOT NULL,
    año_publicacion VARCHAR(10) NOT NULL,
    contenido VARCHAR(300) NOT null );
go
CREATE TABLE Usuario (
    ID_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreCompleto VARCHAR(50) NOT NULL,
    direccion VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
    usuario VARCHAR(20) NOT NULL,
    Contraseña VARCHAR(20) NOT NULL,
	Administrador INT NOT NULL)
go
CREATE TABLE Prestamo (
    ID_Prestamo INT IDENTITY(1,1) PRIMARY KEY,
	ID_Usuario INT NOT NULL,
	ID_Libro INT NOT NULL,
    fecha_prestamo DATE NOT NULL,
    fecha_devolucion DATE NOT NULL,
	FOREIGN KEY (ID_Libro) REFERENCES Libro(ID_Libro),
    FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
);
go
