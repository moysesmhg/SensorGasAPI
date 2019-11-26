     SELECT  Imagens.Imagem Imagem
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeSolicitante
           , Consulta.CodigoConsulta CodigoConsulta
           , Consulta.DataRealizacaoConsulta
           , Consulta.SituacaoConsulta
        FROM Consulta
  INNER JOIN Paciente ON Consulta.CodigoPaciente = Paciente.CodigoPaciente
  INNER JOIN Usuario ON Paciente.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
   LEFT JOIN Imagens ON Usuario.CodigoUsuario = Imagens.CodigoUsuario
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta NOT IN (3, 5, 4) /* Não recupera as consultas canceladas */
         AND Consulta.CodigoProfissional = @CodigoProfissional
         AND Consulta.DataRealizacaoConsulta > @DataAtual OR
            (Consulta.DataRealizacaoConsulta = @DataAtual AND
             CAST(Consulta.HoraFinalConsulta AS VARCHAR) || ':' || CAST(Consulta.MinutoFinalConsulta AS VARCHAR) >= CAST(@HoraAtual AS VARCHAR))
          /* TODO: verificar a necessidade de não trazer as consultas canceladas e indeferidas */