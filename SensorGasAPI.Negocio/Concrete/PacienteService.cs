using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepositorio _repository;
        public PacienteService(IPacienteRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<string> RecuperarNomePaciente(long aCodigoPaciente)
        {
            return await _repository.RecuperarNomePaciente(aCodigoPaciente);
        }

        public async Task<PacienteProjecao> RecuperarContatoPaciente(long aCodigoPaciente)
        {
            return await _repository.RecuperarContatoPaciente(aCodigoPaciente);
        }


    }

}