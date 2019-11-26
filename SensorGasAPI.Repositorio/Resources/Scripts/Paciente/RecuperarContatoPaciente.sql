     SELECT *
       FROM DadosAdicionais
 INNER JOIN Pessoa
         ON DadosAdicionais.CodigoPessoa = Pessoa.CodigoPessoa
 INNER JOIN Usuario
         ON Pessoa.CodigoPessoa = Usuario.CodigoPessoa
 INNER JOIN Paciente
         ON Usuario.CodigoUsuario = Paciente.CodigoUsuario
      WHERE 1 = 1
        AND Paciente.CodigoPaciente = @CodigoPaciente