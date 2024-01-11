USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[up_Processtable_Pr]    Script Date: 2024-01-11 목요일 오후 10:47:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_Processtable_Pr]
	@cMode				VARCHAR(16) = NULL,
	@model				varchar(500) = NULL,
	@ALCvalue			varchar(500) = NULL
AS
	IF @cMode = 'SL'
		BEGIN
			SELECT Pr.model,M.modelname,Pr.ALC,Pt.PartName,Pt.PartNum,Pt.PartColor
			FROM processtable as Pr
			INNER JOIN printsystemtable as M ON Pr.model = M.model
			INNER JOIN partchtable as Pt ON Pr.ALC = Pt.ALC
			;
		END
    ELSE IF @cMode = 'IN' 
		BEGIN
			INSERT INTO processtable(model,ALC) 
			values(	@model,
					@ALCvalue);
		END
	ELSE IF @cMode = 'DEL' 
		BEGIN
			DELETE FROM processtable
				WHERE model = @model AND ALC = @ALCvalue
		END
	