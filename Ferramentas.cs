using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCadastro
{
    public static class Ferramentas
    {       
        public static void Menu()
        {
            Console.Clear();            
            Console.WriteLine("1 - CADASTRAR (Nome, Endereço, Telefone)\n2 - LISTAR REGISTRO\n3 - CONSULTAR O REGISTRO");
            Console.Write("Escolha a opção (N°)...........:");
            return;            
        }
    }
}
