     SELECT  Imagens.Imagem Imagem
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomePaciente
           , Consulta.CodigoConsulta CodigoConsulta
           , Consulta.DataRealizacaoConsulta
           , Avaliacao.NotaAvaliacao NotaAvaliacao
        FROM Consulta
  INNER JOIN Paciente ON Consulta.CodigoPaciente = Paciente.CodigoPaciente
  INNER JOIN Usuario ON Paciente.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
   LEFT JOIN Imagens ON Usuario.CodigoUsuario = Imagens.CodigoUsuario
   LEFT JOIN Avaliacao ON Avaliacao.CodigoConsulta = Consulta.CodigoConsulta
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta = 4 /* 4 - Consulta Realizada */
         AND Avaliacao.SituacaoAvaliacao = 1 /* 1 - Avaliação Efetuada */
         AND Consulta.CodigoProfissional = @CodigoProfissional