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

namespace Pharmacy.FL
{
    public partial class Login1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        Message_Of_Login x = new Message_Of_Login();
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public Login1()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1030, 547, 25, 25));

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            DataTable dt = log.login(textID.Text,textPWD.Text);
            if (dt.Rows.Count > 0)
            {
                x.Show();
            }
            else MessageBox.Show("Login Failed");
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPWD_TextChanged(object sender, EventArgs e)
        {
            pass_la.Visible = false;
        }

        private void textPWD_Click(object sender, EventArgs e)
        {

        }

        private void textPWD_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
