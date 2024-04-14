using Macierze;
using static System.Net.Mime.MediaTypeNames;

namespace NET_lab3_Macierze
{
    public partial class Form1 : Form
    {
        Matrix FirstMatrix { get; set; }
        Matrix SecondMatrix { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void losowe_macierze_button_Click(object sender, EventArgs e)
        {
            Matrix A = new Matrix(Int32.Parse(row_A.Text.ToString()), Int32.Parse(column_A.Text.ToString()));
            Matrix B = new Matrix(Int32.Parse(row_B.Text.ToString()), Int32.Parse(column_B.Text.ToString()));
            FirstMatrix = A;
            SecondMatrix = B;

            var A_text = A.ToString().Replace("\n", Environment.NewLine);
            var B_text = B.ToString().Replace("\n", Environment.NewLine);

            A_textBox.Text = A_text;
            B_textBox.Text = B_text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sequentialaritmetic = 0;
            long parallelaritmetic = 0;
            MultiplyThread parallelresult;
            MultiplyThread sequentialresult;
            string resultt_text = "";
            for (int i = 0; i < 5; i++)
            {
                sequentialresult = new MultiplyThread(FirstMatrix, SecondMatrix, 1);
                parallelresult = new MultiplyThread(FirstMatrix, SecondMatrix, Int32.Parse(number_of_threads.Text.ToString()));
                sequentialaritmetic += sequentialresult.time;
                parallelaritmetic += parallelresult.time;
                string result_text = parallelresult.ToString().Replace("\n", Environment.NewLine);
                resultt_text = result_text;
            }

            sequentialaritmetic /= 5;
            parallelaritmetic /= 5;
            long speed_increase = 100 - ((parallelaritmetic * 100) / sequentialaritmetic);



            string time_text = ("Czas obliczeñ sekwencyjnie: " + sequentialaritmetic + Environment.NewLine + "Czas obliczeñ równolegle dla " + number_of_threads.Text.ToString() + " w¹tków: " + parallelaritmetic);
            time_text += (Environment.NewLine + "Przyspieszenie: " + speed_increase);


            result_textBox.Text = resultt_text;
            times_textBox.Text = time_text;
        }

        private void parallel_calculate_Click(object sender, EventArgs e)
        {
            long sequentialaritmetic = 0;
            long parallelaritmetic = 0;
            MultiplyParallel parallelresult;
            MultiplyParallel sequentialresult;
            string resultt_text = "";
            for (int i = 0; i < 5; i++)
            {
                sequentialresult = new MultiplyParallel(FirstMatrix, SecondMatrix, 1);
                parallelresult = new MultiplyParallel(FirstMatrix, SecondMatrix, Int32.Parse(number_of_threads.Text.ToString()));
                sequentialaritmetic += sequentialresult.time;
                parallelaritmetic += parallelresult.time;
                string result_text = parallelresult.ToString().Replace("\n", Environment.NewLine);
                resultt_text = result_text;
            }

            sequentialaritmetic /= 5;
            parallelaritmetic /= 5;

            long speed_increase = 100 - ((parallelaritmetic * 100) / sequentialaritmetic);

            string time_text = ("Czas obliczeñ sekwencyjnie: " + sequentialaritmetic + Environment.NewLine + "Czas obliczeñ równolegle dla " + number_of_threads.Text.ToString() + " w¹tków: " + parallelaritmetic);
            time_text += (Environment.NewLine + "Przyspieszenie: " + speed_increase); 

            result_textBox.Text = resultt_text;
            times_textBox.Text = time_text;
        }


        private void thread_parallel_comparision_Click(object sender, EventArgs e)
        {
            long threadaritmetic = 0;
            long parallellaritmetic = 0;
            MultiplyParallel parallelresult;
            MultiplyThread threadresult;
            string resultt_text = "";
            for (int i = 0; i < 5; i++)
            {
                parallelresult = new MultiplyParallel(FirstMatrix, SecondMatrix, Int32.Parse(number_of_threads.Text.ToString()));
                threadresult = new MultiplyThread(FirstMatrix, SecondMatrix, Int32.Parse(number_of_threads.Text.ToString()));
                parallellaritmetic += parallelresult.time;
                threadaritmetic += threadresult.time;
                string result_text = parallelresult.ToString().Replace("\n", Environment.NewLine);
                resultt_text = result_text;
            }

            threadaritmetic /= 5;
            parallellaritmetic /= 5;

            string time_text = ("Liczba w¹tków: " + Int32.Parse(number_of_threads.Text.ToString()) + Environment.NewLine + "Czas obliczeñ dla biblioteki Thread: " + threadaritmetic + Environment.NewLine + "Czas obliczeñ dla biblioteki Parallel " + parallellaritmetic);

            result_textBox.Text = resultt_text;
            times_textBox.Text = time_text;





        }










        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


    }
}