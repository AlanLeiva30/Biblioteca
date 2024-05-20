--Creando los procedimientos almacenados para la base de datos BibliotecaForm
--Procedimiento almacenado para agregar libros
CREATE PROCEDURE AgregarLibro
    -- Parámetros para el procedimiento
    @tituloLibro VARCHAR(100), 
    @autor VARCHAR(50), 
    @año_publicacion VARCHAR(10),
    @contenido VARCHAR(300)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    -- Insertar los valores en la tabla
    INSERT INTO Libro 
        (tituloLibro, autor, año_publicacion, contenido) 
    VALUES 
        (@tituloLibro, @autor, @año_publicacion, @contenido)
END
GO
--Procedimiento almacenado para eliminar libros
CREATE PROCEDURE EliminarLibro
    @idLibro INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Libro WHERE id_libro = @idLibro
END
GO
--Pocedimiento almacenado para mostrar libros
CREATE PROCEDURE MostrarLibros
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Libro
END
GO
--Procedimiento almacenado para mostrar Usuarios
CREATE PROCEDURE MostrarUsuarios
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Usuario
END
GO
--Procedimiento almacenado para mostrar Prestamos
CREATE PROCEDURE MostrarPrestamos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT P.ID_Prestamo, 
           U.ID_Usuario,
           U.nombreCompleto, 
           L.id_libro, 
           L.tituloLibro,
           P.fecha_prestamo, 
           P.fecha_devolucion
    FROM Prestamo P
    INNER JOIN Usuario U ON P.ID_Usuario = U.ID_Usuario
    INNER JOIN Libro L ON P.ID_Libro = L.id_libro
END
GO
--Procedimiento almacenado para Eliminar Usuario
CREATE PROCEDURE EliminarUsuario
    @IDUsuario VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Usuario WHERE ID_Usuario = @IDUsuario;
END
GO
--Procedimiento almacenado para Eliminar Prestamo
CREATE PROCEDURE EliminarPrestamo
    @idPrestamo INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Prestamo WHERE ID_Prestamo = @idPrestamo;
END
GO
--Procedimiento almacenado para Registrar Usuario
CREATE PROCEDURE RegistrarUsuario
    @nombreCompleto NVARCHAR(100),
    @direccion NVARCHAR(100),
    @telefono NVARCHAR(20),
    @correo NVARCHAR(50),
    @usuario NVARCHAR(50),
    @contraseña NVARCHAR(50),
    @administrador INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (nombreCompleto, direccion, telefono, Correo, usuario, Contraseña, Administrador) 
    VALUES (@nombreCompleto, @direccion, @telefono, @correo, @usuario, @contraseña, @administrador);
END
GO
--Procedimiento almacenado para Registrar Prestamo
CREATE PROCEDURE RegistrarPrestamo
    @ID_Usuario INT,
    @ID_Libro INT,
    @fecha_prestamo DATE,
    @fecha_devolucion DATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Prestamo (ID_Usuario, ID_Libro, fecha_prestamo, fecha_devolucion)
    VALUES (@ID_Usuario, @ID_Libro, @fecha_prestamo, @fecha_devolucion);
END
go
--Procedimiento almacenado para Obtener Titulo Libro Y Nombre Completo
CREATE PROCEDURE ObtenerTituloLibroYNombreCompleto
    @ID_Libro INT,
    @ID_Usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT L.tituloLibro, U.nombreCompleto
    FROM Libro L
    CROSS JOIN Usuario U 
    WHERE L.id_libro = @ID_Libro AND U.ID_Usuario = @ID_Usuario;
END



