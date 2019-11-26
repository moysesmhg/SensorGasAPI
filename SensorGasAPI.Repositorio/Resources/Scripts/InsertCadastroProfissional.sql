/* INÍCIO */

   /* Insert da tabela "Pessoa" */
   INSERT INTO Pessoa
        ( PrimeiroNomePessoa
        , SobreNomePessoa
        , CPFPessoa
        , DataNascimentoPessoa )
   VALUES
        ( @PrimeiroNomePessoa
        , @SobreNomePessoa
        , @CPFPessoa
        , @DataNascimentoPessoa );
   
   /* Insert tabela "Usuario" */
   INSERT INTO Usuario
        ( CodigoPessoa
        , LoginUsuario
        , SenhaUsuario
        , TipoUsuario )
   VALUES
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa)
        , @LoginUsuario
        , @SenhaUsuario
        , @TipoUsuario );
   
   /* Insert na tabela "Profissional" */
   INSERT INTO Profissional
        ( CodigoUsuario )
   VALUES
        ( (SELECT CodigoUsuario FROM Usuario WHERE LoginUsuario = @LoginUsuario ) );
   
   /* Insert na tabela "Paciente" */
   INSERT INTO Paciente
        ( CodigoUsuario )
   VALUES
        ( (SELECT CodigoUsuario FROM Usuario WHERE LoginUsuario = @LoginUsuario ) );
   
   /* Insert na tabela "EnderecoMobile" */
   INSERT INTO EnderecoMobile
        ( CodigoPessoa
        , LogradouroEndereco
        , NumeroEndereco
        , ComplementoEndereco
        , BairroEndereco
        , MunicipioEndereco
        , AbreviacaoEstadoEndereco
        , CepEndereco
        , TipoEndereco )
   VALUES
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa)
        , @LogradouroEndereco
        , @NumeroEndereco
        , @ComplementoEndereco
        , @BairroEndereco
        , @MunicipioEndereco
        , @AbreviacaoEstadoEndereco
        , @CepEndereco
        , @TipoEndereco );
   
   /* Insert na tabela "DadosAdicionais" */
   INSERT INTO DadosAdicionais
        ( CodigoPessoa
        , DDDTelefoneDadosAdicionais
        , NumeroTelefoneDadosAdicionais
        , EmailDadosAdicionais )
   VALUES
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa)
        , @DDDTelefoneDadosAdicionais
        , @NumeroTelefoneDadosAdicionais
        , @EmailDadosAdicionais );
   
   /* Insert na tabela "RelacaoProfissionalClasse" */
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
        , @NumeroRegistroProfissional );
   
/* FIM */