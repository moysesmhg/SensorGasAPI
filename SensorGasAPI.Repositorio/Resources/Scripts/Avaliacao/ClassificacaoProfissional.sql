      SELECT COALESCE((SELECT SUM(COALESCE(A1.NotaAvaliacao, 0))
                         FROM Avaliacao A1
                        WHERE 1 = 1
                          AND A1.CodigoAvaliacao = Avaliacao.CodigoAvaliacao) /
                      (SELECT COUNT(Avaliacao.CodigoAvaliacao)
                         FROM Avaliacao A1
                        WHERE 1 = 1
                          AND A1.CodigoAvaliacao = Avaliacao.CodigoAvaliacao
                          AND A1.CodigoAvaliacao IS NOT NULL), 0) ClassificacaoProfissional
        FROM Consulta
   LEFT JOIN Avaliacao ON Avaliacao.CodigoConsulta = Consulta.CodigoConsulta
       WHERE 1 = 1        
         AND Consulta.CodigoProfissional = @CodigoProfissional
         AND Consulta.SituacaoConsulta = 4 /* 4. Consulta Realizada */
    GROUP BY Avaliacao.CodigoAvaliacao