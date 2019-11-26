     SELECT Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa NomeProfissional
       FROM Pessoa
 INNER JOIN Usuario
         ON Pessoa.CodigoPessoa = Usuario.CodigoPessoa
 INNER JOIN Profissional
         ON Usuario.CodigoUsuario = Profissional.CodigoUsuario
      WHERE 1 = 1
        AND Profissional.CodigoProfissional = @CodigoProfissional