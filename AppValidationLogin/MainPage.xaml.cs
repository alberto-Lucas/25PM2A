namespace AppValidationLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ValidarCampo(
            Entry txtCampo, Label lblValidation, string valor)
        {
            if((String.IsNullOrEmpty(txtCampo.Text)) ||
               (txtCampo.Text != valor))
            {
                Animation.Tremer(txtCampo);
                lblValidation.IsVisible = true;
            }
            else
                lblValidation.IsVisible = false;
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            ValidarCampo(txtEmail, lblValidationEmail, "admin");
            ValidarCampo(txtSenha, lblValidationSenha, "admin");
        }
    }
}
