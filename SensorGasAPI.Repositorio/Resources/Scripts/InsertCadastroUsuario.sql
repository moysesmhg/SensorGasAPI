   INSERT INTO Pessoa 
        ( PrimeiroNomePessoa 
        , SobreNomePessoa 
        , CPFPessoa 
        , DataNascimentoPessoa ) 
   VALUES 
        ( @primeiroNome 
        , @sobreNome
        , @cpfPessoa
        , @dataNascimento ); 

   INSERT INTO Usuario 
        ( CodigoPessoa 
        , LoginUsuario 
        , SenhaUsuario 
        , TipoUsuario ) 
   VALUES 
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @cpfPessoa) 
        , @login
        , @senha
        , 1 );  

   INSERT INTO Paciente 
        ( CodigoUsuario ) 
   VALUES 
        ( (SELECT CodigoUsuario FROM Usuario WHERE LoginUsuario = @login ) );
  
   INSERT INTO DadosAdicionais 
        ( CodigoPessoa 
        , DDDTelefoneDadosAdicionais 
        , NumeroTelefoneDadosAdicionais 
        , EmailDadosAdicionais ) 
   VALUES 
        ( (SELECT CodigoPessoa FROM Pessoa WHERE CPFPessoa = @cpfPessoa) 
        , @ddd 
        , @telefone 
        , @email ); 
