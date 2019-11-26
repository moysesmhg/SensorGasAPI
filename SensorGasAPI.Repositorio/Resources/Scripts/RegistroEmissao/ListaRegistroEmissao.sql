     SELECT  *
        FROM RegistroEmissao
       WHERE 1 = 1
         AND (IdRegistroEmissao = @IdRegistroEmissao OR @IdRegistroEmissao IS NULL)
         AND ( (DataRegistroEmissao BETWEEN @DataInicio AND @DataFim) OR
               (@DataInicio IS NULL AND @DataFim IS NULL) )