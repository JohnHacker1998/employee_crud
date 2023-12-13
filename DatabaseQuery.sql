Create database employee_crud
use employee_crud

CREATE TABLE Employee (
    Employee_ID NVARCHAR(30) PRIMARY KEY,
    Name NVARCHAR(MAX),
    Phone VARCHAR(12),
    Region NVARCHAR(MAX),
    City NVARCHAR(MAX),
    Sub_City NVARCHAR(MAX),
    Location_Special_Name NVARCHAR(MAX),
    Data_Update_Date DATE,
    Active_Ind BIT
);

CREATE PROCEDURE AddEmployee
    @Employee_ID NVARCHAR(30),
    @Name NVARCHAR(255),
    @Phone VARCHAR(12),
    @Region NVARCHAR(255),
    @City NVARCHAR(255),
    @Sub_City NVARCHAR(255),
    @Location_Special_Name NVARCHAR(255),
    @Data_Update_Date DATE,
    @Active_Ind BIT
AS
BEGIN
    INSERT INTO Employee (Employee_ID, Name, Phone, Region, City, Sub_City, Location_Special_Name, Data_Update_Date, Active_Ind)
    VALUES (@Employee_ID, @Name, @Phone, @Region, @City, @Sub_City, @Location_Special_Name, @Data_Update_Date, @Active_Ind);
END;

CREATE PROCEDURE UpdateEmployee
    @Employee_ID NVARCHAR(30),
    @Name NVARCHAR(255),
    @Phone VARCHAR(12),
    @Region NVARCHAR(255),
    @City NVARCHAR(255),
    @Sub_City NVARCHAR(255),
    @Location_Special_Name NVARCHAR(255),
    @Data_Update_Date DATE,
    @Active_Ind BIT
AS
BEGIN
    UPDATE Employee
    SET
        Name = @Name,
        Phone = @Phone,
        Region = @Region,
        City = @City,
        Sub_City = @Sub_City,
        Location_Special_Name = @Location_Special_Name,
        Data_Update_Date = @Data_Update_Date,
        Active_Ind = @Active_Ind
    WHERE Employee_ID = @Employee_ID;
END;

CREATE PROCEDURE SearchEmployeeByID
    @Employee_ID NVARCHAR(30)
AS
BEGIN
    SELECT *
    FROM Employee
    WHERE Employee_ID = @Employee_ID;
END;

CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT *
    FROM Employee
END;
CREATE PROCEDURE SearchEmployeeByName
    @Name NVARCHAR(255)
AS
BEGIN
    SELECT *
    FROM Employee
    WHERE Name LIKE '%' + @Name + '%';
END;