﻿
namespace Task_2
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.glControl1 = new OpenTK.GLControl();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(682, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // glControl1
      // 
      this.glControl1.BackColor = System.Drawing.Color.Black;
      this.tableLayoutPanel1.SetColumnSpan(this.glControl1, 2);
      this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.glControl1.Location = new System.Drawing.Point(3, 126);
      this.glControl1.Name = "glControl1";
      this.glControl1.Size = new System.Drawing.Size(676, 343);
      this.glControl1.TabIndex = 1;
      this.glControl1.VSync = false;
      this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.Controls.Add(this.radioButton3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.glControl1, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.trackBar1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.trackBar2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.radioButton1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.radioButton2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.trackBar3, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 472);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // trackBar1
      // 
      this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar1.Location = new System.Drawing.Point(2, 2);
      this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(528, 37);
      this.trackBar1.TabIndex = 2;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // trackBar2
      // 
      this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar2.Location = new System.Drawing.Point(2, 43);
      this.trackBar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.trackBar2.Maximum = 50;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(528, 37);
      this.trackBar2.TabIndex = 3;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radioButton1.Location = new System.Drawing.Point(534, 2);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(146, 37);
      this.radioButton1.TabIndex = 4;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Quads";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radioButton2.Location = new System.Drawing.Point(534, 43);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(146, 37);
      this.radioButton2.TabIndex = 5;
      this.radioButton2.Text = "Texture";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // trackBar3
      // 
      this.trackBar3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar3.Location = new System.Drawing.Point(2, 84);
      this.trackBar3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.trackBar3.Maximum = 50;
      this.trackBar3.Minimum = 1;
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new System.Drawing.Size(528, 37);
      this.trackBar3.TabIndex = 6;
      this.trackBar3.Value = 50;
      this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radioButton3.Location = new System.Drawing.Point(534, 84);
      this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(146, 37);
      this.radioButton3.TabIndex = 7;
      this.radioButton3.Text = "Strips";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(682, 496);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.RadioButton radioButton3;
  }
}

