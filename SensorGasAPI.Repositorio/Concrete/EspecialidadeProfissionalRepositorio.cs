using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class EspecialidadeProfissionalRepositorio : IEspecialidadeProfissionalRepositorio
    {
        public async Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new EspecialidadeProfissionalDAL().ListarTodasEspecialidades();
        }

        public async Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new EspecialidadeProfissionalDAL().ListarEspecialidades(aCodigoClasseProfissional);
        }

    }
}