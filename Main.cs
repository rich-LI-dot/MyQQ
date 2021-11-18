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
using Aptech.UI;//引入命明空间

namespace MyQQ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private static Main main;
        public static Main getinref()
        {
            if (main == null || main.IsDisposed == true)
            {
                main = new Main();
            }
            return main;
        }//单例方法
        private void Main_Load(object sender, EventArgs e)//加载事件
        {
            GetMessage();

            GetFriends();
        }
        private void GetMessage()//获取信息
        {
            SqlCommand Cmd;
            SqlDataAdapter Sda;
            DataTable Dt;
            try
            {
                using (SqlConnection Conn = new SqlConnection(DBHelper.Connstr))
                {
                    Conn.Open();
                    string Sql = "select * from users where id='" + UserHelper.UseerId + "' ";
                    Sda = new SqlDataAdapter(Sql, Conn);
                    Dt = new DataTable();
                    Sda.Fill(Dt);
                    User_Name.Text = Dt.Rows[0][3].ToString();//用户昵称
                    Via.BackgroundImage = Face.Images[(int)Dt.Rows[0][4]];//用户头像
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message + "", "提示");

            }


        }
        private void GetFriends()//获取好友列表
        {
            SqlCommand Cmd;
            SqlDataAdapter Sda;
            DataTable Dt;

            sideBar1.AddGroup("我的好友");
            sideBar1.AddGroup("陌生人");
            try
            {
                using (SqlConnection Conn = new SqlConnection(DBHelper.Connstr))
                {
                    Conn.Open();
                    string Sql = "select FriendId,NickName,FaceId from users ,Friends where  Friends.HostId='" + UserHelper.UseerId + "'and  users.Id=Friends.FriendId";
                    //Cmd = new SqlCommand(Sql, Conn);
                    Sda = new SqlDataAdapter(Sql, Conn);
                    Dt = new DataTable();
                    Sda.Fill(Dt);
                    for (int i = 0; i < Dt.Rows.Count; i++)//循环把添加好友项
                    {
                        SbItem item = new SbItem((String)Dt.Rows[i][1],(int)Dt.Rows[i][2]);
                        sideBar1.Groups[0].Items.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("错误：" + ex.Message + "", "提示");
            }


        }
        private void Button_MouseEnter(object sender, EventArgs e)//当鼠标移动到按钮上时提示功能信息
        {

            ShowMessage.SetToolTip(((Button)sender), "" + Convert.ToString(((Button)sender).Tag) + "");
        }

        private void Quit_Click(object sender, EventArgs e)//退出按钮
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }//关闭时退出程序
    }
}
