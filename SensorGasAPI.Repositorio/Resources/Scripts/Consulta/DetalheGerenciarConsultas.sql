     SELECT (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeSolicitante
           , Consulta.CodigoConsulta CodigoConsulta
           , Consulta.CodigoProfissional
           , Consulta.CodigoPaciente
           , Consulta.DataRealizacaoConsulta
           , CAST(Consulta.HoraInicialConsulta AS VARCHAR (2)) HoraInicio
           , CAST(Consulta.MinutoInicialConsulta AS VARCHAR) MinutoInicio
           , CAST(Consulta.HoraFinalConsulta AS VARCHAR) HoraFim
           , CAST(Consulta.MinutoFinalConsulta AS VARCHAR) MinutoFim
           , '(' || CAST(DadosAdicionais.DDDTelefoneDadosAdicionais AS VARCHAR) || ') ' || CAST(DadosAdicionais.NumeroTelefoneDadosAdicionais AS VARCHAR) TelefoneProfissional
           , Consulta.SituacaoConsulta SituacaoConsulta
        FROM Consulta
  INNER JOIN Paciente ON Consulta.CodigoPaciente = Paciente.CodigoPaciente
  INNER JOIN Usuario ON Paciente.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
  INNER JOIN DadosAdicionais ON Pessoa.CodigoPessoa = DadosAdicionais.CodigoPessoa
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta NOT IN (3)
         AND Consulta.CodigoConsulta = @CodigoConsulta