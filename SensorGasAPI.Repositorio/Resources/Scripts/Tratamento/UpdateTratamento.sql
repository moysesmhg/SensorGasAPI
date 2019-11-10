     UPDATE Tratamento      
        SET CodigoConsulta = @CodigoConsulta
          , NomeTratamento = @NomeTratamento
          , DescricaoTratamento = @DescricaoTratamento
          , InicioTratamento = @InicioTratamento
          , TerminoTratamento = @TerminoTratamento
          , HoraInicio = @HoraInicio
          , MinutoInicio = @MinutoInicio
          , FrequenciaDias = @FrequenciaDias
          , FrequenciaHoras = @FrequenciaHoras
          , TratamentoAtivado = @TratamentoAtivado
      WHERE 1 = 1
        AND CodigoTratamento = @CodigoTratamento