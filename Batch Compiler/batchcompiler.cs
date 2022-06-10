using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO;

namespace Batch_Compiler
{
    public partial class batchcompiler : Form
    {
        public batchcompiler()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("PLEASE READ CAREFULLY BEFORE RUNNING THE BATCH SCRIPT!\n\nYou are about to execute the inputted batch script in the editor.\n\nThis will be runned on the local machine.\n\nPlease be sure of what you are executing otherwise we are not responsible for execution! If you got this from a 3rd party website, review the code carefully!\n\nAre you sure you want to continue?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (dialogResult == DialogResult.Yes)
            {
                File.WriteAllText("BatchScript.bat", richTextBox1.Text);
                await Task.Delay(1000);
                System.Diagnostics.Process.Start("BatchScript.bat");
                await Task.Delay(1000);
                File.Delete("BatchScript.bat");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
