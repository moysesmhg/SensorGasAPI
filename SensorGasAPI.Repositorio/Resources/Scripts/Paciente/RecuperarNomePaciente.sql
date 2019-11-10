     SELECT Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa NomePaciente
       FROM Pessoa
 INNER JOIN Usuario
         ON Pessoa.CodigoPessoa = Usuario.CodigoPessoa
 INNER JOIN Paciente
         ON Usuario.CodigoUsuario = Paciente.CodigoUsuario
      WHERE 1 = 1
        AND Paciente.CodigoPaciente = @CodigoPaciente