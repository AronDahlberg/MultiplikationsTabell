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
            // Kontrollera att användaren skickar in ett argument för matrisstorleken
            if (args.Length == 0 || !int.TryParse(args[0], out int size) || size <= 0)
            {
                Console.WriteLine("Ange en giltig matrisstorlek som ett argument.");
                return;
            }

            // Skapa en ny matris med storleken från kommandoradsargumentet
            Matrix matrix = new(size);

            // Skriv ut matrisen
            matrix.PrintMatrix();
        }
    }
}