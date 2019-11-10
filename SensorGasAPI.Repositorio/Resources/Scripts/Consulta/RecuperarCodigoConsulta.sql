SELECT CodigoConsulta 
  FROM Consulta 
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
   AND CodigoPaciente = @CodigoPaciente
   AND SituacaoConsulta = @SituacaoConsulta
   AND TipoPagamentoConsulta = @TipoPagamentoConsulta
   AND DataRealizacaoConsulta = @DataRealizacaoConsulta
   AND HoraInicialConsulta  = @HoraInicialConsulta 
   AND MinutoInicialConsulta = @MinutoInicialConsulta
   AND HoraFinalConsulta = @HoraFinalConsulta
   AND MinutoFinalConsulta = @MinutoFinalConsulta