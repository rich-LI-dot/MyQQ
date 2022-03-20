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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private static Register register;
        public static Register getinref()
        {
            if (register == null || register.IsDisposed == true)
            {
                register = new Register();
            }
            return register;
        }//单例模式
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable db;
        string sex = "";
        private void Register_Load(object sender, EventArgs e)
        {
          
            GetStar();
            GetBloodtype();

        }//加载界面
        private void GetStar()//星座绑定下拉框
        {
            try
            {
                using (conn = new SqlConnection(DBHelper.Connstr))
                {
                    string sql = "select * from star ";
                    sda = new SqlDataAdapter(sql, conn);
                    db = new DataTable();
                    sda.Fill(db);
                    this.star.DataSource = db;
                    this.star.DisplayMember = "star";
                    this.star.ValueMember = "id";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message + "");

            }
            star.SelectedIndex = -1;//设置下拉框没有显示内容
        }
        private void GetBloodtype()//血型绑定下拉框
        {
            try
            {
                using (conn = new SqlConnection(DBHelper.Connstr))
                {
                    string sql = "select * from bloodtype";
                    sda = new SqlDataAdapter(sql, conn);
                    db = new DataTable();
                    sda.Fill(db);
                    this.bloodType.DataSource = db;
                    this.bloodType.DisplayMember = "bloodtype";
                    this.bloodType.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("错误：" + ex.Message + "");
            }
            bloodType.SelectedIndex = -1;//设置下拉框没有显示内容
        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)//关闭时返回登录界面
        {
            //Login login = Login.getinref();
            //login.Show();
        }
        private void cancell_Click(object sender, EventArgs e)//取消注册时返回登录界面
        {
            //Login login = Login.getinref();
            //login.Show();
            this.Close();
            //Login.Conceal();
        }
        private bool cheekNull()//检查是否填写信息
        {
            bool isok = false;
          
            if (user_name==null||user_name.Text=="")
            {
                MessageBox.Show("请输入昵称！！");
                isok = false;
                this.user_name.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (user_age==null||user_age.Text=="")
            {
                MessageBox.Show("请输入年龄！！");
                isok = false;
                this.user_age.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (user_pwd1==null||user_pwd1.Text=="")
            {
                MessageBox.Show("请输入密码！！");
                isok = false;
                this.user_pwd1.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (user_realName==null||user_realName.Text=="")
            {
                MessageBox.Show("请输入真实姓名！！");
                isok = false;
                this.user_realName.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (user_pwd2.Text!=user_pwd1.Text)
            {
                MessageBox.Show("请输入相同的密码！！");
                isok = false;
                this.user_pwd2.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (man.Checked)
            {
                sex = "男";
                isok = true;
            }
            else if (gril.Checked)
            {
                sex = "女";
                isok = true;
            }
            else
            {
                MessageBox.Show("请选择性别!!");
                isok = false;
                this.man.Focus();
                return isok;
            }
            if (star.SelectedIndex==-1)
            {
                MessageBox.Show("请选择星座!!");
                isok = false;
                this.star.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            if (bloodType.SelectedIndex==-1)
            {
                MessageBox.Show("请选择血型!!");
                isok = false;
                this.bloodType.Focus();
                return isok;
            }
            else
            {
                isok = true;
            }
            return isok;
        }
        private void SetRegister()//向数据库插入注册信息
        {
            try
            {
                using (conn = new SqlConnection(DBHelper.Connstr))
                {
                    conn.Open();
                    string sql = "insert into users (loginpwd,NickName,Sex,Age,Name,StarId,BloodTypeId)" +
                        " values('" + user_pwd2.Text.Trim() + "','" + user_name.Text.Trim() + "','"+sex+"'," +
                        "'"+user_age.Text.Trim() + "','"+user_realName.Text.Trim() + "','"+this.star.SelectedValue.ToString()+"'," +
                        "'"+this.bloodType.SelectedValue.ToString()+"')";
                    cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        string sql1 = "select id from users where name='"+user_realName.Text+"' and nickname='"+user_name.Text+"'";
                        sda = new SqlDataAdapter(sql1,conn);
                        db = new DataTable();
                        sda.Fill(db);
                        MessageBox.Show("注册成功你的\n账号为："+db.Rows[0][0].ToString()+"\n密码："+user_pwd2.Text+"");


                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message + "");

            }
        }
        private void regist_Click(object sender, EventArgs e)//点击注册
        {
            if (cheekNull())
            {
                SetRegister();
                
            }
        }
    }
}
