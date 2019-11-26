     SELECT (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional
           , Consulta.CodigoConsulta
           , Consulta.CodigoProfissional
           , Consulta.CodigoPaciente
           , Consulta.DataRealizacaoConsulta
           , Consulta.SituacaoConsulta
           , Tratamento.CodigoTratamento
           , Tratamento.NomeTratamento
           , Tratamento.DescricaoTratamento
           , Tratamento.InicioTratamento
           , Tratamento.TerminoTratamento
           , Tratamento.HoraInicio
           , Tratamento.MinutoInicio
           , Tratamento.FrequenciaDias
           , Tratamento.FrequenciaHoras
           , Tratamento.TratamentoAtivado
        FROM Consulta
  INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
  INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
  INNER JOIN DadosAdicionais ON Pessoa.CodigoPessoa = DadosAdicionais.CodigoPessoa
   LEFT JOIN Tratamento ON Consulta.CodigoConsulta = Tratamento.CodigoConsulta
       WHERE 1 = 1
         AND Consulta.CodigoConsulta = @CodigoConsulta