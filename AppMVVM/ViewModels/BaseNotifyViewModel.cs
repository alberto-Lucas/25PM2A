using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMVVM.ViewModels
{
    //Primeira coisa é importar a biblioteca
    //do ComponentModel resposavel
    //por gerenciar as notificações
    //using System.ComponentModel;

    //Segundo passo, transformar a classe em abstratc
    //pois classe abstratc não pode ser instanciada

    //Terceiro passo é a classe herda da Interface
    //INotifyPropertyChanged
    //Vamos herdar pois a rotina original
    //é preciso passar o nome da propriedade manualmente
    //iremos modificar para que a nossa rotina
    //identifique o nome automaticamente
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        //Evento publico herdado da classe
        //"assinatura do contrato"
        public event PropertyChangedEventHandler? PropertyChanged;

        //Vamos cirar o nosso método personalizado
        //Iremos utilizar o CallerMemberName para identificar
        //o nome da propriedade automaticamente
        //Para uso do CallerMemberName é preciso importar
        //a biblioteca Runtime.CompilerServices
        //using System.Runtime.CompilerServices;
        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            //Se a propriedade for alterada irá
            //disparar o evento de notificação
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
