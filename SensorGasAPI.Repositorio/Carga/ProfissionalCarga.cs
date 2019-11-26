using System;
using System.Linq;
using System.Collections.Generic;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ProfissionalCarga
    {

        public void InserirProfissionais()
        {
            // Profissional 01
            var profissional01 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("moysesmhg@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Moisés"),
                    SobreNomePessoa = string.Format("Noah Henry Nunes"),
                    CPFPessoa = 63819418636.ToString(),
                    DataNascimentoPessoa = "1985-09-06",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Kepler"),
                    NumeroEndereco = 603,
                    ComplementoEndereco = string.Format("Sala 26"),
                    BairroEndereco = string.Format("Santa Lúcia"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "30360-536",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("moysesmhg@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 26691192,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 983249729,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(11),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional01);

            // Profissional 02
            var profissional02 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("henrypeixotobh@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Henry"),
                    SobreNomePessoa = string.Format("Vinicius Peixoto"),
                    CPFPessoa = 69429565621.ToString(),
                    DataNascimentoPessoa = "1987-02-26",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Engenho da Luz"),
                    NumeroEndereco = 919,
                    ComplementoEndereco = string.Format("Sala 08"),
                    BairroEndereco = string.Format("Engenho Nogueira"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31535-070",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("henrypeixotobh@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 25630315,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 988475286,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(12),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional02);

            // Profissional 03
            var profissional03 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("jennifer.bernardes.bh@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Jennifer"),
                    SobreNomePessoa = string.Format("Tatiane Bernardes"),
                    CPFPessoa = 42441510606.ToString(),
                    DataNascimentoPessoa = "1989-07-14",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Navajos"),
                    NumeroEndereco = 134,
                    ComplementoEndereco = string.Format("Sala 112"),
                    BairroEndereco = string.Format("Santa Mônica"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31530-100",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("jennifer.bernardes.bh@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 26691192,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 983249729,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(13),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional03);

            // Profissional 04
            var profissional04 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("prof.carlos.costa@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Carlos"),
                    SobreNomePessoa = string.Format("Eduardo Vinicius Costa"),
                    CPFPessoa = 69522574627.ToString(),
                    DataNascimentoPessoa = "1970-06-18",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Dom Helder Câmara"),
                    NumeroEndereco = 493,
                    ComplementoEndereco = string.Format("Escritório 104"),
                    BairroEndereco = string.Format("Belmonte"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31870-440",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("prof.carlos.costa@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 26691192,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 983249729,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(14),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional04);

            // Profissional 05
            var profissional05 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("isabelastella.bh@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Isabela"),
                    SobreNomePessoa = string.Format("Stella da Silva"),
                    CPFPessoa = 45167204690.ToString(),
                    DataNascimentoPessoa = "1986-08-24",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua José Alves de Souza"),
                    NumeroEndereco = 466,
                    ComplementoEndereco = string.Format("Sala 144"),
                    BairroEndereco = string.Format("Santa Terezinha"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31360-120",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("isabelastella.bh@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 29498569,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 988568872,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(15),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional05);

            // Profissional 06
            var profissional06 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("lorenzo.brito.bh@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Lorenzo"),
                    SobreNomePessoa = string.Format("Filipe Paulo Brito"),
                    CPFPessoa = 07802471672.ToString(),
                    DataNascimentoPessoa = "1979-11-11",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Avenida do Contorno"),
                    NumeroEndereco = 6283,
                    ComplementoEndereco = string.Format("Escritório 14"),
                    BairroEndereco = string.Format("Funcionários"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "30110-931",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("lorenzo.brito.bh@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 27349681,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 981935394,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(16),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional06);

            // Profissional 07
            var profissional07 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("carlosanthonyalmeida@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Carlos"),
                    SobreNomePessoa = string.Format("Anthony Almeida"),
                    CPFPessoa = 55217993626.ToString(),
                    DataNascimentoPessoa = "1977-03-30",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Quatorze de Junho"),
                    NumeroEndereco = 435,
                    ComplementoEndereco = string.Format("Sala 514"),
                    BairroEndereco = string.Format("Buritis"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "30575-350",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("carlosanthonyalmeida@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 37122136,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 985580132,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(17),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional07);

            // Profissional 08
            var profissional08 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("isaac.araujo.prof@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Isaac"),
                    SobreNomePessoa = string.Format("Mateus Benjamin Araújo"),
                    CPFPessoa = 58888961607.ToString(),
                    DataNascimentoPessoa = "1981-05-22",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Professora Dona Áurea"),
                    NumeroEndereco = 905,
                    ComplementoEndereco = string.Format("Sala 202"),
                    BairroEndereco = string.Format("Buritis"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "30575-205",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("isaac.araujo.prof@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 28815776,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 993367756,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(18),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional08);

            // Profissional 09
            var profissional09 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("isadora.figueiredo@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Isadora"),
                    SobreNomePessoa = string.Format("Camila Figueiredo"),
                    CPFPessoa = 07200080691.ToString(),
                    DataNascimentoPessoa = "1988-10-05",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Expedicionário Adelino Torres"),
                    NumeroEndereco = 723,
                    ComplementoEndereco = string.Format("Sala 203"),
                    BairroEndereco = string.Format("São Paulo"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31910-640",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("isadora.figueiredo@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 25795496,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 986551357,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(19),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional09);

            // Profissional 10
            var profissional10 = new CadastroProfissionalProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = string.Format("teresinha.fabiana@gmail.com"),
                    SenhaUsuario = "asd",
                    TipoUsuario = 2,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = string.Format("Fabiana"),
                    SobreNomePessoa = string.Format("Teresinha Nunes"),
                    CPFPessoa = 37978553620.ToString(),
                    DataNascimentoPessoa = "1993-01-23",
                },
                Endereco = new EnderecoDados()
                {
                    LogradouroEndereco = string.Format("Rua Carlos Niemeyer"),
                    NumeroEndereco = 652,
                    ComplementoEndereco = string.Format("Sala 101"),
                    BairroEndereco = string.Format("Sagrada Família"),
                    CodigoMunicipio = 2549, /* 2549 - Belo Horizontw */
                    CodigoEstado = 11, /* 11 - Minas Gerais */
                    CepEndereco = "31035-291",
                    TipoEndereco = 1,
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = string.Format("teresinha.fabiana@gmail.com"),
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 39539014,
                    DDDCelularDadosAdicionais = 31,
                    NumeroCelularDadosAdicionais = 996118730,
                },
                ClasseProfissional = new ClasseProfissionalDados()
                {
                    ConselhoProfissional = "CRM",
                },
                RelacaoProfissionalClasse = new RelacaoProfissionalClasseDados()
                {
                    NumeroRegistroProfissional = GeradorUtilitario.GerarNumeroAleatorio(8),
                },
                Imagens = new ImagensCarga().LerImagensDiretorio(20),
            };

            new CadastroProfissionalDAL().InsertCadastro(profissional10);

        }

    }

}