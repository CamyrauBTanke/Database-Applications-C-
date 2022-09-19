
namespace WindowsFormsApp1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыДляРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работыПоЗаказуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.создатьОтчетВручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыДляРаботыToolStripMenuItem,
            this.дополнительнаяИнформацияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.создатьОтчетВручнуюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыДляРаботыToolStripMenuItem
            // 
            this.таблицыДляРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.работыПоЗаказуToolStripMenuItem});
            this.таблицыДляРаботыToolStripMenuItem.Name = "таблицыДляРаботыToolStripMenuItem";
            this.таблицыДляРаботыToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.таблицыДляРаботыToolStripMenuItem.Text = "Таблицы для работ";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыToolStripMenuItem.Image")));
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // работыПоЗаказуToolStripMenuItem
            // 
            this.работыПоЗаказуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("работыПоЗаказуToolStripMenuItem.Image")));
            this.работыПоЗаказуToolStripMenuItem.Name = "работыПоЗаказуToolStripMenuItem";
            this.работыПоЗаказуToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.работыПоЗаказуToolStripMenuItem.Text = "Работы по заказу";
            this.работыПоЗаказуToolStripMenuItem.Click += new System.EventHandler(this.работыПоЗаказуToolStripMenuItem_Click);
            // 
            // дополнительнаяИнформацияToolStripMenuItem
            // 
            this.дополнительнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.менеджерыToolStripMenuItem,
            this.рабочиеToolStripMenuItem,
            this.допИнформацияToolStripMenuItem});
            this.дополнительнаяИнформацияToolStripMenuItem.Name = "дополнительнаяИнформацияToolStripMenuItem";
            this.дополнительнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.дополнительнаяИнформацияToolStripMenuItem.Text = "Справочник";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("пользователиToolStripMenuItem.Image")));
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.пользователиToolStripMenuItem.Text = "Клиенты";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // менеджерыToolStripMenuItem
            // 
            this.менеджерыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("менеджерыToolStripMenuItem.Image")));
            this.менеджерыToolStripMenuItem.Name = "менеджерыToolStripMenuItem";
            this.менеджерыToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.менеджерыToolStripMenuItem.Text = "Менеджеры";
            this.менеджерыToolStripMenuItem.Click += new System.EventHandler(this.менеджерыToolStripMenuItem_Click);
            // 
            // рабочиеToolStripMenuItem
            // 
            this.рабочиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.специализацияToolStripMenuItem});
            this.рабочиеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рабочиеToolStripMenuItem.Image")));
            this.рабочиеToolStripMenuItem.Name = "рабочиеToolStripMenuItem";
            this.рабочиеToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.рабочиеToolStripMenuItem.Text = "Специалисты";
            this.рабочиеToolStripMenuItem.Click += new System.EventHandler(this.рабочиеToolStripMenuItem_Click);
            // 
            // специализацияToolStripMenuItem
            // 
            this.специализацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("специализацияToolStripMenuItem.Image")));
            this.специализацияToolStripMenuItem.Name = "специализацияToolStripMenuItem";
            this.специализацияToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.специализацияToolStripMenuItem.Text = "Специализация";
            this.специализацияToolStripMenuItem.Click += new System.EventHandler(this.специализацияToolStripMenuItem_Click);
            // 
            // допИнформацияToolStripMenuItem
            // 
            this.допИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.материалыToolStripMenuItem1,
            this.услугиToolStripMenuItem,
            this.статусыЗаказовToolStripMenuItem});
            this.допИнформацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("допИнформацияToolStripMenuItem.Image")));
            this.допИнформацияToolStripMenuItem.Name = "допИнформацияToolStripMenuItem";
            this.допИнформацияToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.допИнформацияToolStripMenuItem.Text = "Доп. информация";
            // 
            // материалыToolStripMenuItem1
            // 
            this.материалыToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("материалыToolStripMenuItem1.Image")));
            this.материалыToolStripMenuItem1.Name = "материалыToolStripMenuItem1";
            this.материалыToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.материалыToolStripMenuItem1.Text = "Материалы";
            this.материалыToolStripMenuItem1.Click += new System.EventHandler(this.материалыToolStripMenuItem1_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("услугиToolStripMenuItem.Image")));
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // статусыЗаказовToolStripMenuItem
            // 
            this.статусыЗаказовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("статусыЗаказовToolStripMenuItem.Image")));
            this.статусыЗаказовToolStripMenuItem.Name = "статусыЗаказовToolStripMenuItem";
            this.статусыЗаказовToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.статусыЗаказовToolStripMenuItem.Text = "Статусы заказов";
            this.статусыЗаказовToolStripMenuItem.Click += new System.EventHandler(this.статусыЗаказовToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКомпанииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // информацияОКомпанииToolStripMenuItem
            // 
            this.информацияОКомпанииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("информацияОКомпанииToolStripMenuItem.Image")));
            this.информацияОКомпанииToolStripMenuItem.Name = "информацияОКомпанииToolStripMenuItem";
            this.информацияОКомпанииToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.информацияОКомпанииToolStripMenuItem.Text = "Информация о компании";
            this.информацияОКомпанииToolStripMenuItem.Click += new System.EventHandler(this.информацияОКомпанииToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 168);
            this.label1.TabIndex = 2;
            this.label1.Text = "Приветствую в моём \r\nприложении!!!\r\n\r\nДанное приложение \r\nработает с локальной \r\n" +
    "базой данных из-за\r\nэтого скорость работы \r\nприложения несколько снижена.\r\n";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(37, 41);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(101, 17);
            this.label_user.TabIndex = 3;
            this.label_user.Text = "Пользователь";
            this.label_user.Visible = false;
            // 
            // создатьОтчетВручнуюToolStripMenuItem
            // 
            this.создатьОтчетВручнуюToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьОтчетВручнуюToolStripMenuItem.Image")));
            this.создатьОтчетВручнуюToolStripMenuItem.Name = "создатьОтчетВручнуюToolStripMenuItem";
            this.создатьОтчетВручнуюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьОтчетВручнуюToolStripMenuItem.Text = "PHP.MyAdmin";
            this.создатьОтчетВручнуюToolStripMenuItem.Click += new System.EventHandler(this.создатьОтчетВручнуюToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(501, 285);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 285);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОКомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рабочиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыДляРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работыПоЗаказуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗаказовToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетВручнуюToolStripMenuItem;
    }
}