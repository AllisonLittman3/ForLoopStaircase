using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopStaircase
{
    class Program
    {
        static void Main(string[] args)
        {

            //The goal of this program is to create a right aligned staircase out of spaces (" ") and # symbols.

            var width = 6; //This staircase will be 6 characters wide, and 6 tall
            
            for (int i = 1; i <= width; i++) //This loop will create 6 lines of characters
            {

                
             for (int s = 0; s <= (width - i); s++) //This loop writes the spaces and aligns the staircase to the right
             { Console.Write(" "); }



             for (int h = 0; h < i; h++) //This loop writes the # symbols
             { Console.Write("#"); }
             
                
                
                Console.WriteLine(); //This creates a new line of characters
                

            }
            Console.ReadLine();
        }
    }
}
