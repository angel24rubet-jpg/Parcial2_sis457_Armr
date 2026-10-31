CREATE DATABASE Parcial2Armr
GO
USE master
GO
CREATE LOGIN usrparcial2 WITH PASSWORD =N'12345678',
DEFAULT_DATABASE=Parcial2Armr,
CHECK_EXPIRATION=OFF,
CHECK_POLICY=ON
GO

USE Parcial2Armr
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE [db_owner] ADD MEMBER usrparcial2
GO

DROP TABLE IF EXISTS HorarioPrograma;
DROP TABLE IF EXISTS Canal;

USE Parcial2Armr;
GO

CREATE TABLE Canal (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    frecuencia VARCHAR(20) NOT NULL,
    estado SMALLINT NOT NULL
);
GO

USE Parcial2Armr;
GO

CREATE TABLE HorarioPrograma (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idCanal INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL,
    diaSemana VARCHAR(20) NOT NULL,
    conductorPrincipal VARCHAR(100) NOT NULL,
    estado SMALLINT NOT NULL,

    CONSTRAINT FK_HorarioPrograma_Canal
    FOREIGN KEY (idCanal)
    REFERENCES Canal(id)
);
GO

DROP PROC IF EXISTS paHorarioProgramaListar;
GO

CREATE PROC paHorarioProgramaListar @parametro VARCHAR(50)
AS
    SELECT hp.id, hp.idCanal, c.nombre AS canal,
        hp.titulo, hp.horaInicio, hp.horaFin,
        hp.diaSemana, hp.conductorPrincipal, hp.estado
    FROM HorarioPrograma hp
    INNER JOIN Canal c ON c.id = hp.idCanal
    WHERE hp.estado = 1
    AND hp.titulo + c.nombre + hp.diaSemana + hp.conductorPrincipal
        LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY hp.titulo;
GO

EXEC paHorarioProgramaListar '';
GO

-- datos para la tabla Canal

USE Parcial2Armr;
GO

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES
('BOLIVIA TV', '174 MHz', 1),
('BOLIVISION', '66 MHz', 1),
('RED UNO', '186 MHz', 1),
('ATB', '76 MHz', 1),
('UNITEL', '192 MHz', 1);
GO

SELECT * FROM Canal;
GO

-- ver datos de la tabla HorarioPrograma
SELECT * FROM HorarioPrograma;
GO