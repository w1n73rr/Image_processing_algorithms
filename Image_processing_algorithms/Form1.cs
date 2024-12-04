namespace Image_processing_algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgOFD.ShowDialog() == DialogResult.OK)
            {
                string fileName = imgOFD.FileName;
                samplePicture.Image = new Bitmap(fileName);
            }
        }

        private void pictureToBw(object sender, EventArgs e)
        {
            if (samplePicture.Image != null)
            {
                Bitmap source = new Bitmap(samplePicture.Image, new Size(bwPicture.Width, bwPicture.Height));
                Bitmap result = new Bitmap(bwPicture.Width, bwPicture.Height);
                for (int i = 0; i < samplePicture.Width; i++)
                    for (int j = 0; j < samplePicture.Height; j++)
                    {
                        Color color = source.GetPixel(i, j);
                        int grey = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        result.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                    }
                bwPicture.Image = result;
            }
        }

        private void getBWButton_Click(object sender, EventArgs e)
        {
            pictureToBw(sender, e);
        }

        private void samplePicture_Click(object sender, EventArgs e)
        {
            if (imgOFD.ShowDialog() == DialogResult.OK)
            {
                string fileName = imgOFD.FileName;
                samplePicture.Image = new Bitmap(fileName);
            }
        }

        private void incompleteThresholdProcessing(object sender, EventArgs e)
        {
            if (samplePicture.Image != null)
            {
                Bitmap source = new Bitmap(samplePicture.Image);
                Bitmap result = new Bitmap(source.Width, source.Height);
                int threshold = int.Parse(valueTextBox.Text);
                for (int i = 0; i < bwPicture.Width; i++)
                {
                    for (int j = 0; j < bwPicture.Height; j++)
                    {
                        Color color = source.GetPixel(i, j);
                        int grey = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        int newGrey = grey >= threshold ? 255 : grey;
                        result.SetPixel(i, j, Color.FromArgb(newGrey, newGrey, newGrey));
                    }
                }
                preparationPB.Image = result;
            }
        }
        private void thresholdButton_Click(object sender, EventArgs e)
        {
            incompleteThresholdProcessing(sender, e);
        }
        private void mask()
        {
            if (samplePicture.Image != null)
            {
                double[,] matr = new double[,]
                {
            { Convert.ToDouble(TB00.Text), Convert.ToDouble(TB01.Text), Convert.ToDouble(TB02.Text) },
            { Convert.ToDouble(TB10.Text), Convert.ToDouble(TB11.Text), Convert.ToDouble(TB12.Text) },
            { Convert.ToDouble(TB20.Text), Convert.ToDouble(TB21.Text), Convert.ToDouble(TB22.Text) }
                };

                double a = Convert.ToDouble(aTB.Text);
                double b = Convert.ToDouble(bTB.Text);

                double color = 0;

                Bitmap source = new Bitmap(samplePicture.Image, maskPB.Size);
                Bitmap result = new Bitmap(maskPB.Width, maskPB.Height);

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        if (i == 0 || j == 0 || i == source.Width - 1 || j == source.Height - 1)
                        {
                            result.SetPixel(i, j, source.GetPixel(i, j)); // Просто копируем оригинальный пиксель для границы
                        }
                        else
                        {
                            color = a + b * (
                                GetPixelValue(source, i - 1, j - 1) * matr[0, 0] +
                                GetPixelValue(source, i - 1, j) * matr[0, 1] +
                                GetPixelValue(source, i - 1, j + 1) * matr[0, 2] +
                                GetPixelValue(source, i, j - 1) * matr[1, 0] +
                                GetPixelValue(source, i, j) * matr[1, 1] +
                                GetPixelValue(source, i, j + 1) * matr[1, 2] +
                                GetPixelValue(source, i + 1, j - 1) * matr[2, 0] +
                                GetPixelValue(source, i + 1, j) * matr[2, 1] +
                                GetPixelValue(source, i + 1, j + 1) * matr[2, 2]
                            );

                            check(ref color);
                            result.SetPixel(i, j, Color.FromArgb((byte)color, (byte)color, (byte)color));
                        }
                    }
                }
                maskPB.Image = result;
            }
        }

        /// <summary>
        /// Безопасно возвращает значение пикселя, не выходя за пределы изображения.
        /// </summary>
        private double GetPixelValue(Bitmap source, int x, int y)
        {
            if (x < 0) return x = 0;
            if (x>=source.Width) return x =source.Width-1;
            if (y < 0) return y = 0;
            if (y >= source.Width) return y = source.Width - 1;
            return source.GetPixel(x, y).R;
        }

        private void check(ref double i)
        {
            if (i > 255) i = 255;
            else if (i < 0) i = 0;
        }

        private void preobrButton_Click(object sender, EventArgs e)
        {
            mask();
        }
    }
}
