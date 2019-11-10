       SELECT Consulta.CodigoConsulta CodigoConsulta
           ,  Consulta.DataRealizacaoConsulta
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional
           ,  Avaliacao.CodigoAvaliacao CodigoAvaliacao
           ,  Avaliacao.SituacaoAvaliacao
           ,  Avaliacao.NotaAvaliacao
           ,  Avaliacao.DescricaoAvaliacao
         FROM Consulta
   INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
   INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
   INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
    LEFT JOIN Avaliacao ON Avaliacao.CodigoConsulta = Consulta.CodigoConsulta
       WHERE 1 = 1        
         AND Consulta.CodigoConsulta = @CodigoConsulta