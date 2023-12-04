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
    public partial class GenerateBlankPage : Form 
    {
        modlib.Generate corelib = new modlib.Generate();
        public GenerateBlankPage()
        {
            InitializeComponent();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtNoOfPages.Text, out int noOfPages);
                corelib.generateBlank(noOfPages, txtOutputPath.Text);
                MessageBox.Show("Succesfully Completed");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
