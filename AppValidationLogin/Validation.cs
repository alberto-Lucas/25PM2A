using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValidationLogin
{
    public class Validation
    {
        //Definir as propriedades referente
        //ao nosso "PAR" de componentes
        private Entry EntryCampo { get; set; }
        private Label LabelValidation { get; set; }

        //Criar o contrustor para fazer o vinculo
        public Validation(Entry txtCampo, Label lblValidation)
        {
            EntryCampo = txtCampo;
            LabelValidation = lblValidation;
        }

        //Método para retorno o conteudo do Entry
        public string GetText()
        { 
            return EntryCampo.Text; 
        }

        //Método para definir o texto da label validation
        public void SetValidation(string msgValidation)
        {
            LabelValidation.Text = msgValidation;
            LabelValidation.IsVisible = true;
        }

        //Método de sobrecarga para aplicar animação no validation
        public void SetValidation(string msgValidation, bool ExibirTremer)
        {
            if (ExibirTremer)
                Animation.Tremer(EntryCampo);
            SetValidation(msgValidation);
        }

        //Método para ocultar a label validation
        public void HideValidation()
        {
            LabelValidation.IsVisible = false;
        }

        //Método que retorna se o campo está vazio
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(EntryCampo.Text);
        }

        //Método que retorna se o conteudo do campo igual a X texto
        public bool IsEquals(string valor)
        {
            return EntryCampo.Text == valor;
        }
    }
}
