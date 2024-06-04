using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III
{
        public class Usuario
    {

        public string nome { get; private set; } 
        public string cpf { get; private set; } 
        public string email { get; private set; }


        public Usuario (string nome,
                     string cpf,
                     string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;

            return;
        }

    }
       
}
