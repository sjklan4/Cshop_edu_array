create procedure up_Factoring_Manage
	@cMode				VARCHAR(6) = NULL,
	@cTable				VARCHAR(50) = NULL,
	@model				varchar(500),
	@modelname			varchar(500),
	@ALCVL			varchar(500),
	@partnameVL			varchar(500),
	@partnumVL			varchar(500),
	@partocolorVL				varchar(500)
as
IF @cMode = 'INSERT' AND @cTable = 'printsystemtable' 
	BEGIN
		INSERT INTO printsystemtable(model,modelname) 
		values(	@model,
				@modelname);
			
	END


ELSE IF @cMode = 'INSERT' AND @cTable = 'partchtable' 
	BEGIN
		INSERT INTO partchtable(ALC,부품명,부품번호,색상) 
		values(	@ALCVL,
				@partnameVL,
				@partnumVL,
				@partocolorVL);
			
	END

ELSE IF @cMode = 'INSERT' AND @cTable = 'process
' 
	BEGIN
		INSERT INTO partchtable(ALC,부품명,부품번호,색상) 
		values(	@ALCVL,
				@partnameVL,
				@partnumVL,
				@partocolorVL);
			
	END
