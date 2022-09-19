using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string User_save
        {
            get { return label_user.Text; }
            set { label_user.Text = value; }
        }

        private void информацияОКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтвердить выход из приложения?", "Выход из приложения", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
               
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            clientsForm clientsForm = new clientsForm();
            clientsForm.User_save = label_user.Text;
            clientsForm.Show();                  
        }

        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managersForm managersForm = new managersForm();
            managersForm.User_save = label_user.Text;
            managersForm.Show();
        }

        private void рабочиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workersForm workersForm = new workersForm();
            workersForm.User_save = label_user.Text;
            workersForm.Show();
        }

        private void специализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workers_specz_Form workers_specz_Form = new workers_specz_Form();
            workers_specz_Form.User_save = label_user.Text;
            workers_specz_Form.Show();
        }

        private void материалыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            materialForm materialForm = new materialForm();
            materialForm.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicesForm servicesForm = new servicesForm();
            servicesForm.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.User_save = label_user.Text;
            ordersForm.Show();
        }

        private void работыПоЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            works_of_ordersForm works_of_ordersForm = new works_of_ordersForm();
            works_of_ordersForm.Show();
        }

        private void статусыЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusForm statusForm = new statusForm();
            statusForm.Show();
        }


        Point LastPoint;
        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        public void Count()
        {
            
            string str = User_save;
            for (int i = 0; i < str.Length; i++)
                if (str[0] == 'm' && str[1] == 'a' && str[2] == 'n' && str[3] == 'a' && str[4] == 'g' && str[5] == 'e' && str[6] == 'r' || str[0] == 'w' && str[1] == 'o' && str[2] == 'r' && str[3] == 'k' && str[4] == 'i' && str[5] == 'n' && str[6] == 'g')
                {
                    MessageBox.Show(
                    "Вы вошли в приложения со статусом #Сотрудник",
                    "Статус пользователя",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                }            
                else if (label_user.Text == "admin" || label_user.Text == "1")
                {
                    MessageBox.Show(
                            "Вы вошли в приложения со статусом #Администратор",
                            "Статус пользователя",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    MessageBox.Show(
                    "Вы вошли в приложения со статусом #Клиент",
                    "Статус пользователя",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    дополнительнаяИнформацияToolStripMenuItem.Visible = false;
                    таблицыДляРаботыToolStripMenuItem.Visible = false;
                    break;
                }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {            
            Count();
            if (label_user.Text == "1" || label_user.Text == "admin")
            {

            }
            else
                создатьОтчетВручнуюToolStripMenuItem.Visible = false;
        }

        private void создатьОтчетВручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            System.Diagnostics.Process.Start(@"chrome.exe", "http://127.0.0.1/openserver/phpmyadmin/db_structure.php?server=1&db=bd_tv_services");
        }
    }
}
