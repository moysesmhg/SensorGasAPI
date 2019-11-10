

namespace SensorGasAPI.Negocio
{
    public class EspecialidadeProfissionaisProjecao : BaseProjecao
    {

        #region Atributos

        private long _codigo;
        private ClasseProfissionalDados _classeProfissionais;
        private string _descricao;

        #endregion

        #region Propriedades

        public long Codigo
        {
            get { return _codigo; }
            set { _codigo = value; OnPropertyChanged(); }
        }

        public ClasseProfissionalDados ClasseProfissionais
        {
            get { return _classeProfissionais; }
            set { _classeProfissionais = value; OnPropertyChanged(); }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; OnPropertyChanged(); }
        }

        #endregion

        #region Construtores

        public EspecialidadeProfissionaisProjecao() { }

        public EspecialidadeProfissionaisProjecao(long aCodigo,
                                                  ClasseProfissionalDados aClasseProfissionais,
                                                  string aDescricao)
        {
            this.Codigo = aCodigo;
            this.ClasseProfissionais = aClasseProfissionais;
            this.Descricao = aDescricao;

        }

        #endregion

    }
}
