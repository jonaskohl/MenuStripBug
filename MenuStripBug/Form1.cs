namespace MenuStripBug
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