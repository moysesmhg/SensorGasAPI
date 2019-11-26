     SELECT (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional
           , Consulta.DataRealizacaoConsulta
           , Consulta.CodigoConsulta
        FROM Consulta
  INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
  INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
   LEFT JOIN Tratamento
          ON Consulta.CodigoConsulta = Tratamento.CodigoConsulta
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta = 4 /* 4 - Consulta Realizada */
         AND Consulta.CodigoPaciente = @CodigoPaciente