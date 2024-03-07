CREATE PROCEDURE up_mInspector_Pr
	@cMode				VARCHAR(16) = NULL,
	@차종				varchar(500) = NULL,
	@ALC				varchar(500) = NULL,
	@품번				varchar(500) = NULL,
	@사양				varchar(500) = NULL
	
AS
	IF @cMode = 'SL'
		BEGIN
			SELECT * FROM mInspector;
		END
    ELSE IF @cMode = 'IN'
		BEGIN
			INSERT INTO mInspector(차종,ALC, 품번, 사양) 
			values(	@차종,@ALC,@품번,@사양);
		END
	ELSE IF @cMode = 'DEL'
		BEGIN
			DELETE FROM mInspector
				WHERE ALC = @ALC
		END