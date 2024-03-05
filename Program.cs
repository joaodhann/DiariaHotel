using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da diária do hotel que você está hospedado: ");
            double vald = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de adultos: ");
            int qad = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de crianças: ");
            int qcr = int.Parse(Console.ReadLine());

            double VPD = (qad * vald) + (qcr * vald) / 2;

            Console.WriteLine("O valor por dia da família será: " + VPD.ToString("C"));

            Console.WriteLine("Digite quantos dias ficará hospedado: ");
            int DH = int.Parse(Console.ReadLine());

            double VT = VPD * DH;

            Console.WriteLine("O valor total da hospedagem é: " + VT.ToString("C"));

            Console.WriteLine("Digite em quantas parcelas você vai dividir");
            int parc = int.Parse(Console.ReadLine());

            double VP = VT / parc;

            Console.WriteLine("O valor de cada parcela é: " +VP.ToString("C"));

            Console.ReadKey();



        }
    }
}
