
namespace MyQQ
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Via = new System.Windows.Forms.PictureBox();
            this.User_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.SystemMessage = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.FindFriend = new System.Windows.Forms.Button();
            this.EditMessage = new System.Windows.Forms.Button();
            this.sideBar1 = new Aptech.UI.SideBar();
            this.Face = new System.Windows.Forms.ImageList(this.components);
            this.ShowMessage = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Via)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Via
            // 
            this.Via.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Via.Location = new System.Drawing.Point(29, 32);
            this.Via.Name = "Via";
            this.Via.Size = new System.Drawing.Size(74, 74);
            this.Via.TabIndex = 2;
            this.Via.TabStop = false;
            // 
            // User_Name
            // 
            this.User_Name.BackColor = System.Drawing.Color.Transparent;
            this.User_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_Name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.User_Name.Location = new System.Drawing.Point(150, 55);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(318, 59);
            this.User_Name.TabIndex = 3;
            this.User_Name.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.SystemMessage);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.FindFriend);
            this.panel1.Controls.Add(this.EditMessage);
            this.panel1.Location = new System.Drawing.Point(0, 908);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 68);
            this.panel1.TabIndex = 5;
            // 
            // Quit
            // 
            this.Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quit.BackgroundImage")));
            this.Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quit.Location = new System.Drawing.Point(260, 13);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(59, 54);
            this.Quit.TabIndex = 4;
            this.Quit.Tag = "退出";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            // 
            // SystemMessage
            // 
            this.SystemMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemMessage.BackgroundImage")));
            this.SystemMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SystemMessage.Location = new System.Drawing.Point(195, 13);
            this.SystemMessage.Name = "SystemMessage";
            this.SystemMessage.Size = new System.Drawing.Size(59, 54);
            this.SystemMessage.TabIndex = 3;
            this.SystemMessage.Tag = "消息";
            this.SystemMessage.UseVisualStyleBackColor = true;
            this.SystemMessage.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refresh.Location = new System.Drawing.Point(130, 13);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(59, 54);
            this.Refresh.TabIndex = 2;
            this.Refresh.Tag = "刷新列表";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            // 
            // FindFriend
            // 
            this.FindFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindFriend.BackgroundImage")));
            this.FindFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FindFriend.Location = new System.Drawing.Point(65, 13);
            this.FindFriend.Name = "FindFriend";
            this.FindFriend.Size = new System.Drawing.Size(59, 54);
            this.FindFriend.TabIndex = 1;
            this.FindFriend.Tag = "查找好友";
            this.FindFriend.UseVisualStyleBackColor = true;
            this.FindFriend.Click += new System.EventHandler(this.FindFriend_Click);
            this.FindFriend.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            // 
            // EditMessage
            // 
            this.EditMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditMessage.BackgroundImage")));
            this.EditMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditMessage.Location = new System.Drawing.Point(0, 13);
            this.EditMessage.Name = "EditMessage";
            this.EditMessage.Size = new System.Drawing.Size(59, 54);
            this.EditMessage.TabIndex = 0;
            this.EditMessage.Tag = "编辑个人信息";
            this.EditMessage.UseVisualStyleBackColor = true;
            this.EditMessage.Click += new System.EventHandler(this.EditMessage_Click_1);
            this.EditMessage.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            // 
            // sideBar1
            // 
            this.sideBar1.AllowDragItem = false;
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.FlatStyle = Aptech.UI.SbFlatStyle.Normal;
            this.sideBar1.GroupHeaderBackColor = System.Drawing.Color.Gray;
            this.sideBar1.GroupTextColor = System.Drawing.Color.Black;
            this.sideBar1.ImageList = this.Face;
            this.sideBar1.ItemContextMenuStrip = null;
            this.sideBar1.ItemStyle = Aptech.UI.SbItemStyle.PushButton;
            this.sideBar1.ItemTextColor = System.Drawing.Color.White;
            this.sideBar1.Location = new System.Drawing.Point(0, 139);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.RadioSelectedItem = null;
            this.sideBar1.Size = new System.Drawing.Size(523, 776);
            this.sideBar1.TabIndex = 6;
            this.sideBar1.View = Aptech.UI.SbView.LargeIcon;
            this.sideBar1.VisibleGroup = null;
            this.sideBar1.VisibleGroupIndex = -1;
            this.sideBar1.Click += new System.EventHandler(this.sideBar1_Click);
            // 
            // Face
            // 
            this.Face.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Face.ImageStream")));
            this.Face.TransparentColor = System.Drawing.Color.Transparent;
            this.Face.Images.SetKeyName(0, "1.bmp");
            this.Face.Images.SetKeyName(1, "2.bmp");
            this.Face.Images.SetKeyName(2, "3.bmp");
            this.Face.Images.SetKeyName(3, "4.bmp");
            this.Face.Images.SetKeyName(4, "5.bmp");
            this.Face.Images.SetKeyName(5, "6.bmp");
            this.Face.Images.SetKeyName(6, "7.bmp");
            this.Face.Images.SetKeyName(7, "8.bmp");
            this.Face.Images.SetKeyName(8, "9.bmp");
            this.Face.Images.SetKeyName(9, "10.bmp");
            this.Face.Images.SetKeyName(10, "11.bmp");
            this.Face.Images.SetKeyName(11, "12.bmp");
            this.Face.Images.SetKeyName(12, "13.bmp");
            this.Face.Images.SetKeyName(13, "14.bmp");
            this.Face.Images.SetKeyName(14, "15.bmp");
            this.Face.Images.SetKeyName(15, "16.bmp");
            this.Face.Images.SetKeyName(16, "17.bmp");
            this.Face.Images.SetKeyName(17, "18.bmp");
            this.Face.Images.SetKeyName(18, "19.bmp");
            this.Face.Images.SetKeyName(19, "20.bmp");
            this.Face.Images.SetKeyName(20, "21.bmp");
            this.Face.Images.SetKeyName(21, "22.bmp");
            this.Face.Images.SetKeyName(22, "23.bmp");
            this.Face.Images.SetKeyName(23, "24.bmp");
            this.Face.Images.SetKeyName(24, "25.bmp");
            this.Face.Images.SetKeyName(25, "26.bmp");
            this.Face.Images.SetKeyName(26, "27.bmp");
            this.Face.Images.SetKeyName(27, "28.bmp");
            this.Face.Images.SetKeyName(28, "29.bmp");
            this.Face.Images.SetKeyName(29, "30.bmp");
            this.Face.Images.SetKeyName(30, "31.bmp");
            this.Face.Images.SetKeyName(31, "32.bmp");
            this.Face.Images.SetKeyName(32, "33.bmp");
            this.Face.Images.SetKeyName(33, "34.bmp");
            this.Face.Images.SetKeyName(34, "35.bmp");
            this.Face.Images.SetKeyName(35, "36.bmp");
            this.Face.Images.SetKeyName(36, "37.bmp");
            this.Face.Images.SetKeyName(37, "38.bmp");
            this.Face.Images.SetKeyName(38, "39.bmp");
            this.Face.Images.SetKeyName(39, "40.bmp");
            this.Face.Images.SetKeyName(40, "41.bmp");
            this.Face.Images.SetKeyName(41, "42.bmp");
            this.Face.Images.SetKeyName(42, "43.bmp");
            this.Face.Images.SetKeyName(43, "44.bmp");
            this.Face.Images.SetKeyName(44, "45.bmp");
            this.Face.Images.SetKeyName(45, "46.bmp");
            this.Face.Images.SetKeyName(46, "47.bmp");
            this.Face.Images.SetKeyName(47, "48.bmp");
            this.Face.Images.SetKeyName(48, "49.bmp");
            this.Face.Images.SetKeyName(49, "50.bmp");
            this.Face.Images.SetKeyName(50, "51.bmp");
            this.Face.Images.SetKeyName(51, "52.bmp");
            this.Face.Images.SetKeyName(52, "53.bmp");
            this.Face.Images.SetKeyName(53, "54.bmp");
            this.Face.Images.SetKeyName(54, "55.bmp");
            this.Face.Images.SetKeyName(55, "56.bmp");
            this.Face.Images.SetKeyName(56, "57.bmp");
            this.Face.Images.SetKeyName(57, "58.bmp");
            this.Face.Images.SetKeyName(58, "59.bmp");
            this.Face.Images.SetKeyName(59, "60.bmp");
            this.Face.Images.SetKeyName(60, "61.bmp");
            this.Face.Images.SetKeyName(61, "62.bmp");
            this.Face.Images.SetKeyName(62, "63.bmp");
            this.Face.Images.SetKeyName(63, "64.bmp");
            this.Face.Images.SetKeyName(64, "65.bmp");
            this.Face.Images.SetKeyName(65, "66.bmp");
            this.Face.Images.SetKeyName(66, "67.bmp");
            this.Face.Images.SetKeyName(67, "68.bmp");
            this.Face.Images.SetKeyName(68, "69.bmp");
            this.Face.Images.SetKeyName(69, "70.bmp");
            this.Face.Images.SetKeyName(70, "71.bmp");
            this.Face.Images.SetKeyName(71, "72.bmp");
            this.Face.Images.SetKeyName(72, "73.bmp");
            this.Face.Images.SetKeyName(73, "74.bmp");
            this.Face.Images.SetKeyName(74, "75.bmp");
            this.Face.Images.SetKeyName(75, "76.bmp");
            this.Face.Images.SetKeyName(76, "77.bmp");
            this.Face.Images.SetKeyName(77, "78.bmp");
            this.Face.Images.SetKeyName(78, "79.bmp");
            this.Face.Images.SetKeyName(79, "80.bmp");
            this.Face.Images.SetKeyName(80, "81.bmp");
            this.Face.Images.SetKeyName(81, "82.bmp");
            this.Face.Images.SetKeyName(82, "83.bmp");
            this.Face.Images.SetKeyName(83, "84.bmp");
            this.Face.Images.SetKeyName(84, "85.bmp");
            this.Face.Images.SetKeyName(85, "86.bmp");
            this.Face.Images.SetKeyName(86, "87.bmp");
            this.Face.Images.SetKeyName(87, "88.bmp");
            this.Face.Images.SetKeyName(88, "89.bmp");
            this.Face.Images.SetKeyName(89, "90.bmp");
            this.Face.Images.SetKeyName(90, "91.bmp");
            this.Face.Images.SetKeyName(91, "92.bmp");
            this.Face.Images.SetKeyName(92, "93.bmp");
            this.Face.Images.SetKeyName(93, "94.bmp");
            this.Face.Images.SetKeyName(94, "95.bmp");
            this.Face.Images.SetKeyName(95, "96.bmp");
            this.Face.Images.SetKeyName(96, "97.bmp");
            this.Face.Images.SetKeyName(97, "98.bmp");
            this.Face.Images.SetKeyName(98, "99.bmp");
            this.Face.Images.SetKeyName(99, "100.bmp");
            this.Face.Images.SetKeyName(100, "101.bmp");
            this.Face.Images.SetKeyName(101, "back.bmp");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 978);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.Via);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Via)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Via;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditMessage;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button SystemMessage;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button FindFriend;
        private Aptech.UI.SideBar sideBar1;
        private System.Windows.Forms.ImageList Face;
        private System.Windows.Forms.ToolTip ShowMessage;
    }
}