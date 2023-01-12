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

namespace Football_Manager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите Фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (loginField.Text == "")
            {
                MessageBox.Show("Придумайте логин!");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("Придумайте пароль!");
                return;
            }

            if (IsUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `players` (`login`, `password`, `name`, `surname`) VALUES (@login,@password,@name,@surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text ;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан!");
            else
                MessageBox.Show("Аккаунт не был создан!");

            db.closeConnection();
        }

        public Boolean IsUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `players` WHERE `login`= @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин существует, введите другой!");
                return true;
            }
            else
                return false;
        }

        private void RegisterLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}

