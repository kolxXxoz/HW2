using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение для штаба:");

            var stierlitzInput = new Stierlitz(Console.ReadLine());
            var stierlitzCypher = stierlitzInput.Encrypt();
            var stierlitzOutput = stierlitzCypher.Decrypt();

            Console.WriteLine(stierlitzCypher.Message);
            Console.WriteLine(stierlitzOutput.Message);
            
            Console.ReadKey();
        }
    }
}
