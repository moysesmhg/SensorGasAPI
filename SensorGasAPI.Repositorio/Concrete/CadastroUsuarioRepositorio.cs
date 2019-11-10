using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class CadastroUsuarioRepositorio : ICadastroUsuarioRepositorio
    {
        public async Task Insert(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroUsuario != null)
                new CadastroUsuarioDAL().InsertCadastro(aCadastroUsuario);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroUsuario != null)
                new CadastroUsuarioDAL().UpdateCadastro(aCadastroUsuario);
            else { /* TODO: Tratamento de exceção */ }
        }
    }
}