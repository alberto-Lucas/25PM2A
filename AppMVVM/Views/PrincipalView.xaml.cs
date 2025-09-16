using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		//Agora vamos vincular a Tela com a ViewModel
		//Primeiro precisamo importar a camada
		//ViewModel
		//using AppMVVM.ViewModels;

		this.BindingContext = 
			new PrincipalViewModel();
	}
}