INSERT INTO Consulta
          ( CodigoProfissional
          , CodigoPaciente
          , SituacaoConsulta
          , TipoPagamentoConsulta
          , DataRealizacaoConsulta
          , HoraInicialConsulta
          , MinutoInicialConsulta
          , HoraFinalConsulta
          , MinutoFinalConsulta )
   VALUES ( @CodigoProfissional
          , @CodigoPaciente
          , @SituacaoConsulta
          , @TipoPagamentoConsulta
          , @DataRealizacaoConsulta
          , @HoraInicialConsulta
          , @MinutoInicialConsulta
          , @HoraFinalConsulta
          , @MinutoFinalConsulta )