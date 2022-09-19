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
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            loginRegistField.Text = "Введиет логин";
            passRegistField.Text = "Введиет пароль";
            passRegistFieldReturn.Text = "Подтвердите пароль";
            passRegistField.Multiline = true;
            passRegistFieldReturn.Multiline = true;
            loginRegistField.ForeColor = Color.Gray;
            passRegistField.ForeColor = Color.Gray;
            passRegistFieldReturn.ForeColor = Color.Gray;

            this.passRegistField.Size = new Size(this.passRegistField.Size.Width, 42);
            this.passRegistField.AutoSize = false;

            this.passRegistFieldReturn.Size = new Size(this.passRegistField.Size.Width, 42);
            this.passRegistFieldReturn.AutoSize = false;

            this.loginRegistField.Size = new Size(this.loginRegistField.Size.Width, 42);
            this.loginRegistField.AutoSize = false;
        }

        private void OutClickButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void OutClickButton_MouseEnter_1(object sender, EventArgs e)
        {
            OutClickButton.Font = new Font("OutClickButton", 20, FontStyle.Regular);
        }

        private void OutClickButton_MouseLeave_1(object sender, EventArgs e)
        {
            OutClickButton.Font = new Font("OutClickButton", 15, FontStyle.Regular);
        }

        Point LastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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

        private void loginRegistField_Enter(object sender, EventArgs e)
        {
            if (loginRegistField.Text == "Введиет логин")
            {
                loginRegistField.Text = "";
                loginRegistField.ForeColor = Color.Black;
            }
        }

        private void loginRegistField_Leave(object sender, EventArgs e)
        {
            if (loginRegistField.Text == "")
            {
                loginRegistField.Text = "Введиет логин";
                loginRegistField.ForeColor = Color.Gray;
            }
        }

        private void passRegistField_Enter(object sender, EventArgs e)
        {
            if (passRegistField.Text == "Введиет пароль")
            {
                passRegistField.Text = "";
                passRegistField.Multiline = false;
                passRegistField.ForeColor = Color.Black;
            }
        }

        private void passRegistField_Leave(object sender, EventArgs e)
        {
            if (passRegistField.Text == "")
            {
                passRegistField.Text = "Введиет пароль";
                passRegistField.Multiline = true;
                passRegistField.ForeColor = Color.Gray;
            }
        }

        private void passRegistFieldReturn_Leave(object sender, EventArgs e)
        {
            if (passRegistFieldReturn.Text == "")
            {
                passRegistFieldReturn.Text = "Подтвердите пароль";
                passRegistFieldReturn.Multiline = true;
                passRegistFieldReturn.ForeColor = Color.Gray;
            }
        }

        private void passRegistFieldReturn_Enter(object sender, EventArgs e)
        {
            if (passRegistFieldReturn.Text == "Подтвердите пароль")
            {
                passRegistFieldReturn.Text = "";
                passRegistFieldReturn.Multiline = false;
                passRegistFieldReturn.ForeColor = Color.Black;
            }
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (loginRegistField.Text == "Введиет логин")
            {
                MessageBox.Show("Не корректный ввод данных");
                return;
            }

            if (passRegistFieldReturn.Text != passRegistField.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
             
            if (isUsersExists())
                return;

            String loginRegistUser = loginRegistField.Text;
            String passRegistUser = passRegistField.Text;

            DateBase db = new DateBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `пользователи` (`Логин`, `Пароль`) VALUES (@login, @pass)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginRegistField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passRegistField.Text;

            db.openConection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("ошибка создания аккаунта");

            db.closeConection();


            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public Boolean isUsersExists()
        {
            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapted = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginRegistField.Text;

            adapted.SelectCommand = command;
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
    }
}