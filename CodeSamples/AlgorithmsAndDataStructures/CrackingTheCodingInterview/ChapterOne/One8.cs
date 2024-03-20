namespace ChapterOne
{
    class One8 : One7pract
    {
        //space O(n)//can do better
        static void MatrixReplace(int[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[j, i] == 0)
                    {
                        row[j] = true;
                        column[i] = true;
                    }
                }
            }
            for (int r = 0; r < row.Length; r++)
            {
                if (row[r] == true)
                {
                    for (int mr = 0; mr < matrix.GetLength(1); mr++)
                    {
                        matrix[r, mr] = 0;
                    }
                }
            }
            for (int c = 0; c < column.Length; c++)
            {
                if (column[c] == true)
                {
                    for (int mc = 0; mc < matrix.GetLength(0); mc++)
                    {
                        matrix[mc, c] = 0;
                    }
                }
            }

        }

        //space o(1)
        static void MatrixReplace1(int[,] matrix)
        {
            bool firstrow = false;
            bool firstcol = false;
            for (int ii = 0; ii < matrix.GetLength(1); ii++)
            {
                if (matrix[0, ii] == 0)
                {
                    firstrow = true;
                }
            }
            for (int jj = 0; jj < matrix.GetLength(0); jj++)
            {
                if (matrix[jj, 0] == 0)
                {
                    firstcol = true;
                }
            }
            for (int j = 1; j < matrix.GetLength(0); j++)
            {
                for (int i = 1; i < matrix.GetLength(1); i++)
                {
                    if (matrix[j, i] == 0)
                    {
                        matrix[0, i] = 0;
                        matrix[j, 0] = 0;
                    }
                }
            }
            for (int rc = 1; rc < matrix.GetLength(1); rc++)
            {
                if (matrix[0, rc] == 0)
                {
                    for (int rcc = 0; rcc < matrix.GetLength(0); rcc++)
                    {
                        matrix[rcc, rc] = 0;
                    }
                }
            }
            for (int cc = 1; cc < matrix.GetLength(0); cc++)
            {
                if (matrix[cc, 0] == 0)
                {
                    for (int ccr = 0; ccr < matrix.GetLength(1); ccr++)
                    {
                        matrix[cc, ccr] = 0;
                    }
                }
            }
            if (firstrow)
            {
                for (int iii = 0; iii < matrix.GetLength(1); iii++)
                {
                    matrix[0, iii] = 0;
                }
            }
            if (firstcol)
            {
                for (int jjj = 0; jjj < matrix.GetLength(0); jjj++)
                {
                    matrix[jjj, 0] = 0;
                }
            }

        }

        static void Run()
        {
            int[,] m = { { 0, 1, 1, 1 }, { 2, 2, 0, 2 }, { 3, 3, 3, 3 } };
            //int[,] m = { { 15, 12, 24 }, { 33, 8, 1 }, { 9, 4, 7 } };
            //Printmatrix(m);
            MatrixReplace1(m);
            //Console.WriteLine(m[0, 3]);
            Printmatrix(m);
            //Console.WriteLine(m.GetLength(1));
            Console.Read();
        }
    }
}
