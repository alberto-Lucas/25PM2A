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
            //Tipo 1 de Validação
            //ValidarCampo(txtEmail, lblValidationEmail, "admin");
            //ValidarCampo(txtSenha, lblValidationSenha, "admin");

            //Tipo 2 de validação usando a classe Validation
            //Primeiro precisando instanciar a classe
            //e vincular os componentes
            Validation Email = new Validation(txtEmail, lblValidationEmail);
            Validation Senha = new Validation(txtSenha, lblValidationSenha);

            //Criar as validações personalizadas
            ValidarEmail(Email);
        }

        private bool ValidarEmail(Validation Email)
        {
            //Definir o resultado padrão
            bool resultado = false;

            if (Email.IsEmpty()) //Valido se está vazio
                Email.SetValidation("* Informe o Email.", true);
            else if (Email.GetText().Length < 5) //Se possui 5 ou mais caracteres
                Email.SetValidation("* Informe um email com no minimo 5 caracteres.", true);
            else if (!Email.Equals("admin")) //Se o conteudo é diferente de admin
                Email.SetValidation("* Informe um Email válido.", true);
            else
            {
                resultado = true;
                Email.HideValidation();
            }

            return resultado;
        }
    }
}
