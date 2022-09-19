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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class clientsForm : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;
        private MySqlCommand command_insert = null;
        private MySqlCommand command_insert_user = null;
        private MySqlCommand command_update = null;
        private MySqlCommand command_if = null;
        private MySqlCommand command_delete_user = null;
        private MySqlCommand command_delete = null;
        private MySqlCommand command_filtr = null;
               
        public clientsForm()
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
            for (int i = 0; i < str.Length; i++)
                if (str[0] == 'm' && str[1] == 'a' && str[2] == 'n' && str[3] == 'a' && str[4] == 'g' && str[5] == 'e' && str[6] == 'r')
                {
                    break;
                }
                else if(label1.Text == "1" || label1.Text == "admin")
                {
                    break;
                }
                else
                {
                    добавитьНовыеДанныеToolStripMenuItem.Visible = false;
                    изменитьДанныеToolStripMenuItem.Visible = false;
                    удалитьДанныеToolStripMenuItem.Visible = false;

                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.ReadOnly = true;
                    break;
                }
        }
        private void clientsForm_Load(object sender, EventArgs e)
        {
            Count();            

            db = new DateBase();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты`", db.getConnection());
             
            table = new DataTable();
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        public Boolean if_data_exists_date()
        {
            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapted = new MySqlDataAdapter();
            int index = dataGridView1.SelectedRows[0].Index;

            command_if = new MySqlCommand("SELECT * FROM `клиенты` WHERE `ФИО` = @FIO", db.getConnection());
            command_if.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;

            adapted.SelectCommand = command_if;
            adapted.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный клиент с такими же ФИО уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean if_data_exists_users()
        {
            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapted = new MySqlDataAdapter();
            int index = dataGridView1.SelectedRows[0].Index;

            command_if = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @login1", db.getConnection());
            command_if.Parameters.Add("@login1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[7].Value;

            adapted.SelectCommand = command_if;
            adapted.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void перезагрузитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты`", db.getConnection());

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

            if (if_data_exists_date())
                return;

            if (if_data_exists_users())
                return;

            db.openConection();

            command_insert_user = new MySqlCommand("INSERT INTO `пользователи` (`Логин`, `Пароль`) VALUES (@l1, @l2)", db.getConnection());
            command_insert_user.Parameters.Add("@l1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[7].Value;
            command_insert_user.Parameters.Add("@l2", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[8].Value;

            
            command_insert = new MySqlCommand("INSERT INTO `клиенты` (`ФИО`, `Место_проживания`, `Номер_паспорта`, `ИНН`, `Номер_телефона`, `Реквизиты`, `Логин`, `Пароль`) VALUES (@ff1, @ff2, @ff3, @ff4, @ff5, @ff6, @ff7, @ff8)", db.getConnection());
            command_insert.Parameters.Add("@ff1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_insert.Parameters.Add("@ff2", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_insert.Parameters.Add("@ff3", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_insert.Parameters.Add("@ff4", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_insert.Parameters.Add("@ff5", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_insert.Parameters.Add("@ff6", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[6].Value;
            command_insert.Parameters.Add("@ff7", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[7].Value;
            command_insert.Parameters.Add("@ff8", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[8].Value;

            try
            {
                if (command_insert_user.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был зарегестрирован");
                else
                    MessageBox.Show("Oшибка добавления данных");


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

            command_update = new MySqlCommand("UPDATE `клиенты` SET `ФИО` = @f1, `Место_проживания` = @f2, `Номер_паспорта` = @f3, `ИНН` = @f4, `Номер_телефона` = @f5, `Реквизиты` = @f6 WHERE `клиенты`.`ID_клиента` = @f0", db.getConnection());
            command_update.Parameters.Add("@f1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_update.Parameters.Add("@f2", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_update.Parameters.Add("@f3", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_update.Parameters.Add("@f4", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_update.Parameters.Add("@f5", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_update.Parameters.Add("@f6", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[6].Value;
            command_update.Parameters.Add("@f0", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_update.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись была изменена");
                else
                    MessageBox.Show("Oшибка изменения данных");
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

            command_delete = new MySqlCommand("DELETE FROM `клиенты` WHERE `клиенты`.`ID_клиента` = @f0", db.getConnection());
            command_delete.Parameters.Add("@f0", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[0].Value;

            command_delete_user = new MySqlCommand("DELETE FROM `пользователи` WHERE `пользователи`.`Логин` = @ff0", db.getConnection());
            command_delete_user.Parameters.Add("@ff0", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[7].Value;

            try
            {
                if (command_delete.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт клиента был удалён");
                else
                    MessageBox.Show("Oшибка удаления аккаунта");


                if (command_delete_user.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись клиента была удалена");
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
                
        private void очиститьФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты`", db.getConnection());

            table = new DataTable();
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void номерПаспортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Номер_паспорта` IS NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void иННToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `ИНН` IS NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }


        private void фИОToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `ФИО` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void местоПроживанияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Место_проживания` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void номерПаспортаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Номер_паспорта` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void иННToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `ИНН` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void номерТелефонаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Номер_телефона` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void реквизитыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Реквизиты` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void логинToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Логин` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void парольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT * FROM `клиенты` WHERE `Пароль` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void отчётПоДаннойТаблицеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            System.Diagnostics.Process.Start(@"chrome.exe", "http://127.0.0.1/openserver/phpmyadmin/tbl_export.php?db=bd_tv_services&table=клиенты&single_table=true");
        }

        private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}