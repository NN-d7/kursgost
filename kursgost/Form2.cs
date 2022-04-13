using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kursgost
{
    public partial class Form2 : Form
    {

        // делаем скошенные края

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //в случае если логин и пароль совпадают с  указанными нами переход на форму 3

            if (textUsername.Text == "admin" && textpassword.Text == "admin")
            {
                new Form3().Show();
                this.Hide(); 
            }



            //иначе вывод сообщения в отдельном окне и очистка полей логина и пароля
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                textUsername.Clear();
                textpassword.Clear();
                textUsername.Focus();
            }
        }


        //очищение полей логина и пароля нажав на label2(сlear fields)
        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textpassword.Clear();
            textUsername.Focus();
        }


        // выход из окна авторизации нажав на label3(EXIT)
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //при нажатии очищаем что написано и меняем цвет на белый ддля вводимых символов
        private void textpassword_Enter(object sender, EventArgs e)
        {
            if (textpassword.Text == "password")
            {
                textpassword.Clear();
                textpassword.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }


        //при нажатии очищаем что написано и меняем цвет на белый ддля вводимых символов
        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "login")
            {
                textUsername.Clear();
                textUsername.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
