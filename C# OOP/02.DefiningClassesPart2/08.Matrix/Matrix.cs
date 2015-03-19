namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Matrix<T> where T : struct,IComparable
    {
        private const int DEFAULT_ROWS = 1;
        private const int DEFAULT_COLS = 1;


        private int rows;
        private int cols;
        private T[,] genericMatrix;

        public Matrix(int rows = DEFAULT_ROWS, int cols = DEFAULT_COLS)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.genericMatrix = new T[this.rows, this.cols];

        }
        public Matrix(T[,] predefinedMatrix) //creates a matrix, consisting of predefined values, passed as a T[,]
        {
            this.genericMatrix = predefinedMatrix;
            this.rows = genericMatrix.GetLength(0);
            this.cols = genericMatrix.GetLength(1);
        }

        public T this[int indexOfRows, int indexOfCols]
        {
            get
            {
                if (indexOfRows > this.rows || indexOfRows < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", indexOfRows));
                }
                if (indexOfCols > this.rows || indexOfCols < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", indexOfCols));
                }
                T result = this.genericMatrix[indexOfRows, indexOfCols];
                return result;
            }
            set { this.genericMatrix[indexOfRows, indexOfCols] = value; }
        }

       public static Matrix<T> operator + (Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(matrix1.rows, matrix1.cols);

            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator - (Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(matrix1.rows, matrix1.cols);

            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator * (Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.cols != matrix2.rows)
            {
                throw new ArgumentException("These matrices cannot be multiplied");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix2.cols);
            T result = (dynamic)0;
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.cols; j++)
                {
                    for (int k = 0; k < matrix1.cols; k++)
                    {
                        result += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }
            return resultMatrix;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Append(string.Format("{0, 11}", this.genericMatrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        public static bool operator true(Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

      
    }
}
