 UPDATE ConfiguracaoConsulta
    SET PrecoConsultaProfissional = @PrecoConsultaProfissional
      , IntervaloConsultaProfissional = @IntervaloConsultaProfissional
  WHERE 1 = 1
    AND CodigoProfissional = @CodigoProfissional