namespace Latih12_MdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewForm = new ChildForm();
            NewForm.MdiParent = this;
            NewForm.Show();
          
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DataForm = new DataChildForm();
            DataForm.MdiParent = this;
            DataForm.Show();
        }
    }
}
