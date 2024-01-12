USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[up_mModeltable_Pr]    Script Date: 2024-01-11 목요일 오후 10:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_mModeltable_Pr]
	@cMode				VARCHAR(16) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@model				varchar(500) = NULL,
	@modelname			varchar(500) = NULL
	
AS
	IF @cMode = 'SL'
		BEGIN
			SELECT * FROM mModeltable;
		END
    ELSE IF @cMode = 'IN'
		BEGIN
			INSERT INTO mModeltable(model,modelname) 
			values(	@model,
					@modelname);
		END
	ELSE IF @cMode = 'DEL'
		BEGIN
			DELETE FROM mModeltable
				WHERE model = @model
		END
	
