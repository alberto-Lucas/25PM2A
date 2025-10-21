using LoginMVVM.Services;
using System.Windows.Input;

namespace LoginMVVM.ViewModels;

public class BaseViewModel : BaseNotifyService
{
    public ICommand VoltarCommand { get; set; }
    public async void Voltar()
    {
        await Application.Current.MainPage.
            Navigation.PopAsync();
    }

    public async void AbrirView(ContentPage view)
    {
        await Application.Current.MainPage.
            Navigation.PushAsync(view);
    }

    public BaseViewModel()
    {
        VoltarCommand = new Command(Voltar);
    }

    public async void AlertInfo(string conteudo)
    {
        await Application.Current.MainPage.
                DisplayAlert("Informação!", conteudo, "OK");
    }
}
