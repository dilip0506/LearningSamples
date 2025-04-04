namespace ChapterOne
{
    class One7
    {
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
                    int top = matrix[first, i];
                    matrix[first, i] = matrix[last - offset, first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = top;
                }
            }
        }
        public static void Run()
        {
            int[,] m = new int[,] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
            Rotate(m);
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write("{0} ", m[i, j]);
                }
                Console.WriteLine();
            }
            // Console.WriteLine(13 / 2 + " " + 13 % 2);
            Console.Read();
        }
    }
}
