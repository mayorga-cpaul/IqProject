USE [EconomicIE]
GO
/****** Object:  StoredProcedure [dbo].[GetUniqueNameInvesment]    Script Date: 10/10/2022 10:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUniqueNameInvesment]
    @solutionId INT
    AS
BEGIN
     SELECT DISTINCT Name, Email FROM InvestmentEntity WHERE ProjectId IN
     (SELECT P.Id FROM Project AS P INNER JOIN Solution S on S.Id = P.SolutionId WHERE S.Id = @solutionId)
END