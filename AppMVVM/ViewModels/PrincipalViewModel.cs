using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVVM.ViewModels
{
    //Classe com os eventos e manipulação
    //da tela Principal

    //Devemos realizar a herança com a classe
    //BaseNotifyViewModel
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //Agora vamos criar as propriedades de acordo
        //com os campos da tela, geralmente é criado
        //a ViewModel primeiro pois o front é modelado
        //de acordo com o backend

        //Criar uma propriedade simples
        public string Nome { get; set; }

        //Criar uma propriedade monitorada
        //para armazenar a informação
        //Obs: o anderline é usado como nomenclatura
        //para informa a propriedade é privada
        private string _retorno;
        //Criar a propriedade que vai manipular
        //a variavel de armazenamento
        public string Retorno
        {
            get { return _retorno; } //exibir info armazenada
            set
            {
                //armazenar a informação
                _retorno = value; //value = informação
                //Disparar a notificação
                OnPropertyChanged();
            }
        }

        //Criar o Command para manipular o nosso Retorno
        //RetornoCommand: comando de execuação do
        //Botão Retorno e iremos atualizar
        //um label com o conteudo da propriedade Retorno
        public Command RetornoCommand
        {
            get
            {
                return new Command(() =>
                {
                    //Propriedade Retorno vai receber
                    //uma nova string concatenada com 
                    //a propriedade Nome
                    Retorno = "Olá, " + Nome;
                });
            }
        }
    }
}
