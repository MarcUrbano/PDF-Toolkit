using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_ToolKit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void blankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateBlankPage gblank = new GenerateBlankPage();
            gblank.Show();
        }
    }
}
