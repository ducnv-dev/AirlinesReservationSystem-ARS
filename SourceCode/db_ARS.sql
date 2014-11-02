--Create Database--
create DATABASE ARS
GO
USE ARS
GO
------------------------------------------------------------------
					-- CREATE TABLES --
------------------------------------------------------------------
-------------------- CREATE TABLE USER --------------------------
CREATE TABLE USERS
(
	[USER_ID] int identity(1,1) NOT NULL,
	USERNAME nvarchar(50) NOT NULL,
	[PASSWORD] nvarchar(20) NOT NULL,
	USER_FULLNAME nvarchar(100) NOT NULL,
	USER_ADDRESS nvarchar(100),
	USER_pHONE nvarchar(15),
	USER_EMAIL nvarchar(100),
	USER_STATUS int,
)
GO
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE USERS
	ADD CONSTRAINT PK_USER_ID
	primary key([USER_ID])
GO
-------------------- CREATE TABLE AIRPORT --------------------------
CREATE TABLE AIRPORT(
	AIRPORT_ID INT IDENTITY(1,1) NOT NULL,
	AIRPORT_CODE NVARCHAR(20),
	AIRPORT_NAME NVARCHAR(20),
)
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE AIRPORT
	ADD CONSTRAINT PK_AIRPORT_ID
	primary key(AIRPORT_ID)
GO
-------------------- CREATE TABLE PLANE --------------------------
CREATE TABLE PLANE(
	PLANE_ID INT IDENTITY(1,1) NOT NULL,
	PLANE_CODE NVARCHAR(20),
	PLANE_NAME NVARCHAR(20),
	PLANE_TOTALSEATS INT,
	PLANE_STATUS INT,
)
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE PLANE
	ADD CONSTRAINT PK_PLANE_ID
	primary key(PLANE_ID)
GO
-------------------- CREATE TABLE AIRLINE --------------------------
CREATE TABLE AIRLINE(
	AIRLINE_ID INT IDENTITY(1,1) NOT NULL,
	AIRLINE_CODE NVARCHAR(20),
	AIRLINE_START_AIRPORT INT,
	AIRLINE_END_AIRPORT INT,
	AIRLINE_DISTANCE INT,
	AIRLINE_STATUS INT,
)
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE AIRLINE
	ADD CONSTRAINT PK_AIRLINE_ID
	primary key(AIRLINE_ID)
GO
-------------------- ADD FOREIGN KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE AIRLINE
	ADD CONSTRAINT FK_AIRLINE_START_AIRPORT
	foreign key(AIRLINE_START_AIRPORT)
	references AIRPORT(AIRPORT_ID)
GO
ALTER TABLE AIRLINE
	ADD CONSTRAINT FK_AIRLINE_END_AIRPORT
	foreign key(AIRLINE_END_AIRPORT)
	references AIRPORT(AIRPORT_ID)
GO
-------------------- CREATE TABLE FLIGHT --------------------------
CREATE TABLE FLIGHT(
	FLIGHT_ID INT IDENTITY(1,1) NOT NULL,
	FLIGHT_CODE NVARCHAR(20),
	FLIGHT_PLANE_ID INT,
	FLIGHT_AIRLINE_ID INT,
	FLIGHT_START_DATE NVARCHAR(20),
	FLIGHT_END_DATE NVARCHAR(20),
	FLIGHT_PRICE INT,
	FLIGHT_TOTALSEATS INT,
)
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE FLIGHT
	ADD CONSTRAINT PK_FLIGHT_ID
	primary key(FLIGHT_ID)
GO
-------------------- ADD FOREIGN KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE FLIGHT
	ADD CONSTRAINT FK_FLIGHT_PLANE_ID
	foreign key(FLIGHT_PLANE_ID)
	references PLANE(PLANE_ID)
GO
ALTER TABLE FLIGHT
	ADD CONSTRAINT FK_FLIGHT_AIRLINE_ID
	foreign key(FLIGHT_AIRLINE_ID)
	references AIRLINE(AIRLINE_ID)
GO
-------------------- CREATE TABLE TICKETS --------------------------
CREATE TABLE TICKETS(
	TICKETS_ID INT IDENTITY(1,1) NOT NULL,
	TICKETS_CODE NVARCHAR(20),
	TICKETS_CUSTOMER INT,
	TICKETS_AIRLINE_ID INT,
	TICKETS_FLIGHT_ID INT,
	TICKETS_SEAT INT,
	TICKETS_TOTALPRICE INT,
)
-------------------- ADD PRIMARY KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE TICKETS
	ADD CONSTRAINT PK_TICKETS_ID
	primary key(TICKETS_ID)
GO
-------------------- ADD FOREIGN KEY-------------------------------
-------------------------------------------------------------------
ALTER TABLE TICKETS
	ADD CONSTRAINT FK_TICKETS_CUSTOMER
	foreign key(TICKETS_CUSTOMER)
	references USERS([USER_ID])
GO
ALTER TABLE TICKETS
	ADD CONSTRAINT FK_TICKETS_AIRLINE_ID
	foreign key(TICKETS_AIRLINE_ID)
	references AIRLINE(AIRLINE_ID)
GO
ALTER TABLE TICKETS
	ADD CONSTRAINT FK_TICKETS_FLIGHT_ID
	foreign key(TICKETS_FLIGHT_ID)
	references FLIGHT(FLIGHT_ID)
GO

-------------Insert Data----------------------
--User
INSERT INTO USERS
	VALUES('ducnv','ducnv','Nguyen Van Duc','Ha Noi','0983932993','ducnvgc00560@fpt.edu.vn',1)
GO
INSERT INTO USERS
	VALUES('ducnv1','ducnv1','Nguyen Van Duc1','Ha Noi','0983932993','ducnvgc00560@fpt.edu.vn',1)
GO
INSERT INTO USERS
	VALUES('ducnv2','ducnv2','Nguyen Van Duc2','Ha Noi','0983932993','ducnvgc00560@fpt.edu.vn',1)
GO
--AirPort
INSERT INTO AIRPORT
	VALUES('NB','San Bay Noi Bai')
GO
INSERT INTO AIRPORT
	VALUES('TSN','San Bay Tan Son Nhat')
GO
INSERT INTO AIRPORT
	VALUES('DN','San Bay Da Nang')
GO
--PLANE
INSERT INTO PLANE
	VALUES('VN-01','VIETNAM-01',100,1)
GO
INSERT INTO PLANE
	VALUES('VN-01','VIETNAM-01',100,1)
GO
INSERT INTO PLANE
	VALUES('VN-02','VIETNAM-02',200,1)
GO
INSERT INTO PLANE
	VALUES('VN-03','VIETNAM-03',300,1)
GO
--AIRLINE
INSERT INTO AIRLINE
	VALUES('VN-LINE01',1,2,300,1)
GO
INSERT INTO AIRLINE
	VALUES('VN-LINE02',2,1,300,1)
GO
INSERT INTO AIRLINE
	VALUES('VN-LINE03',1,3,300,1)
GO
INSERT INTO AIRLINE
	VALUES('VN-LINE01',3,1,300,1)
GO
INSERT INTO AIRLINE
	VALUES('VN-LINE01',2,3,300,1)
GO

--FLIGHT
INSERT INTO FLIGHT
	VALUES('VN-LINE01',1,2,'10/7/2014','11/7/2014',1000000,100)
GO
INSERT INTO FLIGHT
	VALUES('VN-LINE01',2,2,'15/7/2014','16/7/2014',2000000,100)
GO
--TICKETS
INSERT INTO TICKETS
	VALUES('VN-TICKET01',1,2,1,1,1000000)
GO
INSERT INTO TICKETS
	VALUES('VN-TICKET02',1,2,1,1,2000000)
GO