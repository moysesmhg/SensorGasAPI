using System;
using System.Drawing;
using System.IO;
using System.Linq;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ImagensCarga
    {

        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        public void InserirImagens()
        {
            var diretorio = @"C:\tcc\imagens\profile\prontos\";

            for (int i = 1; i < 2; i++)
            {
                Image photo = new Bitmap(diretorio + string.Format("pic_{0}.jpg", i.ToString().PadLeft(2, '0')));
                byte[] imagemByte = ImageToByte(photo, System.Drawing.Imaging.ImageFormat.Jpeg);

                var dados = new ImagensDados()
                {
                    CodigoUsuario = 1,
                    Imagem = imagemByte,
                };

                new ImagensDAL().InserirImagem(dados);
            }

            //RecuperarImagem();

        }

        public void InserirImagensPorCodigo(long aCodigo)
        {
            var diretorio = @"C:\tcc\imagens\profile\prontos\";

            Image photo = new Bitmap(diretorio + string.Format("pic_{0}.jpg", aCodigo.ToString().PadLeft(2, '0')));
            byte[] imagemByte = ImageToByte(photo, System.Drawing.Imaging.ImageFormat.Jpeg);

            var dados = new ImagensDados()
            {
                CodigoUsuario = aCodigo,
                Imagem = imagemByte,
            };

            new ImagensDAL().InserirImagem(dados);

        }

        public ImagensDados LerImagensDiretorio(long aCodigo)
        {
            var diretorio = @"C:\tcc\imagens\profile\prontos\";

            Image photo = new Bitmap(diretorio + string.Format("pic_{0}.jpg", aCodigo.ToString().PadLeft(2, '0')));
            byte[] imagemByte = ImageToByte(photo, System.Drawing.Imaging.ImageFormat.Jpeg);

            var dados = new ImagensDados()
            {
                CodigoUsuario = aCodigo,
                Imagem = imagemByte,
            };

            return dados;

        }

        public void RecuperarImagem()
        {
            var diretorio = @"C:\tcc\imagens\profile\prontos\recuperados\";
            var dados = new ImagensDAL().RecuperarImagem();

            var imagem = ByteToImage(dados.Imagem);

            imagem.Save(diretorio + "pic_01.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

    }

}