namespace Graph_Teori_Falan
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ÖrnekDüğüm = new System.Windows.Forms.Button();
            this.SağTıkMenü = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düğümünAdınıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düğümüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.düğümüBağlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.düğümeRenkVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düğümreRastgeleRenkVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Işıkları_Söndür = new System.Windows.Forms.Timer(this.components);
            this.KenarSağTık = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.renklendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.itere = new System.Windows.Forms.ToolStripTextBox();
            this.iterasyonBelirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bilgi1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Bilgi2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.iterbar = new System.Windows.Forms.ToolStripProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SağTıkMenü.SuspendLayout();
            this.KenarSağTık.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.ÖrnekDüğüm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 642);
            this.panel1.TabIndex = 0;
            // 
            // ÖrnekDüğüm
            // 
            this.ÖrnekDüğüm.BackColor = System.Drawing.Color.White;
            this.ÖrnekDüğüm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÖrnekDüğüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÖrnekDüğüm.Location = new System.Drawing.Point(26, 35);
            this.ÖrnekDüğüm.Name = "ÖrnekDüğüm";
            this.ÖrnekDüğüm.Size = new System.Drawing.Size(110, 53);
            this.ÖrnekDüğüm.TabIndex = 1;
            this.ÖrnekDüğüm.Text = "DÜĞÜM";
            this.ÖrnekDüğüm.UseVisualStyleBackColor = false;
            this.ÖrnekDüğüm.Click += new System.EventHandler(this.button1_Click);
            // 
            // SağTıkMenü
            // 
            this.SağTıkMenü.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SağTıkMenü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düğümünAdınıDeğiştirToolStripMenuItem,
            this.düğümüSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.düğümüBağlaToolStripMenuItem,
            this.toolStripSeparator2,
            this.düğümeRenkVerToolStripMenuItem,
            this.düğümreRastgeleRenkVerToolStripMenuItem,
            this.toolStripSeparator3});
            this.SağTıkMenü.Name = "SağTıkMenü";
            this.SağTıkMenü.Size = new System.Drawing.Size(249, 142);
            this.SağTıkMenü.Tag = "deneme";
            // 
            // düğümünAdınıDeğiştirToolStripMenuItem
            // 
            this.düğümünAdınıDeğiştirToolStripMenuItem.Name = "düğümünAdınıDeğiştirToolStripMenuItem";
            this.düğümünAdınıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.düğümünAdınıDeğiştirToolStripMenuItem.Text = "Düğümün adını değiştir";
            this.düğümünAdınıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.düğümünAdınıDeğiştirToolStripMenuItem_Click);
            // 
            // düğümüSilToolStripMenuItem
            // 
            this.düğümüSilToolStripMenuItem.Name = "düğümüSilToolStripMenuItem";
            this.düğümüSilToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.düğümüSilToolStripMenuItem.Text = "Düğümü sil";
            this.düğümüSilToolStripMenuItem.Click += new System.EventHandler(this.düğümüSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // düğümüBağlaToolStripMenuItem
            // 
            this.düğümüBağlaToolStripMenuItem.Name = "düğümüBağlaToolStripMenuItem";
            this.düğümüBağlaToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.düğümüBağlaToolStripMenuItem.Text = "Düğümü bağla";
            this.düğümüBağlaToolStripMenuItem.Click += new System.EventHandler(this.düğümüBağlaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // düğümeRenkVerToolStripMenuItem
            // 
            this.düğümeRenkVerToolStripMenuItem.Name = "düğümeRenkVerToolStripMenuItem";
            this.düğümeRenkVerToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.düğümeRenkVerToolStripMenuItem.Text = "Düğüme renk ver";
            this.düğümeRenkVerToolStripMenuItem.Click += new System.EventHandler(this.düğümeRenkVerToolStripMenuItem_Click);
            // 
            // düğümreRastgeleRenkVerToolStripMenuItem
            // 
            this.düğümreRastgeleRenkVerToolStripMenuItem.Name = "düğümreRastgeleRenkVerToolStripMenuItem";
            this.düğümreRastgeleRenkVerToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.düğümreRastgeleRenkVerToolStripMenuItem.Text = "Düğüme rastgele renk ver";
            this.düğümreRastgeleRenkVerToolStripMenuItem.Click += new System.EventHandler(this.düğümreRastgeleRenkVerToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(245, 6);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(287, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 228);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SizeChanged += new System.EventHandler(this.listBox1_SizeChanged);
            // 
            // Işıkları_Söndür
            // 
            this.Işıkları_Söndür.Tick += new System.EventHandler(this.Işıkları_Söndür_Tick);
            // 
            // KenarSağTık
            // 
            this.KenarSağTık.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.KenarSağTık.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.KenarSağTık.Name = "KenarSağTık";
            this.KenarSağTık.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.renklendirToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.itere,
            this.iterasyonBelirleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(160, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.toolStripSeparator6,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.toolStripSeparator7,
            this.yazdırToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(127, 6);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(127, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 27);
            this.toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(104, 26);
            this.toolStripMenuItem3.Text = "     ";
            // 
            // renklendirToolStripMenuItem
            // 
            this.renklendirToolStripMenuItem.Name = "renklendirToolStripMenuItem";
            this.renklendirToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.renklendirToolStripMenuItem.Text = "Renklendir";
            this.renklendirToolStripMenuItem.Click += new System.EventHandler(this.renklendirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(25, 27);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 27);
            this.toolStripMenuItem2.Text = " ";
            // 
            // itere
            // 
            this.itere.Name = "itere";
            this.itere.Size = new System.Drawing.Size(100, 27);
            this.itere.Visible = false;
            // 
            // iterasyonBelirleToolStripMenuItem
            // 
            this.iterasyonBelirleToolStripMenuItem.Name = "iterasyonBelirleToolStripMenuItem";
            this.iterasyonBelirleToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.iterasyonBelirleToolStripMenuItem.Text = "-> İterasyon Belirle";
            this.iterasyonBelirleToolStripMenuItem.Visible = false;
            this.iterasyonBelirleToolStripMenuItem.Click += new System.EventHandler(this.iterasyonBelirleToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(618, 281);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(272, 228);
            this.listBox2.TabIndex = 5;
            this.listBox2.Visible = false;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bilgi1,
            this.toolStripSeparator4,
            this.Bilgi2,
            this.toolStripSeparator5,
            this.iterbar});
            this.toolStrip1.Location = new System.Drawing.Point(160, 617);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bilgi1
            // 
            this.Bilgi1.Name = "Bilgi1";
            this.Bilgi1.Size = new System.Drawing.Size(47, 22);
            this.Bilgi1.Text = "Bilgi1";
            this.Bilgi1.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Bilgi2
            // 
            this.Bilgi2.Name = "Bilgi2";
            this.Bilgi2.Size = new System.Drawing.Size(47, 22);
            this.Bilgi2.Text = "Bilgi2";
            this.Bilgi2.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // iterbar
            // 
            this.iterbar.Name = "iterbar";
            this.iterbar.Size = new System.Drawing.Size(300, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 642);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Beyoğlu Gazoz";
            this.panel1.ResumeLayout(false);
            this.SağTıkMenü.ResumeLayout(false);
            this.KenarSağTık.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ÖrnekDüğüm;
        private System.Windows.Forms.ContextMenuStrip SağTıkMenü;
        private System.Windows.Forms.ToolStripMenuItem düğümünAdınıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düğümüSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düğümüBağlaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer Işıkları_Söndür;
        private System.Windows.Forms.ContextMenuStrip KenarSağTık;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renklendirToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem düğümeRenkVerToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem düğümreRastgeleRenkVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Bilgi1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel Bilgi2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem iterasyonBelirleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox itere;
        private System.Windows.Forms.ToolStripProgressBar iterbar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

