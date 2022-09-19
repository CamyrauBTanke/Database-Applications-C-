using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DialogForUser : Form
    {
        public DialogForUser()
        {
            InitializeComponent();
            textBox1.Text = "Введите данные";
            textBox1.ForeColor = Color.Gray;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            clientsForm form = new clientsForm();
            this.Hide();
            form.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите данные")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Введите данные";
            }
        }
    }
}
