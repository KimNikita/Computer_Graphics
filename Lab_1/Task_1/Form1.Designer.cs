
namespace Task_1
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
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.полутоновыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.яркийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.резкийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрПриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.светящиесяКраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтШарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиXToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.поОсиYToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.операцииМатморфологииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.задатьМаскуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.чернаяШляпаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.операцииМатморфологииToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.отменитьToolStripMenuItem,
            this.гистограммаToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить как";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // отменитьToolStripMenuItem
      // 
      this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
      this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.отменитьToolStripMenuItem.Text = "Отменить";
      this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
      // 
      // гистограммаToolStripMenuItem
      // 
      this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
      this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
      this.гистограммаToolStripMenuItem.Text = "Гистограмма";
      this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
      // 
      // фильтрыToolStripMenuItem
      // 
      this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
      this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
      this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.фильтрыToolStripMenuItem.Text = "Фильтры";
      // 
      // точечныеToolStripMenuItem
      // 
      this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.полутоновыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркийToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.волныToolStripMenuItem});
      this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
      this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.точечныеToolStripMenuItem.Text = "Точечные";
      // 
      // инверсияToolStripMenuItem
      // 
      this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
      this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.инверсияToolStripMenuItem.Text = "Инверсия";
      this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
      // 
      // полутоновыйToolStripMenuItem
      // 
      this.полутоновыйToolStripMenuItem.Name = "полутоновыйToolStripMenuItem";
      this.полутоновыйToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.полутоновыйToolStripMenuItem.Text = "Полутоновый";
      this.полутоновыйToolStripMenuItem.Click += new System.EventHandler(this.полутоновыйToolStripMenuItem_Click);
      // 
      // сепияToolStripMenuItem
      // 
      this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
      this.сепияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.сепияToolStripMenuItem.Text = "Сепия";
      this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
      // 
      // яркийToolStripMenuItem
      // 
      this.яркийToolStripMenuItem.Name = "яркийToolStripMenuItem";
      this.яркийToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.яркийToolStripMenuItem.Text = "Яркий";
      this.яркийToolStripMenuItem.Click += new System.EventHandler(this.яркийToolStripMenuItem_Click);
      // 
      // медианныйФильтрToolStripMenuItem
      // 
      this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
      this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
      this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
      // 
      // линейноеРастяжениеToolStripMenuItem
      // 
      this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
      this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
      this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
      // 
      // серыйМирToolStripMenuItem
      // 
      this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
      this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.серыйМирToolStripMenuItem.Text = "Серый мир";
      this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click_1);
      // 
      // эффектСтеклаToolStripMenuItem
      // 
      this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
      this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
      this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
      // 
      // волныToolStripMenuItem
      // 
      this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
      this.волныToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.волныToolStripMenuItem.Text = "Волны";
      this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click);
      // 
      // матричныеToolStripMenuItem
      // 
      this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.резкийToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.фильтрПриToolStripMenuItem,
            this.светящиесяКраяToolStripMenuItem,
            this.фильтШарраToolStripMenuItem});
      this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
      this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.матричныеToolStripMenuItem.Text = "Матричные";
      // 
      // размытиеToolStripMenuItem
      // 
      this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
      this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.размытиеToolStripMenuItem.Text = "Размытие";
      this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
      // 
      // фильтрГауссаToolStripMenuItem
      // 
      this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
      this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
      this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
      // 
      // фильтрСобеляToolStripMenuItem
      // 
      this.фильтрСобеляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиXToolStripMenuItem,
            this.поОсиYToolStripMenuItem});
      this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
      this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
      // 
      // поОсиXToolStripMenuItem
      // 
      this.поОсиXToolStripMenuItem.Name = "поОсиXToolStripMenuItem";
      this.поОсиXToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
      this.поОсиXToolStripMenuItem.Text = "По оси X";
      this.поОсиXToolStripMenuItem.Click += new System.EventHandler(this.поОсиXToolStripMenuItem_Click);
      // 
      // поОсиYToolStripMenuItem
      // 
      this.поОсиYToolStripMenuItem.Name = "поОсиYToolStripMenuItem";
      this.поОсиYToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
      this.поОсиYToolStripMenuItem.Text = "По оси Y";
      this.поОсиYToolStripMenuItem.Click += new System.EventHandler(this.поОсиYToolStripMenuItem_Click);
      // 
      // резкийToolStripMenuItem
      // 
      this.резкийToolStripMenuItem.Name = "резкийToolStripMenuItem";
      this.резкийToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.резкийToolStripMenuItem.Text = "Резкий";
      this.резкийToolStripMenuItem.Click += new System.EventHandler(this.резкийToolStripMenuItem_Click);
      // 
      // тиснениеToolStripMenuItem
      // 
      this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
      this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.тиснениеToolStripMenuItem.Text = "Тиснение";
      this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
      // 
      // фильтрПриToolStripMenuItem
      // 
      this.фильтрПриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиXToolStripMenuItem1,
            this.поОсиYToolStripMenuItem1});
      this.фильтрПриToolStripMenuItem.Name = "фильтрПриToolStripMenuItem";
      this.фильтрПриToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.фильтрПриToolStripMenuItem.Text = "Фильтр Прюитта";
      // 
      // поОсиXToolStripMenuItem1
      // 
      this.поОсиXToolStripMenuItem1.Name = "поОсиXToolStripMenuItem1";
      this.поОсиXToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
      this.поОсиXToolStripMenuItem1.Text = "По оси X";
      this.поОсиXToolStripMenuItem1.Click += new System.EventHandler(this.поОсиXToolStripMenuItem1_Click);
      // 
      // поОсиYToolStripMenuItem1
      // 
      this.поОсиYToolStripMenuItem1.Name = "поОсиYToolStripMenuItem1";
      this.поОсиYToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
      this.поОсиYToolStripMenuItem1.Text = "По оси Y";
      this.поОсиYToolStripMenuItem1.Click += new System.EventHandler(this.поОсиYToolStripMenuItem1_Click);
      // 
      // светящиесяКраяToolStripMenuItem
      // 
      this.светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
      this.светящиесяКраяToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
      this.светящиесяКраяToolStripMenuItem.Click += new System.EventHandler(this.светящиесяКраяToolStripMenuItem_Click);
      // 
      // фильтШарраToolStripMenuItem
      // 
      this.фильтШарраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиXToolStripMenuItem2,
            this.поОсиYToolStripMenuItem2});
      this.фильтШарраToolStripMenuItem.Name = "фильтШарраToolStripMenuItem";
      this.фильтШарраToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.фильтШарраToolStripMenuItem.Text = "Фильт Шарра";
      // 
      // поОсиXToolStripMenuItem2
      // 
      this.поОсиXToolStripMenuItem2.Name = "поОсиXToolStripMenuItem2";
      this.поОсиXToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
      this.поОсиXToolStripMenuItem2.Text = "По оси X";
      this.поОсиXToolStripMenuItem2.Click += new System.EventHandler(this.поОсиXToolStripMenuItem2_Click);
      // 
      // поОсиYToolStripMenuItem2
      // 
      this.поОсиYToolStripMenuItem2.Name = "поОсиYToolStripMenuItem2";
      this.поОсиYToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
      this.поОсиYToolStripMenuItem2.Text = "По оси Y";
      this.поОсиYToolStripMenuItem2.Click += new System.EventHandler(this.поОсиYToolStripMenuItem2_Click);
      // 
      // операцииМатморфологииToolStripMenuItem
      // 
      this.операцииМатморфологииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьМаскуToolStripMenuItem,
            this.расширениеToolStripMenuItem,
            this.сужениеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.чернаяШляпаToolStripMenuItem});
      this.операцииМатморфологииToolStripMenuItem.Name = "операцииМатморфологииToolStripMenuItem";
      this.операцииМатморфологииToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
      this.операцииМатморфологииToolStripMenuItem.Text = "Операции матморфологии";
      // 
      // задатьМаскуToolStripMenuItem
      // 
      this.задатьМаскуToolStripMenuItem.Name = "задатьМаскуToolStripMenuItem";
      this.задатьМаскуToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.задатьМаскуToolStripMenuItem.Text = "Задать структурный элемент";
      this.задатьМаскуToolStripMenuItem.Click += new System.EventHandler(this.задатьМаскуToolStripMenuItem_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Enabled = false;
      this.pictureBox1.Location = new System.Drawing.Point(0, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(800, 470);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.WorkerSupportsCancellation = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.Location = new System.Drawing.Point(6, 10);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(637, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(660, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(119, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Отмена";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.progressBar1);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 455);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 39);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      // 
      // расширениеToolStripMenuItem
      // 
      this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
      this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.расширениеToolStripMenuItem.Text = "Расширение";
      this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
      // 
      // сужениеToolStripMenuItem
      // 
      this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
      this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.сужениеToolStripMenuItem.Text = "Сужение";
      this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
      // 
      // открытиеToolStripMenuItem
      // 
      this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
      this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.открытиеToolStripMenuItem.Text = "Открытие";
      this.открытиеToolStripMenuItem.Click += new System.EventHandler(this.открытиеToolStripMenuItem_Click);
      // 
      // закрытиеToolStripMenuItem
      // 
      this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
      this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.закрытиеToolStripMenuItem.Text = "Закрытие";
      this.закрытиеToolStripMenuItem.Click += new System.EventHandler(this.закрытиеToolStripMenuItem_Click);
      // 
      // чернаяШляпаToolStripMenuItem
      // 
      this.чернаяШляпаToolStripMenuItem.Name = "чернаяШляпаToolStripMenuItem";
      this.чернаяШляпаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
      this.чернаяШляпаToolStripMenuItem.Text = "Черная шляпа";
      this.чернаяШляпаToolStripMenuItem.Click += new System.EventHandler(this.чернаяШляпаToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 494);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Обработчик изображений";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem полутоновыйToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem яркийToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поОсиYToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem резкийToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem гистограммаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрПриToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem поОсиYToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem светящиесяКраяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтШарраToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem поОсиYToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem операцииМатморфологииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem задатьМаскуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem чернаяШляпаToolStripMenuItem;
  }
}

