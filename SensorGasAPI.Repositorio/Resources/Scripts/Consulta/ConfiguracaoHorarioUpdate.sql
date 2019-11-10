 UPDATE ConfiguracaoHorario
    SET AtivacaoConfiguracaoHorario = @AtivacaoConfiguracaoHorario
      , HoraInicialConfiguracaoHorario = @HoraInicialConfiguracaoHorario
      , MinutoInicialConfiguracaoHorario = @MinutoInicialConfiguracaoHorario
      , HoraFinalConfiguracaoHorario = @HoraFinalConfiguracaoHorario
      , MinutoFinalConfiguracaoHorario = @MinutoFinalConfiguracaoHorario
  WHERE 1 = 1
    AND CodigoProfissional = @CodigoProfissional
    AND CodigoDiaConsulta = @CodigoDiaConsulta