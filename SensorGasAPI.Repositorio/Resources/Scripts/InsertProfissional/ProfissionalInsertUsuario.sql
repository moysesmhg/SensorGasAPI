   INSERT INTO Usuario
             ( CodigoPessoa
             , LoginUsuario
             , SenhaUsuario
             , TipoUsuario )
        VALUES
             ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa)
             , @LoginUsuario
             , @SenhaUsuario
             , @TipoUsuario )