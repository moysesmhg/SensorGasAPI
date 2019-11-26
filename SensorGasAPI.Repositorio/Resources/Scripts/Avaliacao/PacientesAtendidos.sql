      SELECT DISTINCT COUNT(Consulta.CodigoPaciente) PacientesAtendidos
        FROM Consulta
       WHERE 1 = 1        
         AND Consulta.CodigoProfissional = @CodigoProfissional
         AND Consulta.SituacaoConsulta = 4 /* 4. Consulta Realizada */