using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        public async Task<string> RecuperarNomePaciente(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new PacienteDAL().RecuperarNomePaciente(aCodigoPaciente);
        }

        public async Task<PacienteProjecao> RecuperarContatoPaciente(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new PacienteDAL().RecuperarContatoPaciente(aCodigoPaciente);
        }

    }
}