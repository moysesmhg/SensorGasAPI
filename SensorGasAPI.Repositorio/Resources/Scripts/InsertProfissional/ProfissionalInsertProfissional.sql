   INSERT INTO Profissional
             ( CodigoUsuario )
        VALUES
             ( (SELECT CodigoUsuario FROM Usuario WHERE LoginUsuario = @LoginUsuario ) )