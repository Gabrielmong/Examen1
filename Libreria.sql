Crear la base de datos Libreria

Use Libreria
Go

CREATE TABLE dbo.Autores
    (Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre varchar(100) NOT NULL,
    Correo varchar(100),
    Telefono varchar(30) NULL)
GO

CREATE TABLE dbo.Categorias
    (Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre varchar(100) NOT NULL)
GO
CREATE TABLE dbo.Libros
    (Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ISBN varchar(100) NOT NULL,
    Titulo varchar(100),
    Autor int FOREIGN KEY REFERENCES dbo.Autores(Id) NOT NULL,
	Categoria int FOREIGN KEY REFERENCES dbo.Categorias(Id) NOT NULL,
	Precio int Null)
GO

CREATE TABLE dbo.Carrito
    (Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Libro int FOREIGN KEY REFERENCES dbo.Libros(Id))
GO
