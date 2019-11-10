using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public interface IClasseProfissionalRepositorio
    {
        Task<IEnumerable<ClasseProfissionalDados>> TodasClasses();
        Task<ClasseProfissionalDados> Select(long aCodigo);
        Task<ClasseProfissionalDados> Select(string aConselho);
        Task Insert(ClasseProfissionalDados aClasseProfissional);
        Task Update(ClasseProfissionalDados aClasseProfissional);
        Task Delete(long aCodigo);
    }
}