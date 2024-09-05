using System;

namespace variant_1
{
    // Klass som hanterar matrislogik
    internal class Matrix
    {
        private int size;

        // Konstruktor som tar matrisens storlek
        public Matrix(int size)
        {
            this.size = size;
        }

        // Metod som skriver ut matrisen
        public void PrintMatrix()
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write((i * j).ToString().PadRight(4));
                }
                Console.WriteLine();
            }
        }
    }

    // Huvudklass med Main-metoden
    internal class Program
    {
        static void Main(string[] args)
        {
            // Läser in storleken på matrisen från användaren
            Console.Write("Ange storleken på matrisen: ");
            int size = int.Parse(Console.ReadLine());

            // Skapar en ny matris med användarens storlek
            Matrix matrix = new Matrix(size);

            // Skriver ut matrisen
            matrix.PrintMatrix();
        }
    }
}