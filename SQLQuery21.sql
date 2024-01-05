create procedure up_Factoring_Manage
	@cMode				VARCHAR(6) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@model				varchar(500),
	@modelname			varchar(500),
	@ALCVL			varchar(500),
	@partnameVL			varchar(500),
	@partnumVL			varchar(500),
	@partcolorVL				varchar(500)
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
		values(	@ALCVL,
				@partnameVL,
				@partnumVL,
				@partcolorVL);
			
	END

ELSE IF @cMode = 'INSERT3' AND @cTable = 'processtable'
	BEGIN
		INSERT INTO processtable(model,modelname,ALC,부품명,부품번호,색상) 
		values(	@model,
				@modelname,
				@ALCVL,
				@partnameVL,
				@partnumVL,
				@partcolorVL);
			
	END
ELSE IF @cMode = 'DELETE1' AND @cTable = 'printsystemtable'
	BEGIN
		DELETE FROM printsystemtable
			WHERE model = @model
	END

ELSE IF @cMode = 'DELETE2' AND @cTable = 'partchtable'
	BEGIN
		DELETE FROM partchtable
			WHERE ALC = @ALCVL
	END

ELSE IF @cMode = 'DELETE3' AND @cTable = 'processtable'
	BEGIN
		DELETE FROM processtable
			WHERE model = @model AND ALC = @ALCVL
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

