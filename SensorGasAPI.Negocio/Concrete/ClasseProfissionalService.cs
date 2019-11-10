using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class ClasseProfissionalService : IClasseProfissionalService
    {
        private readonly IClasseProfissionalRepositorio _repository;
        public ClasseProfissionalService(IClasseProfissionalRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ClasseProfissionalDados>> TodasClasses()
        {
            return await _repository.TodasClasses();
        }

        public async Task<ClasseProfissionalDados> Select(long aCodigo)
        {
            return await _repository.Select(aCodigo);
        }

        public async Task<ClasseProfissionalDados> Select(string aConselho)
        {
            return await _repository.Select(aConselho);
        }

        public async Task Insert(ClasseProfissionalDados aClasseProfissional)
        {
            await _repository.Insert(aClasseProfissional);
        }

        public async Task Update(ClasseProfissionalDados aClasseProfissional)
        {
            await _repository.Update(aClasseProfissional);
        }

        public async Task Delete(long aCodigo)
        {
            await _repository.Delete(aCodigo);
        }
    }
}