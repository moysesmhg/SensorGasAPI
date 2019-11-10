       SELECT CodigoUsuario
            , CodigoPessoa
            , LoginUsuario
            , SenhaUsuario
            , TipoUsuario
         FROM Usuario
        WHERE 1 = 1 
          AND LoginUsuario = @LoginUsuario 
          AND SenhaUsuario = @SenhaUsuario