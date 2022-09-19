
namespace WindowsFormsApp1
{
    partial class ordersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПустыхЗначенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датасдачизаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрированоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроцессеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьФильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колическтвоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСДаннымиToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            this.работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузитьБазуДанныхToolStripMenuItem,
            this.добавитьНовыеДанныеToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem,
            this.удалитьДанныеToolStripMenuItem});
            this.работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            this.работаСДаннымиToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // перезагрузитьБазуДанныхToolStripMenuItem
            // 
            this.перезагрузитьБазуДанныхToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("перезагрузитьБазуДанныхToolStripMenuItem.Image")));
            this.перезагрузитьБазуДанныхToolStripMenuItem.Name = "перезагрузитьБазуДанныхToolStripMenuItem";
            this.перезагрузитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.перезагрузитьБазуДанныхToolStripMenuItem.Text = "Перезагрузить таблицу";
            this.перезагрузитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.перезагрузитьБазуДанныхToolStripMenuItem_Click);
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
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПустыхЗначенийToolStripMenuItem,
            this.статусЗаказаToolStripMenuItem,
            this.очиститьФильтрыToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // поискПустыхЗначенийToolStripMenuItem
            // 
            this.поискПустыхЗначенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.датасдачизаказаToolStripMenuItem});
            this.поискПустыхЗначенийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискПустыхЗначенийToolStripMenuItem.Image")));
            this.поискПустыхЗначенийToolStripMenuItem.Name = "поискПустыхЗначенийToolStripMenuItem";
            this.поискПустыхЗначенийToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.поискПустыхЗначенийToolStripMenuItem.Text = "Поиск пустых значений";
            // 
            // датасдачизаказаToolStripMenuItem
            // 
            this.датасдачизаказаToolStripMenuItem.Name = "датасдачизаказаToolStripMenuItem";
            this.датасдачизаказаToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.датасдачизаказаToolStripMenuItem.Text = "Дата сдачи заказа";
            this.датасдачизаказаToolStripMenuItem.Click += new System.EventHandler(this.датасдачизаказаToolStripMenuItem_Click);
            // 
            // статусЗаказаToolStripMenuItem
            // 
            this.статусЗаказаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарегистрированоToolStripMenuItem,
            this.вПроцессеToolStripMenuItem,
            this.завершеноToolStripMenuItem});
            this.статусЗаказаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("статусЗаказаToolStripMenuItem.Image")));
            this.статусЗаказаToolStripMenuItem.Name = "статусЗаказаToolStripMenuItem";
            this.статусЗаказаToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.статусЗаказаToolStripMenuItem.Text = "Статус заказа";
            // 
            // зарегистрированоToolStripMenuItem
            // 
            this.зарегистрированоToolStripMenuItem.Name = "зарегистрированоToolStripMenuItem";
            this.зарегистрированоToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.зарегистрированоToolStripMenuItem.Text = "1-Зарегистрировано";
            this.зарегистрированоToolStripMenuItem.Click += new System.EventHandler(this.зарегистрированоToolStripMenuItem_Click);
            // 
            // вПроцессеToolStripMenuItem
            // 
            this.вПроцессеToolStripMenuItem.Name = "вПроцессеToolStripMenuItem";
            this.вПроцессеToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.вПроцессеToolStripMenuItem.Text = "2-В процессе";
            this.вПроцессеToolStripMenuItem.Click += new System.EventHandler(this.вПроцессеToolStripMenuItem_Click);
            // 
            // завершеноToolStripMenuItem
            // 
            this.завершеноToolStripMenuItem.Name = "завершеноToolStripMenuItem";
            this.завершеноToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.завершеноToolStripMenuItem.Text = "3-Завершено";
            this.завершеноToolStripMenuItem.Click += new System.EventHandler(this.завершеноToolStripMenuItem_Click);
            // 
            // очиститьФильтрыToolStripMenuItem
            // 
            this.очиститьФильтрыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьФильтрыToolStripMenuItem.Image")));
            this.очиститьФильтрыToolStripMenuItem.Name = "очиститьФильтрыToolStripMenuItem";
            this.очиститьФильтрыToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.очиститьФильтрыToolStripMenuItem.Text = "Очистить фильтры";
            this.очиститьФильтрыToolStripMenuItem.Click += new System.EventHandler(this.очиститьФильтрыToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колическтвоToolStripMenuItem,
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // колическтвоToolStripMenuItem
            // 
            this.колическтвоToolStripMenuItem.Name = "колическтвоToolStripMenuItem";
            this.колическтвоToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.колическтвоToolStripMenuItem.Text = "Колическтво заказов";
            this.колическтвоToolStripMenuItem.Click += new System.EventHandler(this.колическтвоToolStripMenuItem_Click);
            // 
            // подсчетЗаказавоПоСтатусамToolStripMenuItem
            // 
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem.Name = "подсчетЗаказавоПоСтатусамToolStripMenuItem";
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem.Text = "Подсчет заказаво по статусам";
            this.подсчетЗаказавоПоСтатусамToolStripMenuItem.Click += new System.EventHandler(this.подсчетЗаказавоПоСтатусамToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.отчетыToolStripMenuItem.Text = "| Отчёт по данной таблице";
            this.отчетыToolStripMenuItem.Click += new System.EventHandler(this.отчетыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ordersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПустыхЗначенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьФильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датасдачизаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрированоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПроцессеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колическтвоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсчетЗаказавоПоСтатусамToolStripMenuItem;
    }
}