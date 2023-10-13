create database Test
go

CREATE TABLE Orders (
	Id int identity(1,1),
    SalesOrder nvarchar(255) NOT NULL,
    SalesOrderItem nvarchar(255) NOT NULL,
    WorkOrder nvarchar(255) NOT NULL,
    ProductID nvarchar(255) NOT NULL,
    ProductDescription nvarchar(255) NOT NULL,
    OrderQuantity decimal(18,2) NOT NULL,
    OrderStatus nvarchar(255) NOT NULL,
    Times_tamp datetime NOT NULL
);

use Test
go

INSERT INTO Orders (SalesOrder, SalesOrderItem, WorkOrder, ProductID, ProductDescription, OrderQuantity, OrderStatus, Times_tamp)
VALUES
('6604096600', '300', '6682432055', 'KB15_WE_G11', '16A Twin 3Pin Uni So 3M Size Mod Push in', 1600, 'Open', '2023-10-13 12:52:40.000'),
('6604094574', '3800','6682416525', '3426UEST2MP',  'Connected Switch 2AX 240V Zigbee VW', 2400, 'Open', '2023-10-13 12:52:40.000'),
('6610002836', '200', '6682430487', '41E2PBSWMZ-VW',  '16A Twin 3Pin Uni So 3M Size Mod Push in', 4, 'Open', '2023-10-13 12:52:40.000'),
('6604094765', '100', '6682418899', '3426UEST2MP',  '16A Twin 3Pin Uni So 3M Size Mod Push in', 600, 'Open', '2023-10-13 12:52:40.000'),
('6604094574', '1800', '6682429490', '3426UEST2MP',  '16A Twin 3Pin Uni So 3M Size Mod Push in', 2400, 'Open', '2023-10-13 12:52:40.000'),
('6604094576', '100', '6682429491', '3426UEST2MP',  '16A Twin 3Pin Uni So 3M Size Mod Push in', 1600, 'Open', '2023-10-13 12:52:40.000'),
('6604097026', '300', '6682429476', 'PDL395CSG', 'Grid Socket Connected Horiz Twin 10A250V', 60, 'Open', '2023-10-13 12:52:40.000'),
('6604094115', '300', '6682414294', '3025CSG', '16A 250V 2G Universal Socket, GH', 20, 'Open', '2023-10-13 12:52:40.000'),
('6604094735', '100', '6682416840', '3025CSG', '16A 250V 2G Universal Socket, GH', 340, 'Open', '2023-10-13 12:52:40.000'),
('6604096402', '200', '6682426216', 'KB15_WE', '13A 250V 1 GANG SWITCHED SOCKET', 1600, 'Open', '2023-10-13 12:52:40.000');


