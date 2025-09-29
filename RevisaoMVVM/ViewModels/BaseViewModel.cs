using System.Windows.Input;

namespace RevisaoMVVM.ViewModels
{
    //Classe base para centralizar
    //dados e funções genericas
    //para as demais ViewModels
    public class BaseViewModel : BaseNotifyViewModel
    {
        //Precisamos herdar da classe BaseNotifyViewModel

        //Importr a biblioteca:
        //using System.Windows.Input;

        //Implementar o Botão Voltar
        //Para essa implementação precisamos
        //de um Command e de um Método
        public ICommand VoltarCommand { get; set; }

        private async void Voltar()
        {
            await Application.Current.MainPage.
                Navigation.PopAsync();
        }

        //O Voltar será privado pois não é nescessario
        //acessa-lo diretamente pois temos o VoltarCommand
        //executado direto pelo botão em tela
        //Ja o método abrirView precisa ser publico 
        //pois não tem um command e iremos chama-lo
        //via backEnd e não via tela
        public async void AbrirView(ContentPage view)
        {
            //Abriremos a tela recebida via parametro
            await Application.Current.MainPage.
                Navigation.PushAsync(view);
        }

        //Agora iremos vincular o método
        //Voltar com o Command
        public BaseViewModel()
        {
            VoltarCommand = new Command(Voltar);
        }
    }
}
