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
		//antes da animação
		await Task.Delay(2000);
		//Resetamos a posição da imagem
		imgSplash.Rotation = 0;
		//Aplicar uma animação de giro
		//no sentido horario por 3 segundos
		imgSplash.RotateTo(360, 3000);
		//Reseto a posição novamente
		imgSplash.Rotation = 0;
		//Adicionar mais uma espera
		await Task.Delay(2000);

        //Segunda da animção
        //Efeito zoom
        //Easing.Linear suavizar a animação
        //Iremos realizar um pequeno zoom
        await imgSplash.ScaleTo(1.5, 2000, Easing.Linear);
        //Retornar ao tamanho original
        await imgSplash.ScaleTo(1, 1000, Easing.Linear);
        //Irei diminui o tamanho da imagem
        await imgSplash.ScaleTo(0.5, 1000, Easing.Linear);
        //Irei aplicar o zoom de explosão("infinito")
        await imgSplash.ScaleTo(150, 1500, Easing.Linear);

		//Após as animãções iremos abrir a tela principal
		Application.Current.MainPage =
			new NavigationPage(new MainPage());
    }
}