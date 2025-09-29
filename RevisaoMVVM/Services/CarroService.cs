using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoMVVM.Models;

namespace RevisaoMVVM.Services
{
    //Classe de serviço para manipular
    //o objeto Carro no "banco de dados"
    public class CarroService
    {
        //Instancia a classe singleton
        FakeDBSingleton dbSingleton = FakeDBSingleton.Instancia;

        public void Adicionar(Carro value)
        { 
            dbSingleton.Carro = value;
        }

        public Carro Consultar()
        {
            return dbSingleton.Carro;
        }
    }
}
