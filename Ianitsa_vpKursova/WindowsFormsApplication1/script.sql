USE [master]
GO
/****** Object:  Database [kursovaSQL]    Script Date: 21-Dec-15 3:57:57 PM ******/
CREATE DATABASE [kursovaSQL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kursovaSQL', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\kursovaSQL.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'kursovaSQL_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\kursovaSQL_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [kursovaSQL] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kursovaSQL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kursovaSQL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kursovaSQL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kursovaSQL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kursovaSQL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kursovaSQL] SET ARITHABORT OFF 
GO
ALTER DATABASE [kursovaSQL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kursovaSQL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kursovaSQL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kursovaSQL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kursovaSQL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kursovaSQL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kursovaSQL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kursovaSQL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kursovaSQL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kursovaSQL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kursovaSQL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kursovaSQL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kursovaSQL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kursovaSQL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kursovaSQL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kursovaSQL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kursovaSQL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kursovaSQL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kursovaSQL] SET  MULTI_USER 
GO
ALTER DATABASE [kursovaSQL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kursovaSQL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kursovaSQL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kursovaSQL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [kursovaSQL] SET DELAYED_DURABILITY = DISABLED 
GO
USE [kursovaSQL]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckPass]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[CheckPass](@Name nvarchar(20), @Pass nvarchar(10))
returns bit
as 
begin
  declare @result  bit
  if exists (select * from Users
             where UserName=@Name and Password=@Pass)
			 set @result=1
			 else
			   set @result=0
         return @result
end

GO
/****** Object:  UserDefinedFunction [dbo].[Sum_Product_Sales]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Sum_Product_Sales](@ProductID int)
returns money
as
begin
	declare @Sum_Product_Sales money
  select @Sum_Product_Sales= sum(cast(Quantity * p.Price as money))from  Order_detail p
           inner join Product o on p.Product_id=o.Product_id
		   where p.Product_id=@ProductID
		   if @Sum_Product_Sales is null
		  set @Sum_Product_Sales = 0
return @Sum_Product_Sales
end
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[C_id] [int] IDENTITY(1,1) NOT NULL,
	[C_Fname] [nvarchar](20) NOT NULL,
	[C_Lname] [nvarchar](20) NOT NULL,
	[C_address] [nvarchar](max) NULL,
	[C_City] [nvarchar](50) NOT NULL,
	[C_Country] [nvarchar](50) NOT NULL,
	[C_datemodifay] [datetime] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[C_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Jurnal]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jurnal](
	[Date] [datetime] NOT NULL,
	[Operation] [nvarchar](6) NOT NULL,
	[Table_name] [nvarchar](100) NOT NULL,
	[Old_values] [nvarchar](max) NULL,
	[New_values] [nvarchar](max) NULL,
 CONSTRAINT [PK_Jurnal] PRIMARY KEY CLUSTERED 
(
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_detail]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_detail](
	[Product_id] [int] NOT NULL,
	[Order_id] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Datemodifay] [datetime] NULL,
 CONSTRAINT [PK_Order_detail] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC,
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[C_id] [int] NOT NULL,
	[order_date] [datetime] NOT NULL,
	[sheeped_date] [datetime] NOT NULL,
	[O_maodifaydate] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_id] [int] IDENTITY(1,1) NOT NULL,
	[Product_name] [nvarchar](30) NOT NULL,
	[p_modifaydate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_Customer_Orders]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create view [dbo].[v_Customer_Orders]
 as
 select c.C_id,c.C_Fname,c.C_Lname,c.C_Country,c.C_City,o.Order_id,o.Order_date,o.Sheeped_date
    from Customers c inner join Orders o on c.C_id=o.C_id
GO
/****** Object:  View [dbo].[V_Product_OrD]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_Product_OrD]
as select p.Product_id,p.Product_name,od.Quantity,od.Price,od.Order_id
 from Product p inner join Order_detail od on p.Product_id=od.Product_id
GO
/****** Object:  View [dbo].[v_Product_Order]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_Product_Order]
as
select p.Product_id,p.Product_name,od.Price,od.Quantity,o.Order_id
  from Product p inner join Order_detail od on p.Product_id=od.Product_id
                 inner join Orders o on o.Order_id=od.Order_id 
GO
/****** Object:  View [dbo].[v_SearchSales]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_SearchSales]
 as
 select o.Order_id,c.C_id,c.C_Fname,c.C_Lname,c.C_Country,c.C_City,p.Product_name,od.Price,od.Quantity,o.Order_date,o.Sheeped_date
    from Customers c inner join Orders o on c.C_id=o.C_id
	                 inner join Order_detail od on o.Order_id=od.Order_id
					 inner join Product p on p.Product_id=od.Product_id

GO
ALTER TABLE [dbo].[Order_detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Orders] FOREIGN KEY([Order_id])
REFERENCES [dbo].[Orders] ([Order_id])
GO
ALTER TABLE [dbo].[Order_detail] CHECK CONSTRAINT [FK_Order_detail_Orders]
GO
ALTER TABLE [dbo].[Order_detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Product] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Product] ([Product_id])
GO
ALTER TABLE [dbo].[Order_detail] CHECK CONSTRAINT [FK_Order_detail_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([C_id])
REFERENCES [dbo].[Customers] ([C_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
/****** Object:  StoredProcedure [dbo].[sp_Customer_Order]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Customer_Order]
@C_id int =null,
@C_Fname nvarchar(20) =null,
@C_Lname nvarchar(20) = null,
@Order_id int =null
as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from v_Customer_Orders
  where 1=1 '
  if @C_id is not null 
   set @SQL_STRING=@SQL_STRING +'AND C_id = '+cast(@C_id as varchar(10))+' '
  if @C_Fname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Fname like''%' +@C_Fname+'%'' '
  if @C_Lname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Lname  like''%' + @C_Lname+'%'' '
   if @Order_id is not null
   set @SQL_STRING=@SQL_STRING +'AND Order_id  like''%' + @Order_id+'%'' '
 exec (@SQL_STRING) 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_del_Customer]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_del_Customer]
@C_id int
as 
delete from Customers
where C_id=@C_id
GO
/****** Object:  StoredProcedure [dbo].[sp_delOrders]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delOrders]
@Order_id int
as
delete from Orders
where Order_id=@Order_id
GO
/****** Object:  StoredProcedure [dbo].[sp_delOrdersDetail]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delOrdersDetail]
@OrderDet_id int,
@Product_id int
as
delete from Order_detail
where Order_id=@OrderDet_id and Product_id=@Product_id
GO
/****** Object:  StoredProcedure [dbo].[sp_delProduct]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delProduct]
@Product int
as
delete from Product
where Product_id=@Product 
GO
/****** Object:  StoredProcedure [dbo].[sp_insertOrderDetail]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertOrderDetail]
@Product_id int=null,
@Order_id int=null,
@Quantity int=null,
@Price money=null

as begin
 declare @msg nvarchar (50)
 --select @C_id=max(c_id) from Customers
 select @Product_id=max(Product_id) from Product
 select @Order_id=max(Order_id) from Orders
   begin try
     insert into Order_detail (Product_id,Order_id,Quantity,Price)
	 values (@Product_id, @Order_id,@Quantity,@Price)

	 end try
   begin catch
   set @msg=N'Kolichestvoto ili cenata ne moje da bade dobaveno!'
   raiserror(@msg, 16,1)
   return
   end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertOrders]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertOrders]
@C_id int=null,
@Order_date datetime=null,
@Sheeped_date datetime=null

as begin
 declare @msg nvarchar (40)
 select @C_id=max(c_id) from Customers
   begin try
     insert into Orders(C_id,order_date,sheeped_date)
	 values(@C_id,@Order_date,@Sheeped_date )

end try
   begin catch
   set @msg=N'Porachkata ne moje da bade dobavena'
   raiserror(@msg, 16,1)
   return
   end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertProduct]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertProduct]
@Product_name nvarchar(30)

as begin
 declare @msg nvarchar (40)
   begin try
     insert into Product ( Product_name )
	 values( @Product_name  )
   end try
   begin catch
   set @msg=N'Producta ne moje da bade dobaven'
   raiserror(@msg, 16,1)
   return
   end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertUser]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertUser]
@Name nvarchar(20),
@Pass nvarchar(10)

as begin
 declare @msg nvarchar (40)
   begin try
     insert into Users( UserName, Password )
	 values( @Name,@Pass  )
   end try
   begin catch
   set @msg=N'Producta ne moje da bade dobaven'
   raiserror(@msg, 16,1)
   return
   end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_isert_Customer]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_isert_Customer]
@Fname nvarchar(20)=null,
@Lname nvarchar(20)=null,
@address nvarchar(max)=null,
@City nvarchar(50)=null,
@Country nvarchar(50)=null
 as begin
 declare @msg nvarchar (30)
   begin try
     insert into Customers (C_Fname,C_Lname,C_address,C_City,C_Country)
	 values(@Fname,@Lname,@address,@City,@Country  )
   end try
   begin catch
   set @msg=N'Klienta ne moje da bade dobaven'
   raiserror(@msg, 16,1)
   return
   end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_isertCustomer]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_isertCustomer]
@Fname nvarchar(20)=null,
@Lname nvarchar(20)=null,
@address nvarchar(max)=null,
@City nvarchar(50)=null,
@Country nvarchar(50)=null
 as begin
 declare @msg nvarchar (30)
   begin try
     insert into Customers (C_Fname,C_Lname,C_address,C_City,C_Country)
	 values(@Fname,@Lname,@address,@City,@Country  )
   end try
   begin catch
   set @msg=N'Klienta ne moje da bade dobaven'
   raiserror(@msg, 16,1)
   return
   end catch
end


GO
/****** Object:  StoredProcedure [dbo].[sp_Product_OrD]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Product_OrD]
@Product_id int=null,
@Product_name nvarchar(30)= null,
@Order_id int =null
as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from V_Product_OrD
  where 1=1'
    if @Product_id is not null
	  set @SQL_STRING=@SQL_STRING +'AND Product_id = '+cast(@Product_id as varchar(10))+' '
    if @Product_name is not null
	  set @SQL_STRING=@SQL_STRING +'AND Product_name like''%' +@Product_name+'%'' '
	if @Order_id is not null
	  set @SQL_STRING=@SQL_STRING +'AND Order_id = '+cast(@Order_id as varchar(10))+' '

 exec (@SQL_STRING) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Product_Orders]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Product_Orders]
@Order_id int=null,
@Product_id int=null,
@Product_name nvarchar(30)= null,
@Quantity int=null,
@Price money=null

as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from v_Product_Order
  where 1=1'
  if @Product_id is not null
	  set @SQL_STRING=@SQL_STRING +'AND Product_id = '+cast(@Product_id as varchar(10))+' '
    if @Product_name is not null
	  set @SQL_STRING=@SQL_STRING +'AND Product_name like''%' +@Product_name+'%'' '
	if @Order_id is not null
	  set @SQL_STRING=@SQL_STRING +'AND Order_id = '+cast(@Order_id as varchar(10))+' '
    if @Quantity  is not null
	  set @SQL_STRING=@SQL_STRING +'AND Quantity  = '+cast(@Quantity  as varchar(10))+' '
   
	if @Price is not null
	  set @SQL_STRING=@SQL_STRING +'AND Price = '+cast(@Price as varchar(10))+' '

 
 exec (@SQL_STRING) 
END  

GO
/****** Object:  StoredProcedure [dbo].[sp_ReportQtyProduct]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ReportQtyProduct]
@Product_name nvarchar(30)= null
as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from v_Product_Order
  where 1=1'
if @Product_name is not null
	  set @SQL_STRING=@SQL_STRING +'AND Product_name like''%' +@Product_name+'%'' '
exec (@SQL_STRING) 
END 
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchCustomer]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SearchCustomer]
@C_id int =null,
@C_Fname nvarchar(20) =null,
@C_Lname nvarchar(20) = null
as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from Customers
  where 1=1 '
  if @C_id is not null 
   set @SQL_STRING=@SQL_STRING +'AND C_id = '+cast(@C_id as varchar(10))+' '
  if @C_Fname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Fname like''%' +@C_Fname+'%'' '
  if @C_Lname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Lname  like''%' + @C_Lname+'%'' '
exec (@SQL_STRING) 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchSales]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SearchSales]

@C_Fname nvarchar(20) =null,
@C_Lname nvarchar(20) = null,
@Order_id int =null
as
 begin
  declare @SQL_STRING  nvarchar(max)
  set @SQL_STRING=
  'select * from v_SearchSales
  where 1=1 '

  if @C_Fname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Fname like''%' +@C_Fname+'%'' '
  if @C_Lname is not null
   set @SQL_STRING=@SQL_STRING +'AND C_Lname  like''%' + @C_Lname+'%'' '
   if @Order_id is not null
   set @SQL_STRING=@SQL_STRING +'AND Order_id  like''%' + @Order_id+'%'' '
 exec (@SQL_STRING) 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_updateCustomers]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateCustomers]
	@C_id int,
	@FName nvarchar(20),
	@LName nvarchar(20),
	@Address nvarchar(max),
	@City nvarchar(50),
	@Country nvarchar(50)
AS
  BEGIN
  UPDATE Customers
  SET
  C_Fname=@FName,C_Lname=@LName,C_address=@Address,C_City=@City,C_Country=@Country
  where C_id=@C_id
  END

GO
/****** Object:  StoredProcedure [dbo].[sp_User]    Script Date: 21-Dec-15 3:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_User]
@Pass varchar(10),
@Name varchar(20)

as
select count(*)from Users
where Password=@Pass and UserName=@Name
GO
USE [master]
GO
ALTER DATABASE [kursovaSQL] SET  READ_WRITE 
GO
