namespace AppValidationLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Método tremer
        //para aplicar animação no componente informado
        private async void TremerEntry(Entry txtCampo)
        {
            uint tempo = 50;

            await txtCampo.TranslateTo(-15, 0, tempo);
            await txtCampo.TranslateTo(15, 0, tempo);
            await txtCampo.TranslateTo(-10, 0, tempo);
            await txtCampo.TranslateTo(10, 0, tempo);
            await txtCampo.TranslateTo(-5, 0, tempo);
            await txtCampo.TranslateTo(5, 0, tempo);
            txtCampo.TranslationX = 0;
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if (txtEmail.Text != "admin")
                TremerEntry(txtEmail);

            if (txtSenha.Text != "admin")
                TremerEntry(txtSenha);
        }   
    }
}
