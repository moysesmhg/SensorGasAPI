using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class RegistroEmissaoService : IRegistroEmissaoService
    {
        private readonly IRegistroEmissaoRepositorio _repository;
        public RegistroEmissaoService(IRegistroEmissaoRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(int aIdRegistroEmissao)
        {
            return await _repository.ListaRegistroEmissao(aIdRegistroEmissao);
        }

        public async Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(DateTime aDataInicio, DateTime aDataFim)
        {
            return await _repository.ListaRegistroEmissao(aDataInicio, aDataFim);
        }

        public async Task<RegistroEmissao> RecuperarRegistroEmissao(int aIdRegistroEmissao)
        {
            return await _repository.RecuperarRegistroEmissao(aIdRegistroEmissao);
        }

        public async Task SalvarRegistroEmissao(RegistroEmissao aRegistroEmissao)
        {
            await _repository.SalvarRegistroEmissao(aRegistroEmissao);
        }

        public async Task SalvarRegistroEmissao(int aIdIndicadorEmissao)
        {
            await _repository.SalvarRegistroEmissao(aIdIndicadorEmissao);
        }

    }
}