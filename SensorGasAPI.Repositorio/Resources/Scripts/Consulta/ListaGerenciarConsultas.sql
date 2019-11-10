     SELECT  Imagens.Imagem Imagem
           , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional
           , Consulta.CodigoConsulta CodigoConsulta
           , Consulta.DataRealizacaoConsulta
        FROM Consulta
  INNER JOIN Profissional ON Consulta.CodigoProfissional = Profissional.CodigoProfissional
  INNER JOIN Usuario ON Profissional.CodigoUsuario = Usuario.CodigoUsuario
  INNER JOIN Pessoa ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa
   LEFT JOIN Imagens ON Usuario.CodigoUsuario = Imagens.CodigoUsuario
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta NOT IN (3) /* Não recupera as consultas canceladas */
         AND Consulta.CodigoPaciente = @CodigoPaciente
          /* TODO: verificar a necessidade de não trazer as consultas canceladas e indeferidas */