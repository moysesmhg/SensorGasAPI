       SELECT Consulta.CodigoConsulta CodigoConsulta
           ,  Consulta.DataRealizacaoConsulta
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomePaciente
           ,  Avaliacao.CodigoAvaliacao CodigoAvaliacao
           ,  Avaliacao.SituacaoAvaliacao
           ,  Avaliacao.NotaAvaliacao
           ,  Avaliacao.DescricaoAvaliacao
         FROM Consulta
   INNER JOIN Paciente ON Consulta.CodigoPaciente = Paciente.CodigoPaciente
   INNER JOIN Usuario ON Paciente.CodigoUsuario = Usuario.CodigoUsuario
   INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
    LEFT JOIN Avaliacao ON Avaliacao.CodigoConsulta = Consulta.CodigoConsulta
       WHERE 1 = 1        
         AND Consulta.CodigoConsulta = @CodigoConsulta