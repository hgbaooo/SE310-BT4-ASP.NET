CREATE TABLE Product (
    Id INT PRIMARY KEY NOT NULL,
    CatalogId INT,
    ProductCode NVARCHAR(50),
    ProductName NVARCHAR(250),
    Picture NVARCHAR(MAX),
    UnitPrice FLOAT
)

CREATE TABLE Catalog (
    Id INT PRIMARY KEY NOT NULL,
    CatalogCode NVARCHAR(50),
    CatalogName NVARCHAR(250),
)

ALTER TABLE Product ADD CONSTRAINT FK_CatalogId FOREIGN KEY (CatalogId) REFERENCES Catalog(Id)


INSERT INTO Catalog (Id, CatalogCode, CatalogName) VALUES
(1, 'DM01', 'Điên Thoại'),
(2, 'DM02', 'Máy Tính'),
(3, 'DM03', 'Thời Trang'),
(4, 'DM04', 'Gia Dụng'),
(5, 'CAT113', 'Hàng Cháy Nổ');


INSERT INTO Product (Id, CatalogId, ProductCode, ProductName, Picture, UnitPrice) VALUES 
(1, 1, 'PRO01', 'Samsung J7', 'PRO01.PNG', 10000000),
(2, 1, 'PRO02', 'Iphone X', 'PRO02.PNG', 30000000),
(3, 2, 'PRO03', 'Dell Inspiron 14', 'PRO03.PNG', 12000000),
(4, 2, 'PRO04', 'Dell Inspiron 15', 'PRO04.PNG', 13000000),
(5, 2, 'PRO05', 'Acer Aspire', 'PRO05.PNG', 9000000);


