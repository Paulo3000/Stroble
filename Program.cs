using System;
using System.Linq;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Stroble1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escolha uma opção \n1) Vermelho:\n2)Azul\n3)Amarelo\n4)Stroble de Cor\n");
            int escolha = Int32.Parse(Console.ReadLine());
           
            switch (escolha)
            {
                case 1:
                goto vermelho;
                   break;
                case 2:
                    goto Azul;
                    break;
                case 3:
                    goto amarelo;
                    break;
                case 4:
                    goto multipla_cor;
                    break;
            }
            
           vermelho:
            int cor1 = 0;
                while (cor1!=1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                }
        //-----------------------------------------------------

        Azul:
            int cor2 = 0;
            while (cor2 != 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }


        //-----------------------------------

        amarelo:
            int cor3 = 0;
            while (cor3 != 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }


        //-----------------------------------------
        multipla_cor:
            int i = 0;
            while(i!=1)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                
               
            }
            Console.ReadKey();
        }
    }
}
