SELECT COALESCE(PrecoConsultaProfissional, 0) PrecoConsultaProfissional
  FROM ConfiguracaoConsulta
 WHERE 1 = 1
   AND CodigoProfissional = @CodigoProfissional
