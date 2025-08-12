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

        private void btnFade_Clicked(object sender, EventArgs e)
        {
            //Opacity é a propriade que define
            //o quão transparente é a imagem

            //Resetar a opacidade
            imgTeste.Opacity = 1;
            imgTeste.FadeTo(0, 1000);
            //A imagem ficara 100% transparente

            //Agora iremos reverter
            //Resetando a opacidade em trasnparente
            imgTeste.Opacity = 0;
            imgTeste.FadeTo(1, 1000);
        }

        private void btnTremer_Clicked(object sender, EventArgs e)
        {
            Tremer(50);
        }

        //Método para geração animação de "tremida"
        //Precisa ser do tupo async
        //pois precisamos executar e aguardar
        //cada animação
        //Usar o parametro UINT para nao aceitar
        //valores negativos
        async void Tremer(uint tempo)
        {
            //A ideia da animação de tremida
            //é mover a imagem para direita e para esquerda
            //reduzindo a distancia de movimento a cada conjunto
            //Primeiro parametro eixo x tremer horizontal
            //Segundo parametro eixo y tremer vertical
            await imgTeste.TranslateTo(15, 0, tempo);
            await imgTeste.TranslateTo(-15, 0, tempo);
            await imgTeste.TranslateTo(10, 0, tempo);
            await imgTeste.TranslateTo(-10, 0, tempo);
            await imgTeste.TranslateTo(5, 0, tempo);
            await imgTeste.TranslateTo(-5, 0, tempo);
            imgTeste.TranslationX = 0;
        }

        private async void btnGirarZoom_Clicked(object sender, EventArgs e)
        {
            //Executar duas animações ou mais
            //ao mesmo tempo
            //Para isso iremos usar um recurso
            //asincrono para excução simultanea

            imgTeste.Rotation = 0;
            //Agora iremos juntar duas animações
            //girar para direita e zoom + ao mesmo tempo
            await Task.WhenAny<bool>
            (
                //Agora colocar as animações
                imgTeste.RotateTo(360, 2000),
                imgTeste.ScaleTo(2, 1000)
                
            );
            //Remover o zoom
            imgTeste.ScaleTo(1, 1000);
        }
    }

}
