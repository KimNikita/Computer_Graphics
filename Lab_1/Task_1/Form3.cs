using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
  public partial class Form3 : Form
  {
    public bool f = false;
        public int d=3;
    public int[,] mask = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    public Form3()
    {
      InitializeComponent();
    }

    public void refresh(int r)
    {
            d = r * 2 + 1;
            Width = d * 30 + 25;
            Height = d * 30 + 90;
            mask = new int[d, d];
            splitContainer1.Panel1.Controls.Clear();
            for(int i = 0; i < d; i++) 
                for(int j = 0; j < d; j++)
                {
                    mask[i, j] = 0;
                }
            CreateButtons();
    }

        private void CreateButtons()
        {
            for (int i = 0; i < d; i++)
                for (int j = 0; j < d; j++)
                {
                    Button b = new Button();
                    b.Parent = splitContainer1.Panel1;
                    b.Location = new Point(i * 30 + 5, j * 30 + 5);
                    b.Size = new Size(30, 30);
                    b.Text = "0";
                    b.Click += new EventHandler(MaskClick);
                }
        }

        private void MaskClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "1") b.Text = "0";
            else b.Text = "1";
            mask[(b.Location.Y - 5) / 30, (b.Location.X - 5) / 30] = int.Parse(b.Text);
        }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!f)
      {
        this.Hide();
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);

      if (e.CloseReason == CloseReason.WindowsShutDown)
        e.Cancel = false;
      e.Cancel = true;

      this.Hide();
      return;
    }

  }
}
