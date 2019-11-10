    SELECT CheckEmail.CodigoCheckEMail
         , CheckEmail.CodigoConsulta 
      FROM CheckEmail
INNER JOIN Consulta
        ON CheckEmail.CodigoConsulta = Consulta.CodigoConsulta
     WHERE 1 = 1
       AND CAST(Consulta.DataRealizacaoConsulta AS DATETIME) > CAST(DATETIME('NOW') AS DATETIME)
       AND Consulta.CodigoPaciente = @CodigoPaciente
