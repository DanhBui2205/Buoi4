using SRM_Hang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRM_kho sRM_Kho = new SRM_kho();
            sRM_Kho.ShowDialog();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
