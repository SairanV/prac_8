using System;

namespace Ex_Task_2
{
    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return matrix[row, column]; }
            set { matrix[row, column] = value; }
        }

        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a == null || b == null || a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
            {
                throw new ArgumentException("Матрицы должны иметь одинаковые размеры");
            }

            Matrix resultMatrix = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));

            for (int i = 0; i < resultMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.matrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = a[i, j] + b[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix Subtract(Matrix a, Matrix b)
        {
            if (a == null || b == null || a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
            {
                throw new ArgumentException("Матрицы должны иметь одинаковые размеры");
            }

            Matrix resultMatrix = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));

            for (int i = 0; i < resultMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.matrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = a[i, j] - b[i, j];
                }
            }

            return resultMatrix;
        }
    }
}
