     SELECT  Consulta.CodigoConsulta
        FROM Consulta
       WHERE 1 = 1
         AND Consulta.SituacaoConsulta = 4 /* 4 - Consulta Realizada */
         AND Consulta.CodigoPaciente = @CodigoPaciente
         AND Consulta.CodigoProfissional = @CodigoProfissional