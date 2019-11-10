INSERT INTO ConfiguracaoHorario 
          ( CodigoProfissional
          , CodigoDiaConsulta
          , AtivacaoConfiguracaoHorario
          , HoraInicialConfiguracaoHorario
          , MinutoInicialConfiguracaoHorario
          , HoraFinalConfiguracaoHorario
          , MinutoFinalConfiguracaoHorario) 
     VALUES
          ( @CodigoProfissional
          , @CodigoDiaConsulta
          , @AtivacaoConfiguracaoHorario
          , @HoraInicialConfiguracaoHorario
          , @MinutoInicialConfiguracaoHorario
          , @HoraFinalConfiguracaoHorario
          , @MinutoFinalConfiguracaoHorario)
