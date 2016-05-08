using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Devmedia_curso1
{
    class Program
    {

        static void Main(string[] args)
        {

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









            Console.ReadKey();

        }
    }
}
