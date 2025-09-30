using RevisaoMVVM.ViewModels;

namespace RevisaoMVVM.Views;

public partial class CarroVisualizacaoView : ContentPage
{
	public CarroVisualizacaoView()
	{
        //Importar a camada de ViewModels
        //using Nome_Projeto.ViewModels;
        InitializeComponent();

        //Ao abrir a tela, irá carregar dados
        //automaticamente
        //para isso precisamos chamar o
        //ConsultarCommand direto

        //Recuperar a instancia da ViewModel
        var carroViewModel = new CarroViewModel();
        //Vinculo a tela a viewModel
        BindingContext = carroViewModel;
        //Executar o ConsultarCommand direto
        carroViewModel.ConsultarCommand.Execute(null);
	}
}