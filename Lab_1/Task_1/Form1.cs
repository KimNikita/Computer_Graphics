using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
  public partial class Form1 : Form
  {
    Bitmap loadedImage, currentImage;
    string imageName;
    Stack<Bitmap> states;
    public int[] brightsCount;
    Form2 histogram;
    Form3 structelem;
    public float minBright, maxBright;
    public float Rav, Gav, Bav, Avg;
    public Random rand;

    public Form1()
    {
      InitializeComponent();
      states = new Stack<Bitmap>();
      brightsCount = new int[256];
      histogram = new Form2(this);
      structelem = new Form3();
      rand = new Random();
    }

    // Файл

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!backgroundWorker1.IsBusy)
      {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          states.Clear();
          imageName = dialog.FileName;
          loadedImage = new Bitmap(dialog.FileName);
          pictureBox1.Image = loadedImage;
          currentImage = loadedImage;
          states.Push(currentImage);
          pictureBox1.Refresh();
          pictureBox1.Enabled = true;
        }
      }
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
        dialog.Title = "Save an Image File";
        dialog.FileName = imageName;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          if (dialog.FileName != "")
          {
            FileStream fs = (FileStream)dialog.OpenFile();

            switch (dialog.FilterIndex)
            {
              case 1:
                currentImage.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                break;
              case 2:
                currentImage.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                break;
              case 3:
                currentImage.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                break;
            }

            fs.Close();
          }
        }
      }
    }

    private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!backgroundWorker1.IsBusy && states.Count > 1)
      {
        states.Pop();
        currentImage = states.Peek();
        pictureBox1.Image = currentImage;
        pictureBox1.Refresh();
      }
    }

    private void гистограммаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        brightsCount = new int[256];
        for (int x = 0; x < currentImage.Width; x++)
        {
          for (int y = 0; y < currentImage.Height; y++)
          {
            brightsCount[(int)(currentImage.GetPixel(x, y).GetBrightness() * 255)]++;
          }
        }
        histogram.Close();
        histogram = new Form2(this);
        histogram.Show();
      }
    }

    // Точечные фильтры

    private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new InvertFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void полутоновыйToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new GrayScaleFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SepiaFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void яркийToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new BrightFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new MedianFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        minBright = 1;
        maxBright = 0;

        for (int x = 0; x < currentImage.Width; x++)
        {
          for (int y = 0; y < currentImage.Height; y++)
          {
            if (currentImage.GetPixel(x, y).GetBrightness() > maxBright)
              maxBright = currentImage.GetPixel(x, y).GetBrightness();
            if (currentImage.GetPixel(x, y).GetBrightness() < minBright)
              minBright = currentImage.GetPixel(x, y).GetBrightness();
          }
        }

        Filters filter = new LinearStretchingFilter(this);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void серыйМирToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Rav = 0;
        Gav = 0;
        Bav = 0;

        for (int x = 0; x < currentImage.Width; x++)
        {
          for (int y = 0; y < currentImage.Height; y++)
          {
            Rav += currentImage.GetPixel(x, y).R;
            Gav += currentImage.GetPixel(x, y).G;
            Bav += currentImage.GetPixel(x, y).B;
          }
        }

        Rav /= (currentImage.Width * currentImage.Height);
        Gav /= (currentImage.Width * currentImage.Height);
        Bav /= (currentImage.Width * currentImage.Height);
        Avg = (Rav + Gav + Bav) / 3;

        Filters filter = new GrayWorldFilter(this);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new GlassFilter(this);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void волныToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new WaveFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    // Матричные фильтры

    private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new BlurFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new GaussianFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиXToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SobelXFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиYToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SobelYFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void резкийToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SharpFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new EmbossFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиXToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new PruitXFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиYToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new PruitYFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void светящиесяКраяToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new ShinyFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиXToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SharXFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поОсиYToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new SharYFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    // Работа фильтров

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      structelem.f = true;
      Bitmap newImage = ((Filters)e.Argument).processImage(currentImage, backgroundWorker1);
      if (backgroundWorker1.CancellationPending != true)
        currentImage = newImage;
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!e.Cancelled)
      {
        pictureBox1.Image = currentImage;
        states.Push(currentImage);
        pictureBox1.Refresh();
      }
      progressBar1.Value = 0;
      structelem.f = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      backgroundWorker1.CancelAsync();
    }

    // Матморфология

    private void задатьМаскуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!backgroundWorker1.IsBusy)
      {
        structelem.refresh();
        structelem.Show();
      }
    }

    private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new Dilation(structelem.mask, 1, 0);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void сужениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new Erosion(structelem.mask, 1, 0);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new Opening(structelem.mask);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void закрытиеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new Closing(structelem.mask);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void чернаяШляпаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pictureBox1.Enabled && !backgroundWorker1.IsBusy)
      {
        Filters filter = new BlackHat(structelem.mask);
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

  }
}
