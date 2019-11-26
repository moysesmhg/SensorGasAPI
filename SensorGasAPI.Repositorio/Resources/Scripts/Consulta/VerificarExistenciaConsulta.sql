SELECT *
  FROM Consulta
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
   AND DataRealizacaoConsulta = @DataRealizacaoConsulta
   AND HoraInicialConsulta = @HoraInicialConsulta
   AND MinutoInicialConsulta = @MinutoInicialConsulta
   AND HoraFinalConsulta = @HoraFinalConsulta
   AND MinutoFinalConsulta = @MinutoFinalConsulta
   AND SituacaoConsulta NOT IN (3,5) /* Código 3 => Consulta Cancelada, Código 5 => Consulta Indeferida */