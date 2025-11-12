CREATE DATABASE PG02_SISTEMA_GESTION_DEPORTIVA
GO

USE PG02_SISTEMA_GESTION_DEPORTIVA
GO

CREATE TABLE tbUsuario(
	idUsuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NombreUsuario VARCHAR (150) NOT NULL,
	Correo VARCHAR (250) NOT NULL,
	Clave VARCHAR (10) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE tbUsuarioDatos(
	idUsuarioDatos INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	idUsuario INT NOT NULL,
	Nombres VARCHAR (250) NOT NULL,
	ApellidoPaterno VARCHAR (250) NOT NULL,
	ApellidoMaterno VARCHAR (250) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Telefono VARCHAR (9),
	FOREIGN KEY (idUsuario) REFERENCES tbUsuario(idUsuario)
);
GO

INSERT INTO tbUsuario (NombreUsuario, Correo, Clave, Estado)
VALUES ('Juan Pérez', 'juan.perez@example.com', 'abc123', 1);
GO

SELECT * FROM tbUsuario
SELECT * FROM tbUsuarioDatos

DELETE FROM tbUsuario
WHERE NombreUsuario = 'lukan';


DELETE FROM tbUsuarioDatos;
DELETE FROM tbUsuario;
