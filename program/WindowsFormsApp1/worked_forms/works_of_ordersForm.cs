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
    public partial class works_of_ordersForm : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;
        private MySqlCommand command_insert = null;
        private MySqlCommand command_update = null;
        private MySqlCommand command_delete = null;

        public works_of_ordersForm()
        {
            InitializeComponent();
        }

        private void works_of_ordersForm_Load(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `работы_по_заказу`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void перезагрузитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `работы_по_заказу`", db.getConnection());
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

            var price_services = dataGridView1.Rows[index].Cells[2];
            var price_material = dataGridView1.Rows[index].Cells[4];
            var price_koll = dataGridView1.Rows[index].Cells[3];
            int material = 1;
            int servis = 1;
            if ((int)price_services.Value == 1)
                servis = 1300;
            if ((int)price_services.Value == 2)
                servis = 1500;
            if ((int)price_services.Value == 3)
                servis = 500;
            if ((int)price_services.Value == 4)
                servis = 1500;
            if ((int)price_services.Value == 5)
                servis = 3500;
            if ((int)price_services.Value == 6)
                servis = 100;
            if ((int)price_material.Value == 1)
                material = 50;
            if ((int)price_material.Value == 2)
                material = 50;
            if ((int)price_material.Value == 3)
                material = 50;
            if ((int)price_material.Value == 4)
                material = 50;
            if ((int)price_material.Value == 5)
                material = 100;
            if ((int)price_material.Value == 6)
                material = 250;

            var price = material * (int)price_koll.Value + servis;

            db.openConection();

            command_insert = new MySqlCommand("INSERT INTO `работы_по_заказу` (`id_заказа`, `id_услуги`, `Количество_материалов`, `id_материала`, `id_специалиста`, `Дата`, `Цена`) VALUES (@ff1, @ff2, @ff3, @ff4, @ff5, @ff6, @ff7)", db.getConnection());
            command_insert.Parameters.Add("@ff1", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_insert.Parameters.Add("@ff2", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_insert.Parameters.Add("@ff3", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_insert.Parameters.Add("@ff4", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_insert.Parameters.Add("@ff5", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_insert.Parameters.Add("@ff6", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[6].Value;
            command_insert.Parameters.Add("@ff7", MySqlDbType.Int16).Value = price;

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

            var price_services = dataGridView1.Rows[index].Cells[2];
            var price_material = dataGridView1.Rows[index].Cells[4];
            var price_koll = dataGridView1.Rows[index].Cells[3];
            int material = 1;
            int servis = 1;
            if ((int)price_services.Value == 1)
                servis = 1300;
            if ((int)price_services.Value == 2)
                servis = 1500;
            if ((int)price_services.Value == 3)
                servis = 500;
            if ((int)price_services.Value == 4)
                servis = 1500;
            if ((int)price_services.Value == 5)
                servis = 3500;
            if ((int)price_services.Value == 6)
                servis = 100;
            if ((int)price_material.Value == 1)
                material = 50;
            if ((int)price_material.Value == 2)
                material = 50;
            if ((int)price_material.Value == 3)
                material = 50;
            if ((int)price_material.Value == 4)
                material = 50;
            if ((int)price_material.Value == 5)
                material = 100;
            if ((int)price_material.Value == 6)
                material = 250;

            var price = material * (int)price_koll.Value + servis;

            command_update = new MySqlCommand("UPDATE `работы_по_заказу` SET `id_заказа` = @f1, `id_услуги` = @f2, `Количество_материалов` = @f3, `id_материала` = @f4, `id_специалиста` = @f5, `Дата` = @f6, `Цена` = @f7 WHERE `работы_по_заказу`.`ID_работ` = @f0", db.getConnection());
            command_update.Parameters.Add("@f1", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[1].Value;
            command_update.Parameters.Add("@f2", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[2].Value;
            command_update.Parameters.Add("@f3", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[3].Value;
            command_update.Parameters.Add("@f4", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[4].Value;
            command_update.Parameters.Add("@f5", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[5].Value;
            command_update.Parameters.Add("@f6", MySqlDbType.Date).Value = dataGridView1.Rows[index].Cells[6].Value;
            command_update.Parameters.Add("@f7", MySqlDbType.Int16).Value = price;
            command_update.Parameters.Add("@f0", MySqlDbType.Int16).Value = dataGridView1.Rows[index].Cells[0].Value;

            try
            {
                if (command_update.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись была обновлена");
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

            command_delete = new MySqlCommand("DELETE FROM `работы_по_заказу` WHERE `работы_по_заказу`.`ID_работ` = @f0", db.getConnection());
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

        private void поискПоСпециалистуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void акимовИванАлексеевичToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_специалиста` = 1", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_специалиста` = 2", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void кульковДанилИвановичToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_специалиста` = 3", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void подключениеТелефонияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 1", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void подключениеТВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 2", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void установкаТКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 3", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void подключениеТКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 4", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void монтажИЗапускТКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 5", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу` WHERE `id_услуги` = 6", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void очиститьФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT* FROM `работы_по_заказу`", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();
        }

        private void общаяСуммаВыполненныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            db = new DateBase();

            table.Clear();
            db.openConection();

            adapted = new MySqlDataAdapter("SELECT MIN(`работы_по_заказу`.`Дата`) AS Начало_работ, MAX(`работы_по_заказу`.`Дата`) AS Конец_работ, COUNT(`работы_по_заказу`.`ID_работ`) AS Вcего_выполненных_работ, SUM(`работы_по_заказу`.`Цена`) AS Всего, `работы_по_заказу`.`Валюта` FROM `работы_по_заказу` WHERE `работы_по_заказу`.`Дата` IS NOT NULL", db.getConnection());
            adapted.Fill(table);
            dataGridView1.DataSource = table;

            db.closeConection();    
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            System.Diagnostics.Process.Start(@"chrome.exe", "http://127.0.0.1/openserver/phpmyadmin/tbl_export.php?db=bd_tv_services&table=работы_по_заказу&single_table=true");
        }
    }
}