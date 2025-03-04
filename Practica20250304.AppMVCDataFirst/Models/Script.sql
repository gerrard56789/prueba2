-- Crear la base de datos
CREATE DATABASE Practica04032025DataFirst
GO

-- Usar la base de datos
USE Practica04032025DataFirst
GO

-- Crear la tabla "Clientes"
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1), -- Identificador único autoincremental
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(20)
);
GO
