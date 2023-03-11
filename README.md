# Examen Parcial I - Programación Avanzada Web

[TOC]

## Descripción

Este proyecto es una aplicación web que permite la gestión de una biblioteca. La aplicación permite la gestión de libros, su autor y categoría

## Herramientas

- SQL Server
- .NET Core
- Entity Framework Core
- Bootstrap
- HTML

## Base de datos

- Crear una base de datos en SQL Server
- Configurar la cadena de conexión en el archivo appsettings.json

## Appsettings.json

- Crear un archivo llamado appsettings.json en la carpeta de la solución
- Copiar el siguiente código en el archivo

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "Default": "Server=localhost\\sqlexpress;Database=[database];Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;"
  },
  "AllowedHosts": "*"
}
```

- Cambiar el valor de la cadena de conexión por la de su servidor de SQL Server

## Migración

- Crear el folder Migrations en la carpeta de Infraestructura
- Abrir la consola de paquetes NuGet
- Seleccionar el proyecto de Infraestructura
- Ejecutar los siguientes comandos

```powershell

Add-Migration [nombre de la migración]

Update-Database
```
