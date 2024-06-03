namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;

        private void btnCount_Click(object sender, EventArgs e)
        {
            a++ 1;
            lblCount.Text =Convert.ToString(a);
        }
    }
}
