using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class Matrix
    {
        public Matrix(int rows, int columns)
        {
            number_of_rows = rows;
            number_of_columns = columns;
            Matrix_values = Gen_Matrix_values();
        }

        public Matrix(int rows, int columns, int[,] matrix_values)
        {
            number_of_columns = columns;
            number_of_rows = rows;
            Matrix_values = matrix_values;
        }

        public int number_of_rows { get; set; }
        public int number_of_columns { get; set; }

        public int[,] Matrix_values;

        public int[,] Gen_Matrix_values()
        {
            Random rand = new Random();
            int[,] matrix = new int[number_of_rows, number_of_columns];

            for(int i = 0; i < number_of_rows; i++)
                for(int y = 0; y < number_of_columns; y++)
                {
                    var random_number = rand.Next(1, 10);
                    matrix[i, y] = random_number;
                }


            return matrix;

        }


        public void Ovveride_Row(int row_index, int[] row)
        {
            if (row.GetLength(0) != number_of_columns)
            {
                Console.WriteLine("Not good row lenght");
                return;
            }
            for(int i = 0; i < number_of_columns; i++)
            {
                Matrix_values[row_index, i] = row[i];
            }
        }
        public void Ovveride_Column(int column_index, int[] column)
        {
            if (column.GetLength(0) != number_of_rows)
            {
                Console.WriteLine("Not good column lenght");
                return;
            }
            for (int i = 0; i < number_of_columns; i++)
            {
                Matrix_values[i, column_index] = column[i];
            }
        }

        public void Ovverrid_Value(int row, int column, int value)
        {
            if(row >= number_of_rows)
            {
                Console.WriteLine("Not good row");
                return;
            }
            if (column >= number_of_columns)
            {
                Console.WriteLine("Not good column");
                return;
            }
            Matrix_values[row, column] = value;
        }


        public override string ToString()
        {
            string string_matrix = "";
            for (int i = 0; i < number_of_rows; i++)
            {
                for (int y = 0; y < number_of_columns; y++)
                {
                    string_matrix += (Matrix_values[i, y] + " ");
                }
                string_matrix += "\n";
            }
            return string_matrix;
        }
    }
}
