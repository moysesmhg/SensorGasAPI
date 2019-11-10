 INSERT INTO Endereco
           ( CodigoPessoa
           , LogradouroEndereco
           , NumeroEndereco
           , ComplementoEndereco
           , BairroEndereco
           , CodigoMunicipio
           , CodigoEstado
           , CepEndereco
           , TipoEndereco )
      VALUES
           ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa)
           , @LogradouroEndereco
           , @NumeroEndereco
           , @ComplementoEndereco
           , @BairroEndereco
           , @CodigoMunicipio
           , @CodigoEstado
           , @CepEndereco
           , @TipoEndereco )