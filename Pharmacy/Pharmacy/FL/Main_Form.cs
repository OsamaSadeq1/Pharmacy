using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace Pharmacy.FL
{
    
    public partial class Main_Form : Form
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




        public Main_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchasesBtn();
        }
        public void PurchasesBtn()
        {
            Buy_Drugs_btn.Visible = true;
            Update_Deals_btn.Visible = true;
            All_Deals_btn.Visible=true;

            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;

        }

        public void DurgsBtn()
        {
            Add_Drug_btn.Visible = true;
            Delete_Drug_btn.Visible=true;
            Update_Drug_btn.Visible = true;
            Search_Drug_btn.Visible =true;
            Move_Drug_btn.Visible = true;
            Drug_List_btn.Visible = true;


            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }
        public void SalesBtn()
        {
            Sales_All_btn.Visible = true;
            Shift_Sales_btn.Visible = true;
            Rettieval_Drug_btn.Visible = true;


            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Drug_List_btn.Visible = false;
            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }
        public void CompanyBtn()
        {
            New_Company_btn.Visible = true;
            End_With_btn.Visible = true;
            Updates_com_btn.Visible = true;

            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }
        public void UsersBtn()
        {
            Add_User_btn.Visible = true;
            Delete_User_btn.Visible = true;
            Update_User_btn.Visible = true;

            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }
        public void SettingBtn()
        {
            Login_Details_btn.Visible = true;
            Change_Password_btn.Visible = true;
            Logout_btn.Visible = true;

            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;            
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }

        private void Back_p_Click(object sender, EventArgs e)
        {
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            SalesBtn();
        }

        private void Company_btn_Click(object sender, EventArgs e)
        {
            CompanyBtn();
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            UsersBtn();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SettingBtn();
        }

        private void Durgs_btn_Click(object sender, EventArgs e)
        {
            DurgsBtn();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Main_Form_Click(object sender, EventArgs e)
        {
            Login_Details_btn.Visible = false;
            Change_Password_btn.Visible = false;
            Logout_btn.Visible = false;
            New_Company_btn.Visible = false;
            End_With_btn.Visible = false;
            Updates_com_btn.Visible = false;
            Add_Drug_btn.Visible = false;
            Delete_Drug_btn.Visible = false;
            Update_Drug_btn.Visible = false;
            Search_Drug_btn.Visible = false;
            Move_Drug_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Drug_List_btn.Visible = false;
            Sales_All_btn.Visible = false;
            Shift_Sales_btn.Visible = false;
            Rettieval_Drug_btn.Visible = false;
            Add_User_btn.Visible = false;
            Delete_User_btn.Visible = false;
            Update_User_btn.Visible = false;
            Buy_Drugs_btn.Visible = false;
            Update_Deals_btn.Visible = false;
            All_Deals_btn.Visible = false;
        }
    }
}
