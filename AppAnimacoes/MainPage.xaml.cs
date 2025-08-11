namespace AppAnimacoes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDireita_Clicked(object sender, EventArgs e)
        {
            //Rotação simples
            //Seguindo o sentido Horario
            //Ou seja realizando uma volta 
            //de 360 graus

            //Resetar a posição da imagem
            imgTeste.Rotation = 0;

            //Iremos girar a imagem com uma volta completa
            //ou seja 360 graus
            //Definir a quantidade de graus a ser girada
            //Definir o tempo da animação em milisegundos
            imgTeste.RotateTo(360, 2000);
        }

        private void btnEsquerda_Clicked(object sender, EventArgs e)
        {
            imgTeste.Rotation = 0;
            imgTeste.RotateTo(-360, 500);
        }

        private void btnVertical_Clicked(object sender, EventArgs e)
        {
            imgTeste.RotationY = 0;
            imgTeste.RotateYTo(360, 1000);
        }

        private void btnHorizontal_Clicked(object sender, EventArgs e)
        {
            imgTeste.RotationX = 0;
            imgTeste.RotateXTo(360, 5000);
        }

        private void btnZoomMais_Clicked(object sender, EventArgs e)
        {
            //Quantidade de Escala (1x, 2x)
            //Tempo de animação

            imgTeste.ScaleTo(imgTeste.Scale + 0.5, 250);
        }

        private void btnZoomMenos_Clicked(object sender, EventArgs e)
        {
            imgTeste.ScaleTo(imgTeste.Scale - 0.5, 250);
        }
    }

}
