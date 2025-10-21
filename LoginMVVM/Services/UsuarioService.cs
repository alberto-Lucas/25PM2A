using LoginMVVM.Models;

namespace LoginMVVM.Services
{
    public class UsuarioService
    {
        FakeDBSingleton fakeDB = 
            FakeDBSingleton.Instancia;

        public void Inserir(Usuario usuario)
        {
            fakeDB.Usuario = usuario;
        }

        public Usuario GetUsuario()
        {
            return fakeDB.Usuario;
        }
    }
}
