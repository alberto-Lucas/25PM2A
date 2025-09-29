using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoMVVM.Models
{
    //Classe Singleton para simular um banco de dados
    public sealed class FakeDBSingleton
    {
        //O uso de undeline é para identificar 
        //variaveis privadas
        static FakeDBSingleton _instancia;

        public static FakeDBSingleton Instancia
        {
            get
            { 
                return _instancia ?? 
                    (_instancia = new FakeDBSingleton());
            }
        }
        //Atributo que ira armazenar o objeto 
        //com as informações de Carro
        public Carro Carro { get; set; }

    }
}
