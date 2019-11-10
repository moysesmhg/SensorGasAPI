   INSERT INTO DadosAdicionais 
        ( CodigoPessoa 
        , DDDTelefoneDadosAdicionais 
        , NumeroTelefoneDadosAdicionais
        , DDDCelularDadosAdicionais
        , NumeroCelularDadosAdicionais
        , EmailDadosAdicionais ) 
   VALUES 
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @CPFPessoa) 
        , @DDDTelefoneDadosAdicionais 
        , @NumeroTelefoneDadosAdicionais
        , @DDDCelularDadosAdicionais
        , @NumeroCelularDadosAdicionais
        , @EmailDadosAdicionais )
