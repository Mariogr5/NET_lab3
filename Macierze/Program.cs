using System.Numerics;

namespace Macierze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix(100, 200);
            var second_matrix = new Matrix(200, 300);
            long basic_time = 0;
            long time2 = 0;
            long time4 = 0;
            long time6 = 0;
            long time8 = 0;

            long speed2 = 0;
            long speed4 = 0;
            long speed6 = 0;
            long speed8 = 0;
            for (int i = 0; i < 5; i++)
            {

                var basic_matrix = new MultiplyThread(matrix, second_matrix, 1);
                var matrix2 = new MultiplyThread(matrix, second_matrix, 2);
                var matrix4 = new MultiplyThread(matrix, second_matrix, 4);
                var matrix6 = new MultiplyThread(matrix, second_matrix, 6);
                var matrix8 = new MultiplyThread(matrix, second_matrix, 8);

                basic_time += basic_matrix.time;
                time2 += matrix2.time;
                time4 += matrix4.time;
                time6 += matrix6.time;
                time8 += matrix8.time;

            }
            basic_time /= 5;
            time2 /= 5;
            time4 /= 5;
            time6 /= 5;
            time8 /= 5;

            speed2 = 100 - ((time2 * 100) / basic_time);
            speed4 = 100 - ((time4 * 100) / basic_time);
            speed6 = 100 - ((time6 * 100) / basic_time);
            speed8 = 100 - ((time8 * 100) / basic_time);

            Console.WriteLine("Sekwencyjny: " + basic_time + " ms");
            Console.WriteLine("2 Wątki: " + time2 + " ms" + " Przyspieszenie: " + speed2);
            Console.WriteLine("4 Wątki: " + time4 + " ms" + " Przyspieszenie: " + speed4);
            Console.WriteLine("6 Wątki: " + time6 + " ms" + " Przyspieszenie: " + speed6);
            Console.WriteLine("8 Wątki: " + time8 + " ms" + " Przyspieszenie: " + speed8);

        }
    }
}