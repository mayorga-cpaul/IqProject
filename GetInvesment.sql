USE [EconomicIE]
GO
/****** Object:  StoredProcedure [dbo].[GetInvesments]    Script Date: 10/10/2022 10:44:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvesments]
    @solutionId INT
    AS
BEGIN
     SELECT * FROM InvestmentEntity WHERE ProjectId IN
     (SELECT P.Id FROM Project AS P INNER JOIN Solution S on S.Id = P.SolutionId WHERE S.Id = @solutionId)
END