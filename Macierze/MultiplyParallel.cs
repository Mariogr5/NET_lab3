using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class MultiplyParallel
    {
        public MultiplyParallel(Matrix first_matrix, Matrix second_matrix, int Number_of_threads)
        {
            First_matrix = first_matrix;
            Second_matrix = second_matrix;
            Result_matrix = new Matrix(First_matrix.number_of_rows, Second_matrix.number_of_columns, GenZeros());
            if (Number_of_threads > (First_matrix.number_of_rows * Second_matrix.number_of_columns))
                number_of_threads = First_matrix.number_of_rows * Second_matrix.number_of_columns;
            else
                number_of_threads = Number_of_threads;
            MultiplyyParallel();

        }

        public static volatile Matrix First_matrix;
        public static volatile Matrix Second_matrix;
        public volatile Matrix Result_matrix;
        public static int number_of_threads;
        public static readonly object locker = new object();

        public long time { get; set; }
        Mutex mutex = new Mutex();


        public void MultiplyyParallel()
        {
            int First = First_matrix.number_of_columns;
            int Second = Second_matrix.number_of_columns;
            if (number_of_threads == 0)
            {
                MultiplyNotParallel();
                return;
            }
            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = number_of_threads
                //MaxDegreeOfParallelism = Environment.ProcessorCount
            };
            int maxRows = First_matrix.number_of_rows;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, maxRows, opt, x => calcRow(x, Result_matrix, mutex, First, Second));
            time = watch.ElapsedMilliseconds;
            Console.WriteLine($"{number_of_threads} threads ended in {watch.ElapsedMilliseconds} ms.");

        }


        public void MultiplyNotParallel()
        {
            int First = First_matrix.number_of_columns;
            int Second = Second_matrix.number_of_columns;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < First_matrix.number_of_rows; i++)
                calcRow(i, Result_matrix, mutex, First, Second);
            time = watch.ElapsedMilliseconds;
            Console.WriteLine($"{number_of_threads} threads ended in {watch.ElapsedMilliseconds} ms.");
        }

        static void calcRow(int numberofrow, Matrix Result_matrix, Mutex mutex, int firstMatrixColumns, int secondMatrixColumns)
        {
            int[,] First_matrix_values;
            int[,] Second_matrix_values;
            lock (locker)
            {
                First_matrix_values = First_matrix.Matrix_values;
                Second_matrix_values = Second_matrix.Matrix_values;
            }
            int result;
            for(int i = 0; i < secondMatrixColumns; i++)
            {
                result = 0;
                for (int k = 0; k < firstMatrixColumns; k++)
                {
                    result += First_matrix_values[numberofrow, k] * Second_matrix_values[k, i];
                }
                lock (locker)
                {
                    Result_matrix.Matrix_values[numberofrow, i] = result;
                }

            }

        }


        private static int[,] GenZeros()
        {
            int[,] result = new int[First_matrix.number_of_rows, Second_matrix.number_of_columns];
            for (int i = 0; i < First_matrix.number_of_rows; i++)
                for (int j = 0; j < Second_matrix.number_of_columns; j++)
                    result[i, j] = 0;
            return result;
        }

        public override string ToString()
        {
            return Result_matrix.ToString();
        }
    }
}
