USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[up_Factoring_Manage]    Script Date: 2024-01-10 오후 6:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상준
-- Create date: 2024/01/05
-- Description:	process 추가,수정,삭제
-- model, modelname, ALC, 부품명, 부품번호, 색상
-- =============================================
ALTER procedure [dbo].[up_Factoring_Manage]
	@cMode				VARCHAR(16) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@model				varchar(500) = NULL,
	@modelname			varchar(500) = NULL,
	@ALCvalue			varchar(500) = NULL,
	@Partname			varchar(500) = NULL,
	@Partnum			varchar(500) = NULL,
	@Color				varchar(500) = NULL
AS
	IF @cMode = 'INSERT1' AND @cTable = 'printsystemtable' 
		BEGIN
			INSERT INTO printsystemtable(model,modelname) 
			values(	@model,
					@modelname);
			
		END

	ELSE IF @cMode = 'INSERT2' AND @cTable = 'partchtable' 
		BEGIN
			INSERT INTO partchtable(ALC,PartName,PartNum,PartColor) 
			values(	@ALCvalue,
					@Partname,
					@Partnum,
					@Color);
			
		END

	ELSE IF @cMode = 'INSERT3' AND @cTable = 'processtable'
		BEGIN
			INSERT INTO processtable(model,ALC) 
			values(	@model,
					@ALCvalue);
		END
	ELSE IF @cMode = 'DELETE1' AND @cTable = 'printsystemtable'
		BEGIN
			DELETE FROM printsystemtable
				WHERE model = @model
		END

	ELSE IF @cMode = 'DELETE2' AND @cTable = 'partchtable'
		BEGIN
			DELETE FROM partchtable
				WHERE ALC = @ALCvalue
		END

	ELSE IF @cMode = 'DELETE3' AND @cTable = 'processtable'
		BEGIN
			DELETE FROM processtable
				WHERE model = @model AND ALC = @ALCvalue
			END
	ELSE IF @cMode = 'select_print'
		BEGIN
			SELECT * FROM printsystemtable;
		END
	ELSE IF @cMode = 'select_partch'
		BEGIN
			SELECT * FROM partchtable;
		END
	ELSE IF @cMode = 'processtable'
		BEGIN
			SELECT Pr.model,M.modelname,Pr.ALC,Pt.PartName,Pt.PartNum,Pt.PartColor
			FROM processtable as Pr
			INNER JOIN printsystemtable as M ON Pr.model = M.model
			INNER JOIN partchtable as Pt ON Pr.ALC = Pt.ALC
			;
		END
	


