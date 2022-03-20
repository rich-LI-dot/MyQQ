using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Facefrom : Form
    {
        public Facefrom()
        {
            InitializeComponent();
        }

        private void Facefrom_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Face.Images.Count; i++)
            {
                facephoto.Items.Add(i.ToString());
                facephoto.Items[i].ImageIndex = i;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
