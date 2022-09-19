
namespace WindowsFormsApp1
{
    partial class clientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientsForm));
            this.работаСДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерПаспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иННToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.местоПроживанияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.номерПаспортаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.иННToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.номерТелефонаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.реквизитыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.логинToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.парольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьФильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоДаннойТаблицеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            this.работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузитьТаблицуToolStripMenuItem,
            this.добавитьНовыеДанныеToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem,
            this.удалитьДанныеToolStripMenuItem});
            this.работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            this.работаСДаннымиToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // перезагрузитьТаблицуToolStripMenuItem
            // 
            this.перезагрузитьТаблицуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("перезагрузитьТаблицуToolStripMenuItem.Image")));
            this.перезагрузитьТаблицуToolStripMenuItem.Name = "перезагрузитьТаблицуToolStripMenuItem";
            this.перезагрузитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.перезагрузитьТаблицуToolStripMenuItem.Text = "Перезагрузить таблицу";
            this.перезагрузитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.перезагрузитьТаблицуToolStripMenuItem_Click);
            // 
            // добавитьНовыеДанныеToolStripMenuItem
            // 
            this.добавитьНовыеДанныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьНовыеДанныеToolStripMenuItem.Image")));
            this.добавитьНовыеДанныеToolStripMenuItem.Name = "добавитьНовыеДанныеToolStripMenuItem";
            this.добавитьНовыеДанныеToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.добавитьНовыеДанныеToolStripMenuItem.Text = "Добавить новые данные";
            this.добавитьНовыеДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыеДанныеToolStripMenuItem_Click);
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьДанныеToolStripMenuItem.Image")));
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem_Click);
            // 
            // удалитьДанныеToolStripMenuItem
            // 
            this.удалитьДанныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьДанныеToolStripMenuItem.Image")));
            this.удалитьДанныеToolStripMenuItem.Name = "удалитьДанныеToolStripMenuItem";
            this.удалитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.удалитьДанныеToolStripMenuItem.Text = "Удалить данные";
            this.удалитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьДанныеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСДаннымиToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.отчётПоДаннойТаблицеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФИОToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.очиститьФильтрыToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // поискПоФИОToolStripMenuItem
            // 
            this.поискПоФИОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номерПаспортаToolStripMenuItem,
            this.иННToolStripMenuItem});
            this.поискПоФИОToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискПоФИОToolStripMenuItem.Image")));
            this.поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            this.поискПоФИОToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.поискПоФИОToolStripMenuItem.Text = "Поиск пустых значений";
            this.поискПоФИОToolStripMenuItem.Click += new System.EventHandler(this.поискПоФИОToolStripMenuItem_Click);
            // 
            // номерПаспортаToolStripMenuItem
            // 
            this.номерПаспортаToolStripMenuItem.Name = "номерПаспортаToolStripMenuItem";
            this.номерПаспортаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.номерПаспортаToolStripMenuItem.Text = "Номер паспорта";
            this.номерПаспортаToolStripMenuItem.Click += new System.EventHandler(this.номерПаспортаToolStripMenuItem_Click);
            // 
            // иННToolStripMenuItem
            // 
            this.иННToolStripMenuItem.Name = "иННToolStripMenuItem";
            this.иННToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.иННToolStripMenuItem.Text = "ИНН";
            this.иННToolStripMenuItem.Click += new System.EventHandler(this.иННToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОToolStripMenuItem1,
            this.местоПроживанияToolStripMenuItem1,
            this.номерПаспортаToolStripMenuItem1,
            this.иННToolStripMenuItem1,
            this.номерТелефонаToolStripMenuItem1,
            this.реквизитыToolStripMenuItem1,
            this.логинToolStripMenuItem1,
            this.парольToolStripMenuItem1});
            this.поискToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискToolStripMenuItem.Image")));
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.поискToolStripMenuItem.Text = "Поиск заполненный значений";
            // 
            // фИОToolStripMenuItem1
            // 
            this.фИОToolStripMenuItem1.Name = "фИОToolStripMenuItem1";
            this.фИОToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.фИОToolStripMenuItem1.Text = "ФИО";
            this.фИОToolStripMenuItem1.Click += new System.EventHandler(this.фИОToolStripMenuItem1_Click);
            // 
            // местоПроживанияToolStripMenuItem1
            // 
            this.местоПроживанияToolStripMenuItem1.Name = "местоПроживанияToolStripMenuItem1";
            this.местоПроживанияToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.местоПроживанияToolStripMenuItem1.Text = "Место проживания";
            this.местоПроживанияToolStripMenuItem1.Click += new System.EventHandler(this.местоПроживанияToolStripMenuItem1_Click);
            // 
            // номерПаспортаToolStripMenuItem1
            // 
            this.номерПаспортаToolStripMenuItem1.Name = "номерПаспортаToolStripMenuItem1";
            this.номерПаспортаToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.номерПаспортаToolStripMenuItem1.Text = "Номер паспорта";
            this.номерПаспортаToolStripMenuItem1.Click += new System.EventHandler(this.номерПаспортаToolStripMenuItem1_Click);
            // 
            // иННToolStripMenuItem1
            // 
            this.иННToolStripMenuItem1.Name = "иННToolStripMenuItem1";
            this.иННToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.иННToolStripMenuItem1.Text = "ИНН";
            this.иННToolStripMenuItem1.Click += new System.EventHandler(this.иННToolStripMenuItem1_Click);
            // 
            // номерТелефонаToolStripMenuItem1
            // 
            this.номерТелефонаToolStripMenuItem1.Name = "номерТелефонаToolStripMenuItem1";
            this.номерТелефонаToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.номерТелефонаToolStripMenuItem1.Text = "Номер телефона";
            this.номерТелефонаToolStripMenuItem1.Click += new System.EventHandler(this.номерТелефонаToolStripMenuItem1_Click);
            // 
            // реквизитыToolStripMenuItem1
            // 
            this.реквизитыToolStripMenuItem1.Name = "реквизитыToolStripMenuItem1";
            this.реквизитыToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.реквизитыToolStripMenuItem1.Text = "Реквизиты";
            this.реквизитыToolStripMenuItem1.Click += new System.EventHandler(this.реквизитыToolStripMenuItem1_Click);
            // 
            // логинToolStripMenuItem1
            // 
            this.логинToolStripMenuItem1.Name = "логинToolStripMenuItem1";
            this.логинToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.логинToolStripMenuItem1.Text = "Логин";
            this.логинToolStripMenuItem1.Click += new System.EventHandler(this.логинToolStripMenuItem1_Click);
            // 
            // парольToolStripMenuItem1
            // 
            this.парольToolStripMenuItem1.Name = "парольToolStripMenuItem1";
            this.парольToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.парольToolStripMenuItem1.Text = "Пароль";
            this.парольToolStripMenuItem1.Click += new System.EventHandler(this.парольToolStripMenuItem1_Click);
            // 
            // очиститьФильтрыToolStripMenuItem
            // 
            this.очиститьФильтрыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьФильтрыToolStripMenuItem.Image")));
            this.очиститьФильтрыToolStripMenuItem.Name = "очиститьФильтрыToolStripMenuItem";
            this.очиститьФильтрыToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.очиститьФильтрыToolStripMenuItem.Text = "Очистить фильтры";
            this.очиститьФильтрыToolStripMenuItem.Click += new System.EventHandler(this.очиститьФильтрыToolStripMenuItem_Click);
            // 
            // отчётПоДаннойТаблицеToolStripMenuItem
            // 
            this.отчётПоДаннойТаблицеToolStripMenuItem.Name = "отчётПоДаннойТаблицеToolStripMenuItem";
            this.отчётПоДаннойТаблицеToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.отчётПоДаннойТаблицеToolStripMenuItem.Text = "| Отчёт по данной таблице";
            this.отчётПоДаннойТаблицеToolStripMenuItem.Click += new System.EventHandler(this.отчётПоДаннойТаблицеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 485);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // clientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "clientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.clientsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьФильтрыToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem номерПаспортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иННToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem местоПроживанияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem номерПаспортаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem иННToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem номерТелефонаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem реквизитыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem логинToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem парольToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem отчётПоДаннойТаблицеToolStripMenuItem;
    }
}