using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class DetalheProfissionalModelDados
    {
        #region __Construtores__

        public DetalheProfissionalModelDados() { }

        #endregion

        #region __Atributos__

        private long _codigoProfissional;
        private string _nomeProfissional;
        private string _registroProfissional;
        private string _especialidadeProfissional;
        //private string _localAbreviadoProfissional;
        private string _logradouroBairroProfissional;
        private string _cidadeEstadoProfissional;
        private string _cepTelefoneProfissional;

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

        //public string LocalAbreviadoProfissional
        //{
        //    get { return _localAbreviadoProfissional; }
        //    set { _localAbreviadoProfissional = value; }
        //}

        public string LogradouroBairroProfissional
        {
            get { return _logradouroBairroProfissional; }
            set { _logradouroBairroProfissional = value; }
        }


        public string CidadeEstadoProfissional
        {
            get { return _cidadeEstadoProfissional; }
            set { _cidadeEstadoProfissional = value; }
        }


        public string CepTelefoneProfissional
        {
            get { return _cepTelefoneProfissional; }
            set { _cepTelefoneProfissional = value; }
        }

        #endregion

    }
}
