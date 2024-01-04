create procedure insert_model
	@modelValue varchar(500),
	@modelNameValue varchar(500)
as
begin
	Insert into printsystemtable(model, modelname) values(@modelValue, @modelNameValue);
end
