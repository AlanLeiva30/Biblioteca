--Insertando los datos en la base de datos BibliotecaForm
INSERT INTO Libro (tituloLibro, autor, año_publicacion, contenido)
VALUES
    ('El Gran Gatsby',        'F. Scott Fitzgerald', '1925', 'La historia sigue a Jay Gatsby, un millonario misterioso que organiza fiestas extravagantes en su mansión de Long Island.'),
    ('1984',                    'George Orwell', '1949', 'La novela distópica de Orwell presenta un futuro totalitario donde el gobierno controla todos los aspectos de la vida de las personas.'),
    ('Don Quijote de la Mancha',    'Miguel de Cervantes', '1605', 'La obra maestra de Cervantes narra las aventuras del caballero Don Quijote y su fiel escudero Sancho Panza.'),
    ('Cien años de soledad',     'Gabriel García Márquez', '1967', 'La saga familiar de los Buendía en el pueblo ficticio de Macondo es una exploración mágica y realista de la historia de América Latina.'),
    ('Harry Potter y la piedra filosofal',  'J.K. Rowling', '1997', 'El primer libro de la serie de Harry Potter, que sigue las aventuras de un joven mago en la Escuela de Magia y Hechicería de Hogwarts.'),
    ('Moby-Dick',         'Herman Melville', '1851', 'La novela épica de Melville cuenta la obsesión del capitán Ahab por cazar a la legendaria ballena blanca.'),
    ('Orgullo y prejuicio',        'Jane Austen', '1813', 'Esta obra de Austen sigue la historia de Elizabeth Bennet mientras lidia con el amor, el matrimonio y las expectativas sociales en la Inglaterra del siglo XIX.'),
    ('El señor de los anillos',      'J.R.R. Tolkien', '1954', 'La trilogía épica de Tolkien sigue la lucha entre el bien y el mal en la Tierra Media y la misión de un grupo de personajes para destruir un poderoso anillo.'),
    ('Crónica de una muerte anunciada',     'Gabriel García Márquez', '1981', 'La historia relata el asesinato de Santiago Nasar y la inevitabilidad de su destino, anunciado en un pequeño pueblo caribeño.'),
    ('El principito',        'Antoine de Saint-Exupéry', '1943', 'El clásico cuento filosófico narra las aventuras de un niño extraterrestre mientras viaja por diferentes planetas y reflexiona sobre la vida y la amistad.');

	go
-- Insertar datos en la tabla Usuario
INSERT INTO Usuario (nombreCompleto, direccion, telefono, Correo, usuario, Contraseña,Administrador)
VALUES ('John Doe', 'Calle Principal 123', '555-1234', 'johndoe@example.com', 'admin', 'admin123',1),
('Jane Smith', 'Avenida Central 456', '555-5678', 'janesmith@example.com', 'janes', 'password123',0),
('Michael Johnson', 'Plaza Mayor 789', '555-7890', 'michaeljohnson@example.com', 'mjohnson', 'qwerty123',0),
('Emily Davis', 'Calle Secundaria 321', '555-4321', 'emilydavis@example.com', 'emily', 'abcd1234',0),
('Jane Smith', 'Avenida Central 456', '555-5678', 'janesmith@example.com', 'jane', 'smith123',0),
('Mike Johnson', 'Calle Secundaria 789', '555-8901', 'mikejohnson@example.com', 'mike', 'johnson123',0),
('Emily Davis', 'Boulevard Principal 321', '555-2345', 'emilydavis@example.com', 'emily', 'davis123',0),
('Chris Wilson', 'Carrera Central 654', '555-6789', 'chriswilson@example.com', 'chris', 'wilson123',0),
('Jessica Brown', 'Avenida Principal 987', '555-0123', 'jessicabrown@example.com', 'jessica', 'brown123',0),
('David Thompson', 'Calle Principal 654', '555-3456', 'davidthompson@example.com', 'david', 'thompson123',0),
('Jose Escobar', 'Calle Principal 654', '235-3456', 'jose.escobar@mail.com', 'jose', 'jose123',1)
go

INSERT INTO Prestamo (ID_Usuario,ID_Libro,fecha_prestamo, fecha_devolucion)
VALUES
    (10,1, '2023-05-20', '2023-06-20'),
    (8,1, '2023-05-21', '2023-06-21'),
    (2,2, '2023-05-22', '2023-06-22'),
    (1,4, '2023-05-23', '2023-06-23'),
    (3,6, '2023-05-24', '2023-06-24'),
    (1,6, '2023-05-25', '2023-06-25'),
    (6,3, '2023-05-26', '2023-06-26'),
    (4,1, '2023-05-27', '2023-06-27'),
    (2,5, '2023-05-28', '2023-06-28'),
    (1,4, '2023-05-29', '2023-06-29')
go
--Comprobando que los datos fueron insertados
select * from Usuario
select * from Libro
select * from Prestamo
