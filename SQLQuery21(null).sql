USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[up_Factoring_Manage]    Script Date: 2024-01-07 일요일 오후 9:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER procedure [dbo].[up_Factoring_Manage]
	@cMode				VARCHAR(6) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@model				varchar(500) = NULL,
	@modelname			varchar(500) = NULL,
	@ALCvalue			varchar(500) = NULL,
	@Partname			varchar(500) = NULL,
	@Partnum			varchar(500) = NULL,
	@Color				varchar(500) = NULL
as
IF @cMode = 'INSERT1' AND @cTable = 'printsystemtable' 
	BEGIN
		INSERT INTO printsystemtable(model,modelname) 
		values(	@model,
				@modelname);
			
	END


ELSE IF @cMode = 'INSERT2' AND @cTable = 'partchtable' 
	BEGIN
		INSERT INTO partchtable(ALC,부품명,부품번호,색상) 
		values(	@ALCvalue,
				@Partname,
				@Partnum,
				@Color);
			
	END

ELSE IF @cMode = 'INSERT3' AND @cTable = 'processtable'
	BEGIN
		INSERT INTO processtable(model,modelname,ALC,부품명,부품번호,색상) 
		values(	@model,
				@modelname,
				@ALCvalue,
				@Partname,
				@Partnum,
				@Color);
			
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
ELSE IF @cMode = 'select_processtable'
	BEGIN
		SELECT * FROM processtable;
END;

