create table RUBROS(
	Id_Rubro SERIAL primary key,
	Nombre_Rubro VARCHAR (50) not null
);

create table PRODUCTOS (
	Id_producto SERIAL primary key,
	Codigo VARCHAR(50) Unique,
	Nombre_productos VARCHAR(50) not null Unique,
	Precio NUMERIC(12,2)not NULL,
	Compra numeric(12,2),
	Stock INT default 0,
	Id_Rubro INT not null default 1,
	Nombre_Rubro VARCHAR(50),
	constraint fk_id_rubro 
	foreign key (id_rubro) 
	references RUBROS(Id_rubro) 
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE OR REPLACE FUNCTION insertar_nombre_rubro()
RETURNS TRIGGER AS $$
BEGIN
    NEW.Nombre_Rubro := (SELECT Nombre_Rubro FROM Rubros WHERE Id_Rubro = NEW.Id_Rubro);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_insertar_nombre_rubro
BEFORE INSERT ON PRODUCTOS
FOR EACH ROW
EXECUTE FUNCTION insertar_nombre_rubro();


CREATE TABLE Cabecera_Inventario (
    Id_CabInventario SERIAL PRIMARY KEY,
    Autor VARCHAR(50) not NULL,
    Total_Monto NUMERIC(12,2) not NULL,
    Fecha_Inventario DATE DEFAULT CURRENT_DATE
);

CREATE TABLE Detalle_Inventario (
	Id_DetInventario SERIAL PRIMARY KEY,
	Id_CabInventario INT NOT NULL,
	Id_producto INT NOT NULL,
	Cantidad INT NOT NULL,
	Subtotal NUMERIC(12,2) NOT NULL,
	
	CONSTRAINT fk_producto 
		FOREIGN KEY (Id_producto) 
		REFERENCES PRODUCTOS(Id_producto)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
		
	CONSTRAINT fk_cabecera_inventario 
		FOREIGN KEY (Id_CabInventario) 
		REFERENCES Cabecera_Inventario(Id_CabInventario)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

create table Arqueo(
	Id_Arqueo serial primary key,
	AutorCierre VARCHAR(100),
	SencilloApertura Numeric(12,2), 
	SencilloCierre Numeric(12,2),
	Sobrante Numeric(12,2),
	faltante Numeric(12,2),
	Ventas Numeric(12,2) DEFAULT 0,
	Gastos numeric(12,2) DEFAULT 0,
	FechaArqueo DATE DEFAULT CURRENT_DATE
);

create table Cabecera_Ventas(
	Id_CabVentas serial primary key,
	Id_arqueo Int not null,
	Fecha_venta DATE DEFAULT CURRENT_DATE,
	Cliente varchar(100),
	Pago NUMERIC(12,2),
	Montototal NUMERIC(12,2),
	Vuelto NUMERIC(12,2),
	Anulado BOOLEAN default False,
	constraint fk_id_arqueo foreign key(Id_Arqueo) references Arqueo(Id_arqueo)
);

CREATE OR REPLACE FUNCTION actualizar_ventas_arqueo()
RETURNS TRIGGER AS $$
BEGIN
    UPDATE Arqueo
    SET Ventas = Ventas + NEW.MontoTotal
    WHERE Id_Arqueo = NEW.Id_Arqueo;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_actualizar_ventas_arqueo
AFTER INSERT ON Cabecera_Ventas
FOR EACH ROW
EXECUTE FUNCTION actualizar_ventas_arqueo();

CREATE OR REPLACE FUNCTION actualizar_gastos_arqueo()
RETURNS TRIGGER AS $$
BEGIN
    UPDATE Arqueo
    SET gastos = gastos + NEW.Monto
    WHERE Id_Arqueo = NEW.Id_Arqueo;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

create table detalle_ventas(
	Id_DetVentas serial primary key,
	Id_CabVentas int not null,
	Id_producto Int not null,
	Codigo VARCHAR(50),
	Nombre_productos VARCHAR(100) NOT NULL,
	Cantidad INT NOT NULL CHECK (Cantidad > 0),
	Precio NUMERIC(12,2) NOT NULL,
	SubTotal NUMERIC(12,2) NOT NULL,
	
	CONSTRAINT FK_Id_CabVentas 
	FOREIGN KEY (Id_CabVentas) 
	REFERENCES Cabecera_Ventas(Id_CabVentas),
	
	CONSTRAINT FK_IdProducto 
	FOREIGN KEY (Id_Producto) 
	REFERENCES Productos(Id_Producto)
	);

CREATE OR REPLACE FUNCTION actualizar_fecha_actualizacion()
RETURNS TRIGGER AS $$
BEGIN
    NEW.Fecha_Modificacion = now();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER actualizar_fecha_trigger
BEFORE UPDATE ON Cabecera_Inventario
FOR EACH row
EXECUTE FUNCTION actualizar_fecha_actualizacion();

create table Cabecera_Compras (
    Id_CabCompras SERIAL primary key,
    NumFactura INT,
    Prefijo VARCHAR(7),
    Timbrado INT,
    RUC VARCHAR(12),
    Proveedor VARCHAR(500),
    Montototal NUMERIC(12,2),
    FechaCompra DATE DEFAULT CURRENT_DATE
);

create table Detalle_Compras (
    Id_DetCompras SERIAL primary key,
    Id_CabCompras INT NOT NULL,
    Id_producto INT NOT NULL,
    Codigo VARCHAR(50),
    Nombre_productos VARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    Compra NUMERIC(12,2) NOT NULL,
    SubTotal NUMERIC(12,2) NOT NULL,
    CONSTRAINT FK_Id_CabCompras FOREIGN KEY (Id_CabCompras)
        REFERENCES Cabecera_Compras(Id_CabCompras)
        ON DELETE CASCADE
		ON UPDATE CASCADE,
        
    CONSTRAINT fk_producto FOREIGN KEY (Id_producto) 
		REFERENCES PRODUCTOS(Id_producto)
		ON DELETE CASCADE
		ON UPDATE CASCADE   
);

CREATE TABLE Gastos(
Id_Gastos serial PRIMARY KEY,
Id_arqueo int,
Autor varchar(50),
Motivo VARCHAR(100),
Monto Numeric(12,2),
FechaGasto DATE DEFAULT CURRENT_DATE,
constraint fk_Id_arqueo foreign key (Id_arqueo) references ARQUEO(Id_arqueo)
);

CREATE TRIGGER trg_actualizar_gastos_arqueo
AFTER INSERT ON gastos
FOR EACH ROW
EXECUTE FUNCTION actualizar_gastos_arqueo();

CREATE VIEW Vista_Detalle_Inventario AS
SELECT 
    ci.Id_CabInventario,
    ci.Autor,
    di.Id_producto,
    p.nombre_productos AS Producto,
    di.Cantidad,
    ci.Total_Monto,
    ci.Fecha_Inventario,
    di.Id_DetInventario,
    di.Subtotal
FROM 
    Cabecera_Inventario ci
JOIN 
    Detalle_Inventario di ON ci.Id_CabInventario = di.Id_CabInventario
JOIN 
    PRODUCTOS p ON di.Id_producto = p.Id_producto; 
    
CREATE VIEW Vista_Inventario_Cabecera AS
SELECT 
    ci.Id_CabInventario,
    ci.Autor,
    ci.Total_Monto,
    ci.Fecha_Inventario,
    COUNT(di.Id_DetInventario) AS Total_Productos,
    SUM(di.Subtotal) AS Total_Subtotal
FROM 
    Cabecera_Inventario ci
JOIN 
    Detalle_Inventario di ON ci.Id_CabInventario = di.Id_CabInventario
GROUP BY
    ci.Id_CabInventario,
    ci.Autor,
    ci.Total_Monto,
    ci.Fecha_Inventario;
   
CREATE VIEW Vista_Ventas_Completa AS
SELECT 
    cv.Id_CabVentas,
    cv.Fecha_venta,
    cv.Cliente,
    cv.Anulado,
    dv.Id_DetVentas,
    a.Id_Arqueo,
    a.FechaArqueo,
    dv.Codigo,
    dv.Nombre_productos,
    dv.Cantidad,
    dv.Precio,
    dv.SubTotal,
    Cv.Montototal
FROM 
    Cabecera_Ventas cv
JOIN 
    detalle_ventas dv ON cv.Id_CabVentas = dv.Id_CabVentas
LEFT JOIN 
    Arqueo a ON cv.Id_Arqueo = a.Id_Arqueo;      