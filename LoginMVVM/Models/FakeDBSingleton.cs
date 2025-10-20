namespace LoginMVVM.Models
{
    public sealed class FakeDBSingleton
    {
        static FakeDBSingleton _instancia;

        public static FakeDBSingleton Instancia
        {
            get 
            {
                return _instancia ?? 
                    (_instancia = new FakeDBSingleton());
            }
        }

        public Usuario Usuario { get; set; }
    }
}
