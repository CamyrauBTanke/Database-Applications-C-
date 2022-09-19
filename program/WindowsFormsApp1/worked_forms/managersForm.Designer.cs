
namespace WindowsFormsApp1
{
    partial class managersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСДанными1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.работаСДанными1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСДанными1ToolStripMenuItem
            // 
            this.работаСДанными1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузитьТаблицуToolStripMenuItem,
            this.добавитьНовыеДанныеToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem,
            this.удалитьДанныеToolStripMenuItem});
            this.работаСДанными1ToolStripMenuItem.Name = "работаСДанными1ToolStripMenuItem";
            this.работаСДанными1ToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.работаСДанными1ToolStripMenuItem.Text = "Работа с данными";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // managersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "managersForm";
            this.Text = "Менеджеры";
            this.Load += new System.EventHandler(this.managersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСДанными1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}