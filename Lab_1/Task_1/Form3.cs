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
    public int[,] mask = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    public Form3()
    {
      InitializeComponent();
    }

    public void refresh()
    {
      button00.Text = mask[0, 0].ToString();
      button01.Text = mask[0, 1].ToString();
      button02.Text = mask[0, 2].ToString();
      button10.Text = mask[1, 0].ToString();
      button11.Text = mask[1, 1].ToString();
      button12.Text = mask[1, 2].ToString();
      button20.Text = mask[2, 0].ToString();
      button21.Text = mask[2, 1].ToString();
      button22.Text = mask[2, 2].ToString();
    }

    private void button00_Click(object sender, EventArgs e)
    {
      if (button00.Text == "0")
        button00.Text = "1";
      else
        button00.Text = "0";
    }

    private void button01_Click(object sender, EventArgs e)
    {
      if (button01.Text == "0")
        button01.Text = "1";
      else
        button01.Text = "0";
    }

    private void button02_Click(object sender, EventArgs e)
    {
      if (button02.Text == "0")
        button02.Text = "1";
      else
        button02.Text = "0";
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (button10.Text == "0")
        button10.Text = "1";
      else
        button10.Text = "0";
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (button11.Text == "0")
        button11.Text = "1";
      else
        button11.Text = "0";
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (button12.Text == "0")
        button12.Text = "1";
      else
        button12.Text = "0";
    }

    private void button20_Click(object sender, EventArgs e)
    {
      if (button20.Text == "0")
        button20.Text = "1";
      else
        button20.Text = "0";
    }

    private void button21_Click(object sender, EventArgs e)
    {
      if (button21.Text == "0")
        button21.Text = "1";
      else
        button21.Text = "0";
    }

    private void button22_Click(object sender, EventArgs e)
    {
      if (button22.Text == "0")
        button22.Text = "1";
      else
        button22.Text = "0";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!f)
      {
        mask[0, 0] = Convert.ToInt32(button00.Text);
        mask[0, 1] = Convert.ToInt32(button01.Text);
        mask[0, 2] = Convert.ToInt32(button02.Text);
        mask[1, 0] = Convert.ToInt32(button10.Text);
        mask[1, 1] = Convert.ToInt32(button11.Text);
        mask[1, 2] = Convert.ToInt32(button12.Text);
        mask[2, 0] = Convert.ToInt32(button20.Text);
        mask[2, 1] = Convert.ToInt32(button21.Text);
        mask[2, 2] = Convert.ToInt32(button22.Text);
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
