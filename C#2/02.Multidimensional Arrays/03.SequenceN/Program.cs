using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceN
{
    class Program
    {
        static void Main()
        {
            var matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };



            int maxElements = 0;
            int currentElements = 0;
            string maxStr = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {


                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    //Check horizontall elements
                    currentElements = 0;
                    for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                    {

                        if (matrix[j, k + 1] == matrix[j, k])
                        {
                            currentElements++;
                        }

                        if (currentElements > maxElements)
                        {
                            maxElements = currentElements;
                            maxStr = matrix[j, k];
                        }

                    }
                    //vertical elements
                    currentElements = 0;
                    for (int k = j; k < matrix.GetLength(1) - 1; k++)
                    {
                        if (matrix[k, j] == matrix[k + 1, j])
                        {
                            currentElements++;
                        }

                        if (currentElements > maxElements)
                        {
                            maxElements = currentElements;
                            maxStr = matrix[k, i];
                        }
                    }

                    //check diagonal
                    currentElements = 0;
                    for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                    {
                        if (matrix[l, k] == matrix[l + 1, k + 1])
                        {
                            currentElements++;
                        }

                        if (currentElements > maxElements)
                        {
                            maxElements = currentElements;
                            maxStr = matrix[l, k];
                        }
                    }

                }



            }

        }

    }
}
