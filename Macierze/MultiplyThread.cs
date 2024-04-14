using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class MultiplyThread
    {
        public MultiplyThread(Matrix first_matrix, Matrix second_matrix, int Number_of_threads)
        {
            First_matrix = first_matrix;
            Second_matrix = second_matrix;
            Result_matrix = new Matrix(First_matrix.number_of_rows, Second_matrix.number_of_columns, GenZeros());
            number_of_threads = Number_of_threads;

            if(number_of_threads > First_matrix.number_of_rows)
            {
                number_of_threads = First_matrix.number_of_rows;
            }

            Multiplyy();

        }

        public static volatile Matrix First_matrix;
        public static volatile Matrix Second_matrix;
        public static volatile Matrix Result_matrix;
        public static int number_of_threads;
        public static readonly object locker = new object();
        public long time
        { get; set; }


        Mutex mutex = new Mutex();

        public List<Thread> InitializeRowidx(int rowPerThread, bool ifTwo)
        {
            int numberofcolumns = First_matrix.number_of_columns;
            int secondmatrixcolumns = Second_matrix.number_of_columns;
            List<Thread> threads = new List<Thread>();
            List<ThreadHelper> threadhelpers = new List<ThreadHelper>();

            List<int> iterators = new List<int>();

            int current_max_rows;
            if (ifTwo)
            {
                current_max_rows = First_matrix.number_of_rows - 1;
            }
            else
            {
                current_max_rows = First_matrix.number_of_rows;
            }

            for(int z = 0; z < current_max_rows; z += rowPerThread)
            {
                threadhelpers.Add(new ThreadHelper(z));
            }

            foreach(var threadhelper in threadhelpers)
            {
                if(threadhelper.row + rowPerThread == First_matrix.number_of_rows - 1 && ifTwo)
                {
                    threadhelper.thread = new Thread(() => CalculateRowValues(threadhelper.row, rowPerThread + 1, Result_matrix, mutex, numberofcolumns, secondmatrixcolumns));
                }
                else if(threadhelper.row + rowPerThread > First_matrix.number_of_rows - 1)
                {
                    rowPerThread = First_matrix.number_of_rows - 1 - threadhelper.row;
                    threadhelper.thread = new Thread(() => CalculateRowValues(threadhelper.row, rowPerThread, Result_matrix, mutex, numberofcolumns, secondmatrixcolumns));
                }
                else
                {
                    threadhelper.thread = new Thread(() => CalculateRowValues(threadhelper.row, rowPerThread, Result_matrix, mutex, numberofcolumns, secondmatrixcolumns));
                }
                threads.Add(threadhelper.thread);
            }

            return threads;

        }

        public void Multiplyy()
        {
            int numberofrows = First_matrix.number_of_rows;
            bool ifTwo = false;
            if(First_matrix.number_of_rows % 2 != 0)
            {
                ifTwo = true;
            }

            if(number_of_threads == 0)
            {
                MultiplyNotParallel(numberofrows);
                return;
            }


            int rowPerThread = First_matrix.number_of_rows / number_of_threads;

            var threads = InitializeRowidx(rowPerThread, ifTwo);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var thread in threads)
            {
                thread.Start();
            }
            foreach (var thread in threads) thread.Join();
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            Console.WriteLine($"{number_of_threads} threads ended in {watch.ElapsedMilliseconds} ms.");




        }

        static void CalculateRowValues(int row_idx, int rowtoCalculate, Matrix Result_matrix, Mutex mutex, int firstMatrixColumns, int secondMatrixColumns)
        {
            int[,] First_matrix_values;
            int[,] Second_matrix_values;
            lock (locker)
            {
                First_matrix_values = First_matrix.Matrix_values;
                Second_matrix_values = Second_matrix.Matrix_values;
            }
            int result;
            for (int row = row_idx; row < row_idx + rowtoCalculate; row++)
                {
                    for (int i = 0; i < secondMatrixColumns; i++)
                    {
                        result = 0;
                        for (int k = 0; k < firstMatrixColumns; k++)
                        {
                            result += First_matrix_values[row, k] * Second_matrix_values[k, i];
                        }
                        lock (locker)
                        {
                            Result_matrix.Matrix_values[row, i] = result;
                        }

                    }
                }
        }

        public void MultiplyNotParallel(int numberofrows)
        {
            int Columns = Second_matrix.number_of_columns;
            int Rows = First_matrix.number_of_rows;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < numberofrows; i++)
                calcRow(i, Columns, Rows);
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            Console.WriteLine($"{number_of_threads} threads ended in {watch.ElapsedMilliseconds} ms.");
        }

        public void calcRow(int numberofrow, int numberofcolumns, int numberofrows)
        {
            int[,] First_matrix_values = First_matrix.Matrix_values;
            int[,] Second_matrix_values = Second_matrix.Matrix_values;
            int result = 0;
            for (int i = 0; i < numberofcolumns; i++)
            {
                result = 0;
                for (int k = 0; k < numberofrows; k++)
                {
                    result += First_matrix_values[numberofrow, k] * Second_matrix_values[k, i];
                }
                Result_matrix.Matrix_values[numberofrow, i] = result;

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
