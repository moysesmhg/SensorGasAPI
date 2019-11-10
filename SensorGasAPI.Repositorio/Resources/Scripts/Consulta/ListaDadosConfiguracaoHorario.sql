     SELECT * 
       FROM ConfiguracaoHorario
       JOIN DiaConsulta
         ON DiaConsulta.CodigoDiaConsulta = ConfiguracaoHorario.CodigoDiaConsulta
      WHERE 1 = 1
        AND (CodigoProfissional = @CodigoProfissional)