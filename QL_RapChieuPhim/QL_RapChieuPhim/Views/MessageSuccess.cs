using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class MessageSuccess : Form
    {
        public MessageSuccess(string lbl)
        {
            InitializeComponent();
            label1.Text = lbl;
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

        private void MessageSuccess_Load(object sender, EventArgs e)
        {
            btn_Ok.Dock = DockStyle.Top;
            btn_Ok.Dock = DockStyle.Bottom;
        }
    }
}
