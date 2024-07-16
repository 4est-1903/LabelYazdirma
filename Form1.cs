namespace stajornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            lblkayit2.Text = lblkayit1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}