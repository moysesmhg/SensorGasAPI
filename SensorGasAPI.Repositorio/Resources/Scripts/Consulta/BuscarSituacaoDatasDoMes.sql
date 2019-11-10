  SELECT Consulta.DataRealizacaoConsulta DataRealizacaoConsulta
       , (SELECT COUNT(SituacaoConsulta) FROM Consulta C1 
           WHERE Consulta.CodigoProfissional = C1.CodigoProfissional
             AND DATE(Consulta.DataRealizacaoConsulta) = DATE(C1.DataRealizacaoConsulta)
             AND SituacaoConsulta = 0) QuantidadeConsultasAbertas /* Quantidade de Consultas Abertas */
       , (SELECT COUNT(SituacaoConsulta) FROM Consulta C1 
           WHERE Consulta.CodigoProfissional = C1.CodigoProfissional
             AND DATE(Consulta.DataRealizacaoConsulta) = DATE(C1.DataRealizacaoConsulta)
             AND SituacaoConsulta = 1) QuantidadeConsultasSolicitadas /* Quantidade de Consultas Solicitadas */
       , (SELECT COUNT(SituacaoConsulta) FROM Consulta C1 
           WHERE Consulta.CodigoProfissional = C1.CodigoProfissional
             AND DATE(Consulta.DataRealizacaoConsulta) = DATE(C1.DataRealizacaoConsulta)
             AND SituacaoConsulta = 2) QuantidadeConsultasConfirmadas /* Quantidade de Consultas Confirmadas */
       , (SELECT COUNT(SituacaoConsulta) FROM Consulta C1 
           WHERE Consulta.CodigoProfissional = C1.CodigoProfissional
             AND DATE(Consulta.DataRealizacaoConsulta) = DATE(C1.DataRealizacaoConsulta)
             AND SituacaoConsulta = 4) QuantidadeConsultasRealizadas /* Quantidade de Consultas Realizadas */
    FROM Consulta
   WHERE 1 = 1
     AND CodigoProfissional = @CodigoProfissional
     AND DATE(DataRealizacaoConsulta) BETWEEN DATE(@DataInicio) AND DATE(@DataFim)
     AND SituacaoConsulta NOT IN (3,5) /* Código 3 => Consulta Cancelada, Código 5 => Consulta Indeferida */
GROUP BY DataRealizacaoConsulta

--SELECT *
--  FROM Consulta
-- WHERE 1 = 1
--   AND CodigoProfissional = @CodigoProfissional
--   AND DATE(DataRealizacaoConsulta) IN (@ListaDatasConsulta) 
--   AND SituacaoConsulta NOT IN (3,5) /* Código 3 => Consulta Cancelada, Código 5 => Consulta Indeferida */