using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ProfissionaisRepositorio : IProfissionaisRepositorio
    {

        public async Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().ListarTodosProfissionais();
        }

        public async Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                                       long? aCodigoClasseProfissional,
                                                                                       long? aCodigoEspecialidadeProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().ListarProfissionais(aNomeProfissional,
                                                              aCodigoClasseProfissional,
                                                              aCodigoEspecialidadeProfissional);
        }

        public async Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().DetalheProfissional(aCodigoProfissional);
        }

        public async Task<string> RecuperarNomeProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().RecuperarNomeProfissional(aCodigoProfissional);
        }

    }
}