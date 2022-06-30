using Caliburn.Micro;

namespace wpfapp.ViewModels
{
    public class MainViewModel : Screen
    {
        private string nomeCompleto;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}
