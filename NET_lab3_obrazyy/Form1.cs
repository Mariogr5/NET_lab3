namespace NET_lab3_obrazyy
{
    public partial class Form1 : Form
    {
        private Bitmap? img;
        private Mutex mutex = new Mutex();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                original.Image = img;
            }
        }

        private async void process_Click(object sender, EventArgs e)
        {
            int height = img.Height;
            int width = img.Width;
            var threads = new List<Thread>();
            Thread Thresholdthread = new Thread(() => ApplyThreshold(height, width, img, 100, mutex, threshold_image));
            threads.Add(Thresholdthread);
            Thread GrayScalethread = new Thread(() => ConvertToGrayscale(height, width, img, mutex, grayscale_image));
            threads.Add(GrayScalethread);
            Thread FlippThread = new Thread(() => FlipImage(height, width, img, mutex, flipped_image));
            threads.Add(FlippThread);
            Thread CircularThread = new Thread(() => CropToCircle(height, width, img, mutex, circular_image));
            threads.Add(CircularThread);

            foreach (var thread in threads)
                thread.Start();

            foreach (var thread in threads)
                thread.Join();
        }




        static void ApplyThreshold(int height, int width, Bitmap inputImage, int threshold, Mutex mutex, PictureBox box)
        {
            Bitmap outputImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mutex.WaitOne();
                    Color pixelColor = inputImage.GetPixel(x, y);
                    mutex.ReleaseMutex();
                    int brightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color newColor = (brightness > threshold) ? Color.White : Color.Black;
                    outputImage.SetPixel(x, y, newColor);
                }
            }

            box.Image = outputImage;
        }


        static void ConvertToGrayscale(int height, int width, Bitmap inputImage, Mutex mutex, PictureBox box)
        {
            Bitmap outputImage = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mutex.WaitOne();
                    Color pixelColor = inputImage.GetPixel(x, y);
                    mutex.ReleaseMutex();
                    int averageBrightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayscaleColor = Color.FromArgb(averageBrightness, averageBrightness, averageBrightness);
                    outputImage.SetPixel(x, y, grayscaleColor);
                }
            }
            box.Image = outputImage;
        }


        public static void FlipImage(int height, int width, Bitmap inputImage, Mutex mutex, PictureBox box)
        {
            Bitmap flippedImage = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mutex.WaitOne();
                    Color pixelColor = inputImage.GetPixel(x, y);
                    mutex.ReleaseMutex();

                    int newX = width - 1 - x;
                    flippedImage.SetPixel(newX, y, pixelColor);
                }
            }
            box.Image = flippedImage;
        }

        public static void CropToCircle(int height, int width, Bitmap inputImage, Mutex mutex, PictureBox box)
        {
            int radius = Math.Min(width, height) / 2;
            Bitmap circularImage = new Bitmap(width, height);
            int centerX = width / 2;
            int centerY = height / 2;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int distanceFromCenter = (int)Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));

                    if (distanceFromCenter <= radius)
                    {
                        mutex.WaitOne();
                        Color pixelColor = inputImage.GetPixel(x, y);
                        mutex.ReleaseMutex();
                        circularImage.SetPixel(x, y, pixelColor);
                    }
                    else
                    {
                        circularImage.SetPixel(x, y, Color.Transparent);
                    }
                }
            }
            box.Image = circularImage;
        }
    }
}