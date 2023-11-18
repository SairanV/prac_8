using System;

namespace Ex_Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 3);
            Matrix matrix2 = new Matrix(2, 3);

            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[0, 2] = 3;
            matrix1[1, 0] = 4;
            matrix1[1, 1] = 5;
            matrix1[1, 2] = 6;

            matrix2[0, 0] = 7;
            matrix2[0, 1] = 8;
            matrix2[0, 2] = 9;
            matrix2[1, 0] = 10;
            matrix2[1, 1] = 11;
            matrix2[1, 2] = 12;

            Matrix sum = Matrix.Add(matrix1, matrix2);
            Matrix difference = Matrix.Subtract(matrix1, matrix2);

            Console.WriteLine(sum[1, 2]);
            Console.WriteLine(difference[0, 1]);
        }
    }
}
