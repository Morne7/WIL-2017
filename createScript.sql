drop table truck
drop table truckType

create table truckType (
	ID				integer identity(0,1) primary key,
	type			varchar(30),
	manufacturor	varchar(30),
	engineSize		int, --cc
	serviceInterval	int, --km
	maxWeight		int, --kg
	maxVol			int --mm3
)

create table truck (
	ID			integer identity(0,1) primary key,
	vin			varchar(20),
	reg			varchar(20),
	kms			integer,
	availible	bit,
	truckType	int foreign key references truckType(ID) 
)

create table userType (
	ID			integer identity(0,1) primary key,
	userType	varchar(30)
)

create table users (
	ID			integer identity(0,1) primary key,
	username	varchar(30),
	pass		varchar(30),
	userType		int foreign key references userType(ID),
	hours		int,
	fname		varchar(30),
	lname		varchar(30)
)

create table serviceType (
	ID		integer identity(0,1) primary key,
	job		varchar(50),
	cost	money,
	hours	int
)

create table service (
	ID			integer identity(0,1) primary key,
	truckID		integer foreign key references truck(ID),
	mechanic	integer foreign key references users(ID)
)

create table serviceItem (
	ID			integer identity(0,1) primary key,
	serviceID		integer foreign key references service(ID),
	serviceJob		integer foreign key references serviceType(ID)
)

create table department (
	ID		integer identity(0,1) primary key,
	name	varchar(30)
)

create table customer (
	ID			integer identity(0,1) primary key,
	userID		integer foreign key references users(ID),
	bankDetails varchar(100)	
)

create table routes (
	ID			integer identity(0,1) primary key,
	departure	integer foreign key references department(ID),
	destination	integer foreign key references department(ID),
	kms			integer
)

create table trip (
	ID			integer identity(0,1) primary key,
	truckID		integer foreign key references truck(ID),
	clientID	integer foreign key references customer(ID),
	startDate	datetime,
	endDate		datetime,
	driverID	integer foreign key references users(ID),
	routeID		integer foreign key references routes(ID)
)

insert into truckType(type, manufacturor, engineSize, serviceInterval, maxWeight, maxVol)
values('bakkie','Isuzu',2500,15000,1174,1564557280)

insert into truck(vin,reg,kms,availible,truckType)
values('987654321','bak-1',200,1,0)

insert into department(name)
values('Cape Town'),
	  ('Johannesburg')

insert into routes(departure, destination,kms)
values(0,1,1400)
