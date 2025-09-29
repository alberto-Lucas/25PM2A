using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RevisaoMVVM.ViewModels
{
    //Classe padrão para invocar as notificações
    //de alteração das propriedades e atualizar as telas
    //de acordo com a documentação C#
    public class BaseNotifyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
