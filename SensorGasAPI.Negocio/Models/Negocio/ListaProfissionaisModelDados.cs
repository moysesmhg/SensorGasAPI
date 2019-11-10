using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class ListaProfissionaisModelDados
    {
        #region __Construtores__

        public ListaProfissionaisModelDados() { }

        #endregion

        #region __Atributos__

        private long _codigoProfissional;
        private string _nomeProfissional;
        private string _registroProfissional;
        private string _especialidadeProfissional;
        private string _localAbreviadoProfissional;

        #endregion

        #region __Propriedades__

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; }
        }

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; }
        }

        public string RegistroProfissional
        {
            get { return _registroProfissional; }
            set { _registroProfissional = value; }
        }

        public string EspecialidadeProfissional
        {
            get { return _especialidadeProfissional; }
            set { _especialidadeProfissional = value; }
        }

        public string LocalAbreviadoProfissional
        {
            get { return _localAbreviadoProfissional; }
            set { _localAbreviadoProfissional = value; }
        }

        #endregion



    }
}
