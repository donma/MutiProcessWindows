using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MutiProcessWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void menuItemCreateFormA_Click(object sender, EventArgs e)
        {
            var processAgent = new ProcessAgent("-forma");
            processAgent.MdiParent = this;
            processAgent.Show();
        }


        private void menuItemCreateFormB_Click(object sender, EventArgs e)
        {
            var processAgent = new ProcessAgent("-formb");
            processAgent.MdiParent = this;
            processAgent.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
