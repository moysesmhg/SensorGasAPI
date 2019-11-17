using SensorGasAPI.Negocio;
using System;

namespace SensorGasAPI.Repositorio
{
    public class UsuarioCarga
    {

        public void InserirUsuarios()
        {
            //// Usuário 01
            //var usuario01 = new CadastroUsuarioProjecao()
            //{
            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("mdj.domingos.junior@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Moisés"),
            //        SobreNomePessoa = string.Format("Domingos Júnior"),
            //        CPFPessoa = 08859390699.ToString(),
            //        DataNascimentoPessoa = "1989-05-17",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("mdj.domingos.junior@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 35039504,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 994018211,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(1),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario01);

            //// Usuário 02
            //var usuario02 = new CadastroUsuarioProjecao()
            //{
            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("danilo.santos@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Danilo"),
            //        SobreNomePessoa = string.Format("Santos da Silva"),
            //        CPFPessoa = 94926108682.ToString(),
            //        DataNascimentoPessoa = "1986-04-23",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("danilo.santos@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 26485822,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 988047810,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(2),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario02);

            //// Usuário 03
            //var usuario03 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("gigi.figueiredo@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Giovana"),
            //        SobreNomePessoa = string.Format("Carla Alícia Figueiredo"),
            //        CPFPessoa = 64743783607.ToString(),
            //        DataNascimentoPessoa = "1996-09-14",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("gigi.figueiredo@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 25848157,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 997604994,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(3),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario03);

            //// Usuário 04
            //var usuario04 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("mnb.maya.bernardes@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Maya"),
            //        SobreNomePessoa = string.Format("Nina Bernardes"),
            //        CPFPessoa = 47638051696.ToString(),
            //        DataNascimentoPessoa = "1991-08-07",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("mnb.maya.bernardes@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 37633666,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 991567290,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(4),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario04);

            //// Usuário 05
            //var usuario05 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("raul.edu.fernandes@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Rodrigo"),
            //        SobreNomePessoa = string.Format("Raul Eduardo Fernandes"),
            //        CPFPessoa = 01229921648.ToString(),
            //        DataNascimentoPessoa = "1983-12-27",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("raul.edu.fernandes@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 28852940,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 991527741,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(5),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario05);

            //// Usuário 06
            //var usuario06 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("assuncao.dai.clarice@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Clarice"),
            //        SobreNomePessoa = string.Format("Daiane Assunção"),
            //        CPFPessoa = 28102777613.ToString(),
            //        DataNascimentoPessoa = "1988-09-24",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("assuncao.dai.clarice@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 38361596,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 991404436,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(6),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario06);

            //// Usuário 07
            //var usuario07 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("mata.sonia@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Sônia"),
            //        SobreNomePessoa = string.Format("Raimunda da Mata"),
            //        CPFPessoa = 26119875646.ToString(),
            //        DataNascimentoPessoa = "1972-08-24",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("mata.sonia@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 25122341,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 992875445,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(7),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario07);

            //// Usuário 08
            //var usuario08 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("marcelo.bento.cruz@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Marcelo"),
            //        SobreNomePessoa = string.Format("Bento da Cruz"),
            //        CPFPessoa = 40881591602.ToString(),
            //        DataNascimentoPessoa = "1963-05-14",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("marcelo.bento.cruz@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 35171746,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 999601433,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(8),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario08);

            //// Usuário 09
            //var usuario09 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("joaquim.farias@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Joaquim"),
            //        SobreNomePessoa = string.Format("Renan Farias"),
            //        CPFPessoa = 96784252624.ToString(),
            //        DataNascimentoPessoa = "1977-06-26",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("joaquim.farias@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 29364214,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 992575971,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(9),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario09);

            //// Usuário 10
            //var usuario10 = new CadastroUsuarioProjecao()
            //{

            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = string.Format("antonia.almeida@gmail.com"),
            //        SenhaUsuario = "asd",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = string.Format("Antônia"),
            //        SobreNomePessoa = string.Format("Julia Almeida"),
            //        CPFPessoa = 28304389657.ToString(),
            //        DataNascimentoPessoa = "1953-04-12",
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = string.Format("antonia.almeida@gmail.com"),
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 37059493,
            //        DDDCelularDadosAdicionais = 31,
            //        NumeroCelularDadosAdicionais = 981111865,
            //    },
            //    Imagens = new ImagensCarga().LerImagensDiretorio(10),
            //};

            //new CadastroUsuarioDAL().InsertCadastro(usuario10);

        }

    }

}