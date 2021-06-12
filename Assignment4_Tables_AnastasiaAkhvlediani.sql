create table Table_1_Books
(
	TiTle nvarchar(50) not null, 
	Author nvarchar(50) not null, 
	ISBN bigint primary key not null, 
	Price decimal(18,0) not null, 
	Lines bigint not null
);

create table Table_1_Customers
(
	firstName nvarchar(50) not null, 
	lastName nvarchar(50) not null, 
	[address] nvarchar(50) not null,
	city nvarchar(50) not null,
	zip int not null,
	states nvarchar(50) not null, 
	homePhone nvarchar(50) not null,
	email nvarchar(50) not null, 
	id int identity primary key not null
)

create table Table_1_OrderDetails
(
	orderId int identity primary key not null,
	bookId nvarchar(50) not null, 
	bookQuantity nvarchar(50) not null, 
	totalLines nvarchar(50) null, 
);

create table Table_1_Orders
(
	orderId int identity primary key not null,
	customerId int not null,
	subTotal float not null,
	myTax float not null,
	totalAmount float not null,
	orderDate nvarchar(50) not null
);