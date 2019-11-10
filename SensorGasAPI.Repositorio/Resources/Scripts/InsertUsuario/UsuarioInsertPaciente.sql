   INSERT INTO Paciente 
        ( CodigoUsuario ) 
   VALUES 
        ( (SELECT CodigoUsuario FROM Usuario WHERE LoginUsuario = @LoginUsuario ) )