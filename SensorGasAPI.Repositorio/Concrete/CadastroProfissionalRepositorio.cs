using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class CadastroProfissionalRepositorio : ICadastroProfissionalRepositorio
    {
        public async Task Insert(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroProfissional != null)
                new CadastroProfissionalDAL().InsertCadastro(aCadastroProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroProfissional != null)
                new CadastroProfissionalDAL().UpdateCadastro(aCadastroProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }
    }
}