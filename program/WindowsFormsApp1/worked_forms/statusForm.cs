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
    public partial class statusForm : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;

        public statusForm()
        {
            InitializeComponent();
        }

        private void statusForm_Load(object sender, EventArgs e)
        {
            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `статус_заказа`", db.getConnection());
            table = new DataTable();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            adapted.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConection();
        }
    }
}
