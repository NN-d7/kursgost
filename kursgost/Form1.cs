using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kursgost
{
    public partial class Form1 : Form
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



        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));



        }



        //кодировка меню навигации
        private void botnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = botnDashboard.Height;
            pnlNav.Top = botnDashboard.Top;
            pnlNav.Left = botnDashboard.Left;
            botnDashboard.BackColor = Color.FromArgb(0, 128, 128);

        }

        private void botnAnalitycs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = botnAnalitycs.Height;
            pnlNav.Top = botnAnalitycs.Top;
            pnlNav.Left = botnAnalitycs.Left;
            botnAnalitycs.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void bontCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = bontCalendar.Height;
            pnlNav.Top = bontCalendar.Top;
            pnlNav.Left = bontCalendar.Left;
            bontCalendar.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Contact.Height;
            pnlNav.Top = Contact.Top;
            pnlNav.Left = Contact.Left;
            Contact.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void Setings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Setings.Height;
            pnlNav.Top = Setings.Top;
            pnlNav.Left = Setings.Left;
            Setings.BackColor = Color.FromArgb(0, 128, 128);
        }
        //редактируем события для конопок
        private void botnDashboard_Leave(object sender, EventArgs e)
        {
            botnDashboard.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void botnAnalitycs_Leave(object sender, EventArgs e)
        {
            botnAnalitycs.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void bontCalendar_Leave(object sender, EventArgs e)
        {
            bontCalendar.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void Contact_Leave(object sender, EventArgs e)
        {
            Contact.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void Setings_Leave(object sender, EventArgs e)
        {
            Setings.BackColor = Color.FromArgb(47, 79, 79);

        }



    }
}
