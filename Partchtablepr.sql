USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[up_Partchtable_Pr]    Script Date: 2024-01-11 목요일 오후 10:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_Partchtable_Pr]
	@cMode				VARCHAR(16) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@ALCvalue			varchar(500) = NULL,
	@Partname			varchar(500) = NULL,
	@Partnum			varchar(500) = NULL,
	@Color				varchar(500) = NULL
	
AS
	IF @cMode = 'SL'
		BEGIN
			SELECT * FROM partchtable;
		END
    ELSE IF @cMode = 'IN' 
		BEGIN
			INSERT INTO partchtable(ALC,PartName,PartNum,PartColor) 
			values(	@ALCvalue,
					@Partname,
					@Partnum,
					@Color);
		END
	ELSE IF @cMode = 'DEL' 
		BEGIN
			DELETE FROM partchtable
				WHERE ALC = @ALCvalue
		END