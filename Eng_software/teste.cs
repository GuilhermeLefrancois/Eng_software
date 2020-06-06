using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_software
{
    public class teste
    {
        private string nome;
        private int idade;
        private float salario;
        private char sexo;
        private string email;
        
        public teste(string nome, int idade, float salario, string email, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.email = email;
            this.sexo = sexo;
        }

        public static DateTime hora_atual()
        {
            return DateTime.Now;
        }

    }
}
