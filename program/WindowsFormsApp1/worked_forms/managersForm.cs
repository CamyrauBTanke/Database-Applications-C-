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

namespace WindowsFormsApp1
{
    public partial class managersForm : Form
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

        public managersForm()
        {
            InitializeComponent();
        }

        public string User_save
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void managersForm_Load(object sender, EventArgs e)
        {
            if (label1.Text == "1" || label1.Text == "admin")
            {
                
            }
            else
            {
                добавитьНовыеДанныеToolStripMenuItem.Visible = false;
                изменитьДанныеToolStripMenuItem.Visible = false;
                удалитьДанныеToolStripMenuItem.Visible = false;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
            }

            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `менеджеры`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Boolean if_data_exists_date()
        {
            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapted = new MySqlDataAdapter();
            int index = dataGridView1.SelectedRows[0].Index;

            command_if = new MySqlCommand("SELECT * FROM `менеджеры` WHERE `ФИО` = @FIO", db.getConnection());
            command_if.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;

            adapted.SelectCommand = command_if;
            adapted.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный менеджер с такими же ФИО уже существует");
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
            command_if.Parameters.Add("@login1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;

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
            adapted = new MySqlDataAdapter("SELECT * FROM `менеджеры`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
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
            command_insert_user.Parameters.Add("@l1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_insert_user.Parameters.Add("@l2", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[3].Value;

            command_insert = new MySqlCommand("INSERT INTO `менеджеры` (`ФИО`, `Логин`, `Пароль`) VALUES (@ff1, @ff2, @ff3)", db.getConnection());
            command_insert.Parameters.Add("@ff1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_insert.Parameters.Add("@ff2", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_insert.Parameters.Add("@ff3", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[3].Value;

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

            command_update = new MySqlCommand("UPDATE `менеджеры` SET `ФИО` = @f1 WHERE `менеджеры`.`ID_менеджера` = @f0", db.getConnection());
            command_update.Parameters.Add("@f1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_update.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_update.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись менеджера была обновлена");
                else
                    MessageBox.Show("Oшибка обновления данных");
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

            command_delete = new MySqlCommand("DELETE FROM `менеджеры` WHERE `менеджеры`.`ID_менеджера` = @f0", db.getConnection());
            command_delete.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            command_delete_user = new MySqlCommand("DELETE FROM `пользователи` WHERE `пользователи`.`Логин` = @ff0", db.getConnection());
            command_delete_user.Parameters.Add("@ff0", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[2].Value;

            try
            {
                if (command_delete.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт менеджера был удалён");
                else
                    MessageBox.Show("Oшибка удаления аккаунта");

                if (command_delete_user.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись менеджера была удалена");
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
    }
}