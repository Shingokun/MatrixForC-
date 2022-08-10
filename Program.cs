using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace MaTran
{
     class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 100;
        int minValue = 0;
        bool Checkdong;
        bool Checkcot;
        int dong;
        int cot;
        
        //this code will make random numbers in HaHa[,] 
        Random a= new Random();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("            Make a Matrix ");
        //This code will enter line number and check error
        Ldong:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter line number = ");
        Checkdong = int.TryParse(Console.ReadLine(), out dong);
        if (Checkdong == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong data please re-enter!!!");
            goto Ldong;
        }
        //this code will enter column number and check error 
        Lcot:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter column number = "); 
        Checkcot = int.TryParse(Console.ReadLine(), out cot);
        if (Checkcot == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong data please re-enter!!!");
            goto Lcot;
        }

        int[,] HaHa = new int[dong,cot];
        
        //This code will make matrix

        for (int i=0; i<HaHa.GetLength(0); i++)
        {
            for (int j=0; j<HaHa.GetLength(1); j++) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                HaHa[i,j] = a.Next(minValue, maxValue);
                Console.Write("{0,5}",HaHa[i,j]);

            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
        }
    }
}