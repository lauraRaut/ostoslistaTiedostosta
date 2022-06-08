using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitustehtavaTiedostot
{
    class Program
    {
        static void Main(string[] args)
        { 
       
            String polku = @"C:\Users\laura\source\repos\harjoitustehtavaTiedostot\harjoitustehtavaTiedostot\harjoitustehtavaTiedostot.txt";

                Console.WriteLine("Kirjoita tuote: ");
                string tuote = Console.ReadLine();
                



            if (File.Exists(polku))
            {
                File.AppendAllText(polku, tuote + Environment.NewLine);
                
                try
                {
                    String[] lines;
                    lines = File.ReadAllLines(polku);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine("hei");
                        Console.WriteLine(lines[i]);
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine("Tiedostoa ei voida lukea");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löydy.");
            }
            Console.ReadKey();
        }
        
            }
        }
    

