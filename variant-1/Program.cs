using System;

namespace variant_1
{
    internal class Matrix
    {
        private int size;

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

            Matrix matrix = new(size);

            matrix.PrintMatrix();
        }
    }
}