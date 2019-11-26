   INSERT INTO RelacaoProfissionalClasse
             ( CodigoProfissional
             , CodigoClasseProfissional
             , NumeroRegistroProfissional )
        VALUES
             ( (SELECT CodigoProfissional
                  FROM Profissional
                  JOIN Usuario
                    ON Usuario.CodigoUsuario = Profissional.CodigoUsuario
                 WHERE 1 = 1
                   AND Usuario.LoginUsuario = @LoginUsuario )
             , (SELECT CodigoClasseProfissional FROM ClasseProfissional WHERE ConselhoProfissional = @ConselhoProfissional)
             , @NumeroRegistroProfissional )