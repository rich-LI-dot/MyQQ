
namespace MyQQ
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.user_pwd = new System.Windows.Forms.TextBox();
            this.sinGo = new System.Windows.Forms.Button();
            this.cancell = new System.Windows.Forms.Button();
            this.putInNumber = new System.Windows.Forms.LinkLabel();
            this.forgetPwd = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(60, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Myqq号码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(60, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Myqq密码：";
            // 
            // user_id
            // 
            this.user_id.BackColor = System.Drawing.Color.SlateGray;
            this.user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_id.Location = new System.Drawing.Point(213, 210);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(279, 35);
            this.user_id.TabIndex = 2;
            this.user_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_id_KeyPress);
            // 
            // user_pwd
            // 
            this.user_pwd.BackColor = System.Drawing.Color.SlateGray;
            this.user_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pwd.Location = new System.Drawing.Point(213, 317);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.PasswordChar = '*';
            this.user_pwd.Size = new System.Drawing.Size(279, 35);
            this.user_pwd.TabIndex = 3;
            // 
            // sinGo
            // 
            this.sinGo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sinGo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sinGo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sinGo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sinGo.Location = new System.Drawing.Point(413, 482);
            this.sinGo.Name = "sinGo";
            this.sinGo.Size = new System.Drawing.Size(149, 44);
            this.sinGo.TabIndex = 4;
            this.sinGo.Text = "登录";
            this.sinGo.UseVisualStyleBackColor = false;
            this.sinGo.Click += new System.EventHandler(this.sinGo_Click);
            // 
            // cancell
            // 
            this.cancell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancell.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancell.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cancell.Location = new System.Drawing.Point(600, 482);
            this.cancell.Name = "cancell";
            this.cancell.Size = new System.Drawing.Size(149, 44);
            this.cancell.TabIndex = 5;
            this.cancell.Text = "取消";
            this.cancell.UseVisualStyleBackColor = false;
            this.cancell.Click += new System.EventHandler(this.cancell_Click);
            // 
            // putInNumber
            // 
            this.putInNumber.AutoSize = true;
            this.putInNumber.BackColor = System.Drawing.Color.Transparent;
            this.putInNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.putInNumber.Location = new System.Drawing.Point(565, 221);
            this.putInNumber.Name = "putInNumber";
            this.putInNumber.Size = new System.Drawing.Size(110, 24);
            this.putInNumber.TabIndex = 6;
            this.putInNumber.TabStop = true;
            this.putInNumber.Text = "申请号码";
            this.putInNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.putInNumber_LinkClicked);
            // 
            // forgetPwd
            // 
            this.forgetPwd.AutoSize = true;
            this.forgetPwd.BackColor = System.Drawing.Color.Transparent;
            this.forgetPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgetPwd.Location = new System.Drawing.Point(565, 328);
            this.forgetPwd.Name = "forgetPwd";
            this.forgetPwd.Size = new System.Drawing.Size(110, 24);
            this.forgetPwd.TabIndex = 7;
            this.forgetPwd.TabStop = true;
            this.forgetPwd.Text = "忘记密码";
            this.forgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPwd_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 549);
            this.Controls.Add(this.forgetPwd);
            this.Controls.Add(this.putInNumber);
            this.Controls.Add(this.cancell);
            this.Controls.Add(this.sinGo);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox user_pwd;
        private System.Windows.Forms.Button sinGo;
        private System.Windows.Forms.Button cancell;
        private System.Windows.Forms.LinkLabel putInNumber;
        private System.Windows.Forms.LinkLabel forgetPwd;
    }
}