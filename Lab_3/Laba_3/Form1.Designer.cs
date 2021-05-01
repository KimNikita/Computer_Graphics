
namespace Laba_3
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
      this.openGlControl = new OpenTK.GLControl();
      this.SuspendLayout();
      // 
      // openGlControl
      // 
      this.openGlControl.BackColor = System.Drawing.Color.Black;
      this.openGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.openGlControl.Location = new System.Drawing.Point(0, 0);
      this.openGlControl.Margin = new System.Windows.Forms.Padding(1);
      this.openGlControl.Name = "openGlControl";
      this.openGlControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.openGlControl.Size = new System.Drawing.Size(384, 361);
      this.openGlControl.TabIndex = 0;
      this.openGlControl.VSync = false;
      this.openGlControl.Load += new System.EventHandler(this.openGlControl_Load);
      this.openGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.openGlControl_Paint);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 361);
      this.Controls.Add(this.openGlControl);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Raytracing";
      this.ResumeLayout(false);

    }

    #endregion

    private OpenTK.GLControl openGlControl;
  }
}

