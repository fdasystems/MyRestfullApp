BEGIN TRANSACTION
GO
PRINT N'Insertando datos en [dbo].[User]...';


GO
declare	@nombre		varchar(50)
declare @apellido	varchar(50)
declare @email		varchar(150)
declare @password	varchar(32)
declare @contador	int

set @contador=1


while	(@contador<=100)
	begin

		set	@nombre='User'+cast(@contador as varchar)
		set	@apellido='Apellido'+cast(@contador as varchar)
		set	@email='email'+cast(@contador as varchar)+'@email.com'
		set	@password=CONVERT(VARCHAR(32), HashBytes('MD5', @nombre), 2)

		insert into [dbo].[User] 
		select	
				@nombre,
				@apellido,
				@email,
				@password

		set @contador=@contador+1
	end
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

GO


IF @@TRANCOUNT>0 BEGIN
PRINT N'La inserción de datos en la base de datos se realizó correctamente.'
COMMIT TRANSACTION
END
GO
