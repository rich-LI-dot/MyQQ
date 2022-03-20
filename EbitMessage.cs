using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class EbitMessage : Form
    {
        public EbitMessage()
        {
            InitializeComponent();
        }

        private void EbitMessage_Load(object sender, EventArgs e)
        {
            info.Show();
            ebitpassword.Visible = false;
            try
            {
                using (SqlConnection conn=new SqlConnection(DBHelper.Connstr))
                {
                    conn.Open();
                    string sql = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message + "", "提示");

            }
        }

        private void SecuritySettings_Click(object sender, EventArgs e)
        {
            info.Visible = false;
            ebitpassword.Show();
            SecuritySettings.BackgroundImage = Image.FromFile("MyQQ.Properties.Resources.SecurityClick");
        }

        private void PersonalData_Click(object sender, EventArgs e)
        {
            info.Show();
            ebitpassword.Visible = false;
            PersonalData.BackgroundImage = Image.FromFile("MyQQ.Properties.Resources.BaseInfoClick");
        }

        private void change_Click(object sender, EventArgs e)
        {
            Facefrom facefrom = new Facefrom();
            facefrom.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
