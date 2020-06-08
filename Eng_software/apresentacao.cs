using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_software
{
    public class apresentacao
    {
        private string nome;
        private int idade;
        private double pi;
        private float salario;

        public apresentacao(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public DateTime pegarHora()
        {
            return DateTime.Today;
        }
    }
}