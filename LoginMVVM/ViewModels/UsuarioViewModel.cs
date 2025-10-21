using LoginMVVM.Models;
using LoginMVVM.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginMVVM.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        UsuarioService usuarioService =
            new UsuarioService();

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }

        private string _cpf;
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                OnPropertyChanged();
            }
        }

        private string _dtNascimento;
        public string DtNascimento
        {
            get { return _dtNascimento; }
            set
            {
                _dtNascimento = value;
                OnPropertyChanged();
            }
        }

        public ICommand CadastrarCommand { get; set; }
        public async Task Cadastrar()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = Nome;
            usuario.CPF = Cpf;
            usuario.Email = Email;
            usuario.Senha = Senha;
            usuario.DtNascimento = DtNascimento;

            usuarioService.Inserir(usuario);

            AlertInfo("Cadastro realizado com sucesso!");

            Voltar();
        }
    }
}
