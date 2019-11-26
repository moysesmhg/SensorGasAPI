INSERT INTO Tratamento      
          ( CodigoConsulta
          , NomeTratamento
          , DescricaoTratamento
          , InicioTratamento
          , TerminoTratamento
          , HoraInicio
          , MinutoInicio
          , FrequenciaDias
          , FrequenciaHoras
          , TratamentoAtivado )
     VALUES 
          ( @CodigoConsulta
          , @NomeTratamento
          , @DescricaoTratamento
          , @InicioTratamento
          , @TerminoTratamento
          , @HoraInicio
          , @MinutoInicio
          , @FrequenciaDias
          , @FrequenciaHoras
          , @TratamentoAtivado )