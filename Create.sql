USE [EconomicIE]
GO
/****** Object:  StoredProcedure [dbo].[sp_Registras]    Script Date: 10/10/2022 10:45:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Registras]
    -- Add the parameters for the stored procedure here
    @name nvarchar(100),
	@email nvarchar(100),
	@phoneNumber nvarchar(100),
	@dni nvarchar(100),
	@password nvarchar(100),
	@estado bit,
	@creacion datetime
AS
BEGIN
	INSERT INTO [User](Name,Email,PhoneNumber,DNI,Password, Creation, State)
    VALUES(@name, @email,@phoneNumber,@dni,ENCRYPTBYPASSPHRASE('password',@password),@creacion , @estado)
END