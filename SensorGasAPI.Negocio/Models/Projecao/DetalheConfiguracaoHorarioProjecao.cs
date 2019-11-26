using System;


namespace SensorGasAPI.Negocio
{
    public class DetalheConfiguracaoHorarioProjecao : ProjecaoBase
    {

        #region Construtores

        public DetalheConfiguracaoHorarioProjecao() { }

        #endregion

        #region Atributos

        private long _codigoConfiguracaoHorario;
        private long _codigoProfissional;
        private long _codigoDiaConsulta;
        private bool _statusSwitch;
        private string _statusAtivacaoConfiguracaoHorario;
        private TimeSpan _horarioInicial;
        private TimeSpan _horarioFinal;


        #endregion

        #region Propriedades

        public long CodigoConfiguracaoHorario
        {
            get { return _codigoConfiguracaoHorario; }
            set { _codigoConfiguracaoHorario = value; OnPropertyChanged(); }
        }

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; OnPropertyChanged(); }
        }

        public long CodigoDiaConsulta
        {
            get { return _codigoDiaConsulta; }
            set { _codigoDiaConsulta = value; OnPropertyChanged(); }
        }

        public bool StatusSwitch
        {
            get { return _statusSwitch; }
            set { _statusSwitch = value; OnPropertyChanged(); }
        }

        public string StatusAtivacaoConfiguracaoHorario
        {
            get { return _statusAtivacaoConfiguracaoHorario; }
            set { _statusAtivacaoConfiguracaoHorario = value; OnPropertyChanged(); }
        }

        public TimeSpan HorarioInicial
        {
            get { return _horarioInicial; }
            set { _horarioInicial = value; OnPropertyChanged(); }
        }

        public TimeSpan HorarioFinal
        {
            get { return _horarioFinal; }
            set { _horarioFinal = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
