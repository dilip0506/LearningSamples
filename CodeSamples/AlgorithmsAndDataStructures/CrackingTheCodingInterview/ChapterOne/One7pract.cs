namespace ChapterOne
{
    class One7pract
    {
        static int[,] makematrix(int len)
        {
            int count = 0;
            int[,] matrix = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    matrix[i, j] = count++;
                }
            }
            Printmatrix(matrix);
            return matrix;
        }

        public static void Printmatrix(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    //Console.Write("{0},{1}={2} ",j,i,matrix[j,i]);
                    Console.Write("{0} ", matrix[j, i]);
                }
                Console.WriteLine();
            }
        }

        static void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int temp = matrix[first, i];
                    matrix[first, i] = matrix[last - offset, first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = temp;
                }
            }
            Printmatrix(matrix);
        }
        static void Run()
        {
            //int[,] m= makematrix(4);
            int[,] m = { { 1, 0, 1, 1 }, { 2, 2, 0, 2 }, { 3, 3, 3, 0 } };
            //int[,] m = { { 15, 12, 24 }, { 33, 8, 1 }, { 9, 4, 7 } };
            Console.WriteLine("-----------after rotation-----------");
            //Printmatrix(m);
            Console.WriteLine(m.GetLength(1));
            // Rotate(m);
            Console.Read();
        }
    }
}
