using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace AIRobot
{
    public partial class logIn : CCSkinMain
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "")
            {
                FrmMain f = new FrmMain(tbName.Text);
                this.Visible = false;
                f.ShowDialog();
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbName.Clear();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("王旗 1181 0601 0695\r\n刘磊 1181 0601 0724\r\n卜凡 1181 0602 1919","制作人员名单");
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter )
            {
                btnOK_Click(sender,e);
            }
        }
    }
}
