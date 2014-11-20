USE [szkolkarz]
GO

/****** Object:  View [dbo].[V_FULL_SOWN_LOG]    Script Date: 2014-11-20 16:05:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[V_FULL_SOWN_LOG] as
select
	asl.TAPE_ID,
	ASL.YEAR,
	ap.PLANT,
	ap.PRODUCTION_NO
		from ADM_SOWN_LOG ASL
		inner join ADM_PLANTS AP on AP.ID = ASL.ADM_PLANT_ID;
GO

