using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IProfissionaisService
    {
        Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais();
        Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                          long? aCodigoClasseProfissional,
                                                                          long? aCodigoEspecialidadeProfissional);
        Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional);
        Task<string> RecuperarNomeProfissional(long aCodigoProfissional);
    }
}