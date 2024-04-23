using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT6
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades: São os métodos "get" (leitura) e "set" (definição)

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }

        public Contato ()
        {
            Nome = "Maria";
            Sobrenome = "Guimarães";
            Telefone = "(11) 98765-4321";
        }

        public Contato (string nome, string sobrenome, string telefone)
        {
             
        }
    }
}

        
