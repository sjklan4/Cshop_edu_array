USE [printsystem]
GO
/****** Object:  StoredProcedure [dbo].[Insert_model]    Script Date: 2024-01-04 오전 10:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Insert_model]
	@modelValue varchar(500),
	@modelNameValue varchar(1000)

as
begin
     
	insert into printsystemtable (model,modelname) values(@modelValue, @modelNameValue);
end;


	