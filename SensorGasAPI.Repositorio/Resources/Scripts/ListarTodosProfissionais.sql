 SELECT DISTINCT Imagens.Imagem Imagem
               , Profissional.CodigoProfissional CodigoProfissional
               , (Pessoa.PrimeiroNomePessoa || ' ' || Pessoa.SobreNomePessoa) NomeProfissional 
               , (ClasseProfissional.ConselhoProfissional || ' ' || CAST(RelacaoProfissionalClasse.NumeroRegistroProfissional AS VARCHAR) || '-' ||  Estado.AbreviacaoEstado) RegistroProfissional 
               , EspecialidadeProfissional.DescricaoEspecialidadeProfissional EspecialidadeProfissional 
               , (Endereco.BairroEndereco || ' - ' || Municipio.DescricaoMunicipio || ' - ' || Estado.AbreviacaoEstado) LocalAbreviadoProfissional 
            FROM Profissional 
            JOIN Usuario  
              ON Usuario.CodigoUsuario = Profissional.CodigoUsuario 
            JOIN Pessoa 
              ON Usuario.CodigoPessoa = Pessoa.CodigoPessoa           
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
       LEFT JOIN Endereco  
              ON Pessoa.CodigoPessoa = Endereco.CodigoPessoa
       LEFT JOIN Estado
              ON Endereco.CodigoEstado = Estado.CodigoEstado
       LEFT JOIN Municipio
              ON Endereco.CodigoMunicipio = Municipio.CodigoMunicipio
           WHERE 1 = 1   