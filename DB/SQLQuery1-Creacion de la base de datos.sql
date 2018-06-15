--Tabla de productos
create table Products (
	productID int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	productName VARCHAR(50),
	productPresentation VARCHAR(50),
	costPrice FLOAT CHECK(costPrice>0),
	salePrice FLOAT CHECK(salePrice>0),
	unitInStop INT
);
--Tabla de rutas
Create table Routes 
(
	routeID int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	routeName VARCHAR(50)
);
--Tabla de empleados
Create table Employees 
(
	employeesID int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	employeeName VARCHAR(50),
	employeeLastName VARCHAR(50),
	e_UserName VARCHAR(50),
	e_Password VARCHAR(50),
	typeEmployee VARCHAR(50)
);
--Tabla de empleados que entregan
create table Delivery 
(
	deliveryID INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	deliveryName VARCHAR(50)
);
--Tabla sobre rutas y empleados
CREATE TABLE Routes_Delivery 
(
	routeID INT NOT NULL,
	deliveryID  INT NOT NULL,
	descriptionRD VARCHAR(50),
	PRIMARY KEY (routeID,deliveryID),
	CONSTRAINT FK_deliveryID_RD FOREIGN KEY (deliveryID) REFERENCES Delivery(deliveryID),
	CONSTRAINT FK_routeID_RD FOREIGN KEY (routeID) REFERENCES Routes(routeID)
);
--Tabla de clientes
CREATE TABLE Customers 
(
	customerID INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	telephone VARCHAR(50),
	customerName VARCHAR(50),
	identificationCard VARCHAR(50),
	routeID INT NOT NULL,
	CONSTRAINT FK_routeID_CUSTOMERS FOREIGN KEY (routeID) REFERENCES Routes(routeID)
);
--Tabla de ordenes
CREATE TABLE Orders 
(
	orderID INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	dateOrder DATE,
	status1 VARCHAR(50),
	status2 VARCHAR(50),
	code VARCHAR(50),
	deliveryDay VARCHAR(50),
	typeOfSale VARCHAR(50),
	totalDiscount INT CHECK(totalDiscount>-1),
	routeID INT NOT NULL,
	customerID INT NOT NULL,
	deliveryID INT NOT NULL,
	CONSTRAINT FK_routeID_Orders FOREIGN KEY (routeID) REFERENCES Routes(routeID),
	CONSTRAINT FK_customerID_Orders FOREIGN KEY (customerID) REFERENCES Customers(customerID),
	CONSTRAINT FK_deliveryID_Orders	FOREIGN KEY (deliveryID) REFERENCES Delivery(deliveryID)
);
--Tabla del detalle entre todos los productos y las ordenes
CREATE TABLE Detail_Order
(
	orderID INT NOT NULL,
	productID INT NOT NULL,
	quantityPOrder INT CHECK(quantityPOrder>1),
	descriptionDO VARCHAR(50),
	discount INT CHECK(discount>-1),
	PRIMARY KEY (orderID,productID),
	CONSTRAINT FK_orderID_DO FOREIGN KEY (orderID) REFERENCES Orders(orderID),
	CONSTRAINT FK_productID_DO	FOREIGN KEY (productID) REFERENCES Products(productID)
);
--Tabla de combos
CREATE TABLE Combos 
(
	comboID INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	descriptionC VARCHAR(50)
);
--Tabla de combos y productos
CREATE TABLE Combo_Product
(
	comboID INT NOT NULL,
	productID INT NOT NULL,
	quantityPCombo INT cHECK(quantityPCombo>0),
	descriptionCP VARCHAR(50),
	PRIMARY KEY (comboID,productID),
	CONSTRAINT FK_comboID_CP FOREIGN KEY (comboID) REFERENCES Combos(comboID),
	CONSTRAINT FK_productID_CP FOREIGN KEY (productID) REFERENCES Products(productID)
);


	
