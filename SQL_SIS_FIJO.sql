--CREATE DATABASE PRUEBADEPORTE
--GO

--USE master

--USE PRUEBADEPORTE
--GO

CREATE TABLE tbTipoDocumento(
	IDTipoDocumento INT IDENTITY(1,1) PRIMARY KEY,
	TipoDocumento VARCHAR (30) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1,
);
GO

INSERT INTO tbTipoDocumento (TipoDocumento)
VALUES 
('DNI'),
('Carnet de Extranjería'),
('Pasaporte');
GO

CREATE TABLE tbPersona(
	IDPersona INT IDENTITY(1,1) PRIMARY KEY,
	Nombres VARCHAR (250) NOT NULL,
	ApellidoPaterno VARCHAR (250) NOT NULL,
	ApellidoMaterno VARCHAR (250) NOT NULL,
	IDTipoDocumento INT NOT NULL,
	Documento VARCHAR (15) NOT NULL UNIQUE,
	FechaNacimiento DATE NOT NULL,
	Telefono VARCHAR (9),
	Correo VARCHAR(250) NOT NULL UNIQUE,
	Genero CHAR(1) CHECK (Genero IN ('M', 'F')),

	FOREIGN KEY (IDTipoDocumento) REFERENCES tbTipoDocumento(IDTipoDocumento)
);
GO

CREATE TABLE tbUsuario(
	IDUsuario INT IDENTITY(1,1) PRIMARY KEY,
	IDPersona INT NOT NULL,
	NombreUsuario VARCHAR (50) NOT NULL,
	Clave VARCHAR (25) NOT NULL,
	FechaRegistro DATETIME DEFAULT GETDATE(),
	Estado BIT NOT NULL DEFAULT 1,

	FOREIGN KEY (IDPersona) REFERENCES tbPersona(IDPersona)
);
GO

CREATE TABLE tbEquipo(
	IDEquipo INT IDENTITY(1,1) PRIMARY KEY,
	IDCreador INT NOT NULL,
	NombreEquipo VARCHAR(150) NOT NULL,
	Descripcion VARCHAR(250),
	FechaRegistro DATETIME DEFAULT GETDATE(),
	FechaModificacion DATETIME,
	Estado BIT NOT NULL DEFAULT 1,

	FOREIGN KEY (IDCreador) REFERENCES tbUsuario(IDUsuario)
);
GO 


---- TABLA QUE MUESTRA LOS INTEGRANTES DEL EQUIPO
--CREATE TABLE tbEquipoIntegrante(
--	IDIntegrante INT IDENTITY(1,1) PRIMARY KEY,
--	IDEquipo INT NOT NULL,
--	IDUsuario INT NOT NULL,
--	Puesto VARCHAR(100),       -- Ej: "Delantero", "Base", "Portero"
--	NumeroCamiseta INT,        -- Ej: 10, 23, etc.
--	EsCapitan BIT DEFAULT 0,   -- El creador podría tener esto en 1
--	FechaUnion DATETIME DEFAULT GETDATE(),
--	Estado BIT DEFAULT 1,      -- 1=Activo, 0=Inactivo o expulsado
--	FOREIGN KEY (IDEquipo) REFERENCES tbEquipo(IDEquipo),
--	FOREIGN KEY (IDUsuario) REFERENCES tbUsuario(IDUsuario)
--);
--GO

-- TABLA DE INVITACIONES
CREATE TABLE tbInvitacionEquipo(
	IdInvitacion INT IDENTITY(1,1) PRIMARY KEY,
	IdEquipo INT NOT NULL,
	IdUsuarioInvitado INT NOT NULL,
	IdUsuarioEmisor INT NOT NULL,  -- EL QUE ENVIA LA INVITACION (CREADOR DE EQUIPO)
	FechaInvitacion DATETIME DEFAULT GETDATE(),
	EstadoInvitacion VARCHAR(20) DEFAULT 'Pendiente' 
		-- 'Pendiente', 'Aceptada', 'Rechazada'
	,
	FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo),
	FOREIGN KEY (idUsuarioInvitado) REFERENCES tbUsuario(idUsuario),
	FOREIGN KEY (idUsuarioEmisor) REFERENCES tbUsuario(idUsuario)
);
GO



SELECT * FROM tbUsuario
SELECT * FROM tbPersona
SELECT * FROM tbEquipo
SELECT * FROM tbInvitacionEquipo



--INSERT INTO tbPersona
--(Nombres, ApellidoPaterno, ApellidoMaterno, IDTipoDocumento, Documento, FechaNacimiento, Telefono, Correo, Genero)
--VALUES
--('Juan Carlos', 'Pérez', 'Gómez', 1, '12345678', '1990-05-12', '987654321', 'juan.perez@example.com', 'M'),
--('María Luisa', 'Ramírez', 'Torres', 2, 'E1234567', '1987-11-23', '912345678', 'maria.ramirez@example.com', 'F'),
--('Luis Alberto', 'Sánchez', 'Flores', 3, 'PA987654', '1995-03-07', NULL, 'luis.sanchez@example.com', 'M');
--GO

--INSERT INTO tbUsuario (IDPersona, NombreUsuario, Clave, Estado)
--VALUES
--(1, 'jperez', 'clave123', 1),
--(2, 'mramirez', 'pass456', 1),
--(3, 'lsanchez', 'abc789', 1);
--GO

--SELECT IDUsuario, NombreUsuario
--FROM tbUsuario
--WHERE NombreUsuario LIKE 'L%'
--  AND IDUsuario <> 1
--  AND Estado = 1;
