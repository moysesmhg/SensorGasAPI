using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ClasseProfissionalRepositorio : IClasseProfissionalRepositorio
    {

        public async Task<IEnumerable<ClasseProfissionalDados>> TodasClasses()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasses();
        }

        public async Task<ClasseProfissionalDados> Select(long aCodigo)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasse(aCodigo);
        }

        public async Task<ClasseProfissionalDados> Select(string aConselho)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasse(aConselho);
        }

        public async Task Insert(ClasseProfissionalDados aClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aClasseProfissional != null)
                new ClasseProfissionalDAL().InsertClasse(aClasseProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(ClasseProfissionalDados aClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aClasseProfissional != null)
                new ClasseProfissionalDAL().UpdateClasse(aClasseProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Delete(long aCodigo)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ClasseProfissionalDAL().DeleteClasse(aCodigo);
        }
    }
}