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
    public partial class workers_specz_Form : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;
        private MySqlCommand command_insert = null;
        private MySqlCommand command_update = null;
        private MySqlCommand command_if = null;
        private MySqlCommand command_delete = null;

        public workers_specz_Form()
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
                else if (label1.Text == "1" || label1.Text == "admin")
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
        private void workers_specz_Form_Load(object sender, EventArgs e)
        {
            Count();

            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `специализация`", db.getConnection());
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

            command_if = new MySqlCommand("SELECT * FROM `специализация` WHERE `Специализация` = @F", db.getConnection());
            command_if.Parameters.Add("@F", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;

            adapted.SelectCommand = command_if;
            adapted.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данная специализация с таким же наименованием уже существует");
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
            adapted = new MySqlDataAdapter("SELECT * FROM `специализация`", db.getConnection());
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

            db.openConection();

            command_insert = new MySqlCommand("INSERT INTO `специализация` (`Специализация`) VALUES (@ff1)", db.getConnection());
            command_insert.Parameters.Add("@ff1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;

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

            command_update = new MySqlCommand("UPDATE `специализация` SET `Специализация` = @f1 WHERE `специализация`.`ID_специализации` = @f0", db.getConnection());
            command_update.Parameters.Add("@f1", MySqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_update.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_update.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись специализации была обновлена");
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

            command_delete = new MySqlCommand("DELETE FROM `специализация` WHERE `специализация`.`ID_специализации` = @f0", db.getConnection());
            command_delete.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_delete.ExecuteNonQuery() == 1)
                    MessageBox.Show("Специализация была удалена");
                else
                    MessageBox.Show("Oшибка удаления специализации");
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
