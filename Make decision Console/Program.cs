using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Make_decision_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool exit = false;
            while (!exit)
            {
                Random rnd = new Random();

                int random = rnd.Next() % 100;

                //Console.WriteLine(random % 100);

                Console.WriteLine("Введите вопрос на да/нет");                
                string str = Console.ReadLine();
                if (str.Length ==0)
                {
                    Console.WriteLine("Введите вопрос!");
                }
                else
                {
                    //Console.WriteLine(str);
                    int count = str.Length;
                    // int count = str.Split().First().Length;
                    //Console.WriteLine(count);
                    //Console.Clear();

                    if ((random % 2 == 0) && (count % 2 == 0))
                    {
                        Console.WriteLine("yes");
                    }
                    else if ((random % 2 != 0) && (count % 2 != 0))
                    {
                        Console.WriteLine("yes");
                    }
                    else
                        Console.WriteLine("no");

                    Console.WriteLine("\nПовторить ввод?  y/n");
                    char input = char.Parse(Console.ReadLine());
                    if (input == 'n')
                    {
                        exit = true;
                    }
                }
                
            }

            //Console.WriteLine("\nПовторить?  y/n");
            //char input = char.Parse(Console.ReadLine());
            //if (input == 'n')
            //{
            //    exit = true;
            //}

        }
    }
}
