using System.Windows.Input; //ICommand
using RevisaoMVVM.Models;
using RevisaoMVVM.Services;
using RevisaoMVVM.Views;

namespace RevisaoMVVM.ViewModels
{
    //Classe para manipulação do Objeto Carro
    //e das telas vinculadas a Carro
    public class CarroViewModel : BaseViewModel
    {
        //Importar a camada de Services
        //using Nome_Projeto.Services;

        //Instanciar a nossa camada de serviço
        CarroService carroService = new CarroService();

        //Precismo herdar da classe BaseViewModel

        //Agora iremos implementar as propriedades
        //dos campos que poderao ser usados em tela
        //geralmente seguimos os atributos da classe
        //referenciada, no caso a classe Carro
        //Mais conhecido como encapsulamento
        private string _marca;
        public string Marca
        {
            get { return _marca; }
            set
            {
                _marca = value;
                OnPropertyChanged();
            }
        }

        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            set
            {
                _modelo = value;
                OnPropertyChanged();
            }
        }

        private string _cor;
        public string Cor
        {
            get { return _cor; }
            set
            {
                _cor = value;
                OnPropertyChanged();
            }
        }

        //Precisamo criar as telas envolvidas
        //No caso teremos um tela de
        //cadastro e uma de visualização
        //Tela ja criadas

        //Iremos implementar a rotina de cadastro
        public ICommand CadastrarCommand { get; set; }

        void Cadastrar()
        {
            //Importar camada Models
            //using Nome_Projeto.Models;
            //Iremos instanciar um objeto Carro
            Carro carro = new Carro();
            //Popular o objeto
            carro.Marca = Marca;
            carro.Modelo = Modelo;
            carro.Cor = Cor;

            //Importar camada Service
            //using Nome_Projeto.Services;
            //Agora iremos chamar o método Adicionar
            //da classe de serviço
            carroService.Adicionar(carro);

            //Importar camada Views
            //using Nome_Projeto.Views;
            //Iremos a abrir a tela de visulização
            AbrirView(new CarroVisualizacaoView());
        }

        //Iremos implementar a rotina de consulta
        public ICommand ConsultarCommand { get; set; }
        public void Consultar()
        {
            //Instanciar o objeto carro
            //para recuperar o registro cadastrado
            //e atribuir o cadastro salvo
            Carro carro = carroService.Consultar();

            //Iremos popular as propriedades com o objeto
            Marca = carro.Marca;
            Modelo = carro.Modelo;
            Cor = carro.Cor;
        }

        //Iremos vincular os métodos aos commands
        public CarroViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
            ConsultarCommand = new Command(Consultar);
        }
    }
}
