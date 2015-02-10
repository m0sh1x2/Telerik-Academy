using System;

namespace Problem03SequenceNMatrix
{
    class SequenceNMatrix
    {
        static void Main()
        {
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("M = ");
            int m = int.Parse(Console.ReadLine());

            string[,] array = new string[n, m];
            // Read data from console
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Array[{0},{1}] = ", i, j);
                    array[i, j] = Console.ReadLine();
                }
            }

            int numMaxElements = 0;
            int numCurrElements = 0;
            string maxStr = "";

            // Find sequence
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // For current element, goto end horizontally, count elements
                    numCurrElements = 0;
                    for (int k = i; k < n - 1; k++)
                    {
                        if (array[j, k + 1] == array[j, k])
                        {
                            numCurrElements++;
                        }

                        if (numCurrElements > numMaxElements)
                        {
                            numMaxElements = numCurrElements;
                            maxStr = array[j, k];
                        }
                    }

                    // For current element, goto end vertically, count elements
                    numCurrElements = 0;
                    for (int k = j; k < m - 1; k++)
                    {
                        if (array[k, i] == array[k + 1, i])
                        {
                            numCurrElements++;
                        }

                        if (numCurrElements > numMaxElements)
                        {
                            numMaxElements = numCurrElements;
                            maxStr = array[k, i];
                        }
                    }

                    // For current element, goto end diagonally, count elements
                    numCurrElements = 0;
                    for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                    {
                        if (array[l, k] == array[l + 1, k + 1])
                        {
                            numCurrElements++;
                        }

                        if (numCurrElements > numMaxElements)
                        {
                            numMaxElements = numCurrElements;
                            maxStr = array[l, k];
                        }
                    }
                }
            }

            for (int i = 0; i < numMaxElements + 1; i++) Console.Write(maxStr + ", ");
        }
    }
}