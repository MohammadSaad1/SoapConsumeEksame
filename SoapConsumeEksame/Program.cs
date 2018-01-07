using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapConsumeEksame.ServiceReference1;

namespace SoapConsumeEksame
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client("BasicHttpBinding_IService1"))
            {
                Console.WriteLine("Skriv navn på fisk:");
                string navn = Console.ReadLine();
                Console.WriteLine("Skriv fiskens art:");
                string art = Console.ReadLine();
                Console.WriteLine("Skrive uge:");
                int uge = Int32.Parse(Console.ReadLine());

                client.AddCatchAsync(navn, art, uge);
                Console.WriteLine($"{navn} er blevet tilføjet");
                
            }
        }


    }}
