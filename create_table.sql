create table Users
    (
    [Id] Int identity Primary key,
    [UserName] nvarchar(100),
    [Password] nvarchar(100),
    [CustomerId] int foreign key references Customers(CustomerId)
    )