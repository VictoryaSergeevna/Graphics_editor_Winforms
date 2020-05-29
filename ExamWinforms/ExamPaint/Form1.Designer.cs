namespace ExamPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.буферОбменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnGreen = new System.Windows.Forms.ToolStrip();
            this.toolStripButnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblColor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPink = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMaroon = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOrange = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnYellow = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnWhite = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGrey = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnColorCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblTools = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFullScreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMini = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.trackBarColorSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.toolStripBtnGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColorSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 462);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.главнаяToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(814, 24);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.буферОбменаToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // буферОбменаToolStripMenuItem
            // 
            this.буферОбменаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem});
            this.буферОбменаToolStripMenuItem.Name = "буферОбменаToolStripMenuItem";
            this.буферОбменаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.буферОбменаToolStripMenuItem.Text = "Буфер обмена";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.вставитьToolStripMenuItem.Text = "вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.вырезатьToolStripMenuItem.Text = "вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.копироватьToolStripMenuItem.Text = "копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.увеличитьToolStripMenuItem.Text = "увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.уменьшитьToolStripMenuItem.Text = "уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // toolStripBtnGreen
            // 
            this.toolStripBtnGreen.BackColor = System.Drawing.Color.White;
            this.toolStripBtnGreen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBtnGreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButnOpen,
            this.toolStripBtnSave,
            this.toolStripBtnPrint,
            this.toolStripBtnExit,
            this.toolStripSeparator4,
            this.toolStripLblColor,
            this.toolStripBtnBlack,
            this.toolStripBtnPink,
            this.toolStripBtnRed,
            this.toolStripBtnMaroon,
            this.toolStripBtnOrange,
            this.toolStripBtnYellow,
            this.toolStripBtnWhite,
            this.toolStripButton1,
            this.toolStripBtnBlue,
            this.toolStripBtnGrey,
            this.toolStripBtnColorCircle,
            this.toolStripSeparator6,
            this.toolStripLblTools,
            this.toolStripBtnLine,
            this.toolStripBtnRect,
            this.toolStripBtnCircle,
            this.toolStripSeparator5,
            this.toolStripBtnEraser,
            this.toolStripBtnClear,
            this.toolStripBtnFullScreen,
            this.toolStripBtnMini,
            this.toolStripSeparator7});
            this.toolStripBtnGreen.Location = new System.Drawing.Point(0, 24);
            this.toolStripBtnGreen.Name = "toolStripBtnGreen";
            this.toolStripBtnGreen.Size = new System.Drawing.Size(814, 25);
            this.toolStripBtnGreen.TabIndex = 6;
            this.toolStripBtnGreen.Text = "toolStrip2";
            // 
            // toolStripButnOpen
            // 
            this.toolStripButnOpen.BackColor = System.Drawing.Color.White;
            this.toolStripButnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButnOpen.Image")));
            this.toolStripButnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButnOpen.Name = "toolStripButnOpen";
            this.toolStripButnOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButnOpen.Text = "Открыть";
            this.toolStripButnOpen.Click += new System.EventHandler(this.toolStripButnOpen_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.BackColor = System.Drawing.Color.White;
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSave.Image")));
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSave.Text = "Сохранить";
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.BackColor = System.Drawing.Color.White;
            this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPrint.Text = "Печатать";
            this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.BackColor = System.Drawing.Color.White;
            this.toolStripBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnExit.Text = "Выход";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Visible = false;
            // 
            // toolStripLblColor
            // 
            this.toolStripLblColor.Name = "toolStripLblColor";
            this.toolStripLblColor.Size = new System.Drawing.Size(33, 22);
            this.toolStripLblColor.Text = "Цвет";
            // 
            // toolStripBtnBlack
            // 
            this.toolStripBtnBlack.BackColor = System.Drawing.Color.Black;
            this.toolStripBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlack.Name = "toolStripBtnBlack";
            this.toolStripBtnBlack.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlack.Text = "Черный";
            this.toolStripBtnBlack.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnPink
            // 
            this.toolStripBtnPink.BackColor = System.Drawing.Color.Pink;
            this.toolStripBtnPink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPink.Name = "toolStripBtnPink";
            this.toolStripBtnPink.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPink.Text = "Розовый";
            this.toolStripBtnPink.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnRed
            // 
            this.toolStripBtnRed.BackColor = System.Drawing.Color.Red;
            this.toolStripBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRed.Name = "toolStripBtnRed";
            this.toolStripBtnRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRed.Text = "Красный";
            this.toolStripBtnRed.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnMaroon
            // 
            this.toolStripBtnMaroon.BackColor = System.Drawing.Color.Maroon;
            this.toolStripBtnMaroon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMaroon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMaroon.Name = "toolStripBtnMaroon";
            this.toolStripBtnMaroon.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnMaroon.Text = "Бардовый";
            this.toolStripBtnMaroon.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnOrange
            // 
            this.toolStripBtnOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripBtnOrange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOrange.Name = "toolStripBtnOrange";
            this.toolStripBtnOrange.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnOrange.Text = "Оранжевый";
            this.toolStripBtnOrange.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnYellow
            // 
            this.toolStripBtnYellow.BackColor = System.Drawing.Color.Yellow;
            this.toolStripBtnYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnYellow.Name = "toolStripBtnYellow";
            this.toolStripBtnYellow.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnYellow.Text = "Желтый";
            this.toolStripBtnYellow.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnWhite
            // 
            this.toolStripBtnWhite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnWhite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnWhite.Name = "toolStripBtnWhite";
            this.toolStripBtnWhite.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnWhite.Text = "Белый";
            this.toolStripBtnWhite.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Green;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Зеленый";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnBlue
            // 
            this.toolStripBtnBlue.BackColor = System.Drawing.Color.Blue;
            this.toolStripBtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlue.Name = "toolStripBtnBlue";
            this.toolStripBtnBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlue.Text = "Голубой";
            this.toolStripBtnBlue.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnGrey
            // 
            this.toolStripBtnGrey.BackColor = System.Drawing.Color.Silver;
            this.toolStripBtnGrey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGrey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGrey.Name = "toolStripBtnGrey";
            this.toolStripBtnGrey.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnGrey.Text = "Серый";
            this.toolStripBtnGrey.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnColorCircle
            // 
            this.toolStripBtnColorCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnColorCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnColorCircle.Image")));
            this.toolStripBtnColorCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnColorCircle.Name = "toolStripBtnColorCircle";
            this.toolStripBtnColorCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnColorCircle.Text = "Палитра";
            this.toolStripBtnColorCircle.Click += new System.EventHandler(this.toolStripBtnColorCircle_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLblTools
            // 
            this.toolStripLblTools.Name = "toolStripLblTools";
            this.toolStripLblTools.Size = new System.Drawing.Size(83, 22);
            this.toolStripLblTools.Text = "Инструменты";
            // 
            // toolStripBtnLine
            // 
            this.toolStripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLine.Image")));
            this.toolStripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLine.Name = "toolStripBtnLine";
            this.toolStripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnLine.Text = "Линия";
            this.toolStripBtnLine.Click += new System.EventHandler(this.toolStripBtnLine_Click);
            // 
            // toolStripBtnRect
            // 
            this.toolStripBtnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRect.Image")));
            this.toolStripBtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRect.Name = "toolStripBtnRect";
            this.toolStripBtnRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRect.Text = "Прямоугольник";
            this.toolStripBtnRect.Click += new System.EventHandler(this.toolStripBtnRect_Click);
            // 
            // toolStripBtnCircle
            // 
            this.toolStripBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCircle.Image")));
            this.toolStripBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCircle.Name = "toolStripBtnCircle";
            this.toolStripBtnCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCircle.Text = "Круг";
            this.toolStripBtnCircle.Click += new System.EventHandler(this.toolStripBtnCircle_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnEraser
            // 
            this.toolStripBtnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEraser.Image")));
            this.toolStripBtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEraser.Name = "toolStripBtnEraser";
            this.toolStripBtnEraser.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEraser.Text = "Затирачка";
            this.toolStripBtnEraser.Click += new System.EventHandler(this.toolStripBtnEraser_Click);
            // 
            // toolStripBtnClear
            // 
            this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClear.Image")));
            this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClear.Name = "toolStripBtnClear";
            this.toolStripBtnClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnClear.Text = "Очистить все";
            this.toolStripBtnClear.Click += new System.EventHandler(this.toolStripBtnClear_Click);
            // 
            // toolStripBtnFullScreen
            // 
            this.toolStripBtnFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFullScreen.Image")));
            this.toolStripBtnFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFullScreen.Name = "toolStripBtnFullScreen";
            this.toolStripBtnFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripBtnFullScreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnFullScreen.Text = "Увеличить";
            this.toolStripBtnFullScreen.Click += new System.EventHandler(this.toolStripBtnFullScreen_Click);
            // 
            // toolStripBtnMini
            // 
            this.toolStripBtnMini.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMini.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMini.Image")));
            this.toolStripBtnMini.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMini.Name = "toolStripBtnMini";
            this.toolStripBtnMini.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnMini.Text = "Уменьшить";
            this.toolStripBtnMini.Click += new System.EventHandler(this.toolStripBtnMini_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // trackBarColorSize
            // 
            this.trackBarColorSize.AutoSize = false;
            this.trackBarColorSize.BackColor = System.Drawing.Color.White;
            this.trackBarColorSize.Location = new System.Drawing.Point(644, 24);
            this.trackBarColorSize.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarColorSize.Maximum = 100;
            this.trackBarColorSize.Name = "trackBarColorSize";
            this.trackBarColorSize.Size = new System.Drawing.Size(158, 24);
            this.trackBarColorSize.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.trackBarColorSize);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripBtnGreen);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.toolStripBtnGreen.ResumeLayout(false);
            this.toolStripBtnGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColorSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem буферОбменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripBtnGreen;
        private System.Windows.Forms.ToolStripButton toolStripButnOpen;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLblTools;
        private System.Windows.Forms.ToolStripButton toolStripBtnLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnRect;
        private System.Windows.Forms.ToolStripButton toolStripBtnCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLblColor;
        private System.Windows.Forms.ToolStripButton toolStripBtnPink;
        private System.Windows.Forms.ToolStripButton toolStripBtnRed;
        private System.Windows.Forms.ToolStripButton toolStripBtnMaroon;
        private System.Windows.Forms.ToolStripButton toolStripBtnOrange;
        private System.Windows.Forms.ToolStripButton toolStripBtnYellow;
        private System.Windows.Forms.ToolStripButton toolStripBtnWhite;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlue;
        private System.Windows.Forms.ToolStripButton toolStripBtnGrey;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlack;
        private System.Windows.Forms.ToolStripButton toolStripBtnColorCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripBtnEraser;
        private System.Windows.Forms.ToolStripButton toolStripBtnClear;
        private System.Windows.Forms.ToolStripButton toolStripBtnFullScreen;
        private System.Windows.Forms.ToolStripButton toolStripBtnMini;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TrackBar trackBarColorSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

