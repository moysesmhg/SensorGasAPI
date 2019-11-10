UPDATE Consulta
   SET CodigoProfissional = @CodigoProfissional
     , CodigoPaciente = @CodigoPaciente
     , SituacaoConsulta = @SituacaoConsulta
     , TipoPagamentoConsulta = @TipoPagamentoConsulta
     , DataRealizacaoConsulta = @DataRealizacaoConsulta
     , HoraInicialConsulta = @HoraInicialConsulta 
     , MinutoInicialConsulta = @MinutoInicialConsulta
     , HoraFinalConsulta = @HoraFinalConsulta
     , MinutoFinalConsulta = @MinutoFinalConsulta
 WHERE 1 = 1
   AND CodigoConsulta = @CodigoConsulta