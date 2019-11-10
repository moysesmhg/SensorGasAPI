 INSERT INTO UsuarioGlobal
           ( CodigoUsuario
           , CodigoPaciente
           , TipoUsuario
           , LoginUsuario
           , SenhaUsuario
           , NomeUsuario
           , EmailUsuario )
     VALUES 
           ( @CodigoUsuario
           , @CodigoPaciente
           , @TipoUsuario
           , @LoginUsuario
           , @SenhaUsuario
           , @NomeUsuario
           , @EmailUsuario )