using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devmedia_curso1
{
    public class Aluno
    {

        private int idade;

        public int Idade
        {
            get { return idade; }
            set {
                if (value == 20)
                {
                    Console.WriteLine("idade é 20");
                }
                idade = value;
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Aluno(string _nome)
        {
            Nome = _nome;
        }

        public Aluno()
        {
            Console.WriteLine("construtor aluno");
        }

        
        ~Aluno()
        {
            Console.WriteLine("Destructor aluno");
            Console.ReadKey();
        }
    }
}
