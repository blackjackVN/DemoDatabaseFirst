create table Products (ProductID int primary key not null IDENTITY(1,1),
ProductName nvarchar(40) not null, 
UnitPrice money not null, 
UnitInStock smallint not null, 
CategoryID int   not null  )


create table Categories (CategoryID int primary key not null IDENTITY(1,1), CategoryName nvarchar(15))