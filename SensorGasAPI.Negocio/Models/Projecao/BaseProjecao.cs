using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace SensorGasAPI.Negocio
{
    public class BaseProjecao : INotifyPropertyChanged
    {

        #region Property Change

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ICommand RefreshDataCommand { get; set; }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChangedByName(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
