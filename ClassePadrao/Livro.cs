using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePadrao
{
    public class Livro
    {
        string autor;
        string nomeLivro;

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string NomeLivro
        {
            get
            {
                return nomeLivro;
            }

            set
            {
                nomeLivro = value;
            }
        }
    }
}
