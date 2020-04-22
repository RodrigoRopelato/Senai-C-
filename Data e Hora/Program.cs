using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //Console.WriteLine("Informe seu nome:");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Você informou: " + nome);

            //Exercicio 2
            //Console.WriteLine("Informe sua idade:");
            //string idadeemtexto = Console.ReadLine();
            //int idadeemnumero = int.Parse(idadeemtexto);

            //Console.WriteLine("Você informou: " + idadeemnumero);

            //Exercicio 3
            //Console.WriteLine("Informe usa altura:");
            //string alturaemtexto = Console.ReadLine();
            // double alturaemdouble = double.Parse(alturaemtexto);

            //Console.WriteLine("Sua altura é: " + alturaemdouble);

            //Exercicio 4

            //Console.WriteLine("Você informou, nome: {0} idade: {1} altura: {2}", nome, idadeemnumero, alturaemdouble);

            //Exercicio 5

            // DateTime dataehora = new DateTime();
            //Console.WriteLine(dataehora);

            //Exercicio 6

            // DateTime dataehora = new DateTime(2016, 7, 15);
            //Console.WriteLine(dataehora);

            //Exercicio 7
            //DateTime dataehora = new DateTime(2016, 7, 15, 3, 15, 0);
            //Console.WriteLine(dataehora);

            //Exercicio 8
            //DateTime dataehora = DateTime.Now;
            //Console.WriteLine("Hoje é {0}", dataehora);

            //Exercicio 9
            //DateTime dataehora = DateTime.Today;
            //Console.WriteLine("Hoje é {0}", dataehora);

            //Exercicio 10
            //DateTime dataehora = DateTime.Now;
            //Console.WriteLine("Hoje é {0}", dataehora);
            //Console.WriteLine("Dia: {0}", dataehora.Day);
            //Console.WriteLine("Mês: {0}", dataehora.Month);
            //Console.WriteLine("Ano: {0}", dataehora.Year);
            //Console.WriteLine("Hora: {0}", dataehora.Hour);
            //Console.WriteLine("Minuto: {0}", dataehora.Minute);
            //Console.WriteLine("Segundo: {0}", dataehora.Second);
            //Console.WriteLine("Milisegundos: {0}", dataehora.Millisecond);

            //Exercicio 11
            DateTime dataehora = DateTime.Now;
            Console.WriteLine("Agora é {0}", dataehora);
            Console.WriteLine("Ticks: {0}", dataehora.Ticks);

            Console.ReadKey();

        }
    }
}
