-- =====modeltable  procedure ==============================
CREATE PROCEDURE up_mModeltable_Pr
	@cMode				VARCHAR(16) = NULL,
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
--============================================================================

CREATE PROCEDURE up_Partchtable_Pr
	@cMode				VARCHAR(16) = NULL,
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

-- =================================================================
CREATE PROCEDURE up_Processtable_Pr
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
	
