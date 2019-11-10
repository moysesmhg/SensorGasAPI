SELECT *
  FROM Consulta
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
   AND DataRealizacaoConsulta = @DataRealizacaoConsulta
   AND CodigoPaciente = @CodigoPaciente
   AND SituacaoConsulta NOT IN (3,5) /* C�digo 3 => Consulta Cancelada, C�digo 5 => Consulta Indeferida */

UNION ALL

SELECT *
  FROM Consulta
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
   AND DataRealizacaoConsulta = @DataRealizacaoConsulta
   AND CodigoPaciente <> @CodigoPaciente
   AND SituacaoConsulta = 0 /* C�digo 0 => Consulta Aberta */