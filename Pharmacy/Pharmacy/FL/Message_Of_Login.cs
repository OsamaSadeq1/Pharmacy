using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.FL
{
    
    public partial class Message_Of_Login : Form
    {
        Main_Form main = new Main_Form();
        public Message_Of_Login()
        {

            InitializeComponent();
        }

        private void Message_Of_Login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}
