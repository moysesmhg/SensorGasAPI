SELECT *
  FROM Consulta
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
   AND DataRealizacaoConsulta = @DataRealizacaoConsulta
   AND HoraInicialConsulta = @HoraInicialConsulta
   AND MinutoInicialConsulta = @MinutoInicialConsulta
   AND HoraFinalConsulta = @HoraFinalConsulta
   AND MinutoFinalConsulta = @MinutoFinalConsulta
   AND SituacaoConsulta NOT IN (3,5) /* C�digo 3 => Consulta Cancelada, C�digo 5 => Consulta Indeferida */