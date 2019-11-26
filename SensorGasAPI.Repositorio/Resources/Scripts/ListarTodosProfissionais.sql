 SELECT DISTINCT Imagens.Imagem Imagem
               , Profissional.CodigoProfissional
               , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) AS NomeProfissional 
               , (ClasseProfissional.ConselhoProfissional || ' ' || CAST(RelacaoProfissionalClasse.NumeroRegistroProfissional AS VARCHAR) || '-' ||  EnderecoMobile.AbreviacaoEstadoEndereco) AS RegistroProfissional 
               , EspecialidadeProfissional.DescricaoEspecialidadeProfissional AS EspecialidadeProfissional 
               , (EnderecoMobile.BairroEndereco || ' - ' || EnderecoMobile.MunicipioEndereco || ' - ' || EnderecoMobile.AbreviacaoEstadoEndereco) AS LocalAbreviadoProfissional 
            FROM Profissional 
            JOIN Usuario  
              ON Usuario.CodigoUsuario = Profissional.CodigoUsuario 
            JOIN Pessoa 
              ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa 
            JOIN EnderecoMobile  
              ON Pessoa.CodigoPessoa = EnderecoMobile.CodigoPessoa 
            JOIN DadosAdicionais 
              ON Pessoa.CodigoPessoa = DadosAdicionais.CodigoPessoa 
            JOIN RelacaoProfissionalClasse  
              ON Profissional.CodigoProfissional = RelacaoProfissionalClasse.CodigoProfissional 
       LEFT JOIN RelacaoClasseEspecialidade 
              ON RelacaoProfissionalClasse.CodigoRelacaoProfissionalClasse = RelacaoClasseEspecialidade.CodigoRelacaoProfissionalClasse 
       LEFT JOIN ClasseProfissional 
              ON RelacaoProfissionalClasse.CodigoClasseProfissional = ClasseProfissional.CodigoClasseProfissional 
       LEFT JOIN EspecialidadeProfissional 
              ON RelacaoClasseEspecialidade.CodigoEspecialidadeProfissional = EspecialidadeProfissional.CodigoEspecialidadeProfissional
       LEFT JOIN Imagens
              ON Usuario.CodigoUsuario = Imagens.CodigoUsuario