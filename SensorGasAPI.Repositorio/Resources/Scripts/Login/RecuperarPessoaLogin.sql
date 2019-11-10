       SELECT CodigoPessoa
            , PrimeiroNomePessoa
            , SobreNomePessoa
            , CPFPessoa
            , DataNascimentoPessoa
         FROM Pessoa
        WHERE 1 = 1 
          AND CodigoPessoa = @CodigoPessoa