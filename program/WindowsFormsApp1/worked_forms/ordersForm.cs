using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class ordersForm : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;
        private MySqlCommand command_insert = null;
        private MySqlCommand command = null;
        private MySqlCommand command_update = null;
        private MySqlCommand command_delete = null;

        public ordersForm()
        {
            InitializeComponent();
        }

        public string User_save
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public void Count()
        {
            string str = User_save;
            for(int i=0; i<str.Length; i++)
                if(str[0] == 'm' && str[1] == 'a' && str[2] == 'n' && str[3] == 'a' && str[4] == 'g' && str[5] == 'e' && str[6] == 'r')
                {
                    break;
                }
                else if (label1.Text == "1" || label1.Text == "admin")
                {
                    break;
                }
                else
                {
                    добавитьНовыеДанныеToolStripMenuItem.Visible = false;
                    изменитьДанныеToolStripMenuItem.Visible = false;
                    удалитьДанныеToolStripMenuItem.Visible = false;

                    отчетыToolStripMenuItem.Visible = false;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.ReadOnly = true;
                    break;
                }
        }
        private void ordersForm_Load(object sender, EventArgs e)
        {           
            Count();            

            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `заказ`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();
        }

        private void перезагрузитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `заказ`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();
        }

        private void добавитьНовыеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();

            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            db.openConection();

            command_insert = new MySqlCommand("INSERT INTO `заказ` (`Дата_принятия_заказ`, `Дата_сдачи_заказа`, `id_клиента`, `id_менеджера`, `id_специалиста`, `id_статуса`) VALUES (@ff1, @ff2, @ff3, @ff4, @ff5, @ff6);", db.getConnection());
            command_insert.Parameters.Add("@ff1", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_insert.Parameters.Add("@ff2", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_insert.Parameters.Add("@ff3", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_insert.Parameters.Add("@ff4", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_insert.Parameters.Add("@ff5", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_insert.Parameters.Add("@ff6", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[6].Value;

            try
            {
                if (command_insert.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись была добавлена");
                else
                    MessageBox.Show("Oшибка добавления данных");
            }
            catch
            {
                MessageBox.Show("Oшибка обработки данных");
                return;
            }
            finally
            {
                db.closeConection();
            }
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
            
            db.openConection();

            command_update = new MySqlCommand("UPDATE `заказ` SET `Дата_принятия_заказ` = @f1, `Дата_сдачи_заказа` = @f2, `id_клиента` = @f3, `id_менеджера` = @f4, `id_специалиста` = @f5, `id_статуса` = @f6 WHERE `заказ`.`ID_заказа` = @f0", db.getConnection());
            command_update.Parameters.Add("@f1", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_update.Parameters.Add("@f2", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_update.Parameters.Add("@f3", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_update.Parameters.Add("@f4", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_update.Parameters.Add("@f5", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_update.Parameters.Add("@f6", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[6].Value;
            command_update.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_update.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись была обновлена");
                else
                    MessageBox.Show("Oшибка обновления данных"); ;
            }
            catch
            {
                MessageBox.Show("Oшибка обработки данных");
                return;
            }
            finally
            {
                db.closeConection();
            }
        }

        private void удалитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            db.openConection();

            command_delete = new MySqlCommand("DELETE FROM `заказ` WHERE `заказ`.`ID_заказа` = @f0", db.getConnection());
            command_delete.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;
                        
            try
            {
                if (command_delete.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные были удалены");
                else
                    MessageBox.Show("Oшибка удаления данных");
            }
            catch
            {
                MessageBox.Show("Oшибка обработки данных");
                return;
            }
            finally
            {
                db.closeConection();
            }
        }

        private void зарегистрированоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `заказ` WHERE `id_статуса` = 1", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void вПроцессеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `заказ` WHERE `id_статуса` = 2", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void завершеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `заказ` WHERE `id_статуса` = 3", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void датасдачизаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `заказ` WHERE `Дата_сдачи_заказа` IS NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void очиститьФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `заказ`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();
        }

        void Save_All_report(DataGridView Save_data)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Выберите одну строку", "Внимание!");
                return;
            }

            string part = System.IO.Directory.GetCurrentDirectory() + @"\" + "Report_All_data.xlsx";
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int i = 1; i < Save_data.RowCount + 1; i++)
            {
                for (int j = 0; j < Save_data.ColumnCount + 1; j++)
                {                   
                    worksheet.Rows[i].Columns[j] = Save_data.Rows[i - 1].Cells[j - 1].Value;
                }
            }             
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(part);
            excelapp.Quit();
        }                         

        private void колическтвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT COUNT(ID_заказа) AS Всего_заказов FROM `заказ`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();
        }

        private void подсчетЗаказавоПоСтатусамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT id_статуса, COUNT(id_статуса) AS Количество_Статусов FROM `заказ` GROUP BY id_статуса", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();            
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save_All_report(dataGridView1);   
            WebBrowser web = new WebBrowser();
            System.Diagnostics.Process.Start(@"chrome.exe", "http://127.0.0.1/openserver/phpmyadmin/tbl_export.php?db=bd_tv_services&table=заказ&single_table=true");
            
        }
    }
}
