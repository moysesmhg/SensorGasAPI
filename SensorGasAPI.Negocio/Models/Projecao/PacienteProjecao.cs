

namespace SensorGasAPI.Negocio
{
    public class PacienteProjecao : ProjecaoBase
    {
        #region Construtores

        public PacienteProjecao() { }

        #endregion

        #region Atributos

        private long _codigoPaciente;
        private string _nomePaciente;
        private string _telefonePaciente;
        private string _celularPaciente;
        private string _eMailPaciente;

        #endregion

        #region Propriedades

        public long CodigoPaciente
        {
            get { return _codigoPaciente; }
            set { _codigoPaciente = value; OnPropertyChanged(); }
        }

        public string NomePaciente
        {
            get { return _nomePaciente; }
            set { _nomePaciente = value; OnPropertyChanged(); }
        }

        public string TelefonePaciente
        {
            get { return _telefonePaciente; }
            set { _telefonePaciente = value; OnPropertyChanged(); }
        }

        public string CelularPaciente
        {
            get { return _celularPaciente; }
            set { _celularPaciente = value; OnPropertyChanged(); }
        }

        public string EMailPaciente
        {
            get { return _eMailPaciente; }
            set { _eMailPaciente = value; OnPropertyChanged(); }
        }

        #endregion        

    }
}