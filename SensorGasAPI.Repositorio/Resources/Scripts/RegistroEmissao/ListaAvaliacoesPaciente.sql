     SELECT  Imagens.Imagem Imagem
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional
           , Consulta.CodigoConsulta CodigoConsulta
           , Consulta.DataRealizacaoConsulta
        FROM Consulta
  INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
  INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
   LEFT JOIN Imagens ON Usuario.CodigoUsuario = Imagens.CodigoUsuario
   LEFT JOIN Avaliacao ON Avaliacao.CodigoConsulta = Consulta.CodigoConsulta
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta = 4 /* 4 - Consulta Realizada */
         AND Consulta.CodigoPaciente = @CodigoPaciente
         AND Consulta.DataRealizacaoConsulta < DATETIME('NOW') OR
               (Consulta.DataRealizacaoConsulta = DATETIME('NOW') AND
                CAST(Consulta.HoraFinalConsulta AS VARCHAR) || ':' || CAST(Consulta.MinutoFinalConsulta AS VARCHAR) < CAST(@HoraAtual AS VARCHAR))
         /*AND strftime('%H:%M', CAST(Consulta.HoraFinalConsulta AS VARCHAR) || ':' || CAST(Consulta.MinutoFinalConsulta AS VARCHAR)) < STRFTIME('%H:%M', 'NOW')*/ /* Verifica se o horário da avaliação do paciente é maior que o horário de término da consulta */