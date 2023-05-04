using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimplesT4
{
    internal class Contato
    {
        // Viaráveis internas da classe Contato.
        // a palavra-chave "private" indica que somente a classe
        // "Contato" tem acesso.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        // PROPRIEDADES (GET e SET)
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        public string Sobrenome
        { 
            get { return sobrenome; } 
            set { sobrenome = value; } 
        }

        public string Telefone
        {
            get { return telefone; }
            set 
            {
                if (value.Length == 11) 
                    Telefone = value;
                else
                    Telefone = "00-00000-0000";
            }
        }

        // Método construtor da classe.
        public Contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-91234-5678";
        }

        // Sobrecarga do método construtor da classe.
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = String.Empty;

        }
    }
}
