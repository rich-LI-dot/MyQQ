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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private static Login login;
        public static Login getinref()
        {
            if (login == null || login.IsDisposed == true)
            {
                login = new Login();
            }
            return login;
        }
        //public static void Conceal()
        //{
        //    this.Show();
        //}
        SqlDataAdapter sda;
        SqlConnection conn;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader dr;
        private void cancell_Click(object sender, EventArgs e)//点击取消按钮退出程序
        {
            Application.Exit();
        }
        private void putInNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//点击申请账号按钮打开申请界面
        {
            Register register = Register.getinref();
            register.Show();
            //this.Hide();
        }
        private void forgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//忘记密码点击事件
        {
            MessageBox.Show("该功能尚未开通！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)//关闭界面退出程序
        {
            Application.Exit();
        }
        private void cheekIput()//检查输入
        {
            long i ;//定义输出变量
            Int64.TryParse(user_id.Text, out i);//tryparse(string s 转换的文本，out 转换后的数值（成功返回数值，失败返回false=0）)判断输入的是不是数字，转换成功i输出为转换后的数字否则为0；
            if (user_id.Text == "" || user_id == null)
            {
                MessageBox.Show("请输入信息", "提示");
            }
            else if (i<=0)//如果小于0，则输入的不是数字；
            {
                MessageBox.Show("请输入你的数字ID", "提示");//提示
                user_id.Clear();//清空
            }
            else
            {

                user_id.Text = i.ToString();//转换成功将i的值赋给user_id;
                try
                {
                    using (conn = new SqlConnection(DBHelper.Connstr))
                    {
                        conn.Open();
                        string sql = "select id,loginpwd from users where id='" + user_id.Text.Trim() + "'";
                        cmd = new SqlCommand(sql, conn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            UserHelper.UseerId = this.user_id.Text;
                            if (user_pwd.Text == "" || user_pwd == null)
                            {
                                MessageBox.Show("请输入密码", "提示");
                                return;
                            }
                            else if (dr[1].ToString() != user_pwd.Text.Trim()) 
                            {
                                MessageBox.Show("密码错误！！");
                                user_pwd.Focus();
                            }
                            else
                            {
                                Main main = Main.getinref();
                                main.Show();
                                main.Text = UserHelper.UseerId;
                                main.MaximizeBox = false;
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("该账户没有注册！！！\n请注册");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("错误：" + ex.Message + "");
                }
            }

        }
        private void sinGo_Click(object sender, EventArgs e)//登录按钮
        {
            cheekIput();
        }
        private void user_id_KeyPress(object sender, KeyPressEventArgs e)//设置输入id时只能输入0~9的数字
        {
            //if (char.IsNumber(e.KeyChar)&&e.KeyChar)
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //    MessageBox.Show("请输入0—9的数字ID","提示：");
            //}

        }

    }
}
