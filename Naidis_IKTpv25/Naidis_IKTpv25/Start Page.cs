using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            string tekst = "Tere tulemast C#-i maailma!";
            // Console.WriteLine($"Oli loodud muutaja tekst, mis võrdub: {tekst}");
            // Console.WriteLine("Oli loodud muutaja tekst, mis võrdub: {0}", tekst);
            
            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            //1.
            Console.WriteLine(Naidis_Funktsioonid.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            //2. 
            tekst = Naidis_Funktsioonid.Kuu_nimetus(juhuslik_arv);
            


            //Console.Write("Mis on sinu nimi?: ");
            //string nimi = Console.ReadLine();
            //Console.Write("Kui vana sa oled?: ");
            //try
            //{
            //    int vanus = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);

            //}
            //try
            //{
            //    Console.Write("Arv 1: ");
            //    float a = float.Parse(Console.ReadLine());
            //    Console.Write("Arv 2: ");
            //    float b = float.Parse(Console.ReadLine());
            //    float vastus = Naidis_Funktsioonid.Summa(a, b);
            //    Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}

