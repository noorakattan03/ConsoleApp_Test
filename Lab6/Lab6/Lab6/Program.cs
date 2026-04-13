// Noora Kattan
// Due Date: 10/27/2024
// CIS 199
// This Lab creates four different star pyramid patterns using nested loops.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args) // Main method that generates four star pyramid patterns 
        {   
            // declare const varaible 
            const int MAX_ROWS = 10; // maximum number rows of 10 as an int
            const int START_ROW = 0;  // starting row of 0 as an int



            Console.WriteLine("Pattern A"); // displaying label for Pattern A.
            for (int row =1; row <= MAX_ROWS; row++) // using for-loops through rows 1 to MAX_ROWS (1-10).
            {
                for (int star  = 1; star <= row; star++) // loop to display stars thats equal to the current row number
                {
                    Console.Write("*"); // prints the stars for each iteration
                }
                Console.WriteLine(); // moves on to the next row
            }
            Console.WriteLine(); // blank line for spacing between each pattern


            Console.WriteLine("Pattern B"); // displaying label for Pattern B
            for (int row = MAX_ROWS; row > START_ROW; row--) // loop to control the rows, decreasing row count after each iteration
            {
               for(int star = 1; star <= row; star++) // loop to control the stars to display to the current row count
               {
                    Console.Write("*"); // prints the stars for each row without line break
               }
                Console.WriteLine(); // moves on to the next row
            }
            
            Console.WriteLine(); // blank line for spacing between each pattern

            Console.WriteLine("Pattern C"); // displays label for Pattern C
            for (int row = MAX_ROWS; row > START_ROW; row--) // controls the rows by staring from MAX_ROWS (10) and decreasing to 1.
            {
                for (int space = 1; space <= MAX_ROWS - row; space++) // controls the spacing by starting from the right and going down, creating a bigger space after each row by using "MAX_ROWS - row"
                {
                    Console.Write(" "); // print the space inside each row without line break
                }
                for (int star = 1; star <= row; star++) // controls the stars for each row after spacing, stars are printed equal the current row number
                {
                    Console.Write("*"); // prints the stars for each row without line break
                }
                Console.WriteLine(); // moves on to the next row
            }
            Console.WriteLine(); // blank line for spacing between each pattern

            
            Console.WriteLine("Pattern D"); // displays label for Pattern D
            for (int row = 1; row <= MAX_ROWS; row++) // controls the rows by starting from 1 and increasing up to MAX_ROWS (10)
            {
                for (int space = 1; space <= MAX_ROWS - row; space++) // prints spaces before the stars for it to start from the right side
                {
                    Console.Write(" "); // prints a space without line break
                }
                for (int star = 1; star <= row; star++) // loop to print stars in each row, the stars printed equals the current row number
                {
                    Console.Write("*"); // prints the stars for each row without line break
                }
                Console.WriteLine(); // moves on to the next row
            }



            Console.ReadKey();
           
        } 
    }
}
