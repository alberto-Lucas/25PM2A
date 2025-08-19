using System.Xml.Serialization;

namespace SplashScreen;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();
		AnimateImage();
	}

	async void AnimateImage()
	{
		//Aplicar um tempo de espera
		//antes da anima��o
		await Task.Delay(2000);
		//Resetamos a posi��o da imagem
		imgSplash.Rotation = 0;
		//Aplicar uma anima��o de giro
		//no sentido horario por 3 segundos
		imgSplash.RotateTo(360, 3000);
		//Reseto a posi��o novamente
		imgSplash.Rotation = 0;
		//Adicionar mais uma espera
		await Task.Delay(2000);

        //Segunda da anim��o
        //Efeito zoom
        //Easing.Linear suavizar a anima��o
        //Iremos realizar um pequeno zoom
        await imgSplash.ScaleTo(1.5, 2000, Easing.Linear);
        //Retornar ao tamanho original
        await imgSplash.ScaleTo(1, 1000, Easing.Linear);
        //Irei diminui o tamanho da imagem
        await imgSplash.ScaleTo(0.5, 1000, Easing.Linear);
        //Irei aplicar o zoom de explos�o("infinito")
        await imgSplash.ScaleTo(150, 1500, Easing.Linear);

		//Ap�s as anim���es iremos abrir a tela principal
		Application.Current.MainPage =
			new NavigationPage(new MainPage());
    }
}