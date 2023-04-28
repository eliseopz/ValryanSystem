/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      ERDiagramKoji.DM1
 *
 * Date Created : Friday, April 28, 2023 16:29:48
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: Categor�a 
 */

CREATE TABLE Categor�a(
    idCategoria             int              NOT NULL,
    nombreCategoria         nvarchar(50)     NOT NULL,
    descripci�nCategor�a    nvarchar(100)    NOT NULL,
    idUsuario               int              NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idCategoria)
)
go



IF OBJECT_ID('Categor�a') IS NOT NULL
    PRINT '<<< CREATED TABLE Categor�a >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Categor�a >>>'
go

/* 
 * TABLE: Entradas 
 */

CREATE TABLE Entradas(
    idEntrada               int              NOT NULL,
    unidades                int              NOT NULL,
    fechaEntrada            datetime         NOT NULL,
    observacionesEntrada    nvarchar(100)    NOT NULL,
    idProducto              int              NULL,
    idUsuario               int              NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (idEntrada)
)
go



IF OBJECT_ID('Entradas') IS NOT NULL
    PRINT '<<< CREATED TABLE Entradas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Entradas >>>'
go

/* 
 * TABLE: Productos 
 */

CREATE TABLE Productos(
    idProducto              int              NOT NULL,
    nombreProducto          nvarchar(50)     NOT NULL,
    precioProducto          float            NOT NULL,
    unidadesProducto        int              NOT NULL,
    unidadMedidaProducto    nvarchar(50)     NOT NULL,
    descripci�nProducto     nvarchar(100)    NOT NULL,
    idCategoria             int              NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (idProducto)
)
go



IF OBJECT_ID('Productos') IS NOT NULL
    PRINT '<<< CREATED TABLE Productos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Productos >>>'
go

/* 
 * TABLE: Salida 
 */

CREATE TABLE Salida(
    idSalida               int              NOT NULL,
    unidadesSalida         int              NOT NULL,
    fechaSalida            datetime         NOT NULL,
    observacionesSalida    nvarchar(100)    NOT NULL,
    idProducto             int              NULL,
    idUsuario              int              NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (idSalida)
)
go



IF OBJECT_ID('Salida') IS NOT NULL
    PRINT '<<< CREATED TABLE Salida >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Salida >>>'
go

/* 
 * TABLE: Usuarios 
 */

CREATE TABLE Usuarios(
    idUsuario            int             NOT NULL,
    passwordUsuario      nvarchar(50)    NOT NULL,
    primerNomUsuario     nvarchar(50)    NOT NULL,
    segundoNomUsuario    nvarchar(50)    NOT NULL,
    primerApeUsuario     nvarchar(50)    NOT NULL,
    segundoApeUsuario    nvarchar(50)    NOT NULL,
    fechaNacimiento      datetime        NOT NULL,
    telefonoUsuario      varchar(8)      NOT NULL,
    cedula               varchar(20)     NOT NULL,
    rol                  bit             DEFAULT true NOT NULL,
    sexo                 bit             DEFAULT true NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idUsuario)
)
go



IF OBJECT_ID('Usuarios') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuarios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuarios >>>'
go

/* 
 * TABLE: Categor�a 
 */

ALTER TABLE Categor�a ADD CONSTRAINT RefUsuarios12 
    FOREIGN KEY (idUsuario)
    REFERENCES Usuarios(idUsuario)
go


/* 
 * TABLE: Entradas 
 */

ALTER TABLE Entradas ADD CONSTRAINT RefProductos2 
    FOREIGN KEY (idProducto)
    REFERENCES Productos(idProducto)
go

ALTER TABLE Entradas ADD CONSTRAINT RefUsuarios10 
    FOREIGN KEY (idUsuario)
    REFERENCES Usuarios(idUsuario)
go


/* 
 * TABLE: Productos 
 */

ALTER TABLE Productos ADD CONSTRAINT RefCategor�a8 
    FOREIGN KEY (idCategoria)
    REFERENCES Categor�a(idCategoria)
go


/* 
 * TABLE: Salida 
 */

ALTER TABLE Salida ADD CONSTRAINT RefProductos3 
    FOREIGN KEY (idProducto)
    REFERENCES Productos(idProducto)
go

ALTER TABLE Salida ADD CONSTRAINT RefUsuarios11 
    FOREIGN KEY (idUsuario)
    REFERENCES Usuarios(idUsuario)
go

