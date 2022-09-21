/*
 Navicat Premium Data Transfer

 Source Server         : FrontDeskAppDb
 Source Server Type    : SQL Server
 Source Server Version : 15002095
 Source Host           : .\SQLExpress:1433
 Source Catalog        : FrontDeskAppDb
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002095
 File Encoding         : 65001

 Date: 22/09/2022 01:19:23
*/


-- ----------------------------
-- Table structure for AreaBoxes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AreaBoxes]') AND type IN ('U'))
	DROP TABLE [dbo].[AreaBoxes]
GO

CREATE TABLE [dbo].[AreaBoxes] (
  [AreaBoxId] int  IDENTITY(1,1) NOT NULL,
  [Name] nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [AreaType] nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AreaBoxes] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'Small, Medium, Large',
'SCHEMA', N'dbo',
'TABLE', N'AreaBoxes',
'COLUMN', N'AreaType'
GO

EXEC sp_addextendedproperty
'MS_Description', N'Vacant, Occupied',
'SCHEMA', N'dbo',
'TABLE', N'AreaBoxes',
'COLUMN', N'Status'
GO


-- ----------------------------
-- Records of AreaBoxes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AreaBoxes] ON
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'1', N'SM Box 1  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'2', N'SM Box 2  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'3', N'SM Box 3  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'4', N'SM Box 4  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'5', N'SM Box 5  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'6', N'SM Box 6  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'7', N'SM Box 7  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'8', N'SM Box 8  ', N'SMALL     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'9', N'SM Box 9  ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'10', N'SM Box 10 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'11', N'SM Box 11 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'12', N'SM Box 12 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'13', N'SM Box 13 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'14', N'SM Box 14 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'15', N'SM Box 15 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'16', N'SM Box 16 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'17', N'SM Box 17 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'18', N'SM Box 18 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'19', N'SM Box 19 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'20', N'SM Box 20 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'21', N'SM Box 21 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'22', N'SM Box 22 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'23', N'SM Box 23 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'24', N'SM Box 24 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'25', N'SM Box 25 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'26', N'SM Box 26 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'27', N'SM Box 27 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'28', N'SM Box 28 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'29', N'SM Box 29 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'30', N'SM Box 30 ', N'SMALL     ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'31', N'MD Box 1  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'32', N'MD Box 2  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'33', N'MD Box 3  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'34', N'MD Box 4  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'35', N'MD Box 5  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'36', N'MD Box 6  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'37', N'MD Box 7  ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'38', N'MD Box 8  ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'39', N'MD Box 9  ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'40', N'MD Box 10 ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'41', N'MD Box 11 ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'42', N'MD Box 12 ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'43', N'MD Box 13 ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'44', N'MD Box 14 ', N'MEDIUM    ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'45', N'MD Box 15 ', N'MEDIUM    ', N'VACANT    ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'46', N'LG BOX 1  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'47', N'LG BOX 2  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'48', N'LG BOX 3  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'49', N'LG BOX 4  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'50', N'LG BOX 5  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'51', N'LG BOX 6  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'52', N'LG BOX 7  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'53', N'LG BOX 8  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'54', N'LG BOX 9  ', N'LARGE     ', N'OCCUPIED  ')
GO

INSERT INTO [dbo].[AreaBoxes] ([AreaBoxId], [Name], [AreaType], [Status]) VALUES (N'55', N'LG BOX 10 ', N'LARGE     ', N'OCCUPIED  ')
GO

SET IDENTITY_INSERT [dbo].[AreaBoxes] OFF
GO


-- ----------------------------
-- Table structure for Customers
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type IN ('U'))
	DROP TABLE [dbo].[Customers]
GO

CREATE TABLE [dbo].[Customers] (
  [CustomerId] int  IDENTITY(1,1) NOT NULL,
  [FirstName] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [LastName] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [PhoneNumber] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Customers] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Customers
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Customers] ON
GO

INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (N'1', N'Dondon ', N'Abiada', N'09158565605')
GO

INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (N'2', N'Kate', N'Salvacion', N'09158565608')
GO

INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (N'3', N'Patty', N'Initan', N'09499725771')
GO

INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (N'1002', N'Tess', N'Prieto', N'09124141124')
GO

SET IDENTITY_INSERT [dbo].[Customers] OFF
GO


-- ----------------------------
-- Table structure for Transactions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Transactions]') AND type IN ('U'))
	DROP TABLE [dbo].[Transactions]
GO

CREATE TABLE [dbo].[Transactions] (
  [TransactionId] int  IDENTITY(1,1) NOT NULL,
  [CustomerId] int  NOT NULL,
  [AreaBoxId] int  NOT NULL,
  [DateStored] datetime2(7)  NOT NULL,
  [DateRetrieved] datetime2(7)  NOT NULL,
  [Status] nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Transactions] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'STORED, RETRIEVED',
'SCHEMA', N'dbo',
'TABLE', N'Transactions',
'COLUMN', N'Status'
GO


-- ----------------------------
-- Records of Transactions
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Transactions] ON
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1', N'1', N'31', N'2022-09-15 00:28:15.5321210', N'2022-09-15 01:59:39.3871806', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'2', N'1', N'1', N'2022-09-15 00:46:51.1797931', N'2022-09-15 01:59:58.7586331', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'3', N'1', N'46', N'2022-09-15 02:22:02.6265770', N'2022-09-21 09:28:22.7031200', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'4', N'1', N'10', N'2022-09-20 21:37:07.5038106', N'2022-09-21 09:34:43.7268674', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'5', N'3', N'31', N'2022-09-20 21:48:14.7420382', N'2022-09-21 12:37:57.7592572', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1004', N'1', N'46', N'2022-09-21 09:29:33.4694260', N'2022-09-21 12:39:11.4199229', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1005', N'1', N'46', N'2022-09-21 10:44:54.9795866', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1006', N'1', N'47', N'2022-09-21 10:45:08.7504881', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1007', N'1', N'46', N'2022-09-21 10:46:42.4035335', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1008', N'1', N'48', N'2022-09-21 12:30:58.9776694', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1009', N'2', N'49', N'2022-09-21 12:31:14.3855788', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1010', N'3', N'50', N'2022-09-21 12:31:31.9184960', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1011', N'1002', N'51', N'2022-09-21 12:31:45.7005854', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1012', N'1', N'52', N'2022-09-21 12:31:57.1758168', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1013', N'1', N'53', N'2022-09-21 12:32:05.3850006', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1014', N'1002', N'54', N'2022-09-21 12:32:24.4792476', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1015', N'1', N'55', N'2022-09-21 12:32:59.7096409', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1016', N'1', N'32', N'2022-09-21 12:34:41.2436063', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1017', N'1', N'1', N'2022-09-21 12:41:57.6647621', N'2022-09-21 18:29:39.6503600', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1018', N'1', N'2', N'2022-09-21 12:43:17.2186882', N'2022-09-21 18:31:13.0925080', N'RETRIEVED ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1019', N'1', N'3', N'2022-09-21 12:46:02.5978409', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1020', N'1', N'31', N'2022-09-21 12:48:39.1817042', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1021', N'1', N'33', N'2022-09-21 13:10:06.1547863', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1022', N'1', N'34', N'2022-09-21 13:11:12.3822374', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1023', N'1', N'4', N'2022-09-21 13:15:11.9503119', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1024', N'1', N'5', N'2022-09-21 13:17:23.9257703', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1025', N'1', N'6', N'2022-09-21 18:28:32.8254296', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1026', N'1', N'35', N'2022-09-21 18:30:30.4272303', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1027', N'3', N'44', N'2022-09-21 18:32:55.4571392', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1028', N'1', N'46', N'2022-09-21 18:33:55.8056674', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1029', N'1', N'1', N'2022-09-21 19:11:47.4221021', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1030', N'1', N'36', N'2022-09-21 19:12:44.8318611', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1031', N'1', N'2', N'2022-09-21 19:32:14.6799642', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'1032', N'1', N'7', N'2022-09-21 19:47:52.0975635', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'2004', N'1', N'37', N'2022-09-22 00:28:51.8920065', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [AreaBoxId], [DateStored], [DateRetrieved], [Status]) VALUES (N'2005', N'2', N'8', N'2022-09-22 00:53:15.2864052', N'0001-01-01 00:00:00.0000000', N'STORED    ')
GO

SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO


-- ----------------------------
-- Auto increment value for AreaBoxes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AreaBoxes]', RESEED, 1000)
GO


-- ----------------------------
-- Primary Key structure for table AreaBoxes
-- ----------------------------
ALTER TABLE [dbo].[AreaBoxes] ADD CONSTRAINT [PK_AreaBoxes] PRIMARY KEY CLUSTERED ([AreaBoxId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Customers
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Customers]', RESEED, 1002)
GO


-- ----------------------------
-- Primary Key structure for table Customers
-- ----------------------------
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Transactions
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Transactions]', RESEED, 2005)
GO


-- ----------------------------
-- Primary Key structure for table Transactions
-- ----------------------------
ALTER TABLE [dbo].[Transactions] ADD CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED ([TransactionId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Transactions
-- ----------------------------
ALTER TABLE [dbo].[Transactions] ADD CONSTRAINT [FK__Transacti__Custo__3A81B327] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Transactions] ADD CONSTRAINT [FK__Transacti__AreaB__3B75D760] FOREIGN KEY ([AreaBoxId]) REFERENCES [dbo].[AreaBoxes] ([AreaBoxId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

