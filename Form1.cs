using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Bang_Cuu_Chuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        { 
            lsbketqua.Items.Clear();
            int cc = Convert.ToInt32(txt1.Text);
            for (int i = 1; i <= 10; i++)
            {
                // lsbketqua.Items.Ađd(txtso.Text + "X" + Convert.Tostring(icc * 1));
                lsbketqua.Items.Add(string.Format("{0}x{1}={2}", txt1.Text, i.ToString(), Convert.ToString(cc*1)));
            }    
             
        }
    }
}
