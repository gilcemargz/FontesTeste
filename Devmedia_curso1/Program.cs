using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassePadrao;
using System.Threading;
using System.Globalization;
using System.IO;

namespace Devmedia_curso1
{
    class Program
    {


        public struct livros
        {
            public int codigo;
            public string autor;
            public string nome;
        }

        static void Main(string[] args)
        {

            StringBuilder testeIO = new StringBuilder();
            testeIO.Append("The redfox says");
            File.AppendAllText(@"d:\teste.txt", testeIO.ToString());





            DateTime t1 = new DateTime();
            t1 = DateTime.Now;

            StringBuilder sb = new StringBuilder();

            sb.Append("Gilcemar ");
            sb.Append("Guizzo ");
            sb.Append("Zanette");

            Console.WriteLine(sb);

            for (int i = 0; i < 2000000; i++)
            {
                StringBuilder sb1 = new StringBuilder();

                sb1.Append("Teste");
            }

            


            DateTime t2 = new DateTime() ;

            t2 = DateTime.Now;

            TimeSpan tr = t2- t1;

            CultureInfo cultura1;

            Console.WriteLine(tr);

            CultureInfo pt = new CultureInfo("pt-BR");
            CultureInfo en = new CultureInfo("en-US");

            System.Threading.Thread.CurrentThread.CurrentCulture = en;
            Thread.CurrentThread.CurrentUICulture = en;

            Console.Write(Devmedia_curso1.Main.Descricao);
            



            Console.ReadKey();

            return;




            Livro oioi = new Livro();

            oioi.Autor = "Gilcemar";



            #region livros

            livros l1;
            l1.autor = "Gil";
            l1.codigo = 1;
            l1.nome = "Star wars";

            livros l2;
            l2.autor = "Pedro";
            l2.nome = "Galaxia";
            l2.codigo = 2;



            #endregion


            #region teste

  

            byte b1 = 222;
            int i1 = 199;

            decimal d1 = 100.09m;
            float f1 = 199.00f;

            Console.WriteLine(b1);
            Console.WriteLine(i1);
            Console.WriteLine(d1);
            Console.WriteLine(f1);


            int result = 0;
            if (int.TryParse("001x", out result))
            {
                Console.WriteLine("Converteu");
            }
            else
            {
                Console.WriteLine("Não Converteu");
            };

            object o = i1;

            Console.WriteLine(i1.ToString());

            Console.WriteLine("olá mundo");


            int[] arra1 = new int[5];


            arra1[0] = 10;
            arra1[1] = 12;

            Console.WriteLine(arra1[0]);


            ArrayList arl = new ArrayList();

            arl.Add(10);
            arl.Add(2);


            Console.WriteLine(arl[1]);
            #endregion




            #region if

            int ax = (b1 < 10) ? 2 : 1;

            Console.WriteLine("vairavel b1 =" + b1);
            Console.WriteLine("vairavel ax =" +ax);



            #endregion



            Console.ReadKey();

            #region switch

            switch (ax)
            {
                case 1:
                    Console.WriteLine("oi");
                
                break;

                default:
                    Console.WriteLine("q");
                    break;
            }


            #endregion



            #region listas



            List<string> lista = new List<string>();

            lista.Add("gilcemar");
            lista.Add("teste");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }


            #endregion


            var list = new[]
                            {
                                new { Number = 10, Name = "Smith" },
                                new { Number = 10, Name = "John" }
                            }.ToList();

            var tes = new { Number = 10, Name = "oi" };

            list.Add(tes);



            #region TesteAlunosClasse


            Console.WriteLine("------INICIANDO TESTE CLASSE ALUNO-------");

            Aluno a1 = new Aluno();

            for (int i = 0; i < 10; i++)
            {
                Aluno a = new Aluno();

            }

            Aluno a3 = new Aluno("Gilcemar");

           


            a1.Idade = 20;




            Console.WriteLine("---------FIM TESTES ALUNOS-----------");

            #endregion





            Console.ReadKey();
        }
    }
}
