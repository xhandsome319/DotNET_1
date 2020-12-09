CREATE DATABASE QuanLyQuanPho
GO

USE QuanLyQuanPho
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'QuanPho',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: Chủ quán && 0: Nhân viên
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: Đã thanh toán && 0: Chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO DBO.Account 
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'NV01',
	N'Lê Trung Hậu',
	N'trunghau',
	0
)

INSERT INTO DBO.Account 
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'BOSS',
	N'Nguyễn Thái Tài',
	N'thaitai',
	1
)

GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'BOSS' -- nvarchar(100)

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

DECLARE @i INT = 1

WHILE @i < 10
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM DBO.TableFood
GO

EXEC DBO.USP_GetTableList
GO

--Them loai thuc an
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Thức ăn nước' ) -- name - nvarchar(100)
          
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Thức ăn khô' )
          
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước uống' )

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Thức ăn thêm' )

--Them mon an
--1.Thuc an nuoc
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở đặc biệt', -- name - nvarchar(100)
          1, -- idCategory - int
          39000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở tái', 1, 35000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở gà ', 1, 30000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở bò chín', 1, 35000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở bò viên ', 1, 30000)

--2.Thuc an kho
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở cuốn ', 2, 30000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở chiên phồng ', 2, 30000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Phở chiên trứng ', 2, 30000)

--3.Nuoc uong
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'7Up', 3, 12000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Sting', 3, 12000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Trà đá', 3, 2000)

--4.Thuc an them
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Bánh phở', 4, 8000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Bò', 4, 8000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Bò viên', 4, 8000)

--Them hoa don
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          1 , -- idTable - int
          0  -- status - int
        )
        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          2, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          3 , -- idTable - int
          1  -- status - int
        )

--Them chi tiet hoa don
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )

INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )

INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )

INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status,
		  discount
        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
			NULL , -- DateCheckOut - date
			@idTable , -- idTable - int
			0,  -- status - int
			0
			)		
END
GO

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b
	WHERE idBill =@idBill AND idFood =@idFood

	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF ( @newCount>0 )
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE 
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
	INSERT	dbo.BillInfo
			(	idBill, idFood, count )
	VALUES  (	@idBill, -- idBill - int
				@idFood, -- idFood - int
				@count  -- count - int
			)
	END
END
GO

DELETE dbo.BillInfo

DELETE dbo.Bill

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

--Cap nhat moi

ALTER TABLE dbo.Bill
ADD discount INT

UPDATE dbo.Bill SET discount = 0
GO


CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO