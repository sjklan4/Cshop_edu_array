USE [FDS_DB]
GO
/****** Object:  StoredProcedure [dbo].[up_mProject_Select]    Script Date: 2024-01-05(금) 오후 12:06:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		류춘화
-- Create date: 2018. 07.26.
-- Description:	프로젝트 테이블 조회
-- =============================================

-- EXEC [up_mProject_Select]'20180101','20180728','%'

ALTER PROCEDURE [dbo].[up_mProject_Select]
		@cSdate				varchar(8) = null
		,@cEdate				varchar(8) = null	
		,@cCompany					varchar(100) = null
AS



DECLARE @cPrdSheet varchar(1),
	    @dDateTime datetime	,
	   	@nDisplayIdx tinyint
                                 

 SELECT 
ProjectNo
, ProjectName
, OrderDate
, Company
, REPLACE(CONVERT(VARCHAR, CAST(Amount AS MONEY),1),'.00','')  as Amount
, REPLACE(CONVERT(VARCHAR, CAST(Tax1st AS MONEY),1),'.00','')  as Tax1st
, Tax1stContents
, Tax1stDate
, REPLACE(CONVERT(VARCHAR, CAST(Tax2nd AS MONEY),1),'.00','')  as Tax2nd 
, Tax2ndContents
, Tax2ndDate
, REPLACE(CONVERT(VARCHAR, CAST(Tax3rd AS MONEY),1),'.00','')  as Tax3rd 
, Tax3rdContents
, Tax3rdDate
, REPLACE(CONVERT(VARCHAR, CAST(ISNULL(Tax1st,0) AS MONEY)+CAST(ISNULL(Tax2nd,0) AS MONEY)+CAST(ISNULL(Tax3rd,0) AS MONEY),1),'.00','')  as TOTAL
, FinishYN
 FROM mProject 
 WHERE OrderDate >=  @cSdate and OrderDate <= @cEdate
 and Company like '%'+@cCompany+'%'
 --ORDER BY OrderDate,Company

 union all 

 select
 'TOTAL'
 ,''
 ,''
 ,''
, REPLACE(CONVERT(VARCHAR, SUM(CAST(Amount AS MONEY)),1),'.00','')  as Amount
, REPLACE(CONVERT(VARCHAR, SUM(CAST(Tax1st AS MONEY)),1),'.00','')  as Tax1st
 ,''
 ,''
, REPLACE(CONVERT(VARCHAR, SUM(CAST(Tax2nd AS MONEY)),1),'.00','')  as Tax2nd 
 ,''
 ,''
, REPLACE(CONVERT(VARCHAR, SUM(CAST(Tax3rd AS MONEY)),1),'.00','')  as Tax3rd 
 ,''
 ,''
, REPLACE(CONVERT(VARCHAR, SUM(CAST(ISNULL(Tax1st,0) AS MONEY)+CAST(ISNULL(Tax2nd,0) AS MONEY)+CAST(ISNULL(Tax3rd,0) AS MONEY)),1),'.00','')  as TOTAL
 ,''
from mProject
 WHERE OrderDate >=  @cSdate and OrderDate <= @cEdate
 and Company like '%'+@cCompany+'%'