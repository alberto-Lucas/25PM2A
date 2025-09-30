using RevisaoMVVM.ViewModels;

namespace RevisaoMVVM.Views;

public partial class CarroCadastroView : ContentPage
{
	public CarroCadastroView()
	{
        //Importar a camada ViewModels
        //using Nome_Projeto.ViewModels;

        InitializeComponent();
		BindingContext = new CarroViewModel();
	}
}