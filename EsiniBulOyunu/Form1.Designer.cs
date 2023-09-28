namespace EsiniBulOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            panel1 = new Panel();
            gboYeniOyun = new GroupBox();
            rb2 = new RadioButton();
            btnOyunuBaslat = new Button();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            rb5 = new RadioButton();
            rb1 = new RadioButton();
            menuStrip1 = new MenuStrip();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            btnCikis = new ToolStripMenuItem();
            panel1.SuspendLayout();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(4, 23);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 601);
            pnlKartlar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(gboYeniOyun);
            panel1.ForeColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(134, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 329);
            panel1.TabIndex = 1;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Font = new Font("Myriad Hebrew", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            gboYeniOyun.Location = new Point(3, 3);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(336, 323);
            gboYeniOyun.TabIndex = 1;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.FlatStyle = FlatStyle.System;
            rb2.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location = new Point(90, 61);
            rb2.Name = "rb2";
            rb2.Size = new Size(110, 48);
            rb2.TabIndex = 5;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.FlatStyle = FlatStyle.System;
            btnOyunuBaslat.Font = new Font("Ink Free", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOyunuBaslat.Location = new Point(34, 262);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(273, 48);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.FlatStyle = FlatStyle.System;
            rb3.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location = new Point(90, 109);
            rb3.Name = "rb3";
            rb3.Size = new Size(99, 48);
            rb3.TabIndex = 4;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.FlatStyle = FlatStyle.System;
            rb4.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.Location = new Point(90, 157);
            rb4.Name = "rb4";
            rb4.Size = new Size(88, 48);
            rb4.TabIndex = 3;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.FlatStyle = FlatStyle.System;
            rb5.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.Location = new Point(90, 205);
            rb5.Name = "rb5";
            rb5.Size = new Size(143, 48);
            rb5.TabIndex = 2;
            rb5.Text = "Çok Zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.FlatStyle = FlatStyle.System;
            rb1.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(90, 13);
            rb1.Name = "rb1";
            rb1.Size = new Size(165, 48);
            rb1.TabIndex = 1;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(609, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun, btnCikis });
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(48, 20);
            yeniOyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // btnCikis
            // 
            btnCikis.Name = "btnCikis";
            btnCikis.ShortcutKeys = Keys.Alt | Keys.F4;
            btnCikis.Size = new Size(147, 22);
            btnCikis.Text = "Çıkış";
            btnCikis.Click += btnCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(609, 631);
            Controls.Add(panel1);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            panel1.ResumeLayout(false);
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private Panel panel1;
        private GroupBox gboYeniOyun;
        private Button btnOyunuBaslat;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private RadioButton rb5;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
        private ToolStripMenuItem btnCikis;
    }
}