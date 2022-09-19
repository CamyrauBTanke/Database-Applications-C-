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
    public partial class servicesForm : Form
    {
        private DateBase db = null;
        private DataTable table = null;
        private MySqlDataAdapter adapted = null;
        private MySqlCommand command_insert = null;
        private MySqlCommand command_update = null;
        private MySqlCommand command_if = null;
        private MySqlCommand command_delete = null;

        public servicesForm()
        {
            InitializeComponent();
        }

        private void servicesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            db = new DateBase();
            db.openConection();
            adapted = new MySqlDataAdapter("SELECT * FROM `услуги`", db.getConnection());
            table = new DataTable();

            adapted.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
