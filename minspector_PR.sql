CREATE PROCEDURE up_mInspector_Pr
	@cMode				VARCHAR(16) = NULL,
	@����				varchar(500) = NULL,
	@ALC				varchar(500) = NULL,
	@ǰ��				varchar(500) = NULL,
	@���				varchar(500) = NULL
	
AS
	IF @cMode = 'SL'
		BEGIN
			SELECT * FROM mInspector;
		END
    ELSE IF @cMode = 'IN'
		BEGIN
			INSERT INTO mInspector(����,ALC, ǰ��, ���) 
			values(	@����,@ALC,@ǰ��,@���);
		END
	ELSE IF @cMode = 'DEL'
		BEGIN
			DELETE FROM mInspector
				WHERE ALC = @ALC
		END