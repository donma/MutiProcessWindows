using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiProcessWindows
{
    public partial class FormA : Form
    {
        public FormA()
        {
            
            InitializeComponent();

           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            Application.Exit();
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            //this.TopLevel = false;
        }
    }
}
