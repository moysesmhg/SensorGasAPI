using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IClasseProfissionalService
    {
        Task<IEnumerable<ClasseProfissionalDados>> TodasClasses();
        Task<ClasseProfissionalDados> Select(long aCodigo);
        Task<ClasseProfissionalDados> Select(string aConselho);
        Task Insert(ClasseProfissionalDados aClasseProfissional);
        Task Update(ClasseProfissionalDados aClasseProfissional);
        Task Delete(long aCodigo);
    }
}