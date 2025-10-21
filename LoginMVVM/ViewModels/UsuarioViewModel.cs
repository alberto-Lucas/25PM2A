using LoginMVVM.Models;
using LoginMVVM.Services;

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
    }
}
