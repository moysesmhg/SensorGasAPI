     SELECT  *
        FROM RegistroEmissao
       WHERE 1 = 1
         AND (IdRegistroEmissao = @IdRegistroEmissao OR @IdRegistroEmissao IS NULL)