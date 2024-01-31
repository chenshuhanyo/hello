namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string v = "您典籍了按鈕";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mybox.Text = "您典籍了按鈕";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mybox.Text = "您典籍了按鈕";
        }
    }
}