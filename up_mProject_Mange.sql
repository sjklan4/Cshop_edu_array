USE [FDS_DB]
GO
/****** Object:  StoredProcedure [dbo].[up_mProject_Mange]    Script Date: 2024-01-05(금) 오전 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		류춘화
-- Create date: 2018/07/25
-- Description:	(주)에프에이데이타 프로젝트 마스타 테이블 추가,수정,삭제
-- ProjectNo, ProjectName, OrderDate, Company, Amount, Tax1st, Tax1stContents, Tax1stDate, Tax2nd, Tax2ndContents, Tax2ndDate, Tax3rd, Tax3rdContents, Tax3rdDate, FinishYN
-- =============================================

--exec [dbo].[up_mProject_Mange]'INSERT',''
ALTER PROCEDURE  [dbo].[up_mProject_Mange]
(
	 @cMode				VARCHAR(6)= NULL
	, @cProjectNo					varchar(20)
	, @cProjectName				varchar(100)
	, @cOrderDate				varchar(8)
	, @cCompany					varchar(100)
	, @cAmount					varchar(50) = null
	, @cTax1st					varchar(50) = null
	, @cTax1stContents			varchar(200) = null
	, @cTax1stDate				varchar(8) = null
	, @cTax2nd					varchar(50) = null
	, @cTax2ndContents			varchar(200) = null
	, @cTax2ndDate				varchar(8) = null
	, @cTax3rd					varchar(50) = null
	, @cTax3rdContents			varchar(200) = null
	, @cTax3rdDate				varchar(8) = null
	, @cFinishYN				varchar(5) = null


	
)
AS

BEGIN
SET NOCOUNT ON;


DECLARE	
		@cWERKS			varchar(4) = NULL
		,@ErrorNumber	INT,			-- 오류 번호
		@ErrorSeverity	INT,			-- 오류 심각도
		@ErrorState		INT,			-- 오류 상태번호
		@ErrorProcedure	NVARCHAR(126),	-- 오류 저장프로시저나 트리거의 이름
		@ErrorLine		INT,			-- 오류 줄번호
		@ErrorMessage	NVARCHAR(2048)	-- 오류 메시지
				
DECLARE @i int
DECLARE @numrows int
		,@vPartNo				varchar(50) = null
		,@vALC					varchar(50) = null
		,@vProcNo				varchar(10) = null
		,@vWorkSeq				int = null
		,@vWorkImage			varbinary(max) = null
		,@vTool1				int = null
		,@vTool2				int = null
		,@vMelt1				int = null
		,@vMelt2				int = null


----------
-- INSERT
----------
		


IF @cMode = 'INSERT'
  BEGIN
	BEGIN TRY

		IF exists(SELECT * FROM mProject WHERE ProjectNo = @cProjectNo)
		BEGIN
			UPDATE mProject
			SET
				  ProjectName		=	@cProjectName
				, OrderDate			=	@cOrderDate
				, Company			=	@cCompany
				, Amount			=	@cAmount
				, Tax1st			=	@cTax1st
				, Tax1stContents	=	@cTax1stContents
				, Tax1stDate		=	@cTax1stDate
				, Tax2nd			=	@cTax2nd
				, Tax2ndContents	=	@cTax2ndContents
				, Tax2ndDate		=	@cTax2ndDate
				, Tax3rd			=	@cTax3rd
				, Tax3rdContents	=	@cTax3rdContents
				, Tax3rdDate		=	@cTax3rdDate
				, FinishYN			=	@cFinishYN

			WHERE
			ProjectNo = @cProjectNo

		END
		ELSE
		BEGIN

			INSERT INTO mProject(ProjectNo, ProjectName, OrderDate, Company, Amount, Tax1st, Tax1stContents, Tax1stDate, Tax2nd, Tax2ndContents, Tax2ndDate, Tax3rd, Tax3rdContents, Tax3rdDate, FinishYN)
			values(	 @cProjectNo
			, @cProjectName
			, @cOrderDate
			, @cCompany
			, @cAmount
			, @cTax1st
			, @cTax1stContents
			, @cTax1stDate
			, @cTax2nd
			, @cTax2ndContents
			, @cTax2ndDate
			, @cTax3rd
			, @cTax3rdContents
			, @cTax3rdDate
			, @cFinishYN)
		END



		  IF @@ROWCOUNT = 0
		  BEGIN
			SELECT	@ErrorSeverity	=	11,
					@ErrorProcedure	=	ERROR_PROCEDURE(),
					@ErrorMessage	=	'No row was insert.'
					
			GOTO ERROR
		  END  
	END TRY
	BEGIN CATCH
		SELECT	@ErrorNumber = ERROR_NUMBER(),
				@ErrorSeverity = ERROR_SEVERITY(),
				@ErrorState = ERROR_STATE(),
				@ErrorProcedure = ERROR_PROCEDURE(),
				@ErrorLine = ERROR_LINE(),
				@ErrorMessage = ERROR_MESSAGE()
				
		GOTO ERROR
	END CATCH
  END



----------
-- UPDATE
----------
IF @cMode = 'UPDATE'
  BEGIN
	BEGIN TRY
	
		IF exists(SELECT * FROM mProject WHERE ProjectNo = @cProjectNo)
		BEGIN
			UPDATE mProject
			SET
				  ProjectName		=	@cProjectName
				, OrderDate			=	@cOrderDate
				, Company			=	@cCompany
				, Amount			=	@cAmount
				, Tax1st			=	@cTax1st
				, Tax1stContents	=	@cTax1stContents
				, Tax1stDate		=	@cTax1stDate
				, Tax2nd			=	@cTax2nd
				, Tax2ndContents	=	@cTax2ndContents
				, Tax2ndDate		=	@cTax2ndDate
				, Tax3rd			=	@cTax3rd
				, Tax3rdContents	=	@cTax3rdContents
				, Tax3rdDate		=	@cTax3rdDate
				, FinishYN			=	@cFinishYN

			WHERE
			ProjectNo = @cProjectNo

		END

		IF @@ROWCOUNT = 0
		  BEGIN
			SELECT	@ErrorSeverity	=	11,
					@ErrorProcedure	=	ERROR_PROCEDURE(),
					@ErrorMessage	=	'No row was update.'
					
			GOTO ERROR
		  END
	END TRY
	BEGIN CATCH
		SELECT	@ErrorNumber = ERROR_NUMBER(),
				@ErrorSeverity = ERROR_SEVERITY(),
				@ErrorState = ERROR_STATE(),
				@ErrorProcedure = ERROR_PROCEDURE(),
				@ErrorLine = ERROR_LINE(),
				@ErrorMessage = ERROR_MESSAGE()
				
		GOTO ERROR
	END CATCH
  END

----------
-- DELETE
----------
IF @cMode = 'DELETE'
  BEGIN
	BEGIN TRY

		DELETE mProject
		WHERE ProjectNo = @cProjectNo 
	
		
		IF @@ROWCOUNT = 0
		BEGIN
			SELECT	@ErrorSeverity	=	11,
					@ErrorProcedure	=	ERROR_PROCEDURE(),
					@ErrorMessage	=	'No row was deleted.'
					
			GOTO ERROR
		END
	

	END TRY
	BEGIN CATCH
		SELECT	@ErrorNumber = ERROR_NUMBER(),
				@ErrorSeverity = ERROR_SEVERITY(),
				@ErrorState = ERROR_STATE(),
				@ErrorProcedure = ERROR_PROCEDURE(),
				@ErrorLine = ERROR_LINE(),
				@ErrorMessage = ERROR_MESSAGE()
				
		GOTO ERROR
	END CATCH
  END
  

------------
-- SUCCESS
------------

RETURN
  

----------
-- Error
----------  
ERROR:
	RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	RETURN -1
END



