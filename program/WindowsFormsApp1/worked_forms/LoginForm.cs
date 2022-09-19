using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            passField.Multiline = true;
            loginField.Text = "Введиет логин";
            passField.Text = "Введиет пароль";

            this.passField.Size = new Size(this.passField.Size.Width, 42);
            this.passField.AutoSize = false;

            this.loginField.Size = new Size(this.loginField.Size.Width, 42);
            this.loginField.AutoSize = false;
        }


        private void OutClickButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OutClickButton_MouseEnter(object sender, EventArgs e)
        {
            OutClickButton.Font = new Font("OutClickButton", 20, FontStyle.Regular);
        }

        private void OutClickButton_MouseLeave(object sender, EventArgs e)
        {
            OutClickButton.Font = new Font("OutClickButton", 15, FontStyle.Regular);
        }



        Point LastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapted = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL AND `Пароль` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapted.SelectCommand = command;
            adapted.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.User_save = this.loginField.Text;            
                mainForm.Show();
            }
            else
                MessageBox.Show("Ошибка авторизации");
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistForm newForm = new RegistForm();
            newForm.Show();
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введиет логин")
            {
                loginField.ForeColor = Color.Black;
                loginField.Text = "";
            }
               
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введиет логин";
                loginField.ForeColor = Color.Gray;
            }
        
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введиет пароль";
                passField.Multiline = true;
                passField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введиет пароль")
            {
                passField.Text = "";
                passField.Multiline = false;
                passField.ForeColor = Color.Black;
            }
        }
    }
}