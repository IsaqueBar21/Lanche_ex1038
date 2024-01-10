using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038_Lanche
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código do produto e a quantidade");

            double preco;
            
            int codigo, qntd;

            String[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qntd = int.Parse(vet[1]);

            Console.WriteLine("----------------------------------------------");

            switch (codigo) { 
                case 1:
                if(codigo == 1) {
                        preco = 4 * qntd;
                        Console.WriteLine("Total: R$ " + preco.ToString("f2", CultureInfo.InvariantCulture));
                    }                    
                break;
                case 2:
                    if (codigo == 2)
                    {
                        preco = 4.5 * qntd;
                        Console.WriteLine("Total: R$ " + preco.ToString("f2", CultureInfo.InvariantCulture));
                    }
                    break;
                case 3:
                    if (codigo == 3)
                    {
                        preco = 5 * qntd;
                        Console.WriteLine("Total: R$ " + preco.ToString("f2", CultureInfo.InvariantCulture));
                    }
                    break;
                case 4:
                    if (codigo == 4)
                    {
                        preco = 2 * qntd;
                        Console.WriteLine("Total: R$ " + preco.ToString("f2", CultureInfo.InvariantCulture));
                    }
                    break;
                case 5:
                    if (codigo == 5)
                    {
                        preco = 1.5 * qntd;
                        Console.WriteLine("Total: R$ " + preco.ToString("f2", CultureInfo.InvariantCulture));
                    }
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }


            Console.ReadLine();
        }
    }
}
