USE [EconomicIE]
GO
/****** Object:  StoredProcedure [dbo].[Recover]    Script Date: 10/10/2022 10:45:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Recover]
	@email nvarchar(200)
As
Begin 
	SELECT CONVERT(nvarchar(200), DECRYPTBYPASSPHRASE('password',Password )) as Password from [User] where Email =@email
END