      SELECT Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa
           , Consulta.CodigoConsulta
           , Consulta.DataRealizacaoConsulta DataConsulta
           , Consulta.HoraInicialConsulta HoraInicio
           , Consulta.MinutoInicialConsulta MinutoInicio
        FROM Consulta
  INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
  INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
       WHERE 1 = 1
         AND CAST(Consulta.DataRealizacaoConsulta AS DATETIME) > CAST(DATETIME('NOW') AS DATETIME)
         AND Consulta.CodigoPaciente = @CodigoPaciente