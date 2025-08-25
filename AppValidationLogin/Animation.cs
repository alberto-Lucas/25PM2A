using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValidationLogin
{
    //Criamo uma classe static
    //Pois não é nescessario instanciar a classe
    //em memoria, podemos chamar o método direto
    //Todos os método de uma classe static
    //precisão ser static
    //A ideia da classe é centralizar as animações
    //do aplicativo em um unico arquivo
    public static class Animation
    {
        //Animação tremer para componentes visuais
        //Ou seja, botões, label, entry, imagens, etc....
        static public async void Tremer(VisualElement elemento)
        {
            //Primeiro preciso validar se o elemento
            //não está nulo, ou seja, se ja foi criado
            //se não existir abortamos a execução
            if (elemento == null)
                return; //abortar

            //Definimos o tempo
            uint tempo = 50;

            //Lista de deslocamento para a animação
            var listaDeslocamentos = new[] {-15, 15, -10, 10, -5, 5};

            //Loop para aplicar o deslocamento
            foreach (var deslocamento in listaDeslocamentos)
                await elemento.TranslateTo(deslocamento, 0, tempo);
            elemento.TranslationX = 0;
        }
    }
}
