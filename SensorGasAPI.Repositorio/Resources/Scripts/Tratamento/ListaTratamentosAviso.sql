      SELECT *
        FROM Consulta
  INNER JOIN Tratamento
          ON Consulta.CodigoConsulta = Tratamento.CodigoConsulta
       WHERE 1 = 1
         AND Consulta.CodigoPaciente = @CodigoPaciente
         AND Tratamento.TratamentoAtivado = 1;