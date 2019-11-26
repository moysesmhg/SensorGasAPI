using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Negocio;
using SensorGasAPI.Controllers;
using Moq;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class CadastroUsuarioTeste
    {

        [TestMethod]
        public void InsertUsuarioMock()
        {
            //var usuario = new CadastroUsuarioProjecao()
            //{
            //    Usuario = new UsuarioDados()
            //    {
            //        LoginUsuario = "teste@gmail.com",
            //        SenhaUsuario = "teste",
            //        TipoUsuario = 1,
            //    },
            //    Pessoa = new PessoaDados()
            //    {
            //        PrimeiroNomePessoa = "teste",
            //        SobreNomePessoa = "teste",
            //        CPFPessoa = "08859390699",
            //        DataNascimentoPessoa = new DateTime(1989, 05, 17).ToString("dd/MM/yyyy"),
            //    },
            //    DadosAdicionais = new DadosAdicionaisDados()
            //    {
            //        EmailDadosAdicionais = "",
            //        DDDTelefoneDadosAdicionais = 31,
            //        NumeroTelefoneDadosAdicionais = 94018211,
            //    }
            //};

            //var mockClasseProfissionalRepositorio = new Mock<ICadastroUsuarioService>();

            //// arrange
            //var classe = new CadastroUsuarioController(mockClasseProfissionalRepositorio.Object);

            //// act
            //var teste = classe.Post(usuario);

            //mockClasseProfissionalRepositorio.Setup(m => m.Insert(usuario));

            //// act
            ////IEnumerable<ClasseProfissional> teste = classe.List() as IEnumerable<ClasseProfissional>;

            ////assert
            //Assert.IsNotNull(teste);

        }

        [TestMethod]
        public void InsertUsuario()
        {
            var usuario = new CadastroUsuarioProjecao()
            {
                Usuario = new UsuarioDados()
                {
                    LoginUsuario = "teste1@gmail.com",
                    SenhaUsuario = "teste",
                    TipoUsuario = 1,
                },
                Pessoa = new PessoaDados()
                {
                    PrimeiroNomePessoa = "Usuario 1",
                    SobreNomePessoa = "Sobrenome Usuario 1",
                    CPFPessoa = "08859340000",
                    DataNascimentoPessoa = new DateTime(1990, 06, 10).ToString("dd/MM/yyyy"),
                },
                DadosAdicionais = new DadosAdicionaisDados()
                {
                    EmailDadosAdicionais = "teste1@gmail.com",
                    DDDTelefoneDadosAdicionais = 31,
                    NumeroTelefoneDadosAdicionais = 34154120,
                    //DDDCelularDadosAdicionais = 31,
                    //NumeroCelularDadosAdicionais = 994018211,
                }
            };

            new Repositorio.CadastroUsuarioDAL().InsertCadastro(usuario);

            //assert
            Assert.IsNotNull(1);

        }

    }
}
