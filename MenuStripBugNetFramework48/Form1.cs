using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripBugNetFramework48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu2ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            menu2ToolStripMenuItem.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu2ToolStripMenuItem.Visible = true;
            menu2ToolStripMenuItem.ShowDropDown();
        }
    }
}
