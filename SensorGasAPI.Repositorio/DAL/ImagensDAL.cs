using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using System;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class ImagensDAL : RepositorioAncestral
    {
        public ImagensDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        #region Carga

        public void InserirImagem(ImagensDados aDados)
        {
            this.Conexao.Insert(aDados);
        }

        public ImagensDados RecuperarImagem()
        {
            //var retorno = this.Conexao.Find<ImagensDados>(a => a.CodigoUsuario == 1);
            var retorno = this.Conexao.FindWithQuery<ImagensDados>("SELECT * FROM Imagens WHERE CodigoUsuario = 1");
            var imagem = this.Conexao.FindWithQuery<ImagensDados>("SELECT Imagem FROM Imagens WHERE CodigoUsuario = 1").Imagem;

            return retorno;
        }

        #endregion

    }

}